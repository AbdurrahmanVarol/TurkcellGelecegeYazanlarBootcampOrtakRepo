using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;
using System.Reflection;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.Contexts;
public sealed class VotingDbContext : DbContext {
    public const String DB_SCHEMA = "vote_db";
    public VotingDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Option> Options { get; set; }
    public DbSet<Poll> Polls { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Vote> Votes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        AddingSoftDeletes(modelBuilder);
    }

    public override Task<Int32> SaveChangesAsync(CancellationToken cancellationToken = default) {
        IEnumerable<EntityEntry<Entity>> datas = this.ChangeTracker.Entries<Entity>();

        foreach(EntityEntry<Entity> data in datas) {
            _ = data.State switch {
                EntityState.Added => data.Entity.CreatedAt = DateTime.UtcNow,
                _ => DateTime.UtcNow,
            };
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    //https://www.meziantou.net/entity-framework-core-soft-delete-using-query-filters.htm
    private static void AddingSoftDeletes(ModelBuilder builder) {
        IEnumerable<IMutableEntityType> types = builder.Model.GetEntityTypes()
                                                             .Where(x => x.ClrType.IsAssignableTo(typeof(ISoftDeletable)));
        foreach(IMutableEntityType? entityType in types) {
            // 1. Add the IsDeleted property

            entityType.GetProperty(nameof(ISoftDeletable.IsDeleted));

            // 2. Create the query filter
            ParameterExpression parameter = Expression.Parameter(entityType.ClrType);

            // EF.Property<bool>(TEntity, "IsDeleted")
            MethodInfo? propertyMethodInfo = typeof(EF).GetMethod("Property")?.MakeGenericMethod(typeof(Boolean));
            MethodCallExpression isDeletedProperty = Expression.Call(propertyMethodInfo,
                                                                     parameter,
                                                                     Expression.Constant(nameof(ISoftDeletable.IsDeleted)));

            // EF.Property<bool>(TEntity, "IsDeleted") == false
            BinaryExpression compareExpression = Expression.MakeBinary(
                ExpressionType.Equal,
                isDeletedProperty,
                Expression.Constant(false)
            );

            // TEntity => EF.Property<bool>(TEntity, "IsDeleted") == false
            LambdaExpression lambda = Expression.Lambda(compareExpression, parameter);

            builder.Entity(entityType.ClrType).HasQueryFilter(lambda);
        }
    }
}
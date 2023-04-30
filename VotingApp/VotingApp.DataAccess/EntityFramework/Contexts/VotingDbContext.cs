using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Reflection;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.Contexts;
public sealed class VotingDbContext : DbContext
{
    public const string DB_SCHEMA = "vote_db";
    public VotingDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Option> Options { get; set; }
    public DbSet<Poll> Polls { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Vote> Votes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public override Task<Int32> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        IEnumerable<EntityEntry<Entity>> datas = this.ChangeTracker.Entries<Entity>();

        foreach (EntityEntry<Entity> data in datas)
        {
            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreatedAt = DateTime.UtcNow,
                _ => DateTime.UtcNow,
            };
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
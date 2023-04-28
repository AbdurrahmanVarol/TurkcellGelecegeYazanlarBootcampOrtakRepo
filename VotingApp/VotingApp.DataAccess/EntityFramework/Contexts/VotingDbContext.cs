using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.Contexts;
public sealed class VotingDbContext : DbContext {
    public const string DB_SCHEMA = "vote_db";
    public VotingDbContext(DbContextOptions options) : base(options) { }

    public override Task<Int32> SaveChangesAsync(CancellationToken cancellationToken = default) {
        IEnumerable<EntityEntry<Entity>> datas = this.ChangeTracker.Entries<Entity>();

        foreach(EntityEntry<Entity> data in datas) {
            _ = data.State switch {
                EntityState.Added => data.Entity.AtCreated = DateTime.UtcNow,
                _ => DateTime.UtcNow,
            };
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
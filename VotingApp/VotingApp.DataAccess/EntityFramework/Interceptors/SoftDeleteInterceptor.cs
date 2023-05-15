using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.Interceptors;
public class SoftDeleteInterceptor : SaveChangesInterceptor {
    public override ValueTask<InterceptionResult<Int32>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<Int32> result,
        CancellationToken cancellationToken = default
    ) {
        if(eventData.Context is null)
            return base.SavingChangesAsync(eventData, result, cancellationToken);

        foreach(EntityEntry<ISoftDeletable> entry in eventData.Context.ChangeTracker.Entries<ISoftDeletable>()) {
            switch(entry.State) {
                case EntityState.Added:
                    entry.Entity.IsDeleted = false;
                    break;
                case EntityState.Deleted:
                    entry.State = EntityState.Modified;
                    eventData.Context.Entry(entry.Entity).Entity.IsDeleted = true;
                    eventData.Context.Entry(entry.Entity).Entity.DeletedAt = DateTime.Now;
                    break;
            }
        }

        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }
}
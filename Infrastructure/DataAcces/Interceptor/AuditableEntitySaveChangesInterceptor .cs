using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Infrastructure.DataAcces.Interceptor
{
    public class AuditableEntitySaveChangesInterceptor : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            UpdateEntity(eventData.Context!);
            return base.SavingChanges(eventData, result);
        }
        public override ValueTask<int> SavedChangesAsync(SaveChangesCompletedEventData eventData, int result, CancellationToken cancellationToken = default)
        {
            UpdateEntity(eventData.Context!);
            return base.SavedChangesAsync(eventData, result, cancellationToken);
        }
        public void UpdateEntity(DbContext context)
        {
            if (context == null)
            {
                return;
            }
            foreach (var item in context.ChangeTracker.Entries<BaseAuditableEntity>())
            {
                if (item.State == EntityState.Added)
                {
                    item.Entity.CreatedBy = "Hello";
                    item.Entity.Created = DateTime.UtcNow;
                }
                if (item.State == EntityState.Unchanged)
                {
                    item.Entity.Lasted = DateTime.UtcNow;
                    item.Entity.LastedBy = "Hello";
                }
            }
        }
    }
}

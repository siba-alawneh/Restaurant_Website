using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Restaurant_Website.Models;


namespace Restaurant_Website.Data.Interceptors
{
    public class SoftDeleteInterceptor : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            var dbcontext = eventData.Context;
            if (dbcontext is null)
            {
                return new InterceptionResult<int>();
            }

            var models = dbcontext.ChangeTracker.Entries<BaseEntity>();

            foreach (var item in models)
            {
                if (item.State is EntityState.Deleted)
                {
                    item.State = EntityState.Modified;
                    item.Entity.IsDelete = true;
                }
            }

            return base.SavingChanges(eventData, result);
        }
    }
}

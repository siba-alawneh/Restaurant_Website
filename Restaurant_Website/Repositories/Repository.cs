using Microsoft.EntityFrameworkCore;
using Restaurant_Website.Data;
using Restaurant_Website.Models;
using System.Linq.Expressions;
namespace Restaurant_Website.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        DataDbContext _db;
        DbSet<T> dbSet;
        public Repository(DataDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            entity.CreateDate = DateTime.Now;
            entity.IsActive = true;
            dbSet.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            //entity.IsDeleted = true;
            //dbSet.Update(entity);
            entity.IsActive= false;
            dbSet.Remove(entity);
            _db.SaveChanges();
        }

        public void ChangeStatus(int id)
        {
            var entity = GetById(id);

            entity.IsActive = !entity.IsActive;
            dbSet.Update(entity);
            _db.SaveChanges();
        }
        public List<T> GetAll()
        {
            return dbSet.Where(e => !e.IsDelete).ToList();
        }
        public List<T> GetAllClient()
        {
            return dbSet.Where(e => !e.IsDelete && e.IsActive).ToList();
        }

        public List<T> GetAll(params Expression<Func<T, object>> [] includes)
        {
            IQueryable<T> query = dbSet.Where(e => !e.IsDelete);
            foreach(var include in includes)
            {
                query = query.Include(include);
            }
            return query.ToList();
        }
        public T GetById(int id)
        {
            return dbSet.AsNoTracking().FirstOrDefault(e => e.Id == id && !e.IsDelete);
        }

        public void Update(T entity)
        {
            entity.EditDate = DateTime.Now;
            entity.IsActive = true;
            dbSet.Update(entity);
            _db.SaveChanges();
        }
    }
}

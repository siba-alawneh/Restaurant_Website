using System.Linq.Expressions;
namespace Restaurant_Website.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void ChangeStatus(int id);
        T GetById(int id);
        List<T> GetAll();
        List<T> GetAll(params Expression<Func<T, object>>[] includes);
        List<T> GetAllClient();
    }
}

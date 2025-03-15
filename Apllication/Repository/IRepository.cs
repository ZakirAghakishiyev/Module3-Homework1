using System.Linq.Expressions;

namespace Application.Repository
{
    public interface IRepository<T> 
    {
        T Get(Func<T, bool> predicate);
        List<T> GetAll(Expression<Func<T, bool>>? predicate = null);
        void Add(T entity);
        void Remove(int id);
        void Update(int id, T entity);
    }

}

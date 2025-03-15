using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Contract
{
    internal interface IService<T>
    {
        T Get(Func<T, bool> predicate);
        List<T> GetAll(Expression<Func<T, bool>>? predicate = null);
        void Add(T entity);
        void Remove(int id);
        void Update(int id, T entity);
    }
}

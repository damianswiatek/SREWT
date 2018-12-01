using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataModel.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> SelectAll(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] include );
        Task<IQueryable<T>> SelectAllQuery(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] include);
        Task<T> Select(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Delete(ICollection<T> entities);
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataModel.Repository.Interfaces;

namespace DataModel.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        #region Fields
        internal DbContext _context;
        internal DbSet<T> dbSet;
        #endregion

        #region Properties        
        #endregion

        #region Constructors
        public GenericRepository(DbContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }
        #endregion

        #region Methods
        public bool Add(T entity)
        {
            bool result = false;

            if (entity != null)
            {
                dbSet.Add(entity);
                result = true;
            }

            return result;
        }

        public bool Delete(T entity)
        {
            bool result = false;

            if (entity != null)
            {
                dbSet.Remove(entity);
                result = true;
            }

            return result;
        }

        public bool Delete(ICollection<T> entities)
        {
            bool result = false;

            if (entities != null)
            {
                dbSet.RemoveRange(entities);
                result = true;
            }

            return result;
        }

        public async Task<T> Select(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            T result = null;

            IQueryable<T> query = dbSet as IQueryable<T>;
            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            if (predicate != null)
            {
                result = await query.FirstOrDefaultAsync(predicate);
            }
            
            return result;
        }

        public async Task<List<T>> SelectAll(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes)
        {
            List<T> result = new List<T>();
            IQueryable<T> query = dbSet as IQueryable<T>;

            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }
            if (predicate != null)
            {
                result = await query.Where(predicate).ToListAsync();
            }
            else
            {
                result = await query.ToListAsync();
            }

            return result;
        }

        public async Task<IQueryable<T>> SelectAllQuery(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> result;
            IQueryable<T> query = dbSet as IQueryable<T>;

            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }
            if (predicate != null)
            {
                result = query.Where(predicate);
            }
            else
            {
                result = query;
            }

            return result;
        }


        public bool Update(T entity)
        {
            bool result = false;

            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Modified;
                result = true;
            }

            return result;
        }
        #endregion
    }
}

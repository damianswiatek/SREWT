using DataModel.Container;
using DataModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected DatabaseContainer _context;
        protected DbSet<TEntity> _dbSet;

        public BaseRepository(DatabaseContainer context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public bool Add(TEntity entity)
        {
            bool result = false;

            if (entity != null)
            {
                _dbSet.Add(entity);
                result = true;
            }

            return result;
        }

        public bool Update(TEntity entity)
        {
            bool result = false;

            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Modified;
                result = true;
            }

            return result;
        }

        public bool Delete(TEntity entity)
        {
            bool result = false;

            if (entity != null)
            {
                _dbSet.Remove(entity);
                result = true;
            }

            return result;
        }
    }
}

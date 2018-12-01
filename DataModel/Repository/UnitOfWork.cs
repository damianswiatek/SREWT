using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DataModel.Repository.Interfaces;

namespace DataModel.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields
        private DbContext _context;
        private Dictionary<Type, object> repositoryDictionary;
        private bool disposed = false;
        #endregion

        #region Properties        
        public DbContext Context { get { return _context; } }
        #endregion

        #region Constructors
        public UnitOfWork(DbContext context)
        {
            _context = context;
            repositoryDictionary = new Dictionary<Type, object>();
        }
        #endregion

        #region Methods
        public IRepository<T> Repository<T>() where T : class
        {
            IRepository<T> repository = null;

            if (repositoryDictionary.Keys.Contains(typeof(T)))
            {
                repository = repositoryDictionary[typeof(T)] as IRepository<T>;
            }
            else
            {
                repository = new GenericRepository<T>(_context);
                repositoryDictionary.Add(typeof(T), repository);
            }

            return repository;
        }

        public async Task<bool> SaveAsync()
        {
            bool result = false;

            await _context.SaveChangesAsync();
            result = true;

            return result;
        }

        public bool Save()
        {
            bool result = false;

            _context.SaveChanges();

            return result;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

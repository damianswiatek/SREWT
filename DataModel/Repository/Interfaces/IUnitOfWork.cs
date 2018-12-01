using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DataModel.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        System.Data.Entity.DbContext Context { get; }
        IRepository<T> Repository<T>() where T : class;
        Task<bool> SaveAsync();
        bool Save();
    }
}

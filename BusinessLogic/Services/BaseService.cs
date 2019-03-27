using DataModel.Container;
using DataModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class BaseService
    {
        #region Properties
        public DatabaseContainer _context;
        
        public IUnitOfWork _unitOfWork { get; private set; }
        #endregion

        #region Deducted Properties
        public string Name
        {
            get
            {
                return this.GetType().Name;
            }
        }
        #endregion

        #region Constructors
        public BaseService(IUnitOfWork unitOfWork, DatabaseContainer context)
        {
            this._context = context;
            this._unitOfWork = unitOfWork;
        }
        #endregion
    }
}

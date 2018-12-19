using DataModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class BaseService
    {
        #region Properties
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
        public BaseService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        #endregion
    }
}

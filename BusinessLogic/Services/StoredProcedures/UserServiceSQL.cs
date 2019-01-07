using Common.Results;
using DataModel.Entities;
using DataModel.Repository;
using DataModel.Repository.Interfaces;
using DataModel.Repository.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.StoredProcedures
{
    public class UserServiceSQL : BaseService, IUserServiceSQL
    {
        #region Constructors
        /// <summary>
        /// Default controller
        /// </summary>
        public UserServiceSQL(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }
        #endregion

        public ServiceResult<User> GetUser(Guid userId, Guid? groupLogKey = null)
        {
            try
            {
                User user = new User();

                var dataMapper = MapperFactory.GetOneWayMap<Dictionary<string, object>, User>();
                var result = _unitOfWork.Procedure<MICProcedure>("dbo.test")
                                    .Initialize(
                                        "@Id".PairWith(userId)
                                        )
                                     .Execute()
                                     .DataRows;


                if (result != null && result.Count > 0)
                {
                    dataMapper.Map(result.First(), user);
                }

                return new ServiceResult<User>(user);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

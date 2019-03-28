using Common.Results;
using DataModel.Container;
using DataModel.Entities;
using DataModel.Models;
using DataModel.Repository;
using DataModel.Repository.Interfaces;
using DataModel.Repository.StoredProcedures;
using SREWT.JWT;
using SREWT.JWT.Provider.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.StoredProcedures
{
    public class UserServiceSQL : BaseService, IUserServiceSQL
    {
        protected readonly IMembershipHashProvider _membershipProvider;
        #region Constructors
        /// <summary>
        /// Default controller
        /// </summary>
        public UserServiceSQL(IUnitOfWork unitOfWork, IMembershipHashProvider membershipProvider, DatabaseContainer context) : base(unitOfWork, context)
        {
            _membershipProvider = membershipProvider;
        }
        #endregion

        public async Task<ServiceResult<User>> CreateUser(UserDetail user, Guid? groupLogKey = null)
        {
            ServiceResult<User> serviceResult = new ServiceResult<User>(null);
            try
            {
                User resultData = new User();
                string passwordHash = await this._membershipProvider.HashPassword("password");

                var dataMapper = MapperFactory.GetOneWayMap<Dictionary<string, object>, User>();
                var result = _unitOfWork.Procedure<MICProcedure>("dbo.spCreateUser")
                                    .Initialize(
                                          "@Username".PairWith(user.Username)
                                        , "@PasswordHash".PairWith(passwordHash)
                                        , "@PhoneNumber".PairWith(user.PhoneNumber)
                                        , "@Firstname".PairWith(user.Firstname)
                                        , "@Lastname".PairWith(user.Lastname)
                                        , "@Pesel".PairWith(user.Pesel)
                                        , "@VacationDays".PairWith(user.VacationDays)
                                        , "@X_CreatedDate".PairWith(DateTime.Now)
                                        , "@X_LastUpdateDate".PairWith(DateTime.Now)
                                        )
                                     .Execute()
                                     .DataRows;


                if (result != null && result.Count > 0)
                {
                    dataMapper.Map(result.First(), resultData);
                }

                serviceResult.Result = resultData;
                return serviceResult;
            }
            catch (Exception ex)
            {
                return serviceResult.AddError(this.Name, "CreateUser", ServiceMessageType.Error, "Exception", ex);
            }
        }

        public async Task<ServiceResult<UserDetail>> CreateUserWithAddress(UserDetail user, Guid? groupLogKey = null)
        {
            ServiceResult<UserDetail> serviceResult = new ServiceResult<UserDetail>(null);
            try
            {
                UserDetail resultData = new UserDetail();
                string passwordHash = await this._membershipProvider.HashPassword("password");

                var dataMapper = MapperFactory.GetOneWayMap<Dictionary<string, object>, UserDetail>();
                var result = _unitOfWork.Procedure<MICProcedure>("dbo.spCreateUserWithAddress")
                                    .Initialize(
                                          "@Username".PairWith(user.Username)
                                        , "@PasswordHash".PairWith(passwordHash)
                                        , "@PhoneNumber".PairWith(user.PhoneNumber)
                                        , "@Firstname".PairWith(user.Firstname)
                                        , "@Lastname".PairWith(user.Lastname)
                                        , "@Pesel".PairWith(user.Pesel)
                                        , "@VacationDays".PairWith(user.VacationDays)
                                        , "@PostalCode".PairWith(user.PostalCode)
                                        , "@City".PairWith(user.City)
                                        , "@Street".PairWith(user.Street)
                                        , "@Polity".PairWith(user.Polity)
                                        , "@X_CreatedDate".PairWith(DateTime.Now)
                                        , "@X_LastUpdateDate".PairWith(DateTime.Now)
                                        )
                                     .Execute()
                                     .DataRows;


                if (result != null && result.Count > 0)
                {
                    dataMapper.Map(result.First(), resultData);
                }

                serviceResult.Result = resultData;
                return serviceResult;
            }
            catch (Exception ex)
            {
                return serviceResult.AddError(this.Name, "CreateUserWithAddress", ServiceMessageType.Error, "Exception", ex);
            }
        }

        public ServiceResult<User> GetUser(Guid userId, Guid? groupLogKey = null)
        {
            try
            {
                User user = new User();

                var dataMapper = MapperFactory.GetOneWayMap<Dictionary<string, object>, User>();
                var result = _unitOfWork.Procedure<MICProcedure>("dbo.spGetUser")
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

        public ServiceResult<bool> DeleteUser(Guid userId, Guid? groupLogKey = null)
        {
            try
            {
                ServiceResult<bool> result = new ServiceResult<bool>(false);

                var dataMapper = MapperFactory.GetOneWayMap<Dictionary<string, object>, User>();
                var resultData = _unitOfWork.Procedure<MICProcedure>("dbo.spDeleteUser")
                                    .Initialize(
                                        "@Id".PairWith(userId)
                                        )
                                     .Execute()
                                     .DataRows;

                result.Result = true;

                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

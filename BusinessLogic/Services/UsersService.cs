﻿using Common.Results;
using DataModel.Entities;
using DataModel.Repository.Interfaces;
using SREWT.JWT;
using SREWT.JWT.Provider.Interfaces;
using SREWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class UsersService : BaseService, IUsersService
    {
        #region Fields
        private readonly IRepository<User> _usersRepository;
        private readonly IRepository<Address> _addressRepository;
        private readonly IMembershipHashProvider _membershipProvider;
        private readonly IJwtTokenProvider _jwtTokenProvider;
        #endregion

        #region Constructors
        public UsersService(IUnitOfWork unitOfWork, IRepository<User> usersRepository, IRepository<Address> addressRepository, IMembershipHashProvider membershipProvider, IJwtTokenProvider jwtTokenProvider)
            : base(unitOfWork)
        {
            this._usersRepository = usersRepository;
            this._addressRepository = addressRepository;
            this._membershipProvider = membershipProvider;
            this._jwtTokenProvider = jwtTokenProvider;
        }
        #endregion

        #region Methods
        public async Task<ServiceResult<bool>> CreateUser(UserData userData)
        {
            ServiceResult<bool> result = new ServiceResult<bool>(false);

            try
            {
                Address address = new Address()
                {
                    Id = Guid.NewGuid(),
                    City = userData.City,
                    PostalCode = userData.PostalCode,
                    Polity = userData.Polity,
                    Street = userData.Street,
                    X_CreatedDate = DateTime.UtcNow,
                    X_LastUpdateDate = DateTime.UtcNow                
                };

                User newUser = new User
                {
                    Id = Guid.NewGuid(),
                    Address_Id = address.Id,
                    PhoneNumber = userData.PhoneNumber,
                    X_CreatedDate = DateTime.UtcNow,
                    X_LastUpdateDate = DateTime.UtcNow,
                    InternalToken = Guid.NewGuid(),
                    Username = userData.Username,
                    PasswordHash = await this._membershipProvider.HashPassword(userData.Password)
                };
                this._addressRepository.Add(address);
                this._usersRepository.Add(newUser);

                this._unitOfWork.Save();

                result.Result = true;
            }
            catch (Exception ex)
            {
                result.AddError(this.Name, "CreateUser", ServiceMessageType.Error, null, ex);
            }

            return result;
        }

        public async Task<ServiceResult<string>> GetToken(string userName, string password)
        {
            ServiceResult<string> result = new ServiceResult<string>(null);

            try
            {
                User user = await this._usersRepository.Select(u => u.Username == userName);

                if (user != null)
                {
                    bool passwordVerified = await this._membershipProvider.VerifyPassword(password, user.PasswordHash);

                    if (passwordVerified)
                    {
                        result = await this._jwtTokenProvider.GenerateToken(userName, password);
                    }
                }
                else
                {
                    result.AddError("UsersService", "GetToken", ServiceMessageType.Info, "Unathorize - User with UserName: " + userName + " doesn't exists.");
                }
            }
            catch (Exception ex)
            {
                result.AddError(this.Name, "ValidateUser", ServiceMessageType.Error, null, ex);
            }

            return result;
        }

        public async Task<ServiceResult<LoggedUser>> GetLoggedUser(Guid loggedUserId)
        {
            ServiceResult<LoggedUser> result = null;
            LoggedUser LoggedUser = null;

            User user = await _usersRepository.Select(x => x.Id == loggedUserId);
            if (user != null)
            {
                LoggedUser = new LoggedUser(user);
                result = new ServiceResult<LoggedUser>(LoggedUser, true);
            }
            else
            {
                result = new ServiceResult<LoggedUser>(null, false);
            }
            return result;
        }
        #endregion
    }
}

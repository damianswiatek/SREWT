using Common.Results;
using DataModel.Container;
using DataModel.Entities;
using DataModel.Models;
using DataModel.Repository.Interfaces;
using SREWT.JWT;
using SREWT.JWT.Provider.Interfaces;
using SREWT.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public UsersService(DatabaseContainer context, IUnitOfWork unitOfWork, IRepository<User> usersRepository, IRepository<Address> addressRepository, IMembershipHashProvider membershipProvider, IJwtTokenProvider jwtTokenProvider)
            : base(unitOfWork, context)
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

        public async Task<ServiceResult<bool>> UpdateUserWithAddress(UserDetail user)
        {
            
            ServiceResult<bool> result = new ServiceResult<bool>(false);

            try
            {
                User userToUpdate = await _usersRepository.Select(x => x.Id == user.Id);
                if (userToUpdate != null)
                {
                    Address addressToUpdate = await _addressRepository.Select(x => x.Id == userToUpdate.Address_Id);

                    if (addressToUpdate != null)
                    {
                        addressToUpdate.City = user.City;
                        addressToUpdate.PostalCode = user.PostalCode;
                        addressToUpdate.Polity = user.Polity;
                        addressToUpdate.Street = user.Street;
                        addressToUpdate.X_LastUpdateDate = DateTime.UtcNow;


                        this._addressRepository.Update(addressToUpdate);
                    }

                    userToUpdate.Id = user.Id;
                    userToUpdate.PhoneNumber = user.PhoneNumber;
                    userToUpdate.X_LastUpdateDate = DateTime.UtcNow;
                    userToUpdate.Username = user.Username;
                    userToUpdate.Firstname = user.Firstname;
                    userToUpdate.Lastname = user.Lastname;
                    this._usersRepository.Update(userToUpdate);

                    this._unitOfWork.Save();
                }

                result.Result = true;

            }
            catch (Exception ex)
            {
                result.AddError(this.Name, "UpdateUserWithAddress", ServiceMessageType.Error, null, ex);
            }
            
            
            return result;
        }

        public async Task<ServiceResult<bool>> DeleteUser(Guid userId)
        {
            
            ServiceResult<bool> result = new ServiceResult<bool>(false);

            try
            {
                User userToDelete = await _usersRepository.Select(x => x.Id == userId);
                if (userToDelete != null)
                {
                    this._usersRepository.Delete(userToDelete);

                    this._unitOfWork.Save();
                }

                result.Result = true;
            }
            catch (Exception ex)
            {
                result.AddError(this.Name, "DeleteUser", ServiceMessageType.Error, null, ex);
            }

            
            
            return result;
        }

        public async Task<ServiceResult<List<UserDetail>>> GetUsersCompain(Guid id)
        {
            
            ServiceResult<List<UserDetail>> result = new ServiceResult<List<UserDetail>>(null);

            try
            {
                result.Result = this._context
                    .Users
                    .Include("Address")
                    .AsNoTracking()
                    .Where(x => x.Company_Id == id)
                    .Select(x => new UserDetail()
                    {
                        Id = x.Id,
                        City = x.Address.City,
                        Firstname = x.Firstname,
                        Lastname = x.Lastname,
                        Pesel = x.Pesel,
                        PhoneNumber = x.PhoneNumber,
                        PostalCode = x.Address.PostalCode,
                        Street = x.Address.Street,
                        Username = x.Username,
                        VacationDays = x.VacationDays,
                        Polity = x.Address.Polity
                    }
                    )
                    .ToList();
            }
            catch (Exception ex)
            {
                result.AddError(this.Name, "GetUsersCompain", ServiceMessageType.Error, null, ex);
            }

            
            
            return result;
        }

        public async Task<ServiceResult<DataModel.Entities.User>> GetUser(Guid id)
        {
            
            ServiceResult<DataModel.Entities.User> result = new ServiceResult<DataModel.Entities.User>(null);

            try
            {
                result.Result = await _usersRepository.Select(x => x.Id == id);
            }
            catch (Exception ex)
            {
                result.AddError(this.Name, "GetUsersCompain", ServiceMessageType.Error, null, ex);
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

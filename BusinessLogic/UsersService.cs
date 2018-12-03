using Common.Results;
using DataModel.Entities;
using DataModel.Repository.Interfaces;
using SREWT.JWT;
using SREWT.JWT.Provider.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UsersService : BaseService, IUsersService
    {
        #region Fields
        private readonly IRepository<User> _usersRepository;
        private readonly IMembershipHashProvider _membershipProvider;
        private readonly IJwtTokenProvider _jwtTokenProvider;
        #endregion

        #region Constructors
        public UsersService(IUnitOfWork unitOfWork, IRepository<User> usersRepository, IMembershipHashProvider membershipProvider, IJwtTokenProvider jwtTokenProvider)
            : base(unitOfWork)
        {
            this._usersRepository = usersRepository;
            this._membershipProvider = membershipProvider;
            this._jwtTokenProvider = jwtTokenProvider;
        }
        #endregion

        #region Methods
        public async Task<ServiceResult<bool>> CreateUser(string userName, string password)
        {
            ServiceResult<bool> result = new ServiceResult<bool>(false);

            try
            {
                User newUser = new User
                {
                    Id = Guid.NewGuid(),
                    PhoneNumber = "983414531",
                    ReversedPhoneNumber = "983414532",
                    RegistrationDate = DateTime.UtcNow,
                    X_CreatedDate = DateTime.UtcNow,
                    Username = userName,
                    PasswordHash = await this._membershipProvider.HashPassword(password)
                };

                this._usersRepository.Add(newUser);

                this._unitOfWork.Save();

                result.Result = true;
            }
            catch (Exception ex)
            {
                result.AddError(this.Name, "CreateUser", null, null, ex);
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

                    if (passwordVerified == true)
                    {
                        result.Result = await this._jwtTokenProvider.GenerateToken(user);
                    }
                }
                else
                {
                    result.Result = null;
                    result.AddError("UsersService", "GetToken", "Unathorize", "User with UserName: " + userName + " doesn't exists.");
                }
            }
            catch (Exception ex)
            {
                result.AddError(this.Name, "ValidateUser", null, null, ex);
            }

            return result;
        }
        #endregion
    }
}

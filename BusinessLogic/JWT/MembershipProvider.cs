using DataModel.Entities;
using DataModel.Repository.Interfaces;
using SREWT.JWT.Provider.Interfaces;
using SREWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace SREWT.JWT
{
    public class MembershipProvider : IMembershipProvider
    {
        private IUnitOfWork _unitOfWork;
        private IMembershipHashProvider _membershipHashProvider;

        public MembershipProvider(IUnitOfWork unitOfWork, IMembershipHashProvider membershipHashProvider)
        {
            this._unitOfWork = unitOfWork;
            this._membershipHashProvider = membershipHashProvider;
        }

        public async Task<List<Claim>> GetUserClaims(string username)
        {
            IRepository<User> userRepository = this._unitOfWork.Repository<User>();
            User user = await userRepository.Select(u => u.Username == username);
            if (user != null)
            {
                try
                {
                    LoggedUser userModel = new LoggedUser()
                    {
                        Id = user.Id,
                        InternalToken = user.InternalToken.ToString(),
                        PasswordHash = user.PasswordHash,
                        Roles = user.Roles != null ? Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(user.Roles) : new List<string>(),
                        Username = user.Username,
                        Claims = new List<Claim>()
                    };
                    userModel.Claims.Add(new Claim(ClaimTypes.Authentication, user.InternalToken.ToString()));
                    string role = user.RolesList?.FirstOrDefault();
                    if (role != null)
                    {
                        userModel.Claims.Add(new Claim(ClaimTypes.Role, role.ToString()));
                    }

                    return userModel.Claims;
                }
                catch (Exception)
                {
                    return new List<Claim>();
                }
            }
            else
            {
                return new List<Claim>();
            }

        }

        public async Task<bool> VerifyUserPassword(string username, string password)
        {
            IRepository<User> userRepository = this._unitOfWork.Repository<User>();
            User user = await userRepository.Select(u => u.Username == username);

            if (user != null)
            {
                return await _membershipHashProvider.VerifyPassword(password, user.PasswordHash);
            }
            else
            {
                return false;
            }
        }

    }
}
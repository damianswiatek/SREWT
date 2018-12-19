using BusinessLogic.Services;
using Common.Results;
using SREWT.JWT.Provider.Interfaces;
using SREWT.Models;
using System;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;


namespace SREWT.JWT
{
    public class IdentityProvider : IIdentityProvider
    {
        private readonly IUsersService _userService;

        public IdentityProvider(IUsersService userService)
        {
            this._userService = userService;
        }

        public async Task<LoggedUser> GetLoggedUser(IIdentity identity)
        {
            LoggedUser loggedUser = null;

            try
            {
                ClaimsIdentity claumsIdentity = identity as ClaimsIdentity;
                Claim claim = claumsIdentity.Claims.SingleOrDefault(c => c.Type == ClaimTypes.Authentication);
                if (claim != null)
                {
                    string internalToken = claim.Value;
                    Guid userGuid = Guid.Parse(internalToken);
                    ServiceResult<LoggedUser> resultContent = await _userService.GetLoggedUser(userGuid);
                    loggedUser = resultContent.Result;
                }
            }
            catch (Exception)
            {
                return null;
            }

            return loggedUser;
        }
    }
}

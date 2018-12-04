using SREWT.Models;
using System;
using System.Security.Principal;
using System.Threading.Tasks;

namespace SREWT.JWT.Provider.Interfaces
{
    public interface IIdentityProvider
    {
        Task<LoggedUser> GetLoggedUser(IIdentity identity);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SREWT.JWT
{
    public interface IMembershipProvider
    {
        List<Claim> GetUserClaims(string username);
        bool VerifyUserPassword(string username, string password);
    }
}

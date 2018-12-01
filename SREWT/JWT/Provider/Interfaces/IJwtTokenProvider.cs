using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SREWT.JWT.Provider.Interfaces
{
    public interface IJwtTokenProvider
    {
        Task<string> GenerateToken(User user);
        Task<ClaimsPrincipal> ValidateToken(string token);
    }
}

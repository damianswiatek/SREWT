using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SREWT.JWT
{
    public interface IAuthService
    {
        Task<string> GenerateJwtTokenAsync(string username, string password);
        Task<Boolean> ValidateTokenAsync(string TokenString);
    }
}

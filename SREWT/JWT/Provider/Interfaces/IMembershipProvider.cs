using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SREWT.JWT.Provider.Interfaces
{
    public interface IMembershipProvider
    {
        Task<string> HashPassword(string password, int iterations);
        Task<string> HashPassword(string password);
        Task<bool> VerifyPassword(string password, string hashedPassword);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SREWT.JWT
{
    public interface IRSAKeyProvider
    {
        Task<string> GetPrivateAndPublicKeyAsync();
    }
}

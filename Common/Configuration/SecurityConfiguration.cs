using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Common.Configuration
{
    public static class SecurityConfiguration
    {
        public static string TokenIssuer = WebConfigurationManager.AppSettings["TokenIssuer"];
        public static string TokenAudience = WebConfigurationManager.AppSettings["TokenAudience"];
        public static string TokenLifetime = WebConfigurationManager.AppSettings["TokenLifetime"];
    }
}

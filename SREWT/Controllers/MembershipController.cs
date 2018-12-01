using System;
using System.Web.Http;
using System.Threading.Tasks;
using SREWT.JWT;

namespace SREWT.Controllers
{
    public class MembershipController : ApiController
    {
        private readonly IAuthService _authService;

        public MembershipController(IAuthService authService)
        {
            _authService = authService;
        }

        // GET: Membership
        [HttpGet]
        public async Task<string> Authenticate(String username, String password)
        {
            string Token = await _authService.GenerateJwtTokenAsync(username, password);
            return Token;
        }
    }
}
using System;
using System.Web.Http;
using System.Threading.Tasks;
using SREWT.JWT;
using BusinessLogic;
using Common.Results;
using System.Web.Http.Description;
using SREWT.Models;

namespace SREWT.Controllers
{
    public class MembershipController : ApiController
    {
        private readonly IAuthService _authService;
        private readonly IUsersService _userService;


        public MembershipController(IAuthService authService, IUsersService userService)
        {
            _authService = authService;
            _userService = userService;
        }
        

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<bool>))]
        [HttpPost]
        [Route("api/membership/create")]
        public async Task<ServiceResult<bool>> CreateUser([FromBody] Login login)
        {
            ServiceResult<bool> result = await _userService.CreateUser(login.UserName, login.Password);
            return result;
        }
        
        [AllowAnonymous]
        [HttpGet]
        [Route("api/membership/{login}/token/{password}")]
        public async Task<string> Authenticate(string login, string password)
        {
            string Token = await _authService.GenerateJwtTokenAsync(login, password);
            return Token;
        }
    }
}
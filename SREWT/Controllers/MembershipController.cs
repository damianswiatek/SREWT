using System;
using System.Web.Http;
using System.Threading.Tasks;
using SREWT.JWT;
using BusinessLogic;
using Common.Results;
using System.Web.Http.Description;
using SREWT.Models;
using SREWT.Controllers.Base;
using SREWT.JWT.Provider.Interfaces;
using System.Net.Http;
using System.Net;
using BusinessLogic.Services;
using DataModel.Entities;
using BusinessLogic.Services.StoredProcedures;

namespace SREWT.Controllers
{
    public class MembershipController : BaseController
    {
        private readonly IJwtTokenProvider _jwtTokenProvider;
        private readonly IUserServiceSQL _userServiceSQL;

        public MembershipController(IJwtTokenProvider jwtTokenProvider, IIdentityProvider identityProvider, IUsersService userService, IUserServiceSQL userServiceSQL) : base(identityProvider, userService)
        {
            _jwtTokenProvider = jwtTokenProvider;
            _userServiceSQL = userServiceSQL;
        }

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<bool>))]
        [HttpGet]
        [Route("api/membership/user")]
        public async Task<HttpResponseMessage> GetUser(Guid id)
        {
            ServiceResult<User> result = _userServiceSQL.GetUser(id);
            if (result.IsSuccess)
            {
                base.IsSuccess = true;
                base.ContainerId = base.LoggedUserId;
                return Request.CreateResponse(HttpStatusCode.OK, result.Result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<bool>))]
        [HttpPost]
        [Route("api/membership/create")]
        public async Task<HttpResponseMessage> CreateUser([FromBody] Login login)
        {
            ServiceResult<bool> result = await _userService.CreateUser(login.UserName, login.Password);
            if (result.IsSuccess)
            {
                base.IsSuccess = true;
                base.ContainerId = base.LoggedUserId;
                return Request.CreateResponse(HttpStatusCode.OK, result.Result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<string>))]
        [HttpGet]
        [Route("api/membership/{login}/token/{password}")]
        public async Task<HttpResponseMessage> Authenticate(string login, string password)
        {
            ServiceResult<string> result = await _jwtTokenProvider.GenerateToken(login, password);
            if (result.IsSuccess)
            {
                base.IsSuccess = true;
                base.ContainerId = base.LoggedUserId;
                return Request.CreateResponse(HttpStatusCode.OK, result.Result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized, result);
            }
        }
    }
}
using BusinessLogic.Services;
using SREWT.Attributes;
using SREWT.JWT.Provider.Interfaces;
using System;
using System.Web.Http;

namespace SREWT.Controllers.Base
{
    [JwtAuthentication]
    public class BaseController : ApiController
    {
        protected IIdentityProvider _identityProvider;
        protected IUsersService _userService;

        public bool IsSuccess { get; set; }
        public Guid? LoggedUserId { get; set; }
        public string LoggedUsername { get; set; }
        public Guid? ContainerId { get; set; }

        public BaseController(IIdentityProvider identityProvider, IUsersService userService)
        {
            _identityProvider = identityProvider;
            _userService = userService;
        }
    }
}
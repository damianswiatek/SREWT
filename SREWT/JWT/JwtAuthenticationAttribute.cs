using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.Results;
using System.Web.Mvc;
//using ZavenTraining.Common.Configuration;
//using ZavenTraining.Domain.Services.Membership.Interfaces;

namespace SREWT.JWT
{
    public class JwtAuthenticationAttribute : System.Web.Http.AuthorizeAttribute
    {
        #region Properties
        public override bool AllowMultiple
        {
            get
            {
                return true;
            }
        }
        #endregion

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes<System.Web.Http.AllowAnonymousAttribute>().Count > 0) { return; }
            if (actionContext.ActionDescriptor.GetCustomAttributes<System.Web.Http.AllowAnonymousAttribute>().Count > 0) { return; }

            try
            {
                IJwtTokenProvider jwtTokenProvider = DependencyResolver.Current.GetService<IJwtTokenProvider>();
                AuthenticationHeaderValue authorizationHeader = actionContext.Request.Headers.Authorization;

                if (authorizationHeader == null)
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Authorization header not present.");
                    return;
                }

                if (authorizationHeader.Scheme != "Bearer")
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Authorization scheme invalid.");
                    return;
                }

                if (String.IsNullOrEmpty(authorizationHeader.Parameter))
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Authorization token not present.");
                    return;
                }

                String token = authorizationHeader.Parameter;

                Task<ClaimsPrincipal> validateTokenTask = jwtTokenProvider.ValidateToken(token);
                validateTokenTask.Wait();
                if (validateTokenTask.Result != null)
                {

                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Authorization token not valid.");
                }
            }
            catch (Exception ex)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Unexpected error occured.");
            }
        }
    }
}
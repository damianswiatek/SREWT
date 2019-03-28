using BusinessLogic.Services;
using BusinessLogic.Services.StoredProcedures;
using Common.Results;
using Dapper;
using DataModel.Entities;
using DataModel.Models;
using SREWT.Controllers.Base;
using SREWT.JWT.Provider.Interfaces;
using SREWT.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SREWT.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IJwtTokenProvider _jwtTokenProvider;
        private readonly IUserServiceSQL _userServiceSQL;


        public UsersController(IJwtTokenProvider jwtTokenProvider, IIdentityProvider identityProvider, IUsersService userService, IUserServiceSQL userServiceSQL) : base(identityProvider, userService)
        {
            _jwtTokenProvider = jwtTokenProvider;
            _userServiceSQL = userServiceSQL;
        }

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<List<UserDetail>>))]
        [HttpGet]
        [Route("api/users/getUsers")]
        public async Task<HttpResponseMessage> GetUsers(Guid compainId)
        {
            var watch = Stopwatch.StartNew();
            ServiceResult<List<UserDetail>> result = await _userService.GetUsersCompain(compainId);
            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<DataModel.Entities.User>))]
        [HttpGet]
        [Route("api/users")]
        public async Task<HttpResponseMessage> GetUser(Guid id)
        {
            var watch = Stopwatch.StartNew();
            ServiceResult<DataModel.Entities.User> result = await _userService.GetUser(id);
            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        //SQL
        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<DataModel.Entities.User>))]
        [HttpGet]
        [Route("api/usersSQL")]
        public async Task<HttpResponseMessage> GetUserSQL(Guid id)
        {
            var watch = Stopwatch.StartNew();
            ServiceResult<DataModel.Entities.User> result = _userServiceSQL.GetUser(id);
            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<bool>))]
        [HttpPost]
        [Route("api/users/create")]
        public async Task<HttpResponseMessage> CreateUser([FromBody] UserData user)
        {
            var watch = Stopwatch.StartNew();
            ServiceResult<bool> result = await _userService.CreateUser(user);
            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        //SQL
        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<bool>))]
        [HttpPost]
        [Route("api/users/createSQL")]
        public async Task<HttpResponseMessage> CreateUserSQL([FromBody] UserDetail user)
        {
            var watch = Stopwatch.StartNew();
            ServiceResult<User> result = await _userServiceSQL.CreateUser(user);
            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        //SQL
        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<bool>))]
        [HttpPost]
        [Route("api/users/CreateUserWithAddressSQL")]
        public async Task<HttpResponseMessage> CreateUserWithAddress([FromBody] UserDetail user)
        {
            var watch = Stopwatch.StartNew();
            ServiceResult<UserDetail> result = await _userServiceSQL.CreateUserWithAddress(user);
            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<bool>))]
        [HttpPut]
        [Route("api/users/updateUserWithAddress")]
        public async Task<HttpResponseMessage> UpdateUserWithAddress([FromBody] UserDetail user)
        {
            var watch = Stopwatch.StartNew();
            ServiceResult<bool> result = await _userService.UpdateUserWithAddress(user);
            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<bool>))]
        [HttpDelete]
        [Route("api/users/delete")]
        public async Task<HttpResponseMessage> Delete(Guid userId)
        {
            var watch = Stopwatch.StartNew();
            ServiceResult<bool> result = await _userService.DeleteUser(userId);
            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        //SQL
        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<bool>))]
        [HttpDelete]
        [Route("api/users/deleteSQL")]
        public async Task<HttpResponseMessage> DeleteSQL(Guid userId)
        {
            var watch = Stopwatch.StartNew();
            ServiceResult<bool> result = _userServiceSQL.DeleteUser(userId);
            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<bool>))]
        [HttpGet]
        [Route("api/users/getAll")]
        public async Task<HttpResponseMessage> GetAll()
        {
            ServiceResult<List<User>> result = new ServiceResult<List<User>>(null);
            var watch = Stopwatch.StartNew();
            List<User> users = null;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ConnectionString))
            {
                users = db.Query<User>("Select * From Users").ToList();
            }

            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new ServiceResult<List<User>>(users));
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }

        [AllowAnonymous]
        [ResponseType(typeof(ServiceResult<List<UserDetail>>))]
        [HttpGet]
        [Route("api/users/getAllUsersDetail")]
        public async Task<HttpResponseMessage> GetAllUsersDetailAll()
        {
            string sql = "select * from Users u inner join Addresses a on a.Id = u.Address_Id";
            ServiceResult<List<UserDetail>> result = new ServiceResult<List<UserDetail>>(null);
            var watch = Stopwatch.StartNew();
            List<UserDetail> users = null;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ConnectionString))
            {
                users = db.Query<User, Address, UserDetail>(
                            sql,
                            (user, address) =>
                            {
                                user.Address_Id = address.Id;
                                return new UserDetail() {
                                    Id = user.Id,
                                    Firstname = user.Firstname,
                                    Lastname = user.Lastname,
                                    PhoneNumber = user.PhoneNumber,
                                    Pesel = user.Pesel,
                                    Username = user.Username,
                                    VacationDays = user.VacationDays,
                                    City = address.City,
                                    Polity = address.Polity,
                                    PostalCode = address.PostalCode,
                                    Street = address.Street
                                };
                            },
                            splitOn: "Address_Id")
                            .Distinct()
                            .ToList();
                            }

            watch.Stop();
            result.DurationOfQuery = watch.Elapsed.Ticks / 1000;
            if (result.IsSuccess)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new ServiceResult<List<UserDetail>>(users));
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }
    }
}

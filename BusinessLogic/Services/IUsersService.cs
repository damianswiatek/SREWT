using Common.Results;
using DataModel.Models;
using SREWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IUsersService
    {
        Task<ServiceResult<bool>> CreateUser(UserData userData);
        Task<ServiceResult<bool>> UpdateUserWithAddress(UserDetail user);
        Task<ServiceResult<bool>> DeleteUser(Guid id);
        Task<ServiceResult<DataModel.Entities.User>> GetUser(Guid id);
        Task<ServiceResult<string>> GetToken(string userName, string password);
        Task<ServiceResult<LoggedUser>> GetLoggedUser(Guid loggedUserId);
        Task<ServiceResult<List<UserDetail>>> GetUsersCompain(Guid id);
    }
}

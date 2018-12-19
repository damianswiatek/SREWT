using Common.Results;
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
        Task<ServiceResult<bool>> CreateUser(string userName, string password);
        Task<ServiceResult<string>> GetToken(string userName, string password);
        Task<ServiceResult<LoggedUser>> GetLoggedUser(Guid loggedUserId);
    }
}

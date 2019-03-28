using Common.Results;
using DataModel.Entities;
using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.StoredProcedures
{
    public interface IUserServiceSQL
    {
        ServiceResult<User> GetUser(Guid userId, Guid? groupLogKey = null);
        Task<ServiceResult<UserDetail>> CreateUserWithAddress(UserDetail user, Guid? groupLogKey = null);
        ServiceResult<bool> DeleteUser(Guid userId, Guid? groupLogKey = null);
    }
}

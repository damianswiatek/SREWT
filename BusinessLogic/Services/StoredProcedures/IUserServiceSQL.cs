using Common.Results;
using DataModel.Entities;
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
    }
}

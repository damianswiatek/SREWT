using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures.Mappers
{
    public class UserMap : BaseOneWayMapper<Dictionary<string, object>, User>
    {
        protected override void MapCore(Dictionary<string, object> source, User target)
        {
            target.Id = source["Id"] == DBNull.Value ? Guid.Empty : Guid.Parse(source["Id"].ToString());
            target.Username = source["Username"]?.ToString();
        }
    }
}

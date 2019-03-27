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
            target.Address_Id = source["Address_Id"] == DBNull.Value ? Guid.Empty : Guid.Parse(source["Address_Id"].ToString());
            target.Username = source["Username"]?.ToString();
            target.Company_Id = source["Company_Id"] == DBNull.Value ? Guid.Empty : Guid.Parse(source["Company_Id"].ToString());
            target.Firstname = source["Firstname"]?.ToString();
            target.Lastname = source["Lastname"]?.ToString();
            target.PasswordHash = "PASSWORD";
            target.Pesel = source["Pesel"]?.ToString();
            target.PhoneNumber = source["Pesel"]?.ToString();
            target.VacationDays = source["VacationDays"] == DBNull.Value ? 0 : int.Parse(source["VacationDays"].ToString());
        }
    }
}

using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository.StoredProcedures.Mappers
{
    public class UserDetailMap : BaseOneWayMapper<Dictionary<string, object>, UserDetail>
    {
        protected override void MapCore(Dictionary<string, object> source, UserDetail target)
        {
            target.Id = source["Id"] == DBNull.Value ? Guid.Empty : Guid.Parse(source["Id"].ToString());
            target.Username = source["Username"]?.ToString();
            target.Firstname = source["Firstname"]?.ToString();
            target.Lastname = source["Lastname"]?.ToString();
            target.Pesel = source["Pesel"]?.ToString();
            target.PhoneNumber = source["Pesel"]?.ToString();
            target.VacationDays = source["VacationDays"] == DBNull.Value ? 0 : int.Parse(source["VacationDays"].ToString());
            target.City = source["City"]?.ToString();
            target.Polity = source["Polity"]?.ToString();
            target.PostalCode = source["PostalCode"]?.ToString();
            target.Street = source["Street"]?.ToString();
        }
    }
}

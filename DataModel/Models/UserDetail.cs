using DataModel.Repository.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public class UserDetail : IMappableDTO
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Pesel { get; set; }
        public int VacationDays { get; set; }
        
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Polity { get; set; }

        public UserDetail()
        {
            this.Id = Guid.Empty;
        }
    }
}

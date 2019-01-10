using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SREWT.Models
{
    public class UserData
    {
        public Guid InternalToken { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Pesel { get; set; }
        public int VacationDays { get; set; }
        public string Roles { get; set; }

        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Polity { get; set; }

        public UserData() { }
    }
}
using DataModel.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace SREWT.Models
{
    public class LoggedUser
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string InternalToken { get; set; }
        public string PasswordHash { get; set; }
        public List<string> Roles { get; set; }
        public List<Claim> Claims { get; set; }

        public LoggedUser()
        {
            this.Roles = new List<string>();
            this.Claims = new List<Claim>();
        }
        public LoggedUser(User user)
        {
            this.Id = user.Id;
            this.Username = user.Username;
            this.InternalToken = user.InternalToken.ToString();
            this.PasswordHash = user.PasswordHash;
            this.Roles = user.Roles != null ? JsonConvert.DeserializeObject<List<String>>(user.Roles) : new List<string>();
            this.Claims =  new List<Claim>();
        }
    }
}
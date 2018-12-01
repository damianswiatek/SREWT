using DataModel.Entities.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Entities
{
    public class User : EntityBase
    {
        public Guid InternalToken { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string ReversedPhoneNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Roles { get; set; }
        public DateTime RegistrationDate { get; set; }
        #region Deducted Properties
        /// <summary>
        /// A proxy for getting and setting Roles property as List of strings directly from and to JSON fromat.
        /// </summary>
        public List<String> RolesList { get { return JsonConvert.DeserializeObject<List<String>>(this.Roles); } set { this.Roles = JsonConvert.SerializeObject(value); } }
        #endregion
        

        public User()
        {
        }
    }

    #region Mapper
    public class UserMap : EntityMapBase<User>
    {
        public UserMap()
        {
            // Table name
            this.ToTable("Users");

            // Properties
            this.Property(t => t.InternalToken).HasColumnName("InternalToken")
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_UserInternalToken") { IsUnique = true }));
            this.Property(t => t.Username)
                .HasColumnName("Username")
                .IsRequired();
            this.Property(t => t.PasswordHash)
                .HasColumnName("PasswordHash")
                .IsRequired();
            this.Property(t => t.Firstname).HasColumnName("Firstname");
            this.Property(t => t.Lastname).HasColumnName("Lastname");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Street).HasColumnName("Street");
            this.Property(t => t.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_UserPhoneNumber") { IsUnique = true }));
            this.Property(t => t.ReversedPhoneNumber)
                .HasColumnName("ReversedPhoneNumber")
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_UserReversedPhoneNumber") { IsUnique = true }));

            this.Property(t => t.RegistrationDate).HasColumnName("RegistrationDate").IsRequired();
            this.Property(t => t.Roles).HasColumnName("Roles");

            // Relationships
        }
    }
    #endregion
}

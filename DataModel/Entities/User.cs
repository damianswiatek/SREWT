using DataModel.Entities.Base;
using DataModel.Repository.StoredProcedures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace DataModel.Entities
{
    public class User : EntityBase, IMappableDTO
    {
        public Guid InternalToken { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Pesel { get; set; }
        public int VacationDays { get; set; }
        public string Roles { get; set; }

        public Guid? Company_Id { get; set; }
        [ForeignKey("Company_Id")]
        public virtual Company Company { get; set; }

        public Guid? Address_Id { get; set; }
        [ForeignKey("Address_Id")]
        public virtual Address Address { get; set; }

        //public virtual List<Address> Addresses { get; set; }
        public virtual List<Conclusion> Conclusions { get; set; }

        #region Deducted Properties
        /// <summary>
        /// A proxy for getting and setting Roles property as List of strings directly from and to JSON fromat.
        /// </summary>
        public List<String> RolesList
        {
            get { return this.Roles != null ? JsonConvert.DeserializeObject<List<String>>(this.Roles) : null; }
            set { this.Roles = JsonConvert.SerializeObject(value); }
        }
        #endregion


        public User()
        {
            //this.Addresses = new List<Address>();
            this.Conclusions = new List<Conclusion>();
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
            this.Property(t => t.Pesel).HasColumnName("Pesel");
            this.Property(t => t.VacationDays).HasColumnName("VacationDays");
            this.Property(t => t.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .IsRequired()
                .HasMaxLength(20);
            this.Property(t => t.Roles).HasColumnName("Roles");

            // Relationships
            this.HasMany(t => t.Conclusions).WithOptional(t => t.User).HasForeignKey(t => t.User_Id).WillCascadeOnDelete(false);
        }
    }
    #endregion
}

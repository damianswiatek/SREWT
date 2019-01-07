using DataModel.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    public class Address : EntityBase
    {
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Polity { get; set; }

        public Guid? User_Id { get; set; }
        public virtual User User { get; set; }
    }

    public class AddressMap : EntityMapBase<Address>
    {
        public AddressMap()
        {
            // Table name
            this.ToTable("Addresses");

            // Properties
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Street).HasColumnName("Street");
            this.Property(t => t.Polity).HasColumnName("Polity");

            // Relationships
            //this.HasMany(t => t.Addresses).WithOptional(t => t.Company).HasForeignKey(t => t.Company_Id).WillCascadeOnDelete(false);
        }
    }
}

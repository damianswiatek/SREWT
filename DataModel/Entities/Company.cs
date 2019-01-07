using DataModel.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    public class Company : EntityBase
    {
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string TaxpayerIdentyficationNumber { get; set; }
        public string Regon { get; set; }

        public Guid? Address_Id { get; set; }
        //[ForeignKey("Address_Id")]
        public virtual Address Addresses{ get; set; }

        //public virtual List<Address> Addresses { get; set; }
        public virtual List<User> Users { get; set; }

        public Company()
        {
            //this.Addresses = new List<Address>();
            this.Users = new List<User>();
        }
    }

    public class CompanyMap : EntityMapBase<Company>
    {
        public CompanyMap()
        {
            // Table name
            this.ToTable("Companies");

            // Properties
            this.Property(t => t.ShortName).HasColumnName("ShortName");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.TaxpayerIdentyficationNumber).HasColumnName("TaxpayerIdentyficationNumber");
            this.Property(t => t.Regon).HasColumnName("Regon");

            // Relationships
            this.HasMany(t => t.Users).WithOptional(t => t.Company).HasForeignKey(t => t.Company_Id).WillCascadeOnDelete(false);
        }
    }
}

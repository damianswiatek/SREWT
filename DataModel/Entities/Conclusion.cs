using DataModel.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities
{
    public class Conclusion : EntityBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string VacationType { get; set; }
        public bool Accepted { get; set; }
        public DateTime AcceptedDate { get; set; }

        public Guid? User_Id { get; set; }
        public virtual User User { get; set; }
    }

    public class ConclusionMap : EntityMapBase<Conclusion>
    {
        public ConclusionMap()
        {
            // Table name
            this.ToTable("Conclusions");

            // Properties
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.VacationType).HasColumnName("VacationType");
            this.Property(t => t.Accepted).HasColumnName("Accepted");
            this.Property(t => t.AcceptedDate).HasColumnName("AcceptedDate");
        }
    }
}

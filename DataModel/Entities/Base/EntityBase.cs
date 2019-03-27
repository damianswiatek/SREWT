
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities.Base
{
    public class EntityBase
    {
        #region Properties
        public Guid Id { get; set; }
        public DateTime? X_CreatedDate { get; set; }
        public DateTime? X_LastUpdateDate { get; set; }
        public DateTime? X_ArchivedDate { get; set; }
        public Boolean? X_Archived { get; set; }
        #endregion

        #region Constructors
        public EntityBase()
        {

        }
        #endregion

        #region Methods
        
        #endregion
    }

    public abstract class EntityMapBase<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : EntityBase
    {
        public EntityMapBase()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.X_CreatedDate).HasColumnName("X_CreatedDate");
            this.Property(t => t.X_LastUpdateDate).HasColumnName("X_LastUpdateDate");
            this.Property(t => t.X_ArchivedDate).HasColumnName("X_ArchivedDate");
            this.Property(t => t.X_Archived).HasColumnName("X_Archived");
        }
    }
}

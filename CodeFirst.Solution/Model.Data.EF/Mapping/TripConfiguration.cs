using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.EF.Mapping
{
    public class TripConfiguration : EntityTypeConfiguration<Trip>
    {
        public TripConfiguration()
        {
            //配置Identifier映射到TripId列，并设为主键，且默认值为newid()
            this.HasKey(i => i.Identifier)
                .Property(i => i.Identifier)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("TripId");

            //配置CostUSD的精度为20，小数位数为3
            this.Property(i => i.CostUSD).HasPrecision(20, 3);

            //配置Description的长度为500
            this.Property(i => i.Description).HasMaxLength(500);

            //配置RowVersion乐观并发检查
            this.Property(i => i.RowVersion).IsRowVersion();
        }
    }
}

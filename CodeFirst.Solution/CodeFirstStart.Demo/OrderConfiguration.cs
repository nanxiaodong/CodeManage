using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            //指定映射到数据库的名字
            this.ToTable("Orders","nxd");
            //指定主键OrderID为自动增长，且映射到数据库中的字段名称为“OrderID”
            this.HasKey(i => i.OrderID)
                .Property(i => i.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("OrderID");

            //指定OrderTitle字段映射到数据库中的字段名字为Title
            this.Property(i => i.OrderTitle).HasColumnName("Title");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class OrderDetailConfiguration : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailConfiguration()
        {
            //指定映射到数据库中的表名
            this.ToTable("OrderDetail");
            //指定主键OrderDetailID为自动增长，且映射到数据库中的字段名称为“OrderDetailID”
            this.HasKey(i => i.OrderDetailID)
                .Property(i => i.OrderDetailID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("OrderDetailID");

            //指定外键
            //this.HasRequired(i => i.Order).WithMany(t => t.OrderDetails).HasForeignKey(t => t.FK_Order);
            //this.HasOptional(i => i.Order).WithMany(t => t.OrderDetails).HasForeignKey(t => t.FK_Order);
            //this.HasRequired(i => i.Order).WithMany(t => t.OrderDetails).Map(t => t.MapKey("OrderID"));

            //指定外键并关闭级联删除功能
            this.HasRequired(i=>i.Order).WithMany(t=>t.OrderDetails).HasForeignKey(t=>t.FK_Order).WillCascadeOnDelete(false);
        }
    }
}

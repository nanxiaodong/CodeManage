using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.EF.Mapping
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            //配置映射到数据中的表名
            this.ToTable("MyAddress");

            //配置AddressId映射到AddressId列
            this.Property(i => i.AddressId).HasColumnName("AddressId");

            //配置StreetAddress长度为100并映射到StreetAddrress列 ，不支持Unicode内容   --生成数据库为varchar(100) 
            this.Property(i => i.StreetAddress).IsUnicode(false).HasMaxLength(100).HasColumnName("StreetAddress");

            //配置State设为固定长度为50并映射到State列   --生成数据库nchar(50)
            this.Property(i => i.State).IsFixedLength().HasMaxLength(50).HasColumnName("State");

            //配置City长度为50并映射到City列   --生成数据库为nvarchar(50)
            this.Property(i => i.City).HasMaxLength(50).HasColumnName("City");

            //配置ZipCode映射到ZipCode列，不支持Unicode内容，并设为固定长度为6  --生成数据库为char(6)
            this.Property(i => i.ZipCode).IsUnicode(false).IsFixedLength().HasMaxLength(6).HasColumnName("ZipCode");

            //忽略  --不会再数据库Address表中生成Remark字段
            this.Ignore(i => i.Remark);


            this.Property(i => i.Name).IsFixedLength().HasMaxLength(50);
            this.Property(i => i.AddressName).HasMaxLength(50);
        }
    }
}

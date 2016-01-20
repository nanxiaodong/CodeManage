using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.EF.Mapping
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            //配置SocialSecurityNumber不允许为空且乐观并发检查
            this.Property(i => i.SocialSecurityNumber).IsRequired().IsConcurrencyToken();

            //配置FirstName不允许为空
            this.Property(i => i.FirstName).IsRequired();

            //配置LastName不允许为空
            this.Property(i => i.LastName).IsRequired();

            //配置Photo映射到数据库的数据类型为image
            this.Property(i => i.Photo).HasColumnType("image");

            //配置RowVersion乐观并发检查
            this.Property(i => i.RowVersion).IsRowVersion();
        }
    }
}

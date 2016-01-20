using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.EF.Mapping
{
    public class UserExtendConfiguration:EntityTypeConfiguration<UserExtend>
    {
        public UserExtendConfiguration()
        {
           // this.HasRequired(i => i.User).WithMany(t => t.UserExtends).HasForeignKey(t => t.Fk_User);
            //this.HasOptional(i => i.User).WithMany(t => t.UserExtends);//能够生成数据库，但codeFirst会自动生成外键User_Id
            this.HasRequired(i => i.User).WithMany(t => t.UserExtends).Map(m => m.MapKey("sha"));//能够生成数据库，指定一个外键名字，Fk_UserID不属于UserExtend实体属性

        }
    }
}

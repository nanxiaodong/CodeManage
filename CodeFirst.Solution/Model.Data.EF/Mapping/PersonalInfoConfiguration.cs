using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.EF.Mapping
{
    public class PersonalInfoConfiguration : EntityTypeConfiguration<PersonalInfo>
    {
        public PersonalInfoConfiguration()
        {
            //配置DietryRestrictions长度为100
            this.Property(i => i.DietryRestrictions).HasMaxLength(100);
        }
    }
}

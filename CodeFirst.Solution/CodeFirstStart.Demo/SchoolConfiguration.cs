using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class SchoolConfiguration : EntityTypeConfiguration<School>
    {
        //public SchoolConfiguration()
        //{
        //    this.Map<Teacher>(i => i.ToTable("Teachers"));
        //}

        public SchoolConfiguration()
        {
            this.Map(i=>i.ToTable("Schoolss")).Map<Teacher>(i=>i.ToTable("Teacherss"));
        }
    }
}

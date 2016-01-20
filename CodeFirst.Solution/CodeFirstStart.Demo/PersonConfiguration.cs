using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            this.Property(i => i.Name).HasColumnName("PeosonName");

            Map(i =>
            {
                i.Properties(d => new
                {
                    d.Age, d.Address
                });
                i.ToTable("PersonInfo");
            });
        }
    }
}

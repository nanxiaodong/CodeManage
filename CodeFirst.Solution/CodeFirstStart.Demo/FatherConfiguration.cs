using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class FatherConfiguration : EntityTypeConfiguration<Father>
    {
        public FatherConfiguration()
        {
            this.HasKey(i => i.Id)
                .Property(i => i.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("IdKey");

            this.Map(i =>i.ToTable("Father"))
                .Map<Son>(i =>
                {
                    i.ToTable("Son");
                    i.MapInheritedProperties();
                });
        }
    }
}

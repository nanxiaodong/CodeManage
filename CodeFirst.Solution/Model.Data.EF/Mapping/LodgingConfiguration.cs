using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.EF.Mapping
{
   public class LodgingConfiguration:EntityTypeConfiguration<Lodging>
   {
       public LodgingConfiguration()
       {
           //this.HasRequired(d => d.Destination).WithMany(l => l.Lodgings).HasForeignKey(t => t.DestinationId).WillCascadeOnDelete(true);
           this.HasOptional(d => d.Destination).WithMany(i => i.Lodgings).Map(i => i.MapKey("DestinationId"));
       }
    }
}

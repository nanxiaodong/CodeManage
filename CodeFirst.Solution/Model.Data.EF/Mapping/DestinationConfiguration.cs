using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.EF.Mapping
{
    public class DestinationConfiguration : EntityTypeConfiguration<Destination>
    {
        public DestinationConfiguration ()
        {
            this.HasMany(i => i.Lodgings).WithRequired(t => t.Destination);
        }
    }
}

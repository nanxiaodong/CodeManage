using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Trip
    {
        public Guid Identifier { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal CostUSD { get; set; }

        public string Description { get; set; }

        public byte[] RowVersion { get; set; }
    }
}

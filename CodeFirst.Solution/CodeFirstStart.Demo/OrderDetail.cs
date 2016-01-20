using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        //public int OrderID { get; set; }
        public decimal Cost { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> FK_Order { get; set; }
        public Order Order { get; set; }
    }
}

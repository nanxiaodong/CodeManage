using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    //[Table("", Schema = "baga")]
    public class Order
    {
        public int OrderID { get; set; }
        //[Required, Column("Title")]
        public string OrderTitle { get; set; }
        public string CustomerName { get; set; }
        public DateTime TransactionDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}

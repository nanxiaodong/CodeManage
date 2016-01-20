using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public string ProductDetailName { get; set; }
        public Product Product { get; set; }
    }
}

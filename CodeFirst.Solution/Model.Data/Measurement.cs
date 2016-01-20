using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    //复杂类型
    public class Measurement
    {
        public int ID { get; set; }
        public decimal Reading { get; set; }
        public string Units { get; set; }
    }
}

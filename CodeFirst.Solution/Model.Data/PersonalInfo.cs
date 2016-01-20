using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    //复杂类型

    public class PersonalInfo
    {
        public int ID { get; set; }
        public Measurement Weight { get; set; }
        public Measurement Height { get; set; }
        public string DietryRestrictions { get; set; }
    }
}

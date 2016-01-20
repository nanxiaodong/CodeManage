using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    //复杂类型
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string Remark { get; set; }


        public string  Name { get; set; }
        public string AddressName { get; set; }
        public string Sex { get; set; }
        public string Desc { get; set; }

    }
}

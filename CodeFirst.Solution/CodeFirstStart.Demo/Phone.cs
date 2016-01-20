using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    // [NotMapped]
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        ////[NotMapped]
        //public string Type
        //{
        //    get
        //    {
        //        return _type;
        //    }
        //}

        //private string _type;
    }
}

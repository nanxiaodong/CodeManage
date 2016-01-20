using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class Father
    {
        public int Id { get; set; }
        public string FatherName { get; set; }
        public string FatherAdress { get; set; }
    }
    public class Son : Father
    {
        public int SonId { get; set; }
        public string SonName { get; set; }
        public int Age { get; set; }
    }
}

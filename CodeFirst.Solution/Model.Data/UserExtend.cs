using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class UserExtend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fk_User { get; set; }
        public virtual User User { get; set; }
    }
}

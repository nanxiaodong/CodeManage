using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<Role> Roles { get; set; }
    }
}

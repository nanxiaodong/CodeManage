using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    //[Table("Teacher")]
    public class Teacher : School
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
    }
}

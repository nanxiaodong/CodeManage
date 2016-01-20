using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    [Table("Computer")]
    public class Video
    {
        [Key, ForeignKey("Computer")]
        public int Id { get; set; }
        public int VideoId { get; set; }
        public string VideoName { get; set; }
        public Computer Computer { get; set; }
    }
}

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
    public  class Computer
    {
        [Key, ForeignKey("Video")]
        public int Id { get; set; }
        public int ComputerId { get; set; }
        public string Name { get; set; }
        public Video Video { get; set; }
    }
}

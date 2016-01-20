using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStart.Demo
{
    public abstract class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
    }

    public class Dog : Animal
    {
        public int DogId { get; set; }
        public string Run { get; set; }
    }

    public class Cat : Animal
    {
        public int CatId { get; set; }
        public string Eat { get; set; }
    }
}

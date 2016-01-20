using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39ref和out
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            M1(num);
            Console.WriteLine(num);//10   值传递：传递的是栈中内容

            string name = "nxd";
            M2(name);
            Console.WriteLine(name);//nxd

            Person p = new Person { Name = "123" };
            M3(p);
            Console.WriteLine(p.Name);//234

            M4(ref num);
            Console.WriteLine(num);//11   ref引用传递，传递的是栈本身的地址，不是栈中的内容


            Console.ReadKey();
        }

        static void M1(int n)
        {
            n = n + 1;
        }
        static void M2(string name)
        {
            name = name + "test";
        }
        static void M3(Person p)
        {
            p.Name = "234";
        }
        static void M4(ref int n)
        {
            n = n + 1;
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}

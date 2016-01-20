using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08预处理指令关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 100;
            checked
            {
                byte c =(byte)(256+a);
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
        [Conditional("Debug")]
        private static void ShowMessage()
        {
            Console.WriteLine("It's debug...");
        }
    }
}

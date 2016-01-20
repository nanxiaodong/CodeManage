using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33命名参数和可选参数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(1, 2, 3));//参数值:x为1，y为2，z为3
            Console.WriteLine(MyMethod(1, z: 200));//参数值:x为1，y为10，z为200
            Console.ReadKey();
        }
        public static string MyMethod(int x,int y=10,int z=100)
        {
            return string.Format("参数值:x为{0}，y为{1}，z为{2}", x, y, z);
        }
    }
}

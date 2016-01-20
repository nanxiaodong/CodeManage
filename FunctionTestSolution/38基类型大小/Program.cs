using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38基类型大小
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sizeof(char));//2个字节
            Console.WriteLine(sizeof(int));//4个字节
            Console.WriteLine(sizeof(double));//8个字节
            Console.WriteLine(sizeof(bool));//1个字节
            Console.WriteLine(sizeof(long));//8个字节
            Console.WriteLine(sizeof(short));//2个字节
            Console.WriteLine(sizeof(byte));//1个字节

            Show();

            Console.ReadKey();
        }
        static void Show(params int[] nums)
        {
            if (nums == null)
            {
                Console.WriteLine("nums为null，不科学啊！");
            }
            else
            {
                Console.WriteLine(nums.Count());
                Console.WriteLine(nums.Length);
            }
        }
    }
}

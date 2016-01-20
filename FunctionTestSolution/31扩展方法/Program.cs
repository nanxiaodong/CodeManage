using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31扩展方法
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
    static class MyExtensions
    {
        //扩展String方法，对已有程序集的扩展
        public static void TellType(this string str)
        {
            Console.WriteLine("我是字符串：{0}", str);
        }
        //扩展方法必须实现为静态方法，只能声明与非泛型或非嵌套的静态类中，并且必须以this关键字作为其第一个参数修饰符。
        //在编译器编译时，将根据调用类型string来查找TellType实实例方法还是扩展方法，如果同时找到实例方法和扩展方法，则根据实例方法优先的原则
        //调用string的实例方法，否则再调用该扩展方法。
    }
}

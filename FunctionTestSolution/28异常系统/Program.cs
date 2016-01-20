using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28异常系统
{
    class Program
    {
        static void Main(string[] args)
        {
            //OverflowException//算术运算、类型转换或转换操作导致溢出时引发的异常。
            //StackOverflowException//密封类，不可继承，因包含的嵌套方法调用过多而导致执行堆栈溢出时引发的异常。 此类不能被继承。
            //OutOfMemoryException//没有足够的内存继续执行程序时引发的异常。
            //NullReferenceException//引用空引用对象时引发。
            //InvalidCastException//因无效类型转换或显式转换引发的异常。
            //IndexOutOfRangeException//密封类，不可继承，试图访问索引超出数组界限的数组元素时引发的异常。 此类不能被继承。
            //ArgumentException//当向方法提供的参数之一无效时引发的异常。
            //ArgumentNullException//当将空引用（在 Visual Basic 中为 Nothing）传递给不接受它作为有效参数的方法时引发的异常。
            //DivideByZeroException//试图用零除整数值或十进制数值时引发的异常。
            //ArithmeticException//因算术运算、类型转换或转换操作中的错误而引发的异常
            //FileNotFoundException//尝试访问磁盘上不存在的文件失败时引发的异常。需要引用using System.IO;

            try
            {
                TestException();
            }
            catch (Exception ex)
            {
                //输出当前调用堆栈上的异常的抛出位置
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }
        private static void TestException()
        {
            //直接抛出异常
            throw new FileNotFoundException("Error.");
        }
    }
}

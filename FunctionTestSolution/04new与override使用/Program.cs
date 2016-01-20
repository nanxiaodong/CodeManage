using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04new与override使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.ShowNumber();

            IntNumber intNumber = new IntNumber();
            intNumber.ShowInfo();
            intNumber.ShowNumber();

            IntNumber number = new IntNumber();

            number.ShowInfo();

            number.ShowNumber();

            Console.ReadKey();
        }
    }
    class Number
    {
        public static int i = 123;
        public virtual void ShowInfo()
        {
            Console.WriteLine("base class....");
        }
        public virtual void ShowNumber()
        {
            Console.WriteLine(i.ToString());
        }
    }
    class IntNumber:Number
    {
        new public static int i = 456;
        public new  void ShowInfo()
        {
            Console.WriteLine("Derived class....");
        }
        public virtual void ShowNumber()
        {
            Console.WriteLine("base number is:{0}",Number.i.ToString());
            Console.WriteLine("New number is :{0}",i.ToString());
        }
    }
}

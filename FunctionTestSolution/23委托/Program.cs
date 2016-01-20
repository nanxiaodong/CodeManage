using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23委托
{
    class Program
    {
        #region start
        ////定义委托
        ////1.使用delegate关键字
        ////2.这个委托将来存储的方法如果没有返回值，那么委托也要定义成void；如果委托没有参数，那么将来传递的方法也不能有参数

        ////声明一个委托
        //public delegate void CalculateDelegate(Int32 x, Int32 y);
        //public delegate void VoidDelegate();

        ////创建与委托关联的方法，二者具有相同的返回值类型和参数列表
        //public static void Add(Int32 x, Int32 y)
        //{
        //    Console.WriteLine(x + y);
        //}

        ////创建与委托关联的方法，二者具有相同的返回值类型和参数列表
        //public static void Subtract(Int32 x, Int32 y)
        //{
        //    Console.WriteLine(x - y);
        //}

        //public static void VoidFunc()
        //{
        //    Console.WriteLine("这个是无参数据的方法！");
        //}

        //public static void Test(VoidDelegate Func)
        //{
        //    Func();
        //}

        ////定义委托类型变量
        //private static CalculateDelegate myDelegate;
        //private static VoidDelegate voidDelegate;

        //static void Main(string[] args)
        //{
        //    //进行委托绑定
        //    myDelegate = new CalculateDelegate(Add);
        //    voidDelegate = new VoidDelegate(VoidFunc);
        //    Test(VoidFunc);

        //    //回调Add方法
        //    myDelegate(100, 200);

        //    CalculateDelegate calculateDelegate1 = Subtract;
        //    calculateDelegate1(100, 300);
        //    voidDelegate();
        //    Console.ReadKey();
        //} 
        #endregion

        #region 无参数无返回值-委托声明

        ////声明委托
        //public delegate void VoidDelegate();

        ////定义相关方法
        //static void VoidFunc()
        //{
        //    Console.WriteLine("这是一个无参数无返回值的方法！");
        //}

        ////定义委托变量
        //private static VoidDelegate voidDelegate;

        //static void Test(VoidDelegate canshu)
        //{
        //    canshu();
        //}

        //static void Main(string[] args)
        //{
        //    voidDelegate = new VoidDelegate(VoidFunc);
        //    voidDelegate();

        //    VoidDelegate voidDelegate1 = VoidFunc;
        //    voidDelegate1();



        //    Test(VoidFunc);

        //    Console.ReadKey();
        //}
        #endregion

        #region 多播委托
        //public delegate void MyDelegate(int x, int y);

        //public static void Add(int x, int y)
        //{
        //    Console.WriteLine(x + y);
        //}
        //public static void Subtract(int x, int y)
        //{
        //    Console.WriteLine(x - y);
        //}

        //static void Main(string[] args)
        //{
        //    MyDelegate myDelegate = Add;
        //    myDelegate += Subtract;
        //    myDelegate -= Add;
        //    myDelegate(10, 20);

        //    Console.ReadKey();
        //}
        #endregion

        #region 匿名方法
        public delegate void MyDelegate();//无参数委托声明
        public delegate void ParamsDelegate(string msg);//有参数委托声明
        public delegate int IntDelegate(int num);//有参数及返回值的委托声明

        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate
            {
                Console.WriteLine("委托匿名方法！！！");
            };
            myDelegate();



            ParamsDelegate paramsDelegate = delegate(string message)
            {
                Console.WriteLine(message);
            };
            paramsDelegate("这是有参数的匿名方法！");//这是有参数的匿名方法！

            IntDelegate intDelegate = delegate(int num)
            {
                num++;
                return num;
            };
            int res = intDelegate(100);
            Console.WriteLine(res);//101
            Console.ReadKey();
        }
        #endregion

    }
}

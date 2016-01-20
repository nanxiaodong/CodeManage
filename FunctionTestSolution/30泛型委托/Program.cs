using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30泛型委托
{
    class Program
    {
        #region 泛型委托
        ////声明一个泛型委托
        //public delegate string MyDelegate<T>(T t);

        ////测试方法
        //public static string GetMsg(string txt)
        //{
        //    return txt;
        //}
        //static void Main(string[] args)
        //{
        //    MyDelegate<string> myDelegate = new MyDelegate<string>(GetMsg);

        //    Console.WriteLine(myDelegate("这是泛型委托！"));
        //    Console.ReadKey();
        //} 
        #endregion


        #region Func

        private static Func<int, string> GetCompany = (m) => { return m.ToString(); };

        static void Main(string[] args)
        {
            var result = GetCompany(200001);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        #endregion
        
    }
}

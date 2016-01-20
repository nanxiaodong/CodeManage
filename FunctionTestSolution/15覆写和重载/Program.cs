using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15覆写和重载
{
    class BaseClass
    {
        public virtual void MyFunc<T>(T t) where T : new()
        {
            Console.WriteLine("{0} in Base", t.ToString());
        }
        public void MyFunc(string t)
        {
            Console.WriteLine(t);
        }
    }
    class DerivedClass : BaseClass
    {
        static void Main(string[] args)
        {
            BaseClass c = new BaseClass();
            c.MyFunc<int>(100);
            c.MyFunc("100");
            Console.ReadKey();
        }
    }


    #region 泛型方法覆写
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BaseClass b = new DerivedClass();
    //        b.MyFunc<int>(100);
    //        b.MyFunc<char>('A');
    //        //b.MyFunc<string>("Hello");//出现变异错误  原因：string类型没有公共的无参构造函数
    //        Console.ReadKey();
    //    }
    //}
    //class BaseClass
    //{
    //    public virtual void MyFunc<T>(T t) where T : new()
    //    {
    //        Console.WriteLine("{0} in Base", t.ToString());
    //    }
    //}
    //class DerivedClass : BaseClass
    //{
    //    public override void MyFunc<T>(T t)
    //    {
    //        Console.WriteLine("{0} in Dervied", t.ToString());
    //    }
    //} 
    #endregion
}

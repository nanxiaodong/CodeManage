using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17静态和非静态
{
    #region 静态类
    public class MyStatic
    {
        //声明静态字段
        private static string staticString = "static string";

        //声明静态属性
        private static string StaticString
        {
            get { return staticString; }
            set { staticString = value; }
        }

        //实现静态方法
        public static void ShowMsg()
        {
            Console.WriteLine(StaticString);
        }

        //public static void Main()
        //{
        //    //访问静态方法
        //    MyStatic.ShowMsg();
        //    Console.ReadKey();
        //}

    }
    #endregion

    #region ClassHelper
    class ClassHelper
    {
        //定义静态字段
        public static string StaticString = "Initial static string";
        //定义非静态字段
        public string NonStaticString = "Initial non static string";

        //静态无参构造函数
        static ClassHelper()
        {
            //只能初始化静态成员
            StaticString = "Change static string in static constructor.";
        }

        //实例构造函数
        public ClassHelper()
        {
            //初始化“非静态”成员
            NonStaticString = "Change non static string in instance constructor.";
            //初始化“静态”成员
            StaticString = "Change static string in instance constructor.";
        }
        //public static void Main()
        //{
        //    Console.WriteLine(ClassHelper.StaticString);

        //    ClassHelper ch = new ClassHelper();
        //    Console.WriteLine(ClassHelper.StaticString);
        //    Console.WriteLine(ch.NonStaticString);

        //    Console.ReadKey();
        //}
    }
    #endregion

    #region MyMethodClass
    public class MyMethodClass
    {
        private static string staticString = "A static string.";
        private string nonStaticString = "Not a static string.";

        //静态成员
        //不能修饰为virtual、abstract或override
        public static void StaticMethod()
        {
            //只能访问静态成员
            //不能以this访问
            Console.WriteLine(staticString);
        }

        //实例成员
        public void NonStaticMethod()
        {
            //可以访问静态成员
            Console.WriteLine(staticString);

            //也可以访问实例成员
            //可以使用this关键字
            Console.WriteLine(this.nonStaticString);
        }
    }
    class MyMethodClassDerived : MyMethodClass
    {
        //派生类定义及实现
    }

    class Test_MyMethodClass
    {
        static void Main(string[] args)
        {

            MyMethodClass mms = new MyMethodClass();
            //实例方法只能由对象访问
            mms.NonStaticMethod();
            //静态方法只能由类访问
            MyMethodClass.StaticMethod();

            //派生类可以访问静态方法，但是不能覆写静态方法
            MyMethodClassDerived.StaticMethod();

            Console.ReadKey();
        }
    }
    #endregion

}

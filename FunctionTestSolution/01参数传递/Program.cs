using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01参数传递
{
    /*按值传递的实质为传递值，不同的是这个值在值类型和引用类型的表现是不同的
     *参数为值类型时，“值”为实例本身，因此传递的是实例拷贝，不会对原来的实例产生影响
     *参数为引用类型时，“值”为对象引用，因此传递的是引用地址拷贝，会改变原来对象的引用指向
    */

    #region 值类型参数按值传递
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 值类型实例传递的是该值类型实例的一个拷贝，被调用方法操作的是属于其本身的实例拷贝
             * 因此不影响原来调用方法中的参数值
             */
            int a = 10;
            Add(a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        private static void Add(int i)
        {
            i = i + 10;
            Console.WriteLine(i);
        }
    }
    #endregion

    #region 引用类型参数按值传递
    //class Program
    //{
    //    /*
    //     * 
    //     */
    //    static void Main(string[] args)
    //    {
    //        ArgsByrRef abf = new ArgsByrRef();
    //        AddRef(abf);
    //        Console.WriteLine(abf.i);
    //        Console.ReadKey();
    //    }
    //    private static void AddRef(ArgsByrRef abf)
    //    {
    //        abf.i = 20;
    //        Console.WriteLine(abf.i);
    //    }
    //}
    //class ArgsByrRef
    //{
    //    public int i = 10;
    //}
    #endregion

    #region string类型按值传递
    //class StringArgs
    //{

    //    /* 首先，string str="Old String"产生了一个新的string对象
    //     * 然后执行ChangeStr(aStr)，也就是进行引用类型参数的按值传递，
    //     * ChangeStr(aStr)并没有改变str的引用地址
    //     */
    //    static void Main(string[] args)
    //    {
    //        string str = "Old String";
    //        ChangeStr(str);
    //        Console.WriteLine(str);
    //        Console.ReadKey();
    //    }
    //    static void ChangeStr(string aStr)
    //    {
    //        aStr = "Change String";
    //        Console.WriteLine(aStr);
    //    }
    //} 
    #endregion



    //按引用传递之ref和out

    /* 不管是值类型还是引用类型，按引用传递必须以ref或者out关键字来修饰，其规则是：
     * 1.方法定义和方法调用必须同时显示的使用ref或者out，否则将导致编译错误；
     * 2.CLR允许通过out或者ref参数来重载方法 
     * 
     * ref和out关键字将告诉编译器，方法传递的是参数地址，而不是参数本身
     */


    #region ref或out重载
    //class Test_RefAndOut
    //{
    //    //2.CLR允许通过out或者ref参数来重载方法 
    //    static void ShowInfo(string str)
    //    {
    //        Console.WriteLine(str);
    //    }
    //    static void ShowInfo(ref string str)
    //    {
    //        Console.WriteLine(str);
    //    }
    //} 
    #endregion

    #region 按引用传递之ref和out
    //class Test_Args
    //{
    //    /*
    //     * 不管参数本身是值类型还是引用类型，按引用传递时，传递的是参数的地址，也就是实例的指针
    //     */
    //    static void Main(string[] args)
    //    {
    //        int i = 100;
    //        string str = "One";
    //        ChangeByValue(ref i);
    //        ChangeByRef(ref str);
    //        Console.WriteLine(i);
    //        Console.WriteLine(str);
    //        Console.ReadKey();
    //    }
    //    static void ChangeByValue(ref int iValue)
    //    {
    //        iValue = 200;
    //    }
    //    static void ChangeByRef(ref string sValue)
    //    {
    //        sValue = "One more.";
    //    }
    //} 
    #endregion

    #region ref和out的异同
    /* 相同点：从CLR角度来说，ref和out都是指示编译器传递实例指针，在表现行为上是相同的
     * 不同点：使用的机制不同，ref要求传递之前的参数首先显示初始化，而out不需要。也就是说，
     *        使用ref的参数必须是一个实际的对象，而不能指向null；而使用out的参数可以接受指向null
     *        的对象，然后在调用的方法内部必须完成对象的初始化
     */
    //class Test_RefAndOut
    //{
    //    static void Main(string[] args)
    //    {

    //    }
    //    static void ShowInfo(string str)
    //    {
    //        Console.WriteLine(str);
    //    }
    //    static void ShowInfo(ref string str)
    //    {
    //        Console.WriteLine(str);
    //    }
    //    //ShowInfo不能定义仅在ref和out上有差别的重载方法
    //    //【从编译角度看，不管是ref还是out，编译之后的代码是完全相同的】
    //    //static void ShowInfo(out string str)
    //    //{
    //    //    str = "Hello World!";
    //    //    Console.WriteLine(str);
    //    //}
    //}
    #endregion
}

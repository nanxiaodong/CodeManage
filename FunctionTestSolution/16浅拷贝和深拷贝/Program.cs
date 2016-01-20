using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16浅拷贝和深拷贝
{
    #region 浅拷贝
    class Student
    {
        public string Name { get; set; }
        public Int32 Age;

        public Student(string name, Int32 age)
        {
            Name = name;
            Age = age;
        }
        public void ShowInfo()
        {
            Console.WriteLine("{0}'s age is {1}.", Name, Age);
        }
    }
    class Test_ObjectClone
    {
        //static void Main(string[] args)
        //{
        //    Student s1 = new Student("wang",25);
        //    //执行浅拷贝
        //    Student s2 = s1;

        //    s2.Age = 26;
        //    s1.ShowInfo();
        //    Console.ReadKey();

        //    //执行结果为：wang's age is 26.
        //}
    }
    #endregion

    #region 深拷贝
    class Test_ObjectDeepCopy
    {
        static void Main(string[] args)
        {
            Int32 i = 100;
            Int32 j = i;
            j = 200;    

            Console.WriteLine(i);
            Console.ReadKey();

            //执行结果为：100
        }
        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }

    #endregion
}

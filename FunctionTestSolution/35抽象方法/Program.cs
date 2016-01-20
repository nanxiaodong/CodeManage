using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35抽象方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            p.Say();//学生开始说话了！

            Person p1 = new Teacher();
            p1.Say();//教师开始说话了！

            new Teacher().Say();//教师开始说话了！

            Console.ReadKey();
        }
    }
    abstract class Person
    {
        internal abstract void Say();
    }
    class Student : Person
    {
        internal override void Say()
        {
            Console.WriteLine("学生开始说话了！");
        }
    }
    class Teacher:Person
    {
        internal override void Say()
        {
            Console.WriteLine("教师开始说话了！");
        }
    }
}

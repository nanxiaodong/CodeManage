using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Chinese();
            p.Say();
            p.Sleeping();

          
            Console.ReadKey();
        }
    }

    public class Person
    {
        public virtual void Say()
        {
            Console.WriteLine("人类开始说话了！");
        }
        public virtual void Sleeping()
        {
            Console.WriteLine("人类睡觉了！");
        }
    }
    public class Chinese : Person
    {
        //方法重写
        public override void Say()
        {
            Console.WriteLine("中国人开始说话了！");
        }
        //在子类中写了一个全新的Sleeping方法，同时隐藏了从父类继承下来的Sleeping方法
        public new void Sleeping()
        {
            Console.WriteLine("中国人睡觉了！");
        }
    }

    public abstract class Animal
    {
        public abstract void Run();
    }
    public class Dog : Animal
    {
        public override void Run()
        {
            Console.WriteLine("狗开始跑了！");
        }
    }
}

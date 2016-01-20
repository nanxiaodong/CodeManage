using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14接口和抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal duck = new Duck("Duck");
            duck.MakeVoice();
            duck.Show();

            Animal dog = new Dog("Dog");
            dog.MakeVoice();
            dog.Show();
                
            IAction dogAction = new Dog("A big Dog");
            dogAction.Move();

            Console.ReadKey();
        }
    }
    //定义抽象类
    public abstract class Animal
    {
        protected string _name;
        //声明抽象属性
        public abstract string Name { get; }

        //声明抽象方法
        public abstract void Show();

        //实现一般方法
        public void MakeVoice()
        {
            Console.WriteLine("All Animals can make voice!");
        }
    }
    //定义接口
    public interface IAction
    {
        //定义公共方法标签
        void Move();
    }

    //实现抽象类和接口
    public class Duck : Animal, IAction
    {
        public Duck(string name)
        {
            _name = name;
        }

        //重载抽象方法
        public override void Show()
        {
            Console.WriteLine(_name + " is showing for you.");
        }

        //重载抽象属性
        public override string Name
        {
            get { return _name; }
        }
        //实现接口方法
        public void Move()
        {
            Console.WriteLine("Dock also can swimming...");
        }
    }

    public class Dog : Animal, IAction
    {
        public Dog(string name)
        {
            _name = name;
        }
        public override void Show()
        {
            Console.WriteLine(_name+" is showing for you...");
        }
        public override string Name
        {
            get { return _name; }
        }
        public void Move()
        {
            Console.WriteLine(_name+" also can run...");
        }
    }
}

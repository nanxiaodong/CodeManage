using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05base和this
{
    class Program
    {
        static void Main(string[] args)
        {
            //Audi audi = new Audi();
            //audi[1] = "A6";
            //audi[2] = "A8";
            //Console.WriteLine(audi[1]);

            //audi.Run();
            //audi.ShowResult();

            Car c = new Car();
            Vehicle v = c;

            Car[]cs=new Car[5];
            Vehicle[] vs = cs;

            

            Console.ReadKey();
        }
    }
    public class Action
    {
        public static void ToRun(Vehicle vehicle)
        {
            Console.WriteLine("{0} is running...", vehicle.ToString());
        }
    }
    public class Vehicle
    {
        private string name;
        private int speed;
        private string[] array = new string[10];

        public Vehicle()
        {

        }
        //限定被相似的名称隐藏的成员
        public Vehicle(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public virtual void ShowResult()
        {
            Console.WriteLine("The top speed of {0} is {1}.", name, speed);
        }

        public void Run()
        {
            //传递当前实例参数
            Action.ToRun(this);
        }

        //声明索引器，必须为this，这样就可以向数组一样来索引对象
        public string this[int param]
        {
            get { return array[param]; }
            set { array[param] = value; }
        }
    }
    public class Car : Vehicle
    {
        //派生类和基类通信，以base实现，基类首先被调用
        //指定创建派生类实例时应调用的基类构造函数
        public Car()
            : base("car", 200)
        { }

        public Car(string name, int speed)
            : this()
        { }

        public override void ShowResult()
        {
            //调用基类上已被其他方法重写的方法
            base.ShowResult();
            Console.WriteLine("It 's a car' s result.");
        }
    }
    public class Audi : Car
    {
        public Audi()
            : base("Audi", 300)
        { }
        public Audi(string name, int speed)
            : this()
        { }
        public override void ShowResult()
        {
            //直接基类如果有方法实现，则base只能继承其直接基类成员；
            //否则base会向上层基类访问
            base.ShowResult();
            base.Run();
            Console.WriteLine("It 's audi's result.");
        }
    }
}

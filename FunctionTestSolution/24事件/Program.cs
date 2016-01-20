using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24事件
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            //事件触发者
            CalculatorManager cm = new CalculatorManager();

            //事件绑定
            calculator.MyCalculator += cm.Add;
            calculator.CalculatorFunc(100, 200);


            Console.ReadKey();
        }
    }
    public class Calculator
    {
        //定义一个CalculateEventArgs，用于存放事件引发时向处理程序传递的状态信息
        public class CalculateEventArgs : EventArgs
        {
            public readonly int x, y;
            public CalculateEventArgs(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        //声明事件委托
        public delegate void CalculateEventHandler(object sender, CalculateEventArgs e);

        //定义事件成员，提供外部绑定
        public event CalculateEventHandler MyCalculator;

        //提供受保护的虚方法，可以由子类覆写来拒绝监视
        protected virtual void OnCalculator(CalculateEventArgs e)
        {
            if (MyCalculator != null)
            {
                MyCalculator(this, e);
            }
        }
        //进行计算，调用该方法表示有新的计算发生
        public void CalculatorFunc(int x, int y)
        {
            CalculateEventArgs e = new CalculateEventArgs(x, y);
            //通知所有的事件注册者
            OnCalculator(e);
        }
    }

    //定义事件触发者
    public class CalculatorManager
    {
        //定义消息通知方法
        public void Add(object sender, Calculator.CalculateEventArgs e)
        {
            Console.WriteLine(e.x + e.y);
        }
        public void Substract(object sender, Calculator.CalculateEventArgs e)
        {
            Console.WriteLine(e.x - e.y);
        }
    }

}

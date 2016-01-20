using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36简单工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你想要的笔记本品牌：");
            string brand = Console.ReadLine();
            var nb = CreateNotebook(brand);
            nb.Show();
            Console.ReadKey();
        }
        static Notebook CreateNotebook(string brand)
        {
            Notebook nb = null;
            switch (brand)
            {
                case "lenovo":
                    nb = new Lenovo();
                    break;
                case "dell":
                    nb = new Dell();
                    break;
                case "acer":
                    nb = new Acer();
                    break;
                default:
                    break;
            }
            return nb;
        }
    }

    /// <summary>
    /// 笔记本的父类
    /// </summary>
    abstract class Notebook
    {
        //定义一个抽象方法
        public abstract void Show();
    }
    class Lenovo : Notebook
    {
        public override void Show()
        {
            Console.WriteLine("联想笔记本！");
        }
    }
    class Dell : Notebook
    {
        public override void Show()
        {
            Console.WriteLine("戴尔笔记本！");
        }
    }
    class Acer : Notebook
    {
        public override void Show()
        {
            Console.WriteLine("Acer笔记本");
        }
    }
}

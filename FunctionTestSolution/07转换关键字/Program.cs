using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07转换关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAge age = new MyAge();

            //执行显示类型转换：Myage转换为Int32
            Int32 bornAge = (Int32)age;
            //执行隐式类型转换：Int32转换为MyAge
            age = DateTime.Now.Year;
            //执行隐式转换：MyAge转换为string
            Console.WriteLine(age);

            Console.ReadKey();
        }
    }
    class MyAge
    {
        public Int32 Age { get; set; }
        public MyAge()
        { }
        private MyAge(Int32 age)
        {
            this.Age = age;
        }

        //整形到MyAge的隐式转换
        public static implicit operator MyAge(Int32 year)
        {
            return new MyAge(year > 1980 ? (year - 1980) : -1);
        }
        //MyAge到整形的显示转换
        public static explicit operator Int32(MyAge age)
        {
            if (age == null)
            {
                throw new ArgumentNullException("参数为空！");
            }
            if (age.Age < 0 || age.Age > 150)
            {
                throw new ArgumentNullException("不可能的年龄值！");
            }
            return age.Age;
        }

        //MyAge到string类型的隐式转换
        public static implicit operator String(MyAge age)
        {
            return "我的年龄是：" + age.Age.ToString();
        }
    }
}

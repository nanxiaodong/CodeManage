using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11const和readonly
{
    class ConstAndReadonly
    {
        //声明字段
        private const string NAME = "nanxiaodong";
        private readonly Int32 AGE = 25;
        private readonly string SEX;
        private static readonly string PASSWORD = "000000";

        //构造函数
        public ConstAndReadonly()
        {
            AGE = 26;
        }
        public ConstAndReadonly(Int32 age, string sex)
        {
            AGE = age;
            SEX = sex;
        }
        //静态无参构造函数
        static ConstAndReadonly()
        {
            PASSWORD = "123456";
        }

        //局部常量定义
        public void InlineConst()
        {
            const string myDescription = "Good Night";
            Console.WriteLine(myDescription);
        }

        static void Main(string[] args)
        {
            //访问静态成员
            Console.WriteLine(ConstAndReadonly.NAME);
            Console.WriteLine(ConstAndReadonly.PASSWORD);

            //访问非静态成员
            ConstAndReadonly cr = new ConstAndReadonly();
            Console.WriteLine(cr.AGE);
            Console.WriteLine(cr.SEX);

            ConstAndReadonly cr2 = new ConstAndReadonly(27,"Man");
            Console.WriteLine(cr2.AGE);
            Console.WriteLine(cr2.SEX);

            //局部常量
            cr.InlineConst();
            Console.ReadKey();
        }
    }
}

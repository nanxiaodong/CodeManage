using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22认识枚举
{
    class Program
    {
        static void Main(string[] args)
        {
            #region first

            #region 与整型转换
            ////枚举转换为整数
            //int i = (int)Week.Sun;
            //Console.WriteLine(i);//7
            ////将整型转换为枚举
            //Week day = (Week)7;
            //Console.WriteLine(day);//Sun

            ////使用Parse方法转化
            //Week day1 = (Week)Enum.Parse(typeof(Week),"7");
            //Console.WriteLine(day1);//Sun
            #endregion

            #region 与字符串的映射
            //Week day = (Week)Enum.Parse(typeof(Week), "Mon",true);
            //Console.WriteLine(day);//Mon

            //Week day1 = (Week)Enum.Parse(typeof(Week), "7");
            //Console.WriteLine(day1);//Sun  而不是Weekend
            #endregion

            #region GatNames
            ////获取枚举常数名称的数组
            //foreach (string item in Enum.GetNames(typeof(Week)))
            //{
            //    Console.Write(item.ToString()+"、");//Mon、Tue、Wed、Thur、Fri、Sat、Sun、Weekend
            //}
            // Console.WriteLine("\r\n");
            #endregion

            #region GetValues
            ////获取枚举常数值的数组
            //foreach (Week item in Enum.GetValues(typeof(Week)))
            //{
            //    Console.Write("{0}:{1}、", item.ToString("D"), item.ToString());//1:Mon、2:Tue、3:Wed、4:Thur、5:Fri、6:Sat、7:Sun、7:Sun
            //}
            #endregion

            #region IsDefined
            //if(Enum.IsDefined(typeof(Week),"Fri"))
            //{
            //    Console.WriteLine("ToDay is {0}.",Week.Fri.ToString("G"));
            //}
            #endregion

            #region GetUnderlyingType
            //Console.WriteLine(Enum.GetUnderlyingType(typeof(Week))); //System.Int32
            #endregion

            #region Flags作用
            //ColorStyle mycs = ColorStyle.Red | ColorStyle.Yellow | ColorStyle.Blue;
            //Console.WriteLine(mycs.ToString());//Red, Yellow, Blue  而不是21
            #endregion

            //Study s = Study.Flag2 | Study.Flag3;
            //Console.WriteLine(s.ToString()); 
            #endregion

            #region second
            #region GetValues
            //遍历所有的枚举值
            foreach (int value in Enum.GetValues(typeof(MicrosoftTechnology)))
            {
                Console.Write(value + ",");
            }

            Console.WriteLine();
            #endregion

            #region GetName

            var enumName = Enum.GetName(typeof(MicrosoftTechnology), 1);
            Console.WriteLine("GetName=" + enumName);
            #endregion

            #region GetNames
            //遍历获取所有的枚举名称
            foreach (var name in Enum.GetNames(typeof(MicrosoftTechnology)))
            {
                Console.Write(name + ",");
            }

            Console.WriteLine();
            #endregion

            #region GetEnumDescription
            //获取枚举值的描述信息
            var description = MicrosoftTechnology.CSharp.GetEnumDescription();
            Console.WriteLine(description);

            Console.WriteLine();
            #endregion

            #region Enum.Parse(string)

            const string type = "CSharp";
            var num = (int)Enum.Parse(typeof(MicrosoftTechnology), type);
            Console.WriteLine(num);

            #region 错误
            //const string type1 = "CSharpq";
            //var num1 = (int)Enum.Parse(typeof(MicrosoftTechnology), type1);
            //Console.WriteLine(num1);
            #endregion

            Console.WriteLine();

            #endregion

            #region Enum.TryParse(string)
            const string type2 = "SQlServer";
            MicrosoftTechnology enums;
            //第二个参数可写可不写，如果不写默认为false，将区分大小写，即type2与枚举中定义的一样
            //如果第二个参数为true,代表不区分大小写；false，代表区分大小写
            bool res = Enum.TryParse(type2, true, out enums);

            //如果转换成功，则res=true，enums的值为type2所对应的枚举；
            //如果转换失败，则res=false，enum的值为基础类型的默认值0，此值不是MicrosoftTechnology中的值


            bool res1 = Enum.TryParse<MicrosoftTechnology>(type2, out enums);

            Console.WriteLine(res);

            Console.WriteLine((int)enums);
            #endregion

            #region IsDefine：判断一个值对于一个枚举类型是否合法。

            Console.WriteLine("判断枚举的合法性：");
            //区分大小写
            Console.WriteLine(Enum.IsDefined(typeof(MicrosoftTechnology), 1));//True
            Console.WriteLine(Enum.IsDefined(typeof(MicrosoftTechnology), "SqlServer"));//True
            Console.WriteLine(Enum.IsDefined(typeof(MicrosoftTechnology), "SQlServer"));//False
            #endregion

            #region Enum.Format
            Colors myColor = Colors.Red;
            Console.WriteLine("The value of my color ({0}) is {1}", myColor, Enum.Format(typeof(Colors), myColor, "d"));

            //“G”、“g”、“X”、“x”、“F”、“f”、“D”或“d”。
            var G = Enum.Format(typeof(MicrosoftTechnology), MicrosoftTechnology.CSharp, "G");
            var g = Enum.Format(typeof(MicrosoftTechnology), MicrosoftTechnology.CSharp, "g");

            var X = Enum.Format(typeof(MicrosoftTechnology), MicrosoftTechnology.CSharp, "X");
            var x = Enum.Format(typeof(MicrosoftTechnology), MicrosoftTechnology.CSharp, "x");

            var F = Enum.Format(typeof(MicrosoftTechnology), MicrosoftTechnology.CSharp, "F");
            var f = Enum.Format(typeof(MicrosoftTechnology), MicrosoftTechnology.CSharp, "f");

            var D = Enum.Format(typeof(MicrosoftTechnology), MicrosoftTechnology.CSharp, "D");
            var d = Enum.Format(typeof(MicrosoftTechnology), MicrosoftTechnology.CSharp, "d");

            Console.WriteLine("G:" + G);
            Console.WriteLine("g:" + g);
            Console.WriteLine("X:" + X);
            Console.WriteLine("x:" + x);
            Console.WriteLine("F:" + F);
            Console.WriteLine("f:" + f);
            Console.WriteLine("D:" + D);
            Console.WriteLine("d:" + d);
            #endregion

            #region CompareTo
            //var my1 = MicrosoftTechnology.SqlServer;//4
            //var you1 = MicrosoftTechnology.CSharp;//1

            var my1 = MicrosoftTechnology.SqlServer;//4
            var you1 = MicrosoftTechnology.SilverLight;//16

            //IEnum1.CompareTo(IEnum2) 如果IEnum1>IEnum2,return:1;IEnum1<IEnum2,return:-1;

            int rrr1 = my1.CompareTo(you1);//if(my1>you1)return 1
            var rrr2 = you1.CompareTo(my1);//if(my1<you1)return -1
            Console.WriteLine("枚举CompareTo比较：" + my1.CompareTo(you1));
            Console.WriteLine(rrr1);
            Console.WriteLine(rrr2);
            #endregion

            #region GetType

            var getType = MicrosoftTechnology.SqlServer;
            Console.WriteLine("getType=" + getType.GetType());
            #endregion

            #region HasFlag

            MicrosoftTechnology myTechnology = MicrosoftTechnology.CSharp | MicrosoftTechnology.Aspnetmvc
                                               | MicrosoftTechnology.SilverLight | MicrosoftTechnology.SqlServer;
            MicrosoftTechnology youTechnology = MicrosoftTechnology.CSharp | MicrosoftTechnology.SqlServer
                                                | MicrosoftTechnology.Wcf;

            var isExit = myTechnology.HasFlag(youTechnology);
            Console.WriteLine("HasFlag:" + isExit);

            Console.WriteLine("{0} includes {1}: {2}",
                        myTechnology, youTechnology, myTechnology.HasFlag(youTechnology));
            #endregion

            #region ToObject
            /*如果第二个参数byte、int、long、object、sbyte、short、uint、ulong、ushort
             * 存在于枚举值中，则转换成对应枚举的名称；
             * 不存在于枚举值中，第二个参数是什么就返回什么
            */
            var toObject = Enum.ToObject(typeof(MicrosoftTechnology), 1);
            Console.WriteLine("toObject:" + toObject);
            #endregion

            #region ToString(String)

            var enumType = MicrosoftTechnology.SqlServer;
            Console.WriteLine(enumType.ToString("G"));
            Console.WriteLine(enumType.ToString("g"));

            Console.WriteLine(enumType.ToString("D"));
            Console.WriteLine(enumType.ToString("d"));

            Console.WriteLine(enumType.ToString("X"));
            Console.WriteLine(enumType.ToString("x"));

            Console.WriteLine(enumType.ToString("F"));
            Console.WriteLine(enumType.ToString("f"));
            #endregion
            #endregion
            Console.ReadKey();
        }
    }
    enum LogLevel
    {
        Trace,
        Debug,
        Information,
        Warnning,
        Error,
        Fatal
    }
    enum Week : int
    {
        Sun = 7,
        Mon = 1,
        Tue,
        Wed,
        Thur,
        Fri,
        Sat,
        Weekend = Sun
    }

    //[Flags]
    enum ColorStyle
    {
        None = 0x00,
        Red = 0x01,
        Orange = 0x02,
        Yellow = 0x04,
        Green = 0x08,
        Blue = 0x10,
        Indigotic = 0x20,
        Purple = 0x40,
        All = Red | Orange | Yellow | Green | Blue | Indigotic | Purple
    }
    //[Flags]
    enum Study
    {
        Flag1 = 0,    //000
        Flag2 = 1,    //001
        Flag3 = 2,    //010
        Flag4 = 4     //100

    }

    [Flags]
    enum MicrosoftTechnology
    {
        [Description("CSharp")]
        CSharp = 1,
        [Description("Aspnetmvc")]
        Aspnetmvc = 2,
        [Description("SqlServer")]
        SqlServer = 4,
        [Description("Wcf")]
        Wcf = 8,
        [Description("SilverLight")]
        SilverLight = 16,
    }
    enum Colors { Red, Green, Blue, Yellow };
}

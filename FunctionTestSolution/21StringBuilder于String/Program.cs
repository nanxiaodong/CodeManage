using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21StringBuilder于String
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            #region String性能测试
            //string str = "";
            //sw.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    str += i.ToString();
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds); 
            #endregion
            
            #region StringBuilder性能测试
            //sw.Reset();
            //sw.Start();
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < 100000; i++)
            //{
            //    sb.Append(i.ToString());
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds); 
            #endregion

            #region StringBuilder构造
            //StringBuilder sb = new StringBuilder("hello", 20);
            //Console.WriteLine(sb.GetType()); 
            #endregion

            #region StringBuilder-Append
            //StringBuilder sbs = new StringBuilder("Hello");
            //sbs.Append(" World");
            //Console.WriteLine(sbs);

            #endregion

            #region StringBuilder-AppendFormat
            //StringBuilder builder = new StringBuilder("The price is");
            //builder.AppendFormat("{0:C}",22);
            //builder.AppendFormat("\r\nThe Date is {0:D}",DateTime.Now.Date);
            //Console.WriteLine(builder);

            #endregion

            #region StringBuilder-Insert
            //StringBuilder sb = new StringBuilder("My name nxd");
            //sb.Insert(8,"is ");
            //Console.WriteLine(sb);
            #endregion

            #region StringBuilder-Replace
            StringBuilder sb = new StringBuilder("I Love Game");
            sb.Replace("Game","C#");
            Console.WriteLine(sb);
            #endregion

            Console.ReadKey();
        }
    }
}

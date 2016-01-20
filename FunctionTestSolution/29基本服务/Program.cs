using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _29基本服务
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enviroment
            ////获取当前目录
            //Console.WriteLine("当前目录：{0}",Environment.CurrentDirectory);
            ////获取机器名
            //Console.WriteLine("机器名：{0}",Environment.MachineName);
            ////获取操作系统信息
            //Console.WriteLine("操作系统：{0}",Environment.OSVersion);
            ////获取当前用户名
            //Console.WriteLine("当前用户：{0}",Environment.UserName);
            #endregion

            #region Uri
            //Uri uri = new Uri("http://www.baidu.com/");
            ////应用Uri实例创建WebRequest
            //WebRequest request = WebRequest.Create(uri);
            //WebResponse response = request.GetResponse();

            //Console.WriteLine(response.Headers);
            #endregion

            #region Process
            //Process myProcess = new Process();
            //string myUrl = "http://www.baidu.com/";

            ////必须设置相应的FileName和Arguments属性
            //myProcess.StartInfo.FileName = @"D:\Tool\360浏览器\360se6\Application\360se.exe";
            //myProcess.StartInfo.Arguments = myUrl;

            ////启动进程
            //myProcess.Start();
            #endregion

            #region EventLog
            ////创建EventLog实例
            //EventLog myLog = new EventLog("MyLog", ".", "NxdLog");
            ////写入日志事件
            //myLog.WriteEntry("没想到这些日志竟然存在操作系统中，长见识了！", EventLogEntryType.Information, 1);
            ////日志位置查询:计算机---（右击）管理----系统工具----事件查看器---应用程序和服务日志
            ////读取日志事件
            //foreach (EventLogEntry item in myLog.Entries)
            //{
            //    Console.WriteLine(item.Message);
            //}
            #endregion

            #region Stopwatch
            //StringBuilder builder = new StringBuilder();
            ////创建并开始测量
            //Stopwatch sw = Stopwatch.StartNew();
            //for (int i = 0; i < 100000; i++)
            //{
            //    builder.Append(i.ToString());
            //}
            ////停止测量
            //sw.Stop();

            //Console.WriteLine(sw.ElapsedMilliseconds);
            #endregion

            #region dynamic
            dynamic x = 10;
            dynamic y = 20;
            Console.WriteLine(x+y);//30

            dynamic m = "10";
            dynamic n = "1";//101
            Console.WriteLine(m+n);
            #endregion

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\文件操作练习\File文件.txt";

            #region AppendAllLines
            //List<string> strs = new List<string>();
            //strs.Add("从头再来！");
            //File.AppendAllLines(path, strs);

            //strs.Add("熟悉了一点");
            //File.AppendAllLines(path, strs, Encoding.UTF8); 
            #endregion

            #region AppendAllText
            //File.AppendAllText(path,"换不换行");
            //File.AppendAllText(path,"编码格式打开",Encoding.UTF8);
            #endregion

            #region AppendText
            //string appPath = @"E:\文件操作练习\test.txt";
            //StreamWriter sw = File.AppendText(appPath);
            //sw.WriteLine("test信息");
            //sw.Dispose();
            #endregion

            #region Copy
            //string oldPath = @"E:\文件操作练习\test.txt";
            //string newPath = @"E:\文件操作练习\newTest.txt";
            //File.Copy(oldPath, newPath);


            //string oldPath = @"E:\文件操作练习\test.txt";
            //string newPath = @"E:\文件操作练习\newTest.txt";
            //File.Copy(oldPath, newPath,true);

            #endregion

            #region Create
            //File.Create(@"E:\文件操作练习\create.txt");

            //File.Create(@"E:\文件操作练习\create.txt",1024);

            //File.Create(@"E:\文件操作练习\create.txt", 1024, FileOptions.Encrypted);

            #endregion

            #region CreateText
            //StreamWriter sw = File.CreateText(@"E:\文件操作练习\CreateText.txt");
            //sw.Write("CreateText写入");
            //sw.Dispose();

            #endregion

            #region Delete
            //File.Delete(@"E:\文件操作练习\CreateText.txt");
            #endregion

            #region Exists
            // Console.WriteLine(File.Exists(@"E:\文件操作练习\CreateText.txt")); 

            #endregion

            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}

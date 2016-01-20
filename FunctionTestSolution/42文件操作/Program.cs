using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42文件操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPath = @"D:\test";

            Console.WriteLine(Path.GetTempFileName());

            Console.WriteLine(Path.HasExtension(strPath));//True
            //Console.WriteLine(Path.HasExtension("@D:""\");

            Console.WriteLine(Path.IsPathRooted(strPath));//True

            Console.WriteLine(Path.GetTempPath());//C:\Users\nanxiaodong\AppData\Local\Temp\

            Console.WriteLine(Path.GetRandomFileName());

            Console.WriteLine(Path.GetPathRoot(strPath));//D:\

            //var chs = Path.GetInvalidFileNameChars();
            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);//:*?\/
            //}

            Console.WriteLine(Path.GetFullPath(strPath));//D:\test.cs
            Console.WriteLine(Path.GetFileNameWithoutExtension(strPath));//test
            Console.WriteLine(Path.GetDirectoryName(strPath));//D:\
            Console.WriteLine(Path.GetExtension(strPath));//.cs
            Console.WriteLine(Path.GetFileName(strPath));//test.cs
            
            Console.ReadKey();
        }
    }
}

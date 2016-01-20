using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"C:\Users\nanxiaodong\Desktop\text";
            //在桌面创建一个text文件夹，并将text名字返回
            //Console.WriteLine(Directory.CreateDirectory(@"C:\Users\nanxiaodong\Desktop\text"));

            //删除创建的text文件夹(删除文件夹下不能存在目录或文件)
            //Directory.Delete(@"C:\Users\nanxiaodong\Desktop\text");

            //删除创建的text文件夹,true指定删除文件下所有的文件或目录
            //Directory.Delete(@"C:\Users\nanxiaodong\Desktop\text",true);

            //var strs=  Directory.EnumerateDirectories(str);
            //var strs = Directory.EnumerateDirectories(str, "(2)");

            //var strs = Directory.EnumerateDirectories(str, "新建文件夹 (2)", SearchOption.AllDirectories);
            //foreach (var item in strs)
            //{
            //    Console.WriteLine(item);
            //}


            //var files = Directory.EnumerateFiles(str);
            //var files = Directory.EnumerateFiles(str, "新建文本文档.txt", SearchOption.AllDirectories);
            //foreach (var item in files)
            //{
            //    Console.WriteLine(item);
            //    //C:\Users\nanxiaodong\Desktop\text\新建文本文档.txt
            //    //C:\Users\nanxiaodong\Desktop\text\新建文件夹 (2)\新建文本文档.txt
            //}



            //var fileSystems = Directory.EnumerateFileSystemEntries(str);
            //var fileSystems = Directory.EnumerateFileSystemEntries(str, "(2)");
            //var fileSystems = Directory.EnumerateFileSystemEntries(str, "新建文件夹", SearchOption.AllDirectories);
            //foreach (var item in fileSystems)
            //{
            //    Console.WriteLine(item);
            //    //C:\Users\nanxiaodong\Desktop\text\新建文件夹
            //    //C:\Users\nanxiaodong\Desktop\text\新建文件夹\新建文件夹
            //}


            //Console.WriteLine(Directory.GetCreationTime(str));//2015/11/19 22:04:39

            //Console.WriteLine(Directory.GetCreationTimeUtc(str));//2015/11/19 14:04:39

            //Console.WriteLine(Directory.GetCurrentDirectory());//E:\代码练习\FunctionTestSolution\43Directory\bin\Debug

            //var res = Directory.GetDirectories(str, "新建文件夹", SearchOption.TopDirectoryOnly);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //    //C:\Users\nanxiaodong\Desktop\text\新建文件夹
            //    //C:\Users\nanxiaodong\Desktop\text\新建文件夹\新建文件夹
            //}


            //Console.WriteLine(Directory.GetDirectoryRoot(str));//C:\

            //var res = Directory.GetFiles(str);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //    //C:\Users\nanxiaodong\Desktop\text\新建文本文档 (2).txt
            //    //C:\Users\nanxiaodong\Desktop\text\新建文本文档 (3).txt
            //    //C:\Users\nanxiaodong\Desktop\text\新建文本文档.txt
            //}


            //var res = Directory.GetFileSystemEntries(str);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //    //C:\Users\nanxiaodong\Desktop\text\新建文件夹
            //    //C:\Users\nanxiaodong\Desktop\text\新建文件夹 (2)
            //    //C:\Users\nanxiaodong\Desktop\text\新建文件夹 (3)
            //    //C:\Users\nanxiaodong\Desktop\text\新建文本文档 (2).txt
            //    //C:\Users\nanxiaodong\Desktop\text\新建文本文档 (3).txt
            //    //C:\Users\nanxiaodong\Desktop\text\新建文本文档.txt
            //}

            //var res = Directory.GetFileSystemEntries(str, "*");
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(Directory.GetLastAccessTime(str));//2015/11/22 17:30:55

            //Console.WriteLine(Directory.GetLastWriteTime(str));//2015/11/22 17:34:30


            //var res = Directory.GetLogicalDrives();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //    //C:\
            //    //D:\
            //    //E:\
            //    //F:\
            //}


            //var res = Directory.GetParent(@"C:\Users\nanxiaodong\Desktop\text");
            //Console.WriteLine(res);//C:\Users\nanxiaodong\Desktop


            //Directory.Move(@"C:\Users\nanxiaodong\Desktop\text\新建文本文档.txt", @"C:\Users\nanxiaodong\Desktop\text\新建文件夹 (3)\Move.txt");

           // Directory.SetCreationTime(str, DateTime.Now);


           // Console.WriteLine(Directory.GetCurrentDirectory());

           // Directory.SetCurrentDirectory(str);



            Console.ReadKey();
        }
    }
}

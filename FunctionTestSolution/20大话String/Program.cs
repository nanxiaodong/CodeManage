using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20大话String
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion01
            //string s1 = "abc";
            //string s2 = "ab";
            //string s3 = s2 + "c";
            //Console.WriteLine(string.IsInterned(s1));
            //Console.WriteLine(string.IsInterned(s3));
            //Console.WriteLine(ReferenceEquals(s1, s3));
            #endregion

            #region 字符串创建
            //string mystr = "Hello";
            ////string str = new string("Hello");//编译报错，因为Syste.String只提供了数个接受Char*、Char[]类型的构造函数。
            ////char[] cs = new char() { 'H', 'e', 'l', 'l', 'o' };//编译报错，提示无法使用集合初始化器初始化类型“char”，原因是它未实现System.Collection.IEnumerable

            //char[] cs = { 'H', 'e', 'l', 'l', 'o' };
            //string str1 = new string(cs); 
            //Console.WriteLine(str1);
            #endregion

            #region 字符串恒定性
            //string str = "Hellowask";
            //Console.WriteLine(str.Insert(0,"账号："));
            //Console.WriteLine(str);
            ////输出结果为：账号：Hellowask
            ////          Hellowask

            #endregion

            #region 字符串驻留
            //string strA = "abcdef";
            //string strB = "abcdef";
            //Console.WriteLine(ReferenceEquals(strA, strB));//True

            //string strC = "abc";
            //string strD = strC + "def";
            //Console.WriteLine(ReferenceEquals(strA, strD));//False

            //strD = String.Intern(strD);//Intern:检索系统对指定System.String的引用
            //Console.WriteLine(ReferenceEquals(strA, strD));//True

            #endregion

            #region 补充
            //string strA = "abcdef";
            //string strC = "abc";
            //string strD = strC + "def";
            //Console.WriteLine(ReferenceEquals(strA,strD));//false

            //string strE = "abc" + "def";
            //Console.WriteLine(ReferenceEquals(strA, strE));//true


            #endregion

            Console.ReadKey();
        }
    }
}

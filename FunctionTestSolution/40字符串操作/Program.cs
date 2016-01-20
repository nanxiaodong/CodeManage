using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40字符串操作
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 构造函数声明字符串
            ////string str = new string("abc");//C#不支持
            //String str = new String("123"); //C#不支持，java支持
            #endregion

            #region 拘留池
            //string s1="a";
            //string s2 = "b";
            //string s3 = "c";

            //string x1 = "a";
            //string x2 = "bcd";

            //string s4 = string.Intern(s1+s2+s3);
            //Console.WriteLine(s4);

            //string s5 = string.IsInterned(x1+x2);
            //Console.WriteLine(s5);//null,如果内存中不存在abcd就返回null
            #endregion

            #region length
            //string str = "开发语言C#";
            //Console.WriteLine(str.Length);//6，length指的是字符串中，字符的个数不是字节数

            #endregion

            #region ToCharArray()
            //string str = "abcd";
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length; i++)
            //{
            //    chs[i] = (char)(chs[i] + 1);//对应的ASCII码
            //}
            //Console.WriteLine(new string(chs));//bcde

           //string str = "成功的代价";
           //var chs = str.ToCharArray(3, 2);
           //foreach (var item in chs)
           //{
           //    Console.WriteLine(item);//代
           //                            //价
           //}

            #endregion

            #region 字符串的只读索引器
            //string str = "abcdefg";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    str[i] = char.ToUpper(str[i]);//
            //}
            #endregion

            #region 字符串判等
            //string s1 = "abc";
            //string s2 = "ABC";
            //Console.WriteLine(s1 == s2);//False,因为这种比较字符串的时候是区分大小写的
            //Console.WriteLine(s1.Equals(s2));//False

            //Console.WriteLine(s1.Equals(s2, StringComparison.OrdinalIgnoreCase));//True；忽略大小写进行比较
            #endregion

            #region indexof
            //string str = "我拼了命的努力，我只想证明自己";
            //int index = str.IndexOf("努力");
            //Console.WriteLine(index);//5;在str字符串中，查找“努力”第一次出现的位置（索引从0开始）；如果未找到则返回-1

            //int startIndex = str.IndexOf("我", 5);
            //Console.WriteLine(startIndex);//8;在str字符串中，从索引为5的字符位置开始查找“我”第一次出现的位置；如果未找到则返回-1

            //int noIndex = str.IndexOf("你");
            //Console.WriteLine(noIndex);//-1;如果未找到则返回-1

            //int charIndex = str.IndexOf('明',5);
            //Console.WriteLine(charIndex);//12

            //int emptyIndex = str.IndexOf(string.Empty,5);
            //Console.WriteLine(emptyIndex);//5;如果value为Empty，startIndex位置是几就输出几


            //int lastIndex = str.LastIndexOf("我");
            //Console.WriteLine(lastIndex);//8;在str字符串中，查找“我”最后一次出现的索引位置；如果未找到则返回-1

            //string msg="hello world";
            //int indexChar = msg.IndexOf("W", StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine(indexChar);//6

            #endregion

            #region IndexOfAny
            //string str = "生活中的压力他被我化作动力；混了好几年我仍然没有半点出息";
            ////char[] chs = new char(){ '压','出'};//报错，无法使用集合初始化类型char，原因是它未实现System.Collection.IEnumerable
            //char[] chs = { '中', '力', '我' };

            //int index = str.IndexOfAny(chs);
            //Console.WriteLine(index);//2;检查chs字符数组中的任意一个字符在str的位置，从第一个字符开始检索
            #endregion

            #region Intern
            //string str = "黎明的曙光";

            //var result = string.Intern("黎明的曙光123");
            //Console.WriteLine(result);
            #endregion

            #region Insert
            //string str = "黎明的曙光";
            //var result = str.Insert(5,"-何瑶");
            //Console.WriteLine(result);//黎明的曙光-何瑶
            #endregion

            #region IsNullOrEmpty与IsNullOrWhiteSpace
            //string str = "  ";
            //Console.WriteLine(string.IsNullOrEmpty(str));//False
            //Console.WriteLine(string.IsNullOrWhiteSpace(str));//True

            //string res = string.Empty;
            //Console.WriteLine(string.IsNullOrEmpty(res));//True
            //Console.WriteLine(string.IsNullOrWhiteSpace(res));//True

            //string msg = "";
            //Console.WriteLine(string.IsNullOrEmpty(msg));//True
            //Console.WriteLine(string.IsNullOrWhiteSpace(msg));//True

            //string item = null;
            //Console.WriteLine(string.IsNullOrEmpty(item));//True
            //Console.WriteLine(string.IsNullOrWhiteSpace(item));//True

            #endregion

            #region Join

            //IEnumerable<string> strs = new List<string>() { "科比", "詹姆斯" };
            //string str = string.Join("☆", strs);
            //Console.WriteLine(str);//科比☆詹姆斯

            //IEnumerable<string> strs1 = new List<string>() { };
            //string str1 = string.Join("☆", strs1);
            //Console.WriteLine(str1);//String.Empty

            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
            //string numStr = string.Join<int>("★", nums);
            //Console.WriteLine(numStr);//1★2★3★4★5


            //string res = string.Join("-", "如", "次", "孤", "独");
            //Console.WriteLine(res);//如-次-孤-独

            //string[] strChars = new string[] { "大", "脑", "一", "定", "要", "清", "醒" };
            //string result = string.Join("-", strChars, 4,3);//一定是string[]
            //Console.WriteLine(result);//要-清-醒
            #endregion

            #region PadLeft与PadRight
            //string str = "右对齐";
            //Console.WriteLine(str.PadLeft(5));//  右对齐  长度为5（按字符计算）
            //Console.WriteLine(str.PadLeft(3));//右对齐
            //Console.WriteLine(str.PadLeft(0));//右对齐

            //string mgs = "右对齐";
            //Console.WriteLine(mgs.PadLeft(2, '☆'));//☆☆右对齐

            //string str = "左对齐";
            //Console.WriteLine(str.PadRight(5));//左对齐  
            //Console.WriteLine(str.PadRight(3));//左对齐
            //Console.WriteLine(str.PadRight(0));//左对齐

            //Console.WriteLine(str.PadRight(5, '.'));//左对齐..
            #endregion

            #region Remove
            //string str = "删除的字符的新字符串";
            //Console.WriteLine(str.Remove(8));//删除的字符的新字
            //Console.WriteLine(str.Remove(2, 2));//删除符的新字符串
            #endregion

            #region Replace
            //string str="黎明的曙光的";
            //Console.WriteLine(str.Replace('的', '得'));//黎明得曙光得
            //Console.WriteLine(str.Replace("曙光", "黑暗"));//黎明的黑暗的
            #endregion

            #region Split
            //string str = "公牛,湖人|快船|森林狼☆热火☆小牛";
            //string[] strs = str.Split(',','|','☆');
            //foreach (var item in strs)
            //{
            //    Console.WriteLine(item);
            //}

            //string str = "公牛,湖人|快船|森林狼☆热火☆小牛";
            //char[] chs = new char[] { ',', '|', '☆' };
            //string[] strs = str.Split(chs,2);
            //foreach (var item in strs)
            //{
            //    Console.WriteLine(item);
            //}

            //string str = "公牛,,湖人|快船|森林狼☆热火☆小牛";
            //char[] chs = new char[] { ',', '|', '☆' };
            //string[] strs = str.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in strs)
            //{
            //    Console.WriteLine(item);
            //                        //公牛
            //                        //湖人
            //                        //快船
            //                        //森林狼
            //                        //热火
            //                        //小牛
            //}

            //string[] res = str.Split(chs, StringSplitOptions.None);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //                        //公牛

            //                        //湖人
            //                        //快船
            //                        //森林狼
            //                        //热火
            //                        //小牛
            //}
            #endregion

            #region StartsWith
            //string str = "简单的想法";
            //Console.WriteLine(str.StartsWith("简单"));//True
            //Console.WriteLine(str.StartsWith("1简单"));//False


            //string msg = "hello world";
            //Console.WriteLine(msg.StartsWith("H"));//False
            //Console.WriteLine(msg.StartsWith("H", StringComparison.CurrentCultureIgnoreCase));//True


            //string res = "hellowask";
            //Console.WriteLine(res.StartsWith("H", true, null));//True
            #endregion

            #region Substring
            //string str = "再一次的激情再一次的努力";
            //Console.WriteLine(str.Substring(1));//一次的激情再一次的努力
            //Console.WriteLine(str.Substring(4, 2));//激情
            #endregion

            #region ToLower
            //string str = "HELLO";
            //Console.WriteLine(str.ToLower());//hello
            //Console.WriteLine(str.ToLowerInvariant());//hello
            #endregion

            #region ToUpper
            //string str = "hello";
            //Console.WriteLine(str.ToUpper());//HELLO
            //Console.WriteLine(str.ToUpperInvariant());//HELLO
            #endregion

            #region Trim
            //string str = "   一定要清醒    ☆";
            //Console.WriteLine(str.Trim());//一定要清醒    ☆
            //Console.WriteLine(str.Trim('☆'));//   一定要清醒
            #endregion

            int n = 10;
            double m = 10;
            int x = 10;
            Console.WriteLine(n.Equals(m));//False,因为值类型的Equals只有当n与m的类型相同并且值相同时才返回true
            Console.WriteLine(n.Equals(x));//True

            Console.ReadKey();
        }
    }
}

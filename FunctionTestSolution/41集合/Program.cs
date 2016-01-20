using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41集合
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 基础
            ////初始化arrs的容量为2
            //ArrayList arrs = new ArrayList(10);
            //Console.WriteLine(arrs.Add("hello"));
            //Console.WriteLine(arrs.Add(1));
            //arrs.Add("a");
            //Console.WriteLine(arrs.Capacity);//10,可包含的元素数。
            //arrs.Capacity = 5;
            //Console.WriteLine(arrs.Capacity);//5可包含的元素数。
            //Console.WriteLine(arrs.Count);//2,实际包含的元素数。


            //Console.WriteLine(arrs.Add("黎明的曙光"));
            //Console.WriteLine("BinarySearch:" + arrs.BinarySearch(1)); 
            #endregion

            #region LastIndexOf
            //ArrayList arrs = new ArrayList();
            //arrs.Add(1);//索引：0
            //arrs.Add(2);//索引：1
            //arrs.Add(1);//索引：2
            //arrs.Add(3);//索引：3
            //arrs.Add(1);//索引：4
            //arrs.Add(4);//索引：5
            //arrs.Add(1);//索引：6

            //Console.WriteLine(arrs.LastIndexOf(1));//6
            //Console.WriteLine(arrs.LastIndexOf(1, 5));//4 

            //ArrayList arrs = new ArrayList();
            //arrs.Add("a");



            //Console.WriteLine();

            #endregion


            #region Hashtable
            //Hashtable ht = new Hashtable();
            //ht.Add(1, "黎");
            //ht.Add(2, "明");
            //ht.Add(3, "曙");
            //ht.Add(4, "光");

            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine(item);//4、3、2、1
            //}

            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);//光、曙、明、黎
            //}

            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine("key:"+item.Key+"-"+"value:"+item.Value);
            //    //key:4-value:光、key:3-value:曙、key:2-value:明、key:1-value:黎
            //}

            //Console.WriteLine(ht.ContainsKey(1));//判断键是否存在
            //Console.WriteLine(ht.ContainsValue("光"));//判断值是否存在 
            #endregion

            #region List

            //List<int> li = new List<int>();
            //li.Add(1);//0
            //li.Add(2);//1
            //li.Add(3);//2
            //li.Add(1);//3
            //li.Add(5);//4

            ////li.Remove(1);
            ////foreach (var item in li)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //Console.WriteLine(li.TrueForAll(i => i > 0));//True

            ////Console.WriteLine(li.RemoveAll(i=>i>4));//1

            ////Console.WriteLine(li.BinarySearch(2));

            ////var ls = li.ConvertAll<double>(i=>Convert.ToDouble(i));

            ////var ls1 = li.GetRange(1, 2);
            ////foreach (var item in ls1)
            ////{
            ////    Console.WriteLine(item);
            ////}

            #endregion

            #region Dictionary

            //Dictionary<int, string> dic = new Dictionary<int, string>(10);
            //dic.Add(1, "nxd");
            //dic.Add(2,"华远");
            //Console.WriteLine(dic[1]);//nxd
            //Console.WriteLine(dic.ContainsKey(1));//True
            //Console.WriteLine(dic.Count);//1
            ////dic.Keys
            //foreach (var key in dic.Keys)
            //{
            //    Console.WriteLine("key:"+key);
            //}

            //foreach (var value in dic.Values)
            //{
            //    Console.WriteLine("value:"+value);
            //}

            //foreach (KeyValuePair<int,string> item in dic)
            //{
            //    Console.WriteLine("key:{0},值：{1}", item.Key,item.Value);
            //}

            #endregion


            Console.ReadKey();

        }
    }
}


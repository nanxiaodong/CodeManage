using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37索引
{
    class Program
    {
        static void Main(string[] args)
        {
            Chinese cn = new Chinese();
            Console.WriteLine(cn[1]);//科比

            IndexClass Indexer = new IndexClass();
            Indexer["A0001"] = "张三";
            Indexer["A0002"] = "李四";
            Console.WriteLine(Indexer["A0001"]);
            Console.WriteLine(Indexer["A0002"]);
            Console.ReadKey();
        }
    }
    class Chinese
    {
        private string[] names = new string[] { "乔丹", "科比", "韦德" };
        //索引器必须以this关键字定义，其实这个this就是类实例化之后的对象
        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
    }

    class IndexClass
    {
        //用string作为索引器下标的时候，要用Hashtable
        private Hashtable name = new Hashtable();
        //索引器必须以this关键字定义，其实这个this就是类实例化之后的对象
        public string this[string index]
        {
            get { return name[index].ToString(); }
            set { name.Add(index, value); }

        }
    }
}

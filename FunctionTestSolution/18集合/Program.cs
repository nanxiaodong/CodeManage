using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18集合
{
    #region ArrayListEx
    //class ArrayListEx
    //{
    //    public static void Main(string[] args)
    //    {
    //        //定义集合类型
    //        ArrayList arrs = new ArrayList();

    //        //调用Add方法，增加集合元素
    //        arrs.Add(10);
    //        arrs.Add(new object());
    //        arrs.Add("i am ok");
    //        arrs.Add(new MyClass());
    //        arrs.Add(100);

    //        //调用Remove方法，移除指定对象
    //        arrs.Remove(100);

    //        //调用Insert方法，插入对象到指定索引位置
    //        arrs.Insert(2, "A insert value");

    //        //IndexOf方法，用于从其实位置搜索，并返回第一个匹配项的索引位置
    //        Int32 index = arrs.IndexOf("i am ok");

    //        //获取集合的指定元素
    //        object obj = arrs[index];
    //        Console.WriteLine("{0} -- {1}", obj, index);

    //        //获取集合元素个数
    //        Console.WriteLine(arrs.Count);

    //        //清除集合的所有元素
    //        arrs.Clear();

    //        Console.ReadKey();
    //    }
    //}
    //class MyClass
    //{
    //    public override string ToString()
    //    {
    //        return "这是自定义类型。";
    //    }
    //} 
    #endregion


    #region ArrayList的容量是动态的
    //class ArrayListTest
    //{
    //    public static void Main(string[] args)
    //    {
    //        //初始化arrs容量为2
    //        ArrayList arrs = new ArrayList(2);

    //        Console.WriteLine("当前容量：{0}", arrs.Capacity);//结果为：2

    //        arrs.Add(1);
    //        Console.WriteLine("当前容量：{0}", arrs.Capacity);//结果为：2
    //        arrs.Add(2);
    //        Console.WriteLine("当前容量：{0}", arrs.Capacity);//结果为：2
    //        arrs.Add(3);
    //        Console.WriteLine("当前容量：{0}", arrs.Capacity);//结果为：4(容量是成倍重新分配的)

    //        Console.WriteLine("当前容量：{0}",arrs.Capacity);//结果为：4

    //        arrs.TrimToSize();
    //        Console.WriteLine("当前容量：{0}", arrs.Capacity);//结果为：3
    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Queue和Stack
    //class Queue_Stack
    //{
    //    public static void Main(string[] args)
    //    {
    //        Queue myQueue = new Queue();
    //        //向Queue尾部添加元素
    //        myQueue.Enqueue("我");
    //        myQueue.Enqueue("是");
    //        myQueue.Enqueue("谁");

    //        //返回Queue开始的元素
    //        Console.WriteLine(myQueue.Peek());
    //        //返回并移除Queue开始的元素
    //        myQueue.Dequeue();

    //        //遍历Queue
    //        foreach (object obj in myQueue)
    //        {
    //            Console.WriteLine(obj.ToString());
    //        }

    //        Console.WriteLine("****************************************************");

    //        Stack myStack = new Stack();
    //        //向Stack的顶部插入元素
    //        myStack.Push("我");
    //        myStack.Push("是");
    //        myStack.Push("谁");

    //        //返回Stack顶部的元素
    //        Console.WriteLine(myStack.Peek());
    //        //返回并移除顶部元素
    //        myStack.Pop();

    //        //遍历Stack
    //        foreach (object obj in myStack)
    //        {
    //            Console.WriteLine(obj.ToString());
    //        }

    //        Console.ReadKey();
    //    }
    //}
    #endregion

    #region Hashtable
    class HashtableEx
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            //添加集合元素
            ht.Add("Name", "张三");
            ht.Add("Age",25);
            ht.Add("Address","北京");

            //以键值查找集合
            Console.WriteLine("{0}的年龄是{1}",ht["Name"],ht["Age"]);

            //集合遍历
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("{0}--{1}",item.Key.ToString(),item.Value.ToString());
            }

            //删除集合元素
            ht.Remove("Address");

            //集合排序
            ArrayList als = new ArrayList(ht.Keys);

            als.Sort();

            foreach (string key in als)
            {
                Console.WriteLine("{0}--{1}",key,ht[key].ToString());
            }

            //集合清空
            ht.Clear();

            Console.ReadKey();
        }
    }
    #endregion
}

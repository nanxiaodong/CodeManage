using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _27Name这回事
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单
            Type t1 = typeof(object);
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t1.AssemblyQualifiedName); 
            #endregion

            //Type t2=typeof(Expression<Func<int,int>>);
            //Console.WriteLine(t2.Name);
            //Console.WriteLine(t2.FullName);
            //Console.WriteLine(t2.AssemblyQualifiedName);

            Console.ReadKey();
        }
    }
}

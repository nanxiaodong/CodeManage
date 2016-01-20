using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(LockApp.AddTtems));
            Thread t2 = new Thread(new ThreadStart(LockApp.AddTtems));

            t1.Start();
            t2.Start();

            
            foreach (string str in LockApp.a1)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
    class LockApp
    {
        public  static ArrayList a1 = new ArrayList();
        public static void AddTtems()
        {
            lock(a1)
            {
                a1.Add(DateTime.Now.ToString());
                Thread.Sleep(1000);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02装箱与拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;

            i.GetType();
            i.ToString();
        }
    }
    class GCApp:Object
    {
        int num = 0;
        ~GCApp()
        {
            //num;
        }
    }
}

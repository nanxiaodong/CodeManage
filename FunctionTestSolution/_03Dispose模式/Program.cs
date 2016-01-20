using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Dispose模式
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class MyDispose:IDisposable
    {
        //定义一个访问外部资源的句柄
        private IntPtr _handle;
        //标记Dispose是否被调用
        private bool disposed = false;

        //实现IDispose接口
        public void Dispose()
        {
            Dispose(true);
            //阻止GC调用Finalize方法
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    Console.WriteLine("清理托管堆资源！");
                }
                //清理非托管堆资源
                if(_handle!=IntPtr.Zero)
                {
                    //执行资源清理，在此为关闭对象句柄
                   // ClosedHandle(_handle);
                    _handle = IntPtr.Zero;
                }
            }
            disposed = true;
        }
        public void Close()
        {
            //在内部调用Dispose来实现
            Dispose();
        }
    }
}

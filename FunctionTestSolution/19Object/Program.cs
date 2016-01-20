using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Object
{
    class Program
    {
        static void Main(string[] args)
        {
            IObject obj = new AnyObject();
            Console.WriteLine();
            //obj
        }
    }
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum
    //    | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property
    //    | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
    //public sealed class EditorBrowsableAttriute : Attribute
    //{

    //}
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IAnyObject
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        bool Equals(object obj);
        [EditorBrowsable(EditorBrowsableState.Never)]
        int GetHashCode();
        [EditorBrowsable(EditorBrowsableState.Never)]
        Type GetType();
        [EditorBrowsable(EditorBrowsableState.Never)]
        string ToString();
    }

    public interface IObject : IAnyObject
    {
        void About();
    }

    public class AnyObject : IObject
    {
        public void About()
        {
            throw new NotImplementedException();
        }
    }

    #region 反编译后的System.Object
    //public class object
    //{
    //    //构造函数
    //    public object() { }

    //    public virtual int gethashcode() { }

    //    //获取对象类型信息
    //    public system.type gettype() { }

    //    //虚方法，返回对象的字符串表示方式
    //    public virtual string tostring() { }

    //    //几种对象判等方法
    //    public virtual bool equals(object obj) { }
    //    public static bool equals(object obja,object objb) { }
    //    public static bool referenceequals(object obja, object objb) { }

    //    //执行对象的浅拷贝
    //    protected object memberwiseclone() { }
    //    //析构函数
    //    protected virtual void finalize() { }
    //} 
    #endregion


}

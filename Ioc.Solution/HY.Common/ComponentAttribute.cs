using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY.Common
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ComponentAttribute : Attribute
    {
        public LifeStyle LifeStyle { get; private set; }
        public ComponentAttribute() : this(LifeStyle.Singleton) { }
        public ComponentAttribute(LifeStyle lifeStyle)
        {
            LifeStyle = lifeStyle;
        }
    }
    public enum LifeStyle
    {
        Transient,
        Singleton,
        InstancePerLifetimeScope
    }
}

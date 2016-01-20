using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _22认识枚举
{
    public static class EnumCommonHelper
    {
        public static string GetEnumDescription(this Enum value)
        {

            FieldInfo enumInfo = value.GetType().GetField(value.ToString());
            var enumAttributes = (DescriptionAttribute[])enumInfo.
                GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (enumAttributes.Length > 0)
            {
                return enumAttributes[0].Description;
            }
            return string.Empty;
        }
    }
}

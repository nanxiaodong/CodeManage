using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY.MetaData
{
    public enum CooperationProvider
    {
        [Description("未知的")]
        UnKnow = 0,
        [Description("携程")]
        Ctrip = 200001,
        [Description("途牛")]
        Tuniu = 200002,
    }
}

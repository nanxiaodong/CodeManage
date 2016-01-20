using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY.Common;
using HY.Interface.Common;
using HY.MetaData;

namespace HY.Interface.Ctrip
{
    public static class Extensions
    {
        public static Configuration RegisterCtrip(this Configuration configuration)
        {
            //接口只被实例化一次
            configuration.SetDefault<ICooperationProvider, CrtipProvider>(CooperationProvider.Ctrip.ToString(),
                LifeStyle.Singleton);

            return configuration;
        }
    }
}

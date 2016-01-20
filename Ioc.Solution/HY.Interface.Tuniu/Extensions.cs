using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY.Common;
using HY.Interface.Common;
using HY.MetaData;

namespace HY.Interface.Tuniu
{
    public static class Extensions
    {
        public static Configuration RegisterTuniu(this Configuration configuration)
        {
            //接口只被实例化一次
            configuration.SetDefault<ICooperationProvider, TuniuProvider>(CooperationProvider.Tuniu.ToString(), LifeStyle.Singleton);

            return configuration;
        }
    }
}

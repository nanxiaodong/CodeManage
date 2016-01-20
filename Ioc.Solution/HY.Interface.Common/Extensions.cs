using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY.Common;

namespace HY.Interface.Common
{
    public static class Extensions
    {
        public static Configuration RegisterProviderFactory(this Configuration configuration)
        {
            //接口只被实例化一次
            configuration.SetDefault<ICooperationProviderFactory, CooperationProviderFactory>(LifeStyle.Singleton);

            return configuration;
        }
    }
}

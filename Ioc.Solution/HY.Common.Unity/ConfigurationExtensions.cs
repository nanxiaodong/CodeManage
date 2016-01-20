using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace HY.Common.Unity
{
    public static class ConfigurationExtensions
    {
        public static Configuration UseUnity(this Configuration configuration)
        {
            return UseUnity(configuration, new UnityContainer());
        }
        public static Configuration UseUnity(this Configuration configuration, UnityContainer unityContainer)
        {
            ObjectContainer.SetContainer(new UnityObjectContainer(unityContainer));
            return configuration;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY.Common;
using HY.Common.Autofac;
using HY.Common.Unity;
using HY.Interface.Common;
using HY.Interface.Ctrip;
using HY.Interface.Tuniu;

namespace HY.ConsoleApplication
{
    public class AppInitialize
    {
        public static void Initialize()
        {
            Configuration
                .Create()
                .UseAutofac()
               // .UseUnity()
                .RegisterCommonComponents()
                .RegisterProviderFactory()
                .RegisterCtrip()
                .RegisterTuniu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY.Common;
using HY.Interface.Common;
using HY.MetaData;

namespace HY.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInitialize.Initialize();
            var iCooperationProvider = ObjectContainer.Current
                                        .Resolve<ICooperationProviderFactory>()
                                        .CreateProvider(CooperationProvider.Ctrip);
            iCooperationProvider.ShowAddress();
            Console.ReadKey();
        }
    }
}

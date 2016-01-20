using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY.Common;
using HY.MetaData;

namespace HY.Interface.Common
{
    public interface ICooperationProviderFactory
    {
        ICooperationProvider CreateProvider(CooperationProvider cooperationProvider);
    }
    public class CooperationProviderFactory : ICooperationProviderFactory
    {
        public ICooperationProvider CreateProvider(CooperationProvider cooperationProvider)
        {
            return ObjectContainer.Current.Resolve<ICooperationProvider>(cooperationProvider.ToString());
        }
    }
}

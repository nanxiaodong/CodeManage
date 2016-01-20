using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY.Interface.Common
{
    public abstract class BaseCooperationProvider : ICooperationProvider
    {
        public abstract MetaData.CooperationProvider ProviderPartner { get; }
        public virtual void ShowAddress()
        {
            throw new NotImplementedException();
        }
    }
}

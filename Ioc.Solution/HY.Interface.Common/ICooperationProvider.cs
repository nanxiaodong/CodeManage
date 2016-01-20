using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY.MetaData;

namespace HY.Interface.Common
{
    public interface ICooperationProvider
    {
        CooperationProvider ProviderPartner { get; }
        void ShowAddress();
    }
}

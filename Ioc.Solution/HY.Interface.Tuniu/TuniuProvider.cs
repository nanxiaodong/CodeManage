using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HY.Interface.Common;

namespace HY.Interface.Tuniu
{
    class TuniuProvider : BaseCooperationProvider
    {
        public override HY.MetaData.CooperationProvider ProviderPartner
        {
            get { return HY.MetaData.CooperationProvider.Tuniu; }
        }
        public override void ShowAddress()
        {
            Console.WriteLine("Tuniu");
        }
    }
}

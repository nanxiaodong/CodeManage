using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY.Common
{
    public class Setting
    {
        public int RetryActionDefaultPeriod { get; set; }
        public Setting()
        {
            RetryActionDefaultPeriod = 1000;
        }
    }
}

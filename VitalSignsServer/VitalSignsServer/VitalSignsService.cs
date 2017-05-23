using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VitalSignsServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
                ConcurrencyMode = ConcurrencyMode.Single)]
    class VitalSignsService : IVitalSignsService
    {
        public void offlineAnalyze(string fileName)
        {
            Console.WriteLine("离线分析...");
            throw new NotImplementedException();
        }

        public void realtimeAnalyze()
        {
            Console.WriteLine("实时分析...");
            throw new NotImplementedException();
        }
    }
}

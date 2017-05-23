using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VitalSignsServer
{
    [ServiceContract]
    interface IVitalSignsService
    {
        [OperationContract]
        void realtimeAnalyze();
        [OperationContract]
        void offlineAnalyze(string fileName);
    }
}

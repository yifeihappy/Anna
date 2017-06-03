using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MathWorks.MATLAB.NET.Arrays;

namespace VitalSignsServer
{
    [ServiceContract]
    public interface IVitalSignsService
    {
        [OperationContract]
        void realtimeAnalyze(string[] epc, long[] timestamp, int[] phase, int[] frequency);
        [OperationContract]
        FrequencyInfo offlineAnalyze(string fileName);

    }
    [DataContract]
    public class FrequencyInfo
    {
        [DataMember]
        public int[] breath { get; set; }
        [DataMember]
        public int[] heartbeat { get; set; }
        [DataMember]
        public double[] t;
        [DataMember]
        public int meanBreath;
        [DataMember]
        public int meanHeartbeat;

        public FrequencyInfo(int[]breath,int[] heartbeat,double[]t,int meanBreath,int meanHeartbeat)
        {
            this.breath = breath;
            this.heartbeat = heartbeat;
            this.t = t;
            this.meanBreath = meanBreath;
            this.meanHeartbeat = meanHeartbeat;
        }
    }



}

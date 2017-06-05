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
        void realtimeAnalyze(SignalIn signalIn);
        [OperationContract]
        FrequencyInfo offlineAnalyze(string fileName);

    }
    [DataContract]
    public class FrequencyInfo
    {
        [DataMember]
        public double[] breath { get; set; }
        [DataMember]
        public double[] heartbeat { get; set; }
        [DataMember]
        public double[] t;
        [DataMember]
        public double meanBreath;
        [DataMember]
        public double meanHeartbeat;

        public FrequencyInfo(double[]breath,double[] heartbeat,double[]t,double meanBreath,double meanHeartbeat)
        {
            this.breath = breath;
            this.heartbeat = heartbeat;
            this.t = t;
            this.meanBreath = meanBreath;
            this.meanHeartbeat = meanHeartbeat;
        }
    }

    //string[] epc,long[] timestamp, double[]phase,int[] frequency
    [DataContract]
    public class SignalIn
    {
        [DataMember]
        public string[] epc { get; set; }
        [DataMember]
        public long[] timestamp { get; set; }
        [DataMember]
        public double[] phase;
        [DataMember]
        public int[] frequency;

        public SignalIn(string[] epc, long[] timestamp, double[] phase, int[] frequency)
        {
            this.epc = epc;
            this.timestamp = timestamp;
            this.phase = phase;
            this.frequency = frequency;
        }
     

    }



}

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
<<<<<<< HEAD
        FrequencyInfo realtimeAnalyze();
=======
        void realtimeAnalyze(SignalIn signalIn);
>>>>>>> b8eca286e13f01e4d391b9f6971d8a0ac7bfe2a0
        [OperationContract]
        FrequencyInfo offlineAnalyze(string fileName);
        [OperationContract]
        void addTagInfo(long timestamp, double phase, int frequency, string epc);
        [OperationContract]
        void removeHead();
        [OperationContract]
        void cleanBuffer();

    }
    [DataContract]
    public class FrequencyInfo
    {
        [DataMember]
        public double[] breath { get; set; }
        [DataMember]
        public double[] heartbeat { get; set; }
        [DataMember]
        public double[] t { get; set; }
        [DataMember]
        public double meanBreath { get; set; }
        [DataMember]
        public double meanHeartbeat { get; set; }
        [DataMember]
        public int fail { get; set; }

        public FrequencyInfo(double[]breath,double[] heartbeat,double[]t,double meanBreath,double meanHeartbeat,int fail)
        {
            this.breath = breath;
            this.heartbeat = heartbeat;
            this.t = t;
            this.meanBreath = meanBreath;
            this.meanHeartbeat = meanHeartbeat;
            this.fail = fail;
        }

        public FrequencyInfo()
        {

        }


    }

    //string[] epc,long[] timestamp, double[]phase,int[] frequency
<<<<<<< HEAD

=======
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
>>>>>>> b8eca286e13f01e4d391b9f6971d8a0ac7bfe2a0



}

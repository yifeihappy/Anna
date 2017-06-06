using MathWorks.MATLAB.NET.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using vitalsigns;
namespace VitalSignsServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
                ConcurrencyMode = ConcurrencyMode.Single)]
    class VitalSignsService : IVitalSignsService
    {
        private Queue<string> epcQueue = new Queue<string>();
        private Queue<long> timestampQueue = new Queue<long>();
        private  Queue<double> phaseQueue = new Queue<double>();
        private Queue<int> frequencyQueue = new Queue<int>();
        private VitalSignsExtract vitalSignsExtract = new VitalSignsExtract();
        public FrequencyInfo offlineAnalyze(string fileName)
        {
            Console.WriteLine("Start analyzing offline file："+fileName);
            
            MWCharArray filename = fileName;
            MWArray[] argsIn = new MWArray[] { filename };
            MWArray[] result = new MWArray[3];
            vitalSignsExtract.offlineVitalSignsExtract(3,ref result,argsIn);
            double[,] temp = (double[,])result[0].ToArray();
            int num = temp.GetLength(1);
            double[] breath = new double[num];
            double[] heartbeat = new double[num];
            double[] t = new double[num];
            for (int i = 0; i < num; i++)
            {
                breath[i] = temp[1, i];
                heartbeat[i] = temp[2, i];
                t[i] = temp[0, i];
            }
            double meanBreath = (double)(MWNumericArray)result[1];
            double meanHeartbeat = (double)(MWNumericArray)result[2];
            FrequencyInfo frequency = new FrequencyInfo(breath, heartbeat, t, meanBreath, meanHeartbeat,0);

            /*
            double[,] time = (double[,])result[1].ToArray();
            int num = frequency.GetLength(1);
            int[] breath = new int[num];
            heartbeat = new int[num];
            t = new double[num];
            for(int i = 0; i < num; i++)
            {
                breath[i] = (int)frequency[0, i];
                heartbeat[i] = (int)frequency[1, i];
                t[i] = time[0, i];
            }
            return breath;*/
            Console.WriteLine("Analysis ends");
            return frequency;
            //throw new NotImplementedException();
        }

        public FrequencyInfo realtimeAnalyze()
        {
            /*
            MWCellArray EPCArray = new MWCellArray(tagInfoQueue.Count, 1);
       
            int count = 0;
            ulong[] timestamp = new ulong[tagInfoQueue.Count];
            ushort[] phase = new ushort[tagInfoQueue.Count];
            int[] frequency = new int[tagInfoQueue.Count];
            foreach(TagInfo tagInfo in tagInfoQueue)
            {
                timestamp[count] = tagInfo.TimeStamp;
                phase[count] = tagInfo.RawPhase;
                frequency[count] = tagInfo.Frequency;
                EPCArray[++count, 1] = tagInfo.EPC;
            }
            MWNumericArray timeStampArray = timestamp;
            MWNumericArray phaseArray = phase;
            MWNumericArray frequencyIndex = frequency;
            MWArray[] argsIn = new MWArray[] { EPCArray, timeStampArray, phaseArray, frequencyIndex,0,1,10 };
            MWArray[] result = new MWArray[3];
            VitalSignsExtract vitalSignsExtract = new VitalSignsExtract();
            vitalSignsExtract.vitalSignsExtract(3,ref result,argsIn);
            */
            Console.WriteLine("Realtime Analyzing...");
            long[] timestampArray = timestampQueue.ToArray();
            MWNumericArray timeStampArray = timestampArray;
            double[] phaseArray1 = phaseQueue.ToArray();
            MWNumericArray phaseArray = phaseArray1;
            int[] frequencyArray = frequencyQueue.ToArray();
            MWNumericArray frequencyIndex = frequencyArray;
            string[] epcArray = epcQueue.ToArray();
            Console.WriteLine("array size : "+epcArray.Length);
           MWCellArray EPCArray = new MWCellArray(epcArray.Length, 1);
            //MWNumericArray filter = 0;
            //MWNumericArray method = 1;
            //MWNumericArray T = 10;
            for (int i=0; i < epcArray.Length; i++)
            {
                EPCArray[i + 1, 1] = epcArray[i];
            }

            MWArray[] argsIn = new MWArray[] { EPCArray, timeStampArray, phaseArray, frequencyIndex, 0, 1, 10 };
            MWArray[] result = new MWArray[3];
            FrequencyInfo fre = new FrequencyInfo();
            try
            { 
                vitalSignsExtract.vitalSignsExtract(3, ref result, argsIn);
                double[,] breathAndHb = (double[,])(result[0].ToArray());
                
                int fail = (int)(MWNumericArray)result[2];
                Console.WriteLine("fail: "+fail);
                fre.meanBreath = breathAndHb[0, 1];
                fre.meanHeartbeat = breathAndHb[0, 3];
                Console.WriteLine("breath:"+ breathAndHb[0, 1] + " "+breathAndHb[0,2]);
                Console.WriteLine("heartbeat:" + fre.meanHeartbeat + " "+breathAndHb[0,4]);
                fre.fail = fail;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
           

            return fre;
        }

        public void  addTagInfo(long timestamp, double phase, int frequency, string epc)
        {
            timestampQueue.Enqueue(timestamp);
            phaseQueue.Enqueue(phase);
            frequencyQueue.Enqueue(frequency);
            epcQueue.Enqueue(epc);
        }


        public void removeHead()
        {
            timestampQueue.Dequeue();
            phaseQueue.Dequeue();
            frequencyQueue.Dequeue();
            epcQueue.Dequeue();
        }

        public void cleanBuffer()
        {
            timestampQueue.Clear();
            phaseQueue.Clear();
            frequencyQueue.Clear();
            epcQueue.Clear();
        }

    }
}

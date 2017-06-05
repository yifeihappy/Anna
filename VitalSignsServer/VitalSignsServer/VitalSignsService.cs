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
        public FrequencyInfo offlineAnalyze(string fileName)
        {
            Console.WriteLine("正在离线分析文件："+fileName);
            VitalSignsExtract vitalSignsExtract = new VitalSignsExtract();
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
            FrequencyInfo frequency = new FrequencyInfo(breath, heartbeat, t, meanBreath, meanHeartbeat);

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
            Console.WriteLine("分析结束");
            return frequency;
            //throw new NotImplementedException();
        }

        public void realtimeAnalyze(SignalIn signalIn)
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
            Console.WriteLine("实时分析...");
            MWNumericArray timeStampArray = new MWNumericArray(signalIn.timestamp);
            MWNumericArray phaseArray = new MWNumericArray(signalIn.phase);
            MWNumericArray frequencyIndex = signalIn.frequency;
            MWCellArray EPCArray = new MWCellArray(signalIn.epc.Length, 1);
            //MWNumericArray filter = 0;
            //MWNumericArray method = 1;
            //MWNumericArray T = 10;
            for (int i=0; i < signalIn.epc.Length; i++)
            {
                EPCArray[i + 1, 1] = signalIn.epc[i];
            }
            MWArray[] argsIn = new MWArray[] { EPCArray, timeStampArray, phaseArray, frequencyIndex, 0, 1, 10 };
            MWArray[] result = new MWArray[3];
            VitalSignsExtract vitalSignsExtract = new VitalSignsExtract();
            vitalSignsExtract.vitalSignsExtract(3, ref result, argsIn);

            
        }
    }
}

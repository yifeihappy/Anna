using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using MathWorks.MATLAB.NET.Arrays;


namespace VitalSignsServer
{
    class Program
    {
        static void Main(string[] args)
        {
           
            /*Class1 a = new Class1();
            MWArray b = 3, c = 6;
            MWNumericArray e = new MWNumericArray(new int[] { 1,2});
            MWArray[] argsIn = new MWArray[] { b, c,e };
            MWArray[] result = new MWArray[2];
            a.sub(2,ref result,argsIn);
            Console.WriteLine(result.ToString());*/
            using (ServiceHost host = new ServiceHost(typeof(VitalSignsService)))
            {
                ServiceMetadataBehavior smb = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
                if (smb == null)
                    host.Description.Behaviors.Add(new ServiceMetadataBehavior());

                //暴露出元数据，以便能够让SvcUtil.exe自动生成配置文件
                host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");

                //开启服务
                host.Open();
                Console.WriteLine("Service listen begin to listen on 50004");
                Console.WriteLine("Vital signs Service is running...");
                Console.WriteLine("press any key to teriminate...");
                Console.ReadKey();
                host.Abort();
                host.Close();
            }
        }
    }
}

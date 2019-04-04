using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Create a URI to serve as the base address
            Uri address = new Uri("http://localhost:7777/CalculatorService");
            //Create ServiceHost

            ServiceHost host
            = new ServiceHost(typeof(CalculatorService),address);

            //Add a service endpoints
            host.AddServiceEndpoint(typeof(ICalculatorService)
            , new BasicHttpBinding(),"");

            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            host.Open();
            Console.WriteLine("Calculator Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press <Enter> key to stop");
            Console.ReadLine();
        }
    }
}

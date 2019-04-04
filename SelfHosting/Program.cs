using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:9999/WCFService/TaskService");
            //Create ServiceHost
            
            ServiceHost host
            = new ServiceHost(typeof(WCFServiceTask1.ServiceBehaviors.TaskService), httpUrl);
            
            //Add a service endpoints
            host.AddServiceEndpoint(typeof(WCFServiceTask1.ServiceContracts.ITaskService)
            , new WSHttpBinding(), "http");
            host.AddServiceEndpoint(typeof(WCFServiceTask1.ServiceContracts.ITaskService)
            , new NetTcpBinding(), "net.tcp://localhost:8888/WCFService/TaskService");
            
            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            //Start the Service
            host.Open();

            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press <Enter> key to stop");
            Console.ReadLine();
        }
    }
}

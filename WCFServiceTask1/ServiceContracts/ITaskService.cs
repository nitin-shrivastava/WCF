using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceTask1.ServiceContracts
{
    [ServiceContract]
    public interface ITaskService
    {
        [OperationContract]
        string SayHello(string name);

        [OperationContract]
        string TodayProgram(string name);
    }
}

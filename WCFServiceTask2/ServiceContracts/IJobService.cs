using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceTask2.ServiceContracts
{
    [ServiceContract]
    public interface IJobService
    {
        [OperationContract]
        IEnumerable<string> OpeningJobs();

        [OperationContract]
        IEnumerable<string> OpeningJobsByRole(string role);
    }
}

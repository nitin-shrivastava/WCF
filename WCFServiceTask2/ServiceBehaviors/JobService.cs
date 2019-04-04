using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceTask2.ServiceContracts;

namespace WCFServiceTask2.ServiceBehaviors
{
    public class JobService : IJobService
    {
        private static KeyValuePair<string, string>[] JobOpenings => new KeyValuePair<string, string>[5]
        {
          new KeyValuePair<string,string>("Developer", "DJob1" ),
          new KeyValuePair<string,string>("Developer", "DJob2" ),
          new KeyValuePair<string,string>("Manager", "MJob1" ),
          new KeyValuePair<string,string>("Manager", "MJob2" ),
          new KeyValuePair<string,string>("Manager", "MJob3" )

        };

        public IEnumerable<string> OpeningJobs()
        {
            return JobOpenings.Select(job => job.Value);
        }

        public IEnumerable<string> OpeningJobsByRole(string role)
        {
            return JobOpenings.Where(job => job.Key.Equals(role)).Select(job => job.Value);
        }
    }
}

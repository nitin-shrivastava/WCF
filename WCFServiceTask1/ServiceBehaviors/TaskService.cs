using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceTask1.ServiceContracts;

namespace WCFServiceTask1.ServiceBehaviors
{
    public class TaskService : ITaskService
    {
        public string SayHello(string name)
        {
            var hour = DateTime.Now.Hour;
            string greeting = default(string);
            if (hour > 0 && hour < 12)
            {
                greeting =  $"Good Morning {name}";
            }

            else if (hour > 11 && hour < 17)
            {
                greeting =  $"Good Afternoon {name}";
            }

            else if (hour > 17)
            {
                greeting =  $"Good Evening {name}";
            }

            return greeting;
        }

        public string TodayProgram(string name)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                return "Happy Weekend";
            }

            return "Enjoy Working Day";
        }
    }
}

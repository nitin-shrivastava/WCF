using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFServiceConsumer.JobServiceReference;
using WCFServiceConsumer.TaskServiceReference;

namespace WCFServiceConsumer.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
          
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TestTaskService()
        {
            return View("TestTaskService");
        }

        [HttpPost]
        public ActionResult WithHttp()
        {
            ViewBag.Result = new TaskServiceClient("WSHttpBinding_ITaskService").SayHello("Buddy");
            return View("TestTaskService");
        }

        [HttpPost]
        public ActionResult WithTCP()
        {
            ViewBag.Result = new TaskServiceClient("NetTcpBinding_ITaskService").TodayProgram("Buddy");
            return View("TestTaskService");
        }

        public ActionResult GetJobs()
        {
            ViewBag.Jobs = new JobServiceClient("BasicHttpBinding_IJobService").OpeningJobs();
            return View("TestTaskService");
        }

        public ActionResult GetJobsByRole(string role)
        {
            ViewBag.Jobs = new JobServiceClient("BasicHttpBinding_IJobService").OpeningJobsByRole(role);
            return View("TestTaskService");
        }

    }
}
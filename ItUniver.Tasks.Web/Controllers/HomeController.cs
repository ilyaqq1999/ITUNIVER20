using System.Diagnostics;

using ItUniver.Tasks.Web.Models;
using ItUniver.Tasks.Stores;
using ItUniver.Tasks.Entities;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ItUniver.Tasks.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        private readonly ITaskStore taskStore;
        // private readonly ITaskManager taskManager;

        public HomeController(ILogger<HomeController> logger, ITaskStore taskStore)
        {
            this.logger = logger;
            this.taskStore = taskStore;
        }
        //public HomeController(ILogger<HomeController> logger, ITaskManager taskManager)
        //{
        //    this.logger = logger;
        //    this.taskManager = taskManager;
        //}

        public IActionResult Index()
        {
            //var a = taskStore.Save(new Entities.TaskBase { Subject = "Hello", Description = "Hello World!!!" });
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

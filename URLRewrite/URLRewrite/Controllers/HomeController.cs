using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace URLRewrite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var userAgent = Request.UserAgent;
            var filePath = Server.MapPath("/App_Data/user_agents.txt");
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(DateTime.Now.ToLongDateString() + " - " + userAgent);
            }

            //List all the hits received so far
            var fileContentList = System.IO.File.ReadAllLines(filePath);

            return View(fileContentList);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
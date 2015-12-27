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
        string filePath = "/App_Data/user_agents.txt";

        public ActionResult Index()
        {
            var userAgent = Request.UserAgent;
            
            using (StreamWriter writer = new StreamWriter(Server.MapPath(filePath), true))
            {
                writer.WriteLine(DateTime.Now.ToString() + " - " + userAgent);
            }

            //List all the hits received so far
            var fileContentList = System.IO.File.ReadAllLines(Server.MapPath(filePath));

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

        public ActionResult Facebook()
        {
            var userAgent = Request.UserAgent;

            using (StreamWriter writer = new StreamWriter(Server.MapPath(filePath), true))
            {
                writer.WriteLine("Redirected to facebook crawler page on {0} at {1}. Actual url given below", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
                writer.WriteLine(userAgent);
            }

            return View();
        }
    }
}
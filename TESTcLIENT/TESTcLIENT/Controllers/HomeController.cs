using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TESTcLIENT.Controllers
{
    public class HomeController : Controller
    {
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


        public ActionResult Login() {


            return View();
        }
        public ActionResult check() {

            string user = Request.Form["username"];
            String Pass = Request.Form["password"];

            bool test = UTILS.util.Verifi(user, Pass);


            return View();
        }
    }
}
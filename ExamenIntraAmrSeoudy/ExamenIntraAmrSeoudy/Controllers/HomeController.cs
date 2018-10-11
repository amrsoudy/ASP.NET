using ExamenIntraAmrSeoudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenIntraAmrSeoudy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddVoyage()
        {

            List<String> listville = new List<string>{ "MONTREAL", "LAVAL", "QUEBEC" ,"SHERBROOKE"};
            ViewBag.LISTVILLE = listville;

            return View();
        }
        [HttpPost]
        public ActionResult AddVoyage(FormCollection collection)
        {
            Utilitaire.Utils.GetInstance().AddVoyage(collection);

            List<String> listville = new List<string> { "MONTREAL", "LAVAL", "QUEBEC", "SHERBROOKE" };
            ViewBag.LISTVILLE = listville;

            ViewBag.Message = "le Voyage Added ";
            return View();
        }

        public ActionResult Consult()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Consult(FormCollection collection)
        {
           List<Information> list  = Utilitaire.Utils.GetInstance().getListInformation(collection);

            return View("Show",list);
        }


        public ActionResult VilleInfo()
        {

            List<String> listville = new List<string> { "MONTREAL", "LAVAL", "QUEBEC", "SHERBROOKE" };
            ViewBag.LISTVILLE = listville;
            return View();
        }


        [HttpPost]
        public ActionResult VilleInfo(FormCollection collection)
        {
            List<Information> list = Utilitaire.Utils.GetInstance().getVilleInfo(collection);

            List<String> listville = new List<string> { "MONTREAL", "LAVAL", "QUEBEC", "SHERBROOKE" };
            ViewBag.LISTVILLE = listville;

            return View("Show", list);
        }





    }
}
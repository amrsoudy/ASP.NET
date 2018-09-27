using EntityFrame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<Activite> list  =Utilitaire.Utils.getInstance().getListActivite();

            return View(list);
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
        public ActionResult Vote()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.list  = Utilitaire.Utils.getInstance().getListActivite().Select(s => s.nom);

            return View();
        }
        [HttpPost]
        public ActionResult Vote(FormCollection collection)
        {
            Utilitaire.Utils.getInstance().inserVote(collection["votenom"], collection.Get("listActivite"));
            ViewBag.mess = "inserted";

            return RedirectToAction("Index");
        }

        public ActionResult Consulte() {

            var listvote = Utilitaire.Utils.getInstance().GetVotes();

            return View(listvote);
        }

    }
}
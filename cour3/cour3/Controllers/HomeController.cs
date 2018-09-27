using cour3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cour3.Controllers
{
    public class HomeController : Controller
    {
        private List<Movie> listMovie;
        public List<Movie> getlistMovie()
        {

            if (listMovie != null)
            {

                return listMovie;
            }
            else
            {

                listMovie = Utils.utils.getInstance().getMovies();
                return listMovie;

            }
        }
        // GET: CRUD
        public ActionResult Index()
        {

            return View(getlistMovie());

        }

        public ActionResult Details(int id)
        {

            var list = getlistMovie().Where(s => s.Id == id).Select(s => s);
            Movie mov = new Movie();

            foreach (Movie m in list)
            {

                mov = m;
            }

            return View(mov);
        }

        // GET: CRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CRUD/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                Movie movie1 = new Movie();
                movie1.Id = Int32.Parse(collection["Id"]);
                movie1.Title = collection["title"];
                movie1.Genre = collection["genre"];
                movie1.year = Int32.Parse(collection["year"]);

                int x = Utils.utils.getInstance().insertMovie(movie1);
                ViewBag.num = x + " inserted ";

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CRUD/Edit/5
        public ActionResult Edit(int id)
        {
            var list = getlistMovie().Where(s => s.Id == id).Select(s => s);
            Movie mov = new Movie();

            foreach (Movie m in list)
            {

                mov = m;
            }

            return View(mov);
        }


        // GET: CRUD/Delete/5

        public ActionResult Delete(int id)
        {
            var list = getlistMovie().Where(s => s.Id == id).Select(s => s);
            Movie mov = new Movie();

            foreach (Movie m in list)
            {

                mov = m;
            }

            return View(mov);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

                Utils.utils.getInstance().deleteItem(id);

                return RedirectToAction("Index");
                       
        }


    }
}


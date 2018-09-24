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
        List<Movie> listMovie = new List<Movie>();
        // GET: CRUD
        public ActionResult Index()
        {
            listMovie = Utils.utils.getInstance().getMovies();

            
            return View(listMovie);
        }

        // GET: CRUD/Details/5
        public ActionResult Details(int id)
        {
          
            Movie movie1 = Utils.utils.getInstance().GetSingleMovie( id);


            return View(movie1);
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

               int x  = Utils.utils.getInstance().insertMovie(movie1);
                ViewBag.num = x +" inserted ";

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
            Movie movie1 = Utils.utils.getInstance().GetSingleMovie( id);


            return View(movie1);
        }

       
        // GET: CRUD/Delete/5
        public ActionResult Delete(int id)
        {

            Movie movie1 = Utils.utils.getInstance().GetSingleMovie( id);


            return View(movie1);
        }

        // POST: CRUD/Delete/5
        
        }
    }


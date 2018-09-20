using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {

            var movie = new Movie() {name = "shrek!"};

            var customers = new List<Customer>
            {

                new Customer {Name = "cutomer1"},
                new Customer {Name = "cutomer2"}



            };

            var viewModel = new RandomMoviesViewModel
            {


                movie = movie ,
                Customers = customers

            };

            var viewResult = new ViewResult();
            return View(viewModel);
           



            // return Content("Hello word ");
            //return new EmptyResult();
            //return HttpNotFound();
           // return RedirectToAction("Index", "Home",new {page = 1 ,sortby ="name"});
        }

        public ActionResult Edit(int Id)
        {



            return Content("moiveId=" + Id);
        }

        public ActionResult Index(int? pageindex ,string sortby)
        {

            if (!pageindex.HasValue)
            {

                pageindex = 1;


            }

            if (String.IsNullOrWhiteSpace(sortby))
            {


                sortby = "Name";
            }

            return  Content(String.Format("pageIndex={0}&sortBy={1}",pageindex,sortby));
        }

        [Route("movies/released/{year}/{month:regex(\\d{1}):range(1,12)}")]
        public ActionResult ByRelaseYear(int year, int month)
        {

            return Content(year +"/"+ month);

        }


       
    }
}
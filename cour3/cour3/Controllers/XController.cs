using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cour3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=10.139.31.219;Initial Catalog=Northwind;User ID=sa;Password=1234");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "getListeFilms";
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            reader = cmd.ExecuteReader();

            List<Models.Movie> result = new List<Models.Movie>();

            while (reader.Read()) {

                Models.Movie item = new Models.Movie()
                {

                    Title = reader["title"].ToString(),
                    Genre = reader["genre"].ToString(),
                    year = Int32.Parse(reader["year"].ToString())



                };

                result.Add(item);
            }
            sqlConnection1.Close();


                return View(result);
        }

    }
}
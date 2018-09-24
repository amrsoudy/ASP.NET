using cour3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace cour3.Utils
{
    public  class utils
    {

        private List<Movie> listDAO;
        public List<Movie> getListDao() {

            if (listDAO != null)
            {

                return listDAO;

            }
            else {

                listDAO = new List<Movie>();
                return listDAO;

            }


        }


        private static utils Util ;

        public static utils getInstance() {


            if (Util != null)
            {

                return Util;

            }
            else {

                Util = new utils();
                return Util;

            }





        }


        public  List<Movie> getMovies() {


            SqlConnection connection = new SqlConnection("Data Source=10.139.31.219;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=1234");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "getListeFilms";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            connection.Open();

            reader = cmd.ExecuteReader();

            List<Movie> listMovie = new List<Movie>();

            while (reader.Read()) {

                Movie movie = new Movie();
                movie.Id = Int32.Parse(reader["Id"].ToString());
                movie.Title = reader["title"].ToString();
                movie.Genre = reader["genre"].ToString();
                movie.year = Int32.Parse(reader["year"].ToString());

                getListDao().Add(movie);


            }

            connection.Close();


            return listDAO;

        }

        internal int insertMovie(Movie movie1)
        {
            getListDao().Add(movie1);
            SqlConnection connection = new SqlConnection("Data Source=10.139.31.219;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=1234");

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "InsertFilms";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            cmd.Parameters.Add(new SqlParameter("@id",movie1.Id));
            cmd.Parameters.Add(new SqlParameter("@title", movie1.Title));
            cmd.Parameters.Add(new SqlParameter("@genre", movie1.Genre));
            cmd.Parameters.Add(new SqlParameter("@year", movie1.year));

            connection.Open();

            int x  = cmd.ExecuteNonQuery();

            List<Movie> listMovie = new List<Movie>();


            connection.Close();
            return x;

        }



        internal Movie GetSingleMovie( int id)
        {

            Movie mov = new Movie();
            foreach (Movie movie in listDAO) {

                if (movie.Id == id)
                {


                    mov = movie;


                }
        

            }

            return mov;


        }
    }
}
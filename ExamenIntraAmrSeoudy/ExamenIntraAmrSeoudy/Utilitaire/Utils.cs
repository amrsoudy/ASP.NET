using ExamenIntraAmrSeoudy.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenIntraAmrSeoudy.Utilitaire
{
    public class Utils
    {

        private static Utils utils;
        //Singlton  only one object
        public static Utils GetInstance() {


            if (utils != null)
            {

                return utils;

            }
            else
            { utils = new Utils();

                return utils;
            }

        }

        internal void AddVoyage(FormCollection collection)
        {
            Information info = new Information();
            info.nom = collection["nom"].ToUpper();
            info.prenom = collection["prenom"];


            if (!collection["date"].Equals("")  )
            {
                info.date = collection["date"];
            }
            else {

                info.date = (DateTime.Now).ToString();

            }
           
            info.kilo = Int32.Parse( collection["kilo"].ToString() );
            info.fraisResturant = Double.Parse(collection["fraisResturant"].ToString());
            info.ville = collection["ville"].ToUpper();
            info.postalCode = collection["postalCode"];
            info.Email = collection["Email"];

            SqlConnection connection = new SqlConnection("Data Source=10.139.31.219;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=1234");

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "InsertVoyage";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            cmd.Parameters.Add(new SqlParameter("@nom", info.nom));
            cmd.Parameters.Add(new SqlParameter("@prenom", info.prenom));
            cmd.Parameters.Add(new SqlParameter("@date", info.date));
            cmd.Parameters.Add(new SqlParameter("@kilo", info.kilo));
            cmd.Parameters.Add(new SqlParameter("@ville", info.ville));
            cmd.Parameters.Add(new SqlParameter("@frais", info.fraisResturant));
            cmd.Parameters.Add(new SqlParameter("@postalcoe", info.postalCode));
            cmd.Parameters.Add(new SqlParameter("@email", info.Email));


            connection.Open();

            int x = cmd.ExecuteNonQuery();

            connection.Close();


        }

        internal List<Information> getVilleInfo(FormCollection collection)
        {
            String ville = collection["ville"].ToUpper();

            SqlConnection connection = new SqlConnection("Data Source=10.139.31.219;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=1234");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            List<Information> list = new List<Information>();

            cmd.CommandText = "GetVilleInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ville", ville));

            cmd.Connection = connection;
            connection.Open();

            reader = cmd.ExecuteReader();

            List<Information> listMovie = new List<Information>();

            while (reader.Read())
            {

                Information info = new Information();
                info.nom = reader["nom"].ToString();
                info.prenom = reader["prenom"].ToString();
                info.date = reader["date"].ToString();
                info.kilo = Int32.Parse(reader["kilo"].ToString());
                info.ville = reader["ville"].ToString();
                info.fraisResturant = double.Parse(reader["fraisResturant"].ToString());
                info.postalCode = reader["postalCode"].ToString();
                info.Email = reader["email"].ToString();

                list.Add(info);



            }

            connection.Close();


            return list;
        }

        internal List<Information> getListInformation(FormCollection collection)
        {
            String nom = collection["nom"].ToUpper();

            SqlConnection connection = new SqlConnection("Data Source=10.139.31.219;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=1234");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            List<Information> list = new List<Information>();

            cmd.CommandText = "GetInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@param1", nom));

            cmd.Connection = connection;
            connection.Open();

            reader = cmd.ExecuteReader();

            List<Information> listMovie = new List<Information>();

            while (reader.Read())
            {

                Information info = new Information();
                info.nom = reader["nom"].ToString();
                info.prenom = reader["prenom"].ToString();
                info.date = reader["date"].ToString();
                info.kilo = Int32.Parse(reader["kilo"].ToString());
                info.ville = reader["ville"].ToString().ToUpper();
                info.fraisResturant = double.Parse(reader["fraisResturant"].ToString());
                info.postalCode = reader["postalCode"].ToString();
                info.Email = reader["email"].ToString();

                list.Add(info);
             


            }

            connection.Close();


            return list;

        }
    }
}
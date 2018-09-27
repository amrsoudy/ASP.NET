using EntityFrame.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EntityFrame.Utilitaire
{
    public class Utils
    {
        private static Utils utils;

        public static Utils getInstance() {


            if (utils != null)
            {

                return utils;

            }
            else {

                utils = new Utils();
                return utils;

            }


        }


        public List<Activite> getListActivite() {

            List<Activite> listAct = new List<Activite>();


            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "GetListActivite";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = connection;
            SqlDataReader reader;

            connection.Open();

            reader = cmd.ExecuteReader();
            

            while (reader.Read()) {
                Activite activite = new Activite();

                activite.nom = reader["nom"].ToString();
                activite.duree = Int32.Parse(reader["duree"].ToString());
                activite.cout = double.Parse(reader["cout"].ToString());

                listAct.Add(activite);


            }
            connection.Close();

            return listAct;

        }

        internal Dictionary<String, int> GetVotes()
        {

            Dictionary<String, int> list = new Dictionary<string, int>();


            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "countActivite";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = connection;
            SqlDataReader reader;

            connection.Open();

            reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                list.Add(reader["activitenom"].ToString(), Int32.Parse(reader["Res"].ToString()));
                

            }
            connection.Close();

            return list;
        }

        internal void inserVote(string nom, string choix)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "InsertVote";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@param1", nom));
            cmd.Parameters.Add(new SqlParameter("@param2", choix));
            cmd.Connection = connection;

            connection.Open();

            int x  = cmd.ExecuteNonQuery();


            connection.Close();


        }
    }
}
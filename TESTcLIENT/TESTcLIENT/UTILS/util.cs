using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TESTcLIENT.UTILS
{
    public class util
    {

        public void getClients() {

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;


            cmd.CommandText = "GETCLIENTS";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = connection;
            reader = cmd.ExecuteReader();







        }

        public static bool  Verifi(string user, string pass)
        {
            throw new NotImplementedException();
        }
    }
}
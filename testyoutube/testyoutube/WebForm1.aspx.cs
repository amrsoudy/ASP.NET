using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace testyoutube
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) {

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                connection.Open();

                string checkuser = "select count(*) from Table where username = '"+ TextBox1.Text+"'";
                SqlCommand com = new SqlCommand(checkuser, connection);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

                if(temp == 1 )

                connection.Close();

            }
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }

       

        protected void Button1_Click1(object sender, EventArgs e)
        {

            Response.Write("tu success por registrer ");

        }
    }
}
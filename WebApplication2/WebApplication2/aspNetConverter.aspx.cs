using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class aspNetConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            decimal USAmount = Decimal.Parse(TextBox1.Text);
            if (USAmount > 0)
            {

                decimal euroAmount = USAmount * 0.85M;

                TextBox1.Text = euroAmount.ToString() + "$ Can ";
                TextBox2.Enabled = false;
                 res.InnerHtml = euroAmount.ToString() + "$ can";


            }
            else
            {


                Response.Redirect("erreur.html");

            }
        }
    }
}
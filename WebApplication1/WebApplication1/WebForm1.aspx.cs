using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void convert_us_can(object sender, EventArgs e)
        {
            decimal USAmount = Decimal.Parse(us.Value);
            if (USAmount > 0)
            {

                decimal euroAmount = USAmount * 0.85M;

                can.Value = euroAmount.ToString() + "$ Can ";
                can.Disabled = true;
                canDiv.InnerHtml = euroAmount.ToString() + "$ can";


            }
            else {


                Response.Redirect("erreur.html");

            }

          


        }
        
    }
}
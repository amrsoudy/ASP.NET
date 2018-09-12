using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            HttpContext _context = HttpContext.Current;

            res.InnerHtml = "le montant " + Request.Form["us"] + " vaut " + _context.Items["can"] + "$ can ";


        }
    }
}
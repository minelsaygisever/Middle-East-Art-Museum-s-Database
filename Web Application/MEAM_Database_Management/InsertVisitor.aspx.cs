using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MEAM_Database_Management
{
    public partial class InsertVisitor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertCitizen.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertTourist.aspx");
        }
    }
}
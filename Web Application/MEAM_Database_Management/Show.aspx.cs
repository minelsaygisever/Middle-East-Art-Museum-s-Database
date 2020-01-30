using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MEAM_Database_Management
{
    public partial class Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowVisitor.aspx");

        }

        protected void ShowButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowPiece.aspx");

        }

        protected void ShowButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowEmployee.aspx");

        }

        protected void ShowButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowShop.aspx");

        }

        protected void ShowButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowItem.aspx");

        }

    }
}
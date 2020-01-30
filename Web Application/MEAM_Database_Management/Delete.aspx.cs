using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MEAM_Database_Management
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeleteButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteVisitor.aspx");

        }

        protected void DeleteButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeletePiece.aspx");

        }

        protected void DeleteButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteEmployee.aspx");

        }

        protected void DeleteButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteShop.aspx");

        }

        protected void DeleteButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteItem.aspx");

        }
    }
}
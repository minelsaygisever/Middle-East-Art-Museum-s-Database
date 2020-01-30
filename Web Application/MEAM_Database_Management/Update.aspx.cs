using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MEAM_Database_Management
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void UpdateButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateEmployee.aspx");

        }

        protected void UpdateButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateShop.aspx");

        }

        protected void UpdateButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateItem.aspx");

        }
    }
}
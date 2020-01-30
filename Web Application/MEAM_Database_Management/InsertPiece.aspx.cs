using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace MEAM_Database_Management
{
    public partial class InsertPiece : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPainting.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertSculpture.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertTool.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertClothes.aspx");
        }
    }
}
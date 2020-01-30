using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MEAM_Database_Management
{
    public partial class DeletePiece : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeletePieceButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeletePainting.aspx");

        }

        protected void DeletePieceButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteSculpture.aspx");

        }

        protected void DeletePieceButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteClothes.aspx");

        }

        protected void DeletePieceButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteTools.aspx");

        }

    }
}
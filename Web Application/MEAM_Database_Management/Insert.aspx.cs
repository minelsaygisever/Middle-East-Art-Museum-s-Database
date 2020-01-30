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
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Visitor
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertVisitor.aspx");
        }

        // Piece
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPiece.aspx");
        }

        // Employee
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertEmployee.aspx");
        }

        // Shop 
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertShop.aspx");
        }

        // Item
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertItem.aspx");
        }
        
    }
}
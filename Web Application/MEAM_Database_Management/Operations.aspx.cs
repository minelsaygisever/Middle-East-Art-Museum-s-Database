using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// 
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace MEAM_Database_Management
{
    public partial class Operations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Label1.Text = " Welcome " + Session["EmployeeName"] + " - " + Session["PersonalID"];
            }
        }


        protected void OperationButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert.aspx");
        }

        protected void OperationButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update.aspx");
        }

        protected void OperationButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delete.aspx");
        }

        protected void OperationButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Show.aspx");
        }

    }
}
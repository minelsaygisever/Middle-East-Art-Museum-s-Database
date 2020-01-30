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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con.Close();
                return;
                throw;
            }


            DataSet ds = new DataSet();
            string sqlstr = "select * from EMPLOYEE_T where PersonalID=" + TextBox1.Text;

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            string employeeName = ds.Tables[0].Rows[0]["EmployeeName"].ToString();
            string personalID = ds.Tables[0].Rows[0]["PersonalID"].ToString();
            con.Close();
            string printMessage = "Name : " + employeeName + " ID : " + personalID;
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", printMessage, true);

            Session["EmployeeName"] = employeeName;
            Session["PersonalID"] = personalID;

            Response.Redirect("Operations.aspx");
        }
    }
}
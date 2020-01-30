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
    public partial class InsertReceipt : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
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

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Receipt_T";

            SqlDataAdapter da1 = new SqlDataAdapter(sqlstr, con);
            da1.Fill(ds1);

            GridView1.DataSource = ds1;
            GridView1.DataBind();

            con.Close();
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

            string sqlStrReceipt = "INSERT INTO Receipt_T (ShopName, VisitorNumber, ReceiptNumber, Cost, CuttingDay, CuttingMonth, CuttingYear, " +
                "CuttingHour, CuttingMinute, Cashier) VALUES('" + TextBoxSName.Text + "', " + TextBoxVNum.Text + ", " + TextBoxRNum.Text + ", " +
                TextBoxCost.Text + ", " + TextBoxDay.Text + ", " + TextBoxMonth.Text + ", " + TextBoxYear.Text + ", " + TextBoxHour.Text + ", " +
                TextBoxMin.Text + ", ";

            if (!string.IsNullOrEmpty(TextBoxCashier.Text))
            {
                sqlStrReceipt += "'" + TextBoxCashier.Text + "');";
            }
            else
            {
                sqlStrReceipt += "NULL);";
            }

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand execShop = new SqlCommand(sqlStrReceipt, con);
            adapter1.InsertCommand = new SqlCommand(sqlStrReceipt, con);
            adapter1.InsertCommand.ExecuteNonQuery();
            execShop.Dispose();

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Receipt_T";

            SqlDataAdapter da1 = new SqlDataAdapter(sqlstr, con);
            da1.Fill(ds1);

            GridView2.DataSource = ds1;
            GridView2.DataBind();

            con.Close();
        }
    }
}
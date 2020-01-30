using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MEAM_Database_Management
{
    public partial class InsertShop : System.Web.UI.Page
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
            string sqlstr = "select * from Shop_T";

            SqlDataAdapter da1 = new SqlDataAdapter(sqlstr, con);
            da1.Fill(ds1);

            GridView1.DataSource = ds1;
            GridView1.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Shop_Phone_Number_T";

            SqlDataAdapter da2 = new SqlDataAdapter(sqlstr, con);
            da2.Fill(ds2);

            GridView2.DataSource = ds2;
            GridView2.DataBind();
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

            string sqlStrShop = "INSERT INTO Shop_T (ShopName, Profit, ManagerID) VALUES('" + TextBoxName.Text + "', ";
            string sqlStrPhone;

            if (!string.IsNullOrEmpty(TextBoxProfit.Text))
            {
                sqlStrShop += TextBoxProfit.Text + ", ";
            }
            else
            {
                sqlStrShop += "NULL, ";
            }


            if (!string.IsNullOrEmpty(TextBoxManID.Text))
            {
                sqlStrShop += TextBoxManID.Text + ");";
            }
            else
            {
                sqlStrShop += "NULL);";
            }

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand execShop = new SqlCommand(sqlStrShop, con);
            adapter1.InsertCommand = new SqlCommand(sqlStrShop, con);
            adapter1.InsertCommand.ExecuteNonQuery();
            execShop.Dispose();

            using (StringReader reader = new StringReader(TextBoxPhone.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    sqlStrPhone = "INSERT INTO Shop_Phone_Number_T (ShopName, PhoneNumber) VALUES('" + TextBoxName.Text + "', '" + line + "');";
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    SqlCommand execPhoneNumbers = new SqlCommand(sqlStrPhone, con);
                    adapter2.InsertCommand = new SqlCommand(sqlStrPhone, con);
                    adapter2.InsertCommand.ExecuteNonQuery();
                    execPhoneNumbers.Dispose();
                }
            }

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Shop_T";

            SqlDataAdapter da1 = new SqlDataAdapter(sqlstr, con);
            da1.Fill(ds1);

            GridView3.DataSource = ds1;
            GridView3.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Shop_Phone_Number_T";

            SqlDataAdapter da2 = new SqlDataAdapter(sqlstr, con);
            da2.Fill(ds2);

            GridView4.DataSource = ds2;
            GridView4.DataBind();
            con.Close();

        }
    }
}
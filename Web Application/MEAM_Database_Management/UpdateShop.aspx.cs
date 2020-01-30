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
    public partial class UpdateShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            shopUpdate.Visible = false;
            newTables.Visible = true;
        }

        protected void ButtonShopName_Click(object sender, EventArgs e)
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
            String str = "select * from Shop_T where ShopName='" + TextBoxFirstShopName.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds);
            textshop.Text = TextBoxFirstShopName.Text;
            TextBoxProfit.Text = ds.Tables[0].Rows[0]["Profit"].ToString();
            TextBoxManagerID.Text = ds.Tables[0].Rows[0]["ManagerID"].ToString();


            DataSet ds1 = new DataSet();
            String str1 = "select * from Shop_Phone_Number_T where ShopName='" + TextBoxFirstShopName.Text + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(str1, con);
            da1.Fill(ds1);

            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                TextBoxPhone.Text += ds1.Tables[0].Rows[i]["PhoneNumber"].ToString() + "\n";
            }

            DataSet ds2 = new DataSet();
            String str2 = "select * from Shops_Items_T where ShopName='" + TextBoxFirstShopName.Text + "'";
            SqlDataAdapter da2 = new SqlDataAdapter(str2, con);
            da2.Fill(ds2);

            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                TextBoxItem.Text += ds2.Tables[0].Rows[i]["Barcode"].ToString() + "\n";
            }


            nameEnter.Visible = false;
            shopUpdate.Visible = true;
        }
        protected void ButtonUpdateShop_Click(object sender, EventArgs e)
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


            if (string.IsNullOrEmpty(TextBoxProfit.Text))
            {
                TextBoxProfit.Text = "NULL";
            }

            if (string.IsNullOrEmpty(TextBoxManagerID.Text))
            {
                TextBoxManagerID.Text = "NULL";
            }



            SqlCommand c1 = new SqlCommand("Update Shop_T set Profit=" + TextBoxProfit.Text + ", ManagerID=" + TextBoxManagerID.Text +
                " where ShopName='" + TextBoxFirstShopName.Text + "'", con);
            c1.ExecuteNonQuery();

            SqlCommand c2 = new SqlCommand("Delete from Shop_Phone_Number_T where ShopName='" + TextBoxFirstShopName.Text + "'", con);
            c2.ExecuteNonQuery();

            using (StringReader reader = new StringReader(TextBoxPhone.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    SqlCommand c3 = new SqlCommand("INSERT INTO Shop_Phone_Number_T (ShopName, PhoneNumber) VALUES('" + TextBoxFirstShopName.Text + "', " + line + ")", con);
                    c3.ExecuteNonQuery();
                }
            }

            SqlCommand c4 = new SqlCommand("Delete from Shops_Items_T where ShopName='" + TextBoxFirstShopName.Text + "'", con);
            c4.ExecuteNonQuery();

            using (StringReader reader = new StringReader(TextBoxItem.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    SqlCommand c5 = new SqlCommand("INSERT INTO Shops_Items_T (ShopName, Barcode) VALUES('" + TextBoxFirstShopName.Text + "', '" + line + "')", con);
                    c5.ExecuteNonQuery();
                }
            }
            DataSet ds = new DataSet();
            string sqlstr = "select * from Shop_T where ShopName='" + TextBoxFirstShopName.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataSet ds2 = new DataSet();
            string sqlstr2 = "select * from Shop_Phone_Number_T where ShopName='" + TextBoxFirstShopName.Text + "'";

            SqlDataAdapter da2 = new SqlDataAdapter(sqlstr2, con);
            da2.Fill(ds2);
            GridView2.DataSource = ds2;
            GridView2.DataBind();

            DataSet ds3 = new DataSet();
            string sqlstr3 = "select * from Shops_Items_T where ShopName='" + TextBoxFirstShopName.Text + "'";

            SqlDataAdapter da3 = new SqlDataAdapter(sqlstr3, con);
            da3.Fill(ds3);
            GridView3.DataSource = ds3;
            GridView3.DataBind();

            con.Close();

            shopUpdate.Visible = false;
            newTables.Visible = true;
        }

    }
}
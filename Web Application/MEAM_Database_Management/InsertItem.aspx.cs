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
    public partial class InsertItem : System.Web.UI.Page
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
            string sqlstr = "select * from Item_T";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds1);

            GridView1.DataSource = ds1;
            GridView1.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Book_T";

            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds2);

            GridView2.DataSource = ds2;
            GridView2.DataBind();

            DataSet ds3 = new DataSet();
            sqlstr = "select * from Souvenir_T";

            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds3);

            GridView3.DataSource = ds3;
            GridView3.DataBind();

            DataSet ds4 = new DataSet();
            sqlstr = "select * from Shops_Items_T";

            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds4);

            GridView4.DataSource = ds4;
            GridView4.DataBind();

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

            string sqlStrItem = "INSERT INTO Item_T (Barcode, ItemName, ItemDescription, Price, TaxPercentage, ISTaxNumber) VALUES(" 
                + TextBoxBar.Text + ", '" + TextBoxIName.Text + "', ";
            string sqlStrShopsItems = "INSERT INTO Shops_Items_T (ShopName, Barcode) VALUES('" + TextBoxShopName.Text + "', " + TextBoxBar.Text + ");";

            if (!string.IsNullOrEmpty(TextBoxIDes.Text))
            {
                sqlStrItem += "'" + TextBoxIDes.Text + "', ";
            }
            else
            {
                sqlStrItem += "NULL, ";
            }

            sqlStrItem += TextBoxPrice.Text + ", " + TextBoxTaxPer.Text + ", " + TextBoxTaxNum.Text + ");";

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand execItem = new SqlCommand(sqlStrItem, con);
            adapter1.InsertCommand = new SqlCommand(sqlStrItem, con);
            adapter1.InsertCommand.ExecuteNonQuery();
            execItem.Dispose();

            SqlDataAdapter adapter2 = new SqlDataAdapter();
            SqlCommand execShopsItems = new SqlCommand(sqlStrShopsItems, con);
            adapter2.InsertCommand = new SqlCommand(sqlStrShopsItems, con);
            adapter2.InsertCommand.ExecuteNonQuery();
            execShopsItems.Dispose();

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Item_T";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds1);

            GridView5.DataSource = ds1;
            GridView5.DataBind();

            DataSet ds4 = new DataSet();
            sqlstr = "select * from Shops_Items_T";

            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds4);

            GridView8.DataSource = ds4;
            GridView8.DataBind();

            con.Close();

        }

        // Book
        protected void Button2_Click(object sender, EventArgs e)
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

            string sqlStrItem = "INSERT INTO Item_T (Barcode, ItemName, ItemDescription, Price, TaxPercentage, ISTaxNumber) VALUES("
                + TextBoxBar.Text + ", '" + TextBoxIName.Text + "', ";
            string sqlStrBook = "INSERT INTO Book_T (BBarcode, Author, Genre) VALUES(" + TextBoxBar.Text + ", '" + TextBoxAut.Text + "', '" 
                + TextBoxGen.Text + "');";
            string sqlStrShopsItems = "INSERT INTO Shops_Items_T (ShopName, Barcode) VALUES('" + TextBoxShopName.Text + "', " + TextBoxBar.Text + ");";

            if (!string.IsNullOrEmpty(TextBoxIDes.Text))
            {
                sqlStrItem += "'" + TextBoxIDes.Text + "', ";
            }
            else
            {
                sqlStrItem += "NULL, ";
            }

            sqlStrItem += TextBoxPrice.Text + ", " + TextBoxTaxPer.Text + ", " + TextBoxTaxNum.Text + ");";

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand execItem = new SqlCommand(sqlStrItem, con);
            adapter1.InsertCommand = new SqlCommand(sqlStrItem, con);
            adapter1.InsertCommand.ExecuteNonQuery();
            execItem.Dispose();

            SqlDataAdapter adapter2 = new SqlDataAdapter();
            SqlCommand execShopsItems = new SqlCommand(sqlStrShopsItems, con);
            adapter2.InsertCommand = new SqlCommand(sqlStrShopsItems, con);
            adapter2.InsertCommand.ExecuteNonQuery();
            execShopsItems.Dispose();

            SqlDataAdapter adapter3 = new SqlDataAdapter();
            SqlCommand execBook = new SqlCommand(sqlStrBook, con);
            adapter3.InsertCommand = new SqlCommand(sqlStrBook, con);
            adapter3.InsertCommand.ExecuteNonQuery();
            execBook.Dispose();

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Item_T";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds1);

            GridView5.DataSource = ds1;
            GridView5.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Book_T";

            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds2);

            GridView6.DataSource = ds2;
            GridView6.DataBind();

            DataSet ds4 = new DataSet();
            sqlstr = "select * from Shops_Items_T";

            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds4);

            GridView8.DataSource = ds4;
            GridView8.DataBind();

            con.Close();

        }

        // Souvenir
        protected void Button3_Click(object sender, EventArgs e)
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

            string sqlStrItem = "INSERT INTO Item_T (Barcode, ItemName, ItemDescription, Price, TaxPercentage, ISTaxNumber) VALUES("
                + TextBoxBar.Text + ", '" + TextBoxIName.Text + "', ";
            string sqlStrSouvenir = "INSERT INTO Souvenir_T (SBarcode, Category) VALUES(" + TextBoxBar.Text + ", ";
            string sqlStrShopsItems = "INSERT INTO Shops_Items_T (ShopName, Barcode) VALUES('" + TextBoxShopName.Text + "', " + TextBoxBar.Text + ");";

            if (!string.IsNullOrEmpty(TextBoxIDes.Text))
            {
                sqlStrItem += "'" + TextBoxIDes.Text + "', ";
            }
            else
            {
                sqlStrItem += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxSouCat.Text))
            {
                sqlStrSouvenir += "'" + TextBoxSouCat.Text + "');";
            }
            else
            {
                sqlStrSouvenir += "NULL);";
            }


            sqlStrItem += TextBoxPrice.Text + ", " + TextBoxTaxPer.Text + ", " + TextBoxTaxNum.Text + ");";

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand execItem = new SqlCommand(sqlStrItem, con);
            adapter1.InsertCommand = new SqlCommand(sqlStrItem, con);
            adapter1.InsertCommand.ExecuteNonQuery();
            execItem.Dispose();

            SqlDataAdapter adapter2 = new SqlDataAdapter();
            SqlCommand execShopsItems = new SqlCommand(sqlStrShopsItems, con);
            adapter2.InsertCommand = new SqlCommand(sqlStrShopsItems, con);
            adapter2.InsertCommand.ExecuteNonQuery();
            execShopsItems.Dispose();

            SqlDataAdapter adapter3 = new SqlDataAdapter();
            SqlCommand execSouvenir = new SqlCommand(sqlStrSouvenir, con);
            adapter3.InsertCommand = new SqlCommand(sqlStrSouvenir, con);
            adapter3.InsertCommand.ExecuteNonQuery();
            execShopsItems.Dispose();

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Item_T";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds1);

            GridView5.DataSource = ds1;
            GridView5.DataBind();

            DataSet ds3 = new DataSet();
            sqlstr = "select * from Souvenir_T";

            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds3);

            GridView7.DataSource = ds3;
            GridView7.DataBind();

            DataSet ds4 = new DataSet();
            sqlstr = "select * from Shops_Items_T";

            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds4);

            GridView8.DataSource = ds4;
            GridView8.DataBind();

            con.Close();

        }
    }
}
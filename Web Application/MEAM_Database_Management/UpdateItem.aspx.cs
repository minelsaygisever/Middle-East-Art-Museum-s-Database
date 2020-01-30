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
    public partial class UpdateItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            itemBarcode.Visible = false;
            itemUpdate.Visible = false;
            newItem.Visible = false;
            souvenirUpdate.Visible = false;
            souvenirBarcode.Visible = false;
            newSouvenir.Visible = false;
            bookBarcode.Visible = false;
            bookUpdate.Visible = false;
            newBook.Visible = false;

        }
        protected void ButtonSouvenir_Click(object sender, EventArgs e)
        {
            choose.Visible = false;
            souvenirBarcode.Visible = true;
        }
        protected void ButtonBook_Click(object sender, EventArgs e)
        {
            choose.Visible = false;
            bookBarcode.Visible = true;
        }

        protected void ButtonItem_Click(object sender, EventArgs e)
        {
            choose.Visible = false;
            itemBarcode.Visible = true;
        }

        protected void ButtonItemBarcode_Click(object sender, EventArgs e)
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
            String str = "select * from Item_T where Barcode=" + TextBoxFirstItemBarcode.Text;
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds);
            textbarcode.Text = TextBoxFirstItemBarcode.Text;
            TextBoxItemName.Text = ds.Tables[0].Rows[0]["ItemName"].ToString();
            TextBoxItemDes.Text = ds.Tables[0].Rows[0]["ItemDescription"].ToString();
            TextBoxItemPrice.Text = ds.Tables[0].Rows[0]["Price"].ToString();
            TextBoxItemTaxPer.Text = ds.Tables[0].Rows[0]["TaxPercentage"].ToString();
            TextBoxItemSupTax.Text = ds.Tables[0].Rows[0]["ISTaxNumber"].ToString();
            itemBarcode.Visible = false;
            itemUpdate.Visible = true;
        }

        protected void ButtonUpdateItem_Click(object sender, EventArgs e)
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


            if (string.IsNullOrEmpty(TextBoxItemDes.Text))
            {
                TextBoxItemDes.Text = "NULL";
            }
            else
            {
                TextBoxItemDes.Text = "'" + TextBoxItemDes.Text + "'";
            }

            SqlCommand c1 = new SqlCommand("Update Item_T ItemName='" + TextBoxItemName.Text + "', ItemDescription=" + TextBoxItemDes.Text +
                ", Price=" + TextBoxItemPrice.Text + ", TaxPercentage=" + TextBoxItemTaxPer.Text +
                ", ISTaxNumber=" + TextBoxItemSupTax.Text + " where Barcode=" + TextBoxFirstItemBarcode.Text, con);
            c1.ExecuteNonQuery();

            DataSet ds = new DataSet();
            string sqlstr = "select * from Item_T where Barcode=" + TextBoxFirstItemBarcode.Text;

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            con.Close();

            itemUpdate.Visible = false;
            newItem.Visible = true;

        }

        protected void ButtonSouvenirBarcode_Click(object sender, EventArgs e)
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
            String str = "select * from Item_T where Barcode=" + TextBoxFirstSouvenirBarcode.Text;
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds);
            textsbarcode.Text = TextBoxFirstSouvenirBarcode.Text;
            TextBoxSouvenirName.Text = ds.Tables[0].Rows[0]["ItemName"].ToString();
            TextBoxSouvenirDes.Text = ds.Tables[0].Rows[0]["ItemDescription"].ToString();
            TextBoxSouvenirPrice.Text = ds.Tables[0].Rows[0]["Price"].ToString();
            TextBoxSouvenirTaxPer.Text = ds.Tables[0].Rows[0]["TaxPercentage"].ToString();
            TextBoxSouvenirSupTax.Text = ds.Tables[0].Rows[0]["ISTaxNumber"].ToString();

            DataSet ds2 = new DataSet();
            String str2 = "select * from Souvenir_T where SBarcode=" + TextBoxFirstSouvenirBarcode.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(str2, con);
            da2.Fill(ds2);
            TextBoxSouvenirCategory.Text = ds2.Tables[0].Rows[0]["Category"].ToString();

            souvenirBarcode.Visible = false;
            souvenirUpdate.Visible = true;
        }

        protected void ButtonUpdateSouvenir_Click(object sender, EventArgs e)
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


            if (string.IsNullOrEmpty(TextBoxSouvenirDes.Text))
            {
                TextBoxSouvenirDes.Text = "NULL";
            }
            else
            {
                TextBoxSouvenirDes.Text = "'" + TextBoxSouvenirDes.Text + "'";
            }
            if (string.IsNullOrEmpty(TextBoxSouvenirCategory.Text))
            {
                TextBoxSouvenirCategory.Text = "NULL";
            }
            else
            {
                TextBoxSouvenirCategory.Text = "'" + TextBoxSouvenirCategory.Text + "'";
            }


            SqlCommand c1 = new SqlCommand("Update Item_T ItemName='" + TextBoxSouvenirName.Text + "', ItemDescription=" + TextBoxSouvenirDes.Text +
                ", Price=" + TextBoxSouvenirPrice.Text + ", TaxPercentage=" + TextBoxSouvenirTaxPer.Text +
                ", ISTaxNumber=" + TextBoxSouvenirSupTax.Text + " where Barcode=" + TextBoxFirstSouvenirBarcode.Text, con);
            c1.ExecuteNonQuery();

            SqlCommand c4 = new SqlCommand("Update Souvenir_T set Category=" + TextBoxSouvenirCategory.Text + " where SBarcode=" + TextBoxFirstSouvenirBarcode.Text, con);
            c4.ExecuteNonQuery();

            DataSet ds = new DataSet();
            string sqlstr = "select * from Item_T where Barcode=" + TextBoxFirstSouvenirBarcode.Text;

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();

            DataSet ds1 = new DataSet();
            string sqlstr1 = "select * from Souvenir_T where SBarcode=" + TextBoxFirstSouvenirBarcode.Text;

            SqlDataAdapter da1 = new SqlDataAdapter(sqlstr1, con);
            da1.Fill(ds1);
            GridView3.DataSource = ds1;
            GridView3.DataBind();

            con.Close();

            souvenirUpdate.Visible = false;
            newSouvenir.Visible = true;
        }

        protected void ButtonBookBarcode_Click(object sender, EventArgs e)
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
            String str = "select * from Item_T where Barcode=" + TextBoxFirstBookBarcode.Text;
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds);
            textbbarcode.Text = TextBoxFirstBookBarcode.Text;
            TextBoxBookName.Text = ds.Tables[0].Rows[0]["ItemName"].ToString();
            TextBoxBookDes.Text = ds.Tables[0].Rows[0]["ItemDescription"].ToString();
            TextBoxBookPrice.Text = ds.Tables[0].Rows[0]["Price"].ToString();
            TextBoxBookTaxPer.Text = ds.Tables[0].Rows[0]["TaxPercentage"].ToString();
            TextBoxBookSupTax.Text = ds.Tables[0].Rows[0]["ISTaxNumber"].ToString();

            DataSet ds2 = new DataSet();
            String str2 = "select * from Book_T where BBarcode=" + TextBoxFirstBookBarcode.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(str2, con);
            da2.Fill(ds2);
            TextBoxBookAuthor.Text = ds2.Tables[0].Rows[0]["Author"].ToString();
            TextBoxBookGenre.Text = ds2.Tables[0].Rows[0]["Genre"].ToString();

            bookBarcode.Visible = false;
            bookUpdate.Visible = true;
        }
        protected void ButtonUpdateBook_Click(object sender, EventArgs e)
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


            if (string.IsNullOrEmpty(TextBoxBookDes.Text))
            {
                TextBoxBookDes.Text = "NULL";
            }
            else
            {
                TextBoxBookDes.Text = "'" + TextBoxBookDes.Text + "'";
            }
           


            SqlCommand c1 = new SqlCommand("Update Item_T set ItemName='" + TextBoxBookName.Text + "', ItemDescription=" + TextBoxBookDes.Text +
                ", Price=" + TextBoxBookPrice.Text + ", TaxPercentage=" + TextBoxBookTaxPer.Text +
                ", ISTaxNumber=" + TextBoxBookSupTax.Text + " where Barcode=" + TextBoxFirstBookBarcode.Text, con);
            c1.ExecuteNonQuery();


            SqlCommand c4 = new SqlCommand("Update Book_T set Author='" + TextBoxBookAuthor.Text + "', Genre='" + TextBoxBookGenre.Text + "' where BBarcode=" + TextBoxFirstBookBarcode.Text, con);
            c4.ExecuteNonQuery();

            DataSet ds = new DataSet();
            string sqlstr = "select * from Item_T where Barcode=" + TextBoxFirstBookBarcode.Text;

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);
            GridView4.DataSource = ds;
            GridView4.DataBind();

            DataSet ds1 = new DataSet();
            string sqlstr1 = "select * from Book_T where BBarcode=" + TextBoxFirstBookBarcode.Text;

            SqlDataAdapter da1 = new SqlDataAdapter(sqlstr1, con);
            da1.Fill(ds1);
            GridView5.DataSource = ds1;
            GridView5.DataBind();

            con.Close();

            bookUpdate.Visible = false;
            newBook.Visible = true;
        }
    }
}
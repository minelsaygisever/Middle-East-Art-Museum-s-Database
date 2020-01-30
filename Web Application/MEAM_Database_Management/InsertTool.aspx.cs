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
    public partial class InsertTool : System.Web.UI.Page
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
            string sqlstr = "select * from Piece_T";

            SqlDataAdapter da1 = new SqlDataAdapter(sqlstr, con);
            da1.Fill(ds1);

            GridView1.DataSource = ds1;
            GridView1.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Tools_T";

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

            string pNumber = TextBoxNumber.Text;
            string pName = TextBoxName.Text;
            string personalID = TextBoxPersonalID.Text;
            string pType = "T";
            string category = TextBoxCategory.Text;
            string materials = TextBoxMaterials.Text;

            string sqlStrPiece = "INSERT INTO Piece_T (PieceNumber, PieceName, PieceDescription, YearOfMade, EntryDay, EntryMonth, EntryYear, EntryHour, CountryOfOrigin, PersonalID, PieceType) VALUES("
                + pNumber + ", '" + pName + "', ";
            string sqlStrTools = "INSERT INTO Tools_T (TPieceNumber, Category, ToolsOwner) VALUES(" + pNumber + ", '" + category + "', ";
            string sqlStrToolsMaterials;

            if (!string.IsNullOrEmpty(TextBoxDecription.Text))
            {
                sqlStrPiece += "'" + TextBoxDecription.Text + "', ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxYoM.Text))
            {
                sqlStrPiece += TextBoxYoM.Text + ", ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxDay.Text))
            {
                sqlStrPiece += TextBoxDay.Text + ", ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxMonth.Text))
            {
                sqlStrPiece += TextBoxMonth.Text + ", ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxYear.Text))
            {
                sqlStrPiece += TextBoxYear.Text + ", ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxHour.Text))
            {
                sqlStrPiece += TextBoxHour.Text + ", ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxCoO.Text))
            {
                sqlStrPiece += "'" + TextBoxCoO.Text + "', ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxOwner.Text))
            {
                sqlStrTools += "'" + TextBoxOwner.Text + "');";

            }
            else
            {
                sqlStrTools += "NULL);";
            }

            sqlStrPiece += personalID + ", '" + pType + "');";

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand execPiece = new SqlCommand(sqlStrPiece, con);
            adapter1.InsertCommand = new SqlCommand(sqlStrPiece, con);
            adapter1.InsertCommand.ExecuteNonQuery();
            execPiece.Dispose();

            SqlDataAdapter adapter2 = new SqlDataAdapter();
            SqlCommand execTools = new SqlCommand(sqlStrTools, con);
            adapter2.InsertCommand = new SqlCommand(sqlStrTools, con);
            adapter2.InsertCommand.ExecuteNonQuery();
            execTools.Dispose();

            using (StringReader reader = new StringReader(materials))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    sqlStrToolsMaterials = "INSERT INTO Tools_Materials_T (TPieceNumber, Material) VALUES(" + pNumber + ", '" + line + "');";
                    SqlDataAdapter adapter3 = new SqlDataAdapter();
                    SqlCommand execTMat = new SqlCommand(sqlStrToolsMaterials, con);
                    adapter3.InsertCommand = new SqlCommand(sqlStrToolsMaterials, con);
                    adapter3.InsertCommand.ExecuteNonQuery();
                    execTMat.Dispose();
                }
            }

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Piece_T";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds1);

            GridView3.DataSource = ds1;
            GridView3.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Tools_T";
            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds2);

            GridView4.DataSource = ds2;
            GridView4.DataBind();

            DataSet ds3 = new DataSet();
            sqlstr = "select * from Tools_Materials_T";
            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds3);

            GridView5.DataSource = ds3;
            GridView5.DataBind();


        }
    }
}
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
    public partial class InsertSculpture : System.Web.UI.Page
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
            sqlstr = "select * from Sculpture_T";

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
            string pType = "S";
            string sculptor = TextBoxSculptor.Text;

            string sqlStrPiece = "INSERT INTO Piece_T (PieceNumber, PieceName, PieceDescription, YearOfMade, EntryDay, EntryMonth, EntryYear, EntryHour, CountryOfOrigin, PersonalID, PieceType) VALUES("
                + pNumber + ", '" + pName + "', ";
            string sqlStrSculpture = "INSERT INTO Sculpture_T (SPieceNumber, Sculptor, Width, Height, Depth, Material) VALUES(" + pNumber + ", '" + sculptor + "', ";

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

            if (!string.IsNullOrEmpty(TextBoxWidth.Text))
            {
                sqlStrSculpture += TextBoxWidth.Text + ", ";
            }
            else
            {
                sqlStrSculpture += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxHeight.Text))
            {
                sqlStrSculpture += TextBoxHeight.Text + ", ";
            }
            else
            {
                sqlStrSculpture += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxDepth.Text))
            {
                sqlStrSculpture += TextBoxDepth.Text + ", ";
            }
            else
            {
                sqlStrSculpture += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxMaterial.Text))
            {
                sqlStrSculpture += "'" + TextBoxMaterial.Text + "');";
            }
            else
            {
                sqlStrSculpture += "NULL);";
            }

            sqlStrPiece += personalID + ", '" + pType + "');";

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand execPiece = new SqlCommand(sqlStrPiece, con);
            adapter1.InsertCommand = new SqlCommand(sqlStrPiece, con);
            adapter1.InsertCommand.ExecuteNonQuery();
            execPiece.Dispose();

            SqlDataAdapter adapter2 = new SqlDataAdapter();
            SqlCommand execPainting = new SqlCommand(sqlStrSculpture, con);
            adapter2.InsertCommand = new SqlCommand(sqlStrSculpture, con);
            adapter2.InsertCommand.ExecuteNonQuery();
            execPainting.Dispose();

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Piece_T";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds1);

            GridView3.DataSource = ds1;
            GridView3.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Sculpture_T";
            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds2);

            GridView4.DataSource = ds2;
            GridView4.DataBind();

        }
    } 
}
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
    public partial class InsertPainting : System.Web.UI.Page
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
            sqlstr = "select * from Painting_T";

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
            string pType = "P";
            string painter = TextBoxPainter.Text;

            string pDescription = null;
            string pYoM = null;
            string eDay = null;
            string eMonth = null;
            string eYear = null;
            string eHour = null;
            string pCoO = null;
            string width = null;
            string height = null;
            string paintType = null;

            string sqlStrPiece = "INSERT INTO Piece_T (PieceNumber, PieceName, PieceDescription, YearOfMade, EntryDay, EntryMonth, EntryYear, EntryHour, CountryOfOrigin, PersonalID, PieceType) VALUES("
                + pNumber + ", '" + pName + "', ";
            string sqlStrPainting = "INSERT INTO Painting_T (PPieceNumber, Painter, Width, Height, PaintType) VALUES(" + pNumber + ", '" + painter + "', ";

            if (!string.IsNullOrEmpty(TextBoxDecription.Text))
            {
                pDescription = TextBoxDecription.Text;
                sqlStrPiece += "'" + pDescription + "', ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxYoM.Text))
            {
                pYoM = TextBoxYoM.Text;
                sqlStrPiece += pYoM + ", ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxDay.Text))
            {
                eDay = TextBoxDay.Text;
                sqlStrPiece += eDay + ", ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxMonth.Text))
            {
                eMonth = TextBoxMonth.Text;
                sqlStrPiece += eMonth + ", ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxYear.Text))
            {
                eYear = TextBoxYear.Text;
                sqlStrPiece += eYear + ", ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxHour.Text))
            {
                eHour = TextBoxHour.Text;
                sqlStrPiece += eHour + ", ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxCoO.Text))
            {
                pCoO = TextBoxCoO.Text;
                sqlStrPiece += "'" + pCoO + "', ";
            }
            else
            {
                sqlStrPiece += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxWidth.Text))
            {
                width = TextBoxWidth.Text;
                sqlStrPainting += width + ", ";
            }
            else
            {
                sqlStrPainting += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxHeight.Text))
            {
                height = TextBoxHeight.Text;
                sqlStrPainting += height + ", ";
            }
            else
            {
                sqlStrPainting += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxPaintType.Text))
            {
                paintType = TextBoxPaintType.Text;
                sqlStrPainting += "'" + paintType + "');";
            }
            else
            {
                sqlStrPainting += "NULL);";
            }

            sqlStrPiece += personalID + ", '" + pType + "');";

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand execPiece = new SqlCommand(sqlStrPiece, con);
            adapter1.InsertCommand = new SqlCommand(sqlStrPiece, con);
            adapter1.InsertCommand.ExecuteNonQuery();
            execPiece.Dispose();

            SqlDataAdapter adapter2 = new SqlDataAdapter();
            SqlCommand execPainting = new SqlCommand(sqlStrPainting, con);
            adapter2.InsertCommand = new SqlCommand(sqlStrPainting, con);
            adapter2.InsertCommand.ExecuteNonQuery();
            execPainting.Dispose();

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Piece_T";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds1);

            GridView3.DataSource = ds1;
            GridView3.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Painting_T";
            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds2);

            GridView4.DataSource = ds2;
            GridView4.DataBind();

        }
    }
}
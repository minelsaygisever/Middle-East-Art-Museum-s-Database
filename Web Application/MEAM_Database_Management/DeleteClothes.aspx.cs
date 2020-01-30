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
    public partial class DeleteClothes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Deleted ";
            Label2.Text = "New table  ";
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


            DataSet ds2 = new DataSet();
            string sqlstr2 = "select * from Clothes_T where CPieceNumber=" + TextBox1.Text;

            SqlDataAdapter da2 = new SqlDataAdapter(sqlstr2, con);
            da2.Fill(ds2);
            GridView1.DataSource = ds2;
            GridView1.DataBind();


            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "Delete from Clothes_Materials_T where CPieceNumber=" + TextBox1.Text;
            command = new SqlCommand(sql, con);

            adapter.DeleteCommand = new SqlCommand(sql, con);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();

            SqlCommand command1;
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            String sql1 = "Delete from Clothes_T where CPieceNumber=" + TextBox1.Text;

            command1 = new SqlCommand(sql1, con);

            adapter1.DeleteCommand = new SqlCommand(sql1, con);
            adapter1.DeleteCommand.ExecuteNonQuery();
            command1.Dispose();


            SqlCommand command2;
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            String sql2 = "Delete from Piece_T where PieceNumber=" + TextBox1.Text;

            command2 = new SqlCommand(sql2, con);

            adapter2.DeleteCommand = new SqlCommand(sql2, con);
            adapter2.DeleteCommand.ExecuteNonQuery();
            command2.Dispose();


            DataSet ds3 = new DataSet();
            string sqlstr3 = "select * from Piece_T";

            SqlDataAdapter da3 = new SqlDataAdapter(sqlstr3, con);

            da3.Fill(ds3);



            GridView2.DataSource = ds3;
            GridView2.DataBind();



            con.Close();

        }
    }
}
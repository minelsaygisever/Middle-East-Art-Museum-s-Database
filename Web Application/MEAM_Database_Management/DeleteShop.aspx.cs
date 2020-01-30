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
    public partial class DeleteShop : System.Web.UI.Page
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
            string sqlstr2 = "select * from Shop_T where ShopName='" + TextBox1.Text+ "'";

            SqlDataAdapter da2 = new SqlDataAdapter(sqlstr2, con);
            da2.Fill(ds2);
            GridView1.DataSource = ds2;
            GridView1.DataBind();


            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "Delete from Shop_Phone_Number_T where ShopName='" + TextBox1.Text + "'";
            command = new SqlCommand(sql, con);

            adapter.DeleteCommand = new SqlCommand(sql, con);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();

            SqlCommand command1;
            SqlDataAdapter adapter1 = new SqlDataAdapter();
            String sql1 = "Delete from Shops_Items_T where ShopName='" + TextBox1.Text + "'";

            command1 = new SqlCommand(sql1, con);

            adapter1.DeleteCommand = new SqlCommand(sql1, con);
            adapter1.DeleteCommand.ExecuteNonQuery();
            command1.Dispose();

            SqlCommand command2;
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            String sql2 = "Update Employee_T SET ShopName = NULL where ShopName='" + TextBox1.Text + "'";

            command2 = new SqlCommand(sql2, con);

            adapter2.UpdateCommand = new SqlCommand(sql2, con);
            adapter2.UpdateCommand.ExecuteNonQuery();
            command2.Dispose();


            SqlCommand command3;
            SqlDataAdapter adapter3 = new SqlDataAdapter();
            String sql3 = "Delete from Order_Line_T where ShopName='" + TextBox1.Text + "'";

            command3 = new SqlCommand(sql3, con);

            adapter3.DeleteCommand = new SqlCommand(sql3, con);
            adapter3.DeleteCommand.ExecuteNonQuery();
            command3.Dispose();


            SqlCommand command4;
            SqlDataAdapter adapter4 = new SqlDataAdapter();
            String sql4 = "Delete from Invoice_T where ShopName='" + TextBox1.Text + "'";

            command4 = new SqlCommand(sql4, con);

            adapter4.DeleteCommand = new SqlCommand(sql4, con);
            adapter4.DeleteCommand.ExecuteNonQuery();
            command4.Dispose();

            SqlCommand command5;
            SqlDataAdapter adapter5 = new SqlDataAdapter();
            String sql5 = "Delete from Employees_in_Shop_T where ShopName='" + TextBox1.Text + "'";

            command5 = new SqlCommand(sql5, con);

            adapter5.DeleteCommand = new SqlCommand(sql5, con);
            adapter5.DeleteCommand.ExecuteNonQuery();
            command5.Dispose();


            SqlCommand command6;
            SqlDataAdapter adapter6 = new SqlDataAdapter();
            String sql6 = "Delete from Receipt_T where ShopName='" + TextBox1.Text + "'";

            command6 = new SqlCommand(sql6, con);

            adapter6.UpdateCommand = new SqlCommand(sql6, con);
            adapter6.UpdateCommand.ExecuteNonQuery();
            command6.Dispose();



            SqlCommand command7;
            SqlDataAdapter adapter7 = new SqlDataAdapter();
            String sql7 = "Delete from Shop_T where ShopName='" + TextBox1.Text + "'";

            command7 = new SqlCommand(sql7, con);

            adapter7.DeleteCommand = new SqlCommand(sql7, con);
            adapter7.DeleteCommand.ExecuteNonQuery();
            command7.Dispose();


            DataSet ds7 = new DataSet();
            String sqlstr7 = "select * from Shop_T";

            SqlDataAdapter da7 = new SqlDataAdapter(sqlstr7, con);

            da7.Fill(ds7);



            GridView2.DataSource = ds7;
            GridView2.DataBind();



            con.Close();

        }
    }
}
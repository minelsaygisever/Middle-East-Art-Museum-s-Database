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
    public partial class UpdateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            vis.Visible = false;
            vis2.Visible = false;
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

            DataSet ds = new DataSet();
            String str = "select * from Employee_T where PersonalID=" + TextBoxPersonalID.Text;
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            da.Fill(ds);
            textid.Text = TextBoxPersonalID.Text;
            TextBoxName.Text = ds.Tables[0].Rows[0]["EmployeeName"].ToString();
            TextBoxTask.Text = ds.Tables[0].Rows[0]["Task"].ToString();
            TextBoxSalary.Text = ds.Tables[0].Rows[0]["Salary"].ToString();
            TextBoxAddress.Text = ds.Tables[0].Rows[0]["EmployeeAddress"].ToString();
            TextBoxEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
            TextBoxShop.Text = ds.Tables[0].Rows[0]["ShopName"].ToString();
            TextBoxManID.Text = ds.Tables[0].Rows[0]["ManagerID"].ToString();
            TextBoxBirth.Text = ds.Tables[0].Rows[0]["Birth"].ToString();

            DataSet ds1 = new DataSet();
            String str1 = "select * from Employees_Language_T where PersonalID=" + TextBoxPersonalID.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(str1, con);
            da1.Fill(ds1);



            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                TextBoxLangs.Text += ds1.Tables[0].Rows[i]["Languages"].ToString() + "\n";
            }


            DataSet ds2 = new DataSet();
            String str2 = "select * from Employee_Phone_Number_T where PersonalID=" + TextBoxPersonalID.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(str2, con);
            da2.Fill(ds2);

            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                TextBoxPhone.Text += ds2.Tables[0].Rows[i]["PhoneNumber"].ToString() + "\n";
            }

            vis.Visible = true;
            enterId.Visible = false;
        }
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




            if (string.IsNullOrEmpty(TextBoxAddress.Text))
            {
                TextBoxAddress.Text = "NULL";
            }
            else
            {
                TextBoxAddress.Text = "'" + TextBoxAddress.Text + "'";
            }

            if (string.IsNullOrEmpty(TextBoxEmail.Text))
            {
                TextBoxEmail.Text = "NULL";
            }
            else
            {
                TextBoxEmail.Text = "'" + TextBoxEmail.Text + "'";
            }


            if (string.IsNullOrEmpty(TextBoxBirth.Text))
            {
                TextBoxBirth.Text = "NULL";
                 
            }
            else
            {
                TextBoxBirth.Text = "'" + TextBoxBirth.Text + "'";
            }

            if (string.IsNullOrEmpty(TextBoxShop.Text))
            {
                TextBoxShop.Text = "NULL";
            }
            else
            {
                TextBoxShop.Text = "'" + TextBoxShop.Text + "'";
            }


            if (string.IsNullOrEmpty(TextBoxManID.Text))
            {
                TextBoxManID.Text = "NULL";
            }



            SqlCommand c1 = new SqlCommand("Update Employee_T set EmployeeName='" + TextBoxName.Text + "', Task='" + TextBoxTask.Text + 
                "', Salary=" + TextBoxSalary.Text + ", EmployeeAddress=" + TextBoxAddress.Text + 
                ", Email=" + TextBoxEmail.Text + ", ShopName=" + TextBoxShop.Text + 
                ", ManagerID=" + TextBoxManID.Text + ", Birth=" + TextBoxBirth.Text + " where PersonalID=" + TextBoxPersonalID.Text, con);
            c1.ExecuteNonQuery();

            SqlCommand c2 = new SqlCommand("Delete from Employee_Phone_Number_T Where PersonalID=" + TextBoxPersonalID.Text , con);
            c2.ExecuteNonQuery();

            using (StringReader reader = new StringReader(TextBoxPhone.Text)){
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    SqlCommand c3 = new SqlCommand("INSERT INTO Employee_Phone_Number_T (PersonalID, PhoneNumber) VALUES(" + TextBoxPersonalID.Text + ", '" + line + "')", con);
                    c3.ExecuteNonQuery();
                }
            }

            SqlCommand c4 = new SqlCommand("Delete from Employees_Language_T Where PersonalID=" + TextBoxPersonalID.Text + "", con);
            c4.ExecuteNonQuery();

            using (StringReader reader = new StringReader(TextBoxLangs.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    SqlCommand c5 = new SqlCommand("INSERT INTO Employees_Language_T (PersonalID, Languages) VALUES(" + TextBoxPersonalID.Text + ", '" + line + "')", con);
                    c5.ExecuteNonQuery();
                }
            }
            vis.Visible = false;

            DataSet ds = new DataSet();
            string sqlstr = "select * from Employee_T where PersonalID=" + TextBoxPersonalID.Text;

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataSet ds2 = new DataSet();
            string sqlstr2 = "select * from Employees_Language_T where PersonalID=" + TextBoxPersonalID.Text;

            SqlDataAdapter da2 = new SqlDataAdapter(sqlstr2, con);
            da2.Fill(ds2);
            GridView2.DataSource = ds2;
            GridView2.DataBind();

            DataSet ds3 = new DataSet();
            string sqlstr3 = "select * from Employee_Phone_Number_T where PersonalID=" + TextBoxPersonalID.Text;

            SqlDataAdapter da3 = new SqlDataAdapter(sqlstr3, con);
            da3.Fill(ds3);
            GridView3.DataSource = ds3;
            GridView3.DataBind();

            con.Close();
            vis2.Visible = true;
        }
    }
}
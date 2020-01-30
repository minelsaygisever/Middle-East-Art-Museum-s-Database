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
    public partial class InsertEmployee : System.Web.UI.Page
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


            DataSet ds = new DataSet();
            string sqlstr = "select * from Employee_T";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
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

            int empID = int.Parse(TextBoxID.Text);
            string empName = TextBoxName.Text;
            string empTask = TextBoxTask.Text;
            int empSalary = int.Parse(TextBoxSalary.Text);
            string empPhone = TextBoxPhone.Text;

            string empAddress = null;
            string empEmail = null;
            string empShop = null;
            Nullable<int> empManagerID = null;
            string empBirth = null;
            string empLangs = null;
            string[] empLangArr = new string[10];
            Nullable<int> day = null;
            Nullable<int> month = null;
            Nullable<int> year = null;
            int i;
            string sqlStrShopEmp = string.Empty;
            string sqlStrEmpLangs = string.Empty;
            string sqlStrPhoneNumbers = string.Empty;

            string sqlStrEmployee = "INSERT INTO Employee_T (PersonalID, EmployeeName, Task, Salary, EmployeeAddress, Email, Birth, ShopName, ManagerID) VALUES("
    + empID + ", '" + empName + "', '" + empTask + "', " + empSalary + ", ";

            if (!string.IsNullOrEmpty(TextBoxAddress.Text))
            {
                empAddress = TextBoxAddress.Text;
                sqlStrEmployee += "'" + empAddress + "', ";
            }
            else
            {
                sqlStrEmployee += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxEmail.Text))
            {
                empEmail = TextBoxEmail.Text;
                sqlStrEmployee += "'" + empEmail + "', ";
            }
            else
            {
                sqlStrEmployee += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxBirth.Text))
            {
                empBirth = TextBoxBirth.Text;
                sqlStrEmployee += "'" + empBirth + "', ";

            }
            else
            {
                sqlStrEmployee += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxShop.Text))
            {
                empShop = TextBoxShop.Text;
                sqlStrShopEmp = "INSERT INTO Employees_in_Shop_T (ShopName, PersonalID) VALUES('" + empShop + "', " + empID + ")";
                sqlStrEmployee += "'" + empShop + "', ";

            }
            else
            {
                sqlStrEmployee += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxManID.Text))
            {
                empManagerID = int.Parse(TextBoxManID.Text);
                sqlStrEmployee += empManagerID + ");";
            }
            else
            {
                sqlStrEmployee += "NULL);";
            }

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand execEmp = new SqlCommand(sqlStrEmployee, con);
            adapter1.InsertCommand = new SqlCommand(sqlStrEmployee, con);
            adapter1.InsertCommand.ExecuteNonQuery();
            execEmp.Dispose();

            using (StringReader reader = new StringReader(empPhone))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    sqlStrPhoneNumbers = "INSERT INTO Employee_Phone_Number_T (PersonalID, PhoneNumber) VALUES(" + empID + ", '" + line + "')";
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    SqlCommand execPhoneNumbers = new SqlCommand(sqlStrPhoneNumbers, con);
                    adapter2.InsertCommand = new SqlCommand(sqlStrPhoneNumbers, con);
                    adapter2.InsertCommand.ExecuteNonQuery();
                    execPhoneNumbers.Dispose();
                }
            }

            if (!string.IsNullOrEmpty(sqlStrShopEmp))
            {
                SqlCommand execShopEmp = new SqlCommand(sqlStrShopEmp, con);
                SqlDataAdapter adapter3 = new SqlDataAdapter();
                adapter3.InsertCommand = new SqlCommand(sqlStrShopEmp, con);
                adapter3.InsertCommand.ExecuteNonQuery();
                execShopEmp.Dispose();
            }

            if (!string.IsNullOrEmpty(TextBoxLangs.Text))
            {
                empLangs = TextBoxLangs.Text;

                using (StringReader reader = new StringReader(empLangs))
                {
                    string line;
                    i = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        empLangArr[i] = line;
                        i++;
                    }
                }
                foreach (string s in empLangArr)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        sqlStrEmpLangs = "INSERT INTO Employees_Language_T (PersonalID, Languages) VALUES(" + empID + ", '" + s + "')";
                        SqlCommand execEmpLangs = new SqlCommand(sqlStrEmpLangs, con);
                        SqlDataAdapter adapter4 = new SqlDataAdapter();
                        adapter4.InsertCommand = new SqlCommand(sqlStrEmpLangs, con);
                        adapter4.InsertCommand.ExecuteNonQuery();
                        execEmpLangs.Dispose();
                    }
                }
            }

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Employee_T";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds1);

            GridView2.DataSource = ds1;
            GridView2.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Employee_Phone_Number_T";
            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds2);

            GridView3.DataSource = ds2;
            GridView3.DataBind();

            DataSet ds3 = new DataSet();
            sqlstr = "select * from Employees_Language_T";
            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds3);

            GridView4.DataSource = ds3;
            GridView4.DataBind();

            DataSet ds4 = new DataSet();
            sqlstr = "select * from Employees_in_Shop_T";
            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds4);

            GridView5.DataSource = ds4;
            GridView5.DataBind();

            con.Close();

        }
    }
}
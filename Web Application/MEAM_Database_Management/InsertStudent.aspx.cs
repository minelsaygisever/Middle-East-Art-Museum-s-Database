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
    public partial class InsertStudent : System.Web.UI.Page
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
            string sqlstr = "select * from Visitor_T";

            SqlDataAdapter da1 = new SqlDataAdapter(sqlstr, con);
            da1.Fill(ds1);

            GridView1.DataSource = ds1;
            GridView1.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Citizen_T";

            SqlDataAdapter da2 = new SqlDataAdapter(sqlstr, con);
            da2.Fill(ds2);

            GridView2.DataSource = ds2;
            GridView2.DataBind();
            con.Close();

            DataSet ds3 = new DataSet();
            sqlstr = "select * from Student_T";

            SqlDataAdapter da3 = new SqlDataAdapter(sqlstr, con);
            da3.Fill(ds3);

            GridView3.DataSource = ds3;
            GridView3.DataBind();
            con.Close();

            DataSet ds4 = new DataSet();
            sqlstr = "select * from Ticket_T";

            da3 = new SqlDataAdapter(sqlstr, con);
            da3.Fill(ds4);

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

            string vNumber = TextBoxNumber.Text;
            string vName = TextBoxName.Text;

            string sqlStrVisitor = "INSERT INTO Visitor_T (VisitorNumber, VisitorName, Age, Gender, Email, PhoneNumber, VisitorType, PersonalID) VALUES("
                + vNumber + ", '" + vName + "', ";
            string sqlStrCitizen = "INSERT INTO Citizen_T (CVisitorNumber, IDNumber, CitizenType, Province) VALUES(" + vNumber + ", '" 
                + TextBoxCitID.Text + "', 'S', ";
            string sqlStrStudent = "INSERT INTO Student_T (SCVisitorNumber, SIDNumber,SchoolNumber, SchoolName, Department) VALUES("
                + vNumber + ", '" + TextBoxCitID.Text + "', ";
            string sqlStrTicket = "INSERT INTO Ticket_T (PersonalID, VisitorNumber, TicketNumber, VisitorName, Cost) VALUES(" + TextBoxIDesk.Text + ", "
                + vNumber + ", " + TextBoxTicketNum.Text + ", '" + vName + "', 30);";

            if (!string.IsNullOrEmpty(TextBoxAge.Text))
            {
                sqlStrVisitor += TextBoxAge.Text + ", ";
            }
            else
            {
                sqlStrVisitor += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxGender.Text))
            {
                sqlStrVisitor += "'" + TextBoxGender.Text + "', ";
            }
            else
            {
                sqlStrVisitor += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxEmail.Text))
            {
                sqlStrVisitor += "'" + TextBoxEmail.Text + "', ";
            }
            else
            {
                sqlStrVisitor += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxPhone.Text))
            {
                sqlStrVisitor += "'" + TextBoxPhone.Text + "', ";
            }
            else
            {
                sqlStrVisitor += "NULL, ";
            }

            sqlStrVisitor += "'T', ";

            if (!string.IsNullOrEmpty(TextBoxPerID.Text))
            {
                sqlStrVisitor += TextBoxPerID.Text + ");";
            }
            else
            {
                sqlStrVisitor += "NULL);";
            }

            if (!string.IsNullOrEmpty(TextBoxSNum.Text))
            {
                sqlStrStudent += TextBoxSNum.Text + ", ";
            }
            else
            {
                sqlStrStudent += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxSName.Text))
            {
                sqlStrStudent += "'" + TextBoxSName.Text + "', ";
            }
            else
            {
                sqlStrStudent += "NULL, ";
            }

            if (!string.IsNullOrEmpty(TextBoxDep.Text))
            {
                sqlStrStudent += "'" + TextBoxDep.Text + "');";
            }
            else
            {
                sqlStrStudent += "NULL);";
            }

            if (!string.IsNullOrEmpty(TextBoxCitProvince.Text))
            {
                sqlStrCitizen += "'" + TextBoxCitProvince.Text + "');";
            }
            else
            {
                sqlStrCitizen += "NULL);";
            }

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand execVisitor = new SqlCommand(sqlStrVisitor, con);
            adapter1.InsertCommand = new SqlCommand(sqlStrVisitor, con);
            adapter1.InsertCommand.ExecuteNonQuery();
            execVisitor.Dispose();

            SqlDataAdapter adapter2 = new SqlDataAdapter();
            SqlCommand execTourist = new SqlCommand(sqlStrCitizen, con);
            adapter2.InsertCommand = new SqlCommand(sqlStrCitizen, con);
            adapter2.InsertCommand.ExecuteNonQuery();
            execTourist.Dispose();

            SqlDataAdapter adapter3 = new SqlDataAdapter();
            SqlCommand execStudent = new SqlCommand(sqlStrStudent, con);
            adapter3.InsertCommand = new SqlCommand(sqlStrStudent, con);
            adapter3.InsertCommand.ExecuteNonQuery();
            execStudent.Dispose();

            SqlDataAdapter adapter4 = new SqlDataAdapter();
            SqlCommand execTicket = new SqlCommand(sqlStrTicket, con);
            adapter4.InsertCommand = new SqlCommand(sqlStrTicket, con);
            adapter4.InsertCommand.ExecuteNonQuery();
            execTicket.Dispose();

            DataSet ds1 = new DataSet();
            string sqlstr = "select * from Visitor_T";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds1);

            GridView5.DataSource = ds1;
            GridView5.DataBind();

            DataSet ds2 = new DataSet();
            sqlstr = "select * from Citizen_T";
            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds2);

            GridView6.DataSource = ds2;
            GridView6.DataBind();

            DataSet ds3 = new DataSet();
            sqlstr = "select * from Student_T";

            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds3);

            GridView7.DataSource = ds3;
            GridView7.DataBind();

            DataSet ds4 = new DataSet();
            sqlstr = "select * from Ticket_T";

            da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds4);

            GridView8.DataSource = ds4;
            GridView8.DataBind();
            con.Close();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Data.Common;
using System.Data.OleDb;
using System.Data;
using System.Text.RegularExpressions;

namespace OnlineExaminationSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["adm"].ConnectionString);
                conn.Open();
                string qry = "select * from Courses;";
                SqlCommand obj = new SqlCommand(qry, conn);
                courses.DataSource = obj.ExecuteReader();
                courses.DataBind();
            }
        }

        protected void courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["adm"].ConnectionString);
            conn.Open();
            string qry = "select SemName, CourseId from Semesters where CourseId='" +courses.SelectedValue+ "'";
            SqlCommand obj = new SqlCommand(qry, conn);
            semester.DataSource = obj.ExecuteReader();
            semester.DataBind();
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        protected void upload_Click(object sender, EventArgs e)
          {
            DataSet ds;
            bool c = true;
            bool v = true;
            DataTable Dt;
            Regex mob=new Regex(@"^[0-9]{10}$");
            Regex text=new Regex(@"^[a-zA-Z]+$");
            Regex enroll=new Regex(@"^[A-Z0-9]{8}$");
            Regex id=new Regex("[0-9]");
            if (FileUpload1.HasFile)

            {

                try

                {

                    string path = string.Concat(Server.MapPath("~/" + FileUpload1.FileName));

                    FileUpload1.SaveAs(path);


                    // Connection String to Excel Workbook

 string excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;";

        OleDbConnection connection = new OleDbConnection();

                    connection.ConnectionString = excelConnectionString;

                    OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", connection);

                    connection.Open();

                    // Create DbDataReader to Data Worksheet
                    OleDbDataAdapter objAdapter1 = new OleDbDataAdapter(command);

                    ds = new DataSet();

                    objAdapter1.Fill(ds);
                    Dt = ds.Tables[0];
                    if (Dt.Columns.Count != 10)
                        Label1.Text = "Invalid Number Of Columns In Specified Excel File.Expected Number Of Column is 10.";
                    else
                    {
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            if (id.IsMatch(Dt.Rows[i][0].ToString()))
                            {
                                if (text.IsMatch(Dt.Rows[i][1].ToString()))
                                {
                                    if (text.IsMatch(Dt.Rows[i][2].ToString()))
                                    {
                                        if (text.IsMatch(Dt.Rows[i][3].ToString()))
                                        {
                                            if (text.IsMatch(Dt.Rows[i][4].ToString()))
                                            {
                                                if (id.IsMatch(Dt.Rows[i][5].ToString()))
                                                {
                                                    if (enroll.IsMatch(Dt.Rows[i][6].ToString()))
                                                    {
                                                        if (mob.IsMatch(Dt.Rows[i][7].ToString()))
                                                        {
                                                            if (IsValidEmail(Dt.Rows[i][8].ToString()))
                                                            {
                                                                if (Dt.Rows[i][9].ToString().Length == 8)
                                                                    c = true;
                                                                else
                                                                {
                                                                    Label1.Text += "Password Should Be of Length 8 At row " + i;
                                                                    c = false;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Label1.Text += "Invalid Email Found At row " + i;
                                                                c = false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Label1.Text += "Mobile Number Column should contain only Numbers at Row" + i + "And Should Contain Only 10 Digits.";
                                                            c = false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Label1.Text += "Enrollment Column should contain only Uppercase Letter And Numbers at Row " + i + "And Should Contain Only 8 Letters.";
                                                        c = false;
                                                    }
                                                }
                                                else
                                                {
                                                    Label1.Text += "Semester Column should contain only Numbers at Row" + i;
                                                    c = false;
                                                }
                                            }
                                            else
                                            {
                                                Label1.Text += "Class Column should contain only Alphabtes at Row" + i;
                                                c = false;
                                            }
                                        }
                                        else
                                        {
                                            Label1.Text += "Mother Name Column should contain only Alphabtes at Row" + i;
                                            c = false;
                                        }
                                    }
                                    else
                                    {
                                        Label1.Text += " Father Name Column should contain only Alphabtes at Row" + i;
                                        c = false;
                                    }
                                }
                                else
                                {
                                    Label1.Text += "Name Column should contain only Alphabtes at Row" + i;
                                    c = false;
                                }

                            }
                            else
                            {
                                Label1.Text += "Id Column should contain only number at row" + i;
                                c = false;

                            }
                            v = v & c;

                        }
                    }
                    if (v)
                    {
                        DbDataReader dr = command.ExecuteReader();



                        // SQL Server Connection String

                        string sqlConnectionString = ConfigurationManager.ConnectionStrings["adm"].ConnectionString;




                        // Bulk Copy to SQL Server 

                        SqlBulkCopy bulkInsert = new SqlBulkCopy(sqlConnectionString);

                        bulkInsert.DestinationTableName = "Student";

                        bulkInsert.WriteToServer(dr);

                        Label1.Text = "Ho Gaya";

                    }
                }

                catch (Exception ex)

                {

                    Label1.Text+= ex.Message;

                }

            }

        }

    }




}


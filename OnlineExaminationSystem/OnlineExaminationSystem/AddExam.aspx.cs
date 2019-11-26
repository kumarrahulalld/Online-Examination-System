using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace OnlineExaminationSystem
{
    public partial class AddExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Upload(object sender, EventArgs e)
        {
           
        }

        protected void exam_Click(object sender, EventArgs e)
        {
            if (test_id.Text.Length != 5)
                error.Text = "Test Id Should be Of Length 5.";
            else if (totalques.Text.Length < 3 || int.Parse(totalques.Text) < 100)
                error.Text = "Total Questions Should Be Greater Or Equal To 100.";
            else if (int.Parse(correctmark.Text) < 1)
                error.Text = "Marks For Per Correct Answer Can't Be Less Than 1.";
            else if (int.Parse(wrongmark.Text) > int.Parse(correctmark.Text))
                error.Text = "Marks For Per Wrong Answer Can't Greater Than Marks For Correct Answer .";
            else if (int.Parse(totalmarks.Text) > (int.Parse(correctmark.Text) * int.Parse(totalques.Text)))
                error.Text = "Invalid Total Marks Assigned.";
            else
            {
                int d = DateTime.Compare(DateTime.Parse(date.Text), DateTime.Now.Date);
                if (d < 0)
                    error.Text = "Exam Can't Be Created For Past.";
                else if (course.SelectedIndex == 0)
                    error.Text = "Please Select A Course.";
                else if (semester.SelectedIndex == 0)
                    error.Text = "Please Select A Semester.";
                else if (int.Parse(td.Text) < (int.Parse(totalques.Text) * 36))
                    error.Text = "Atlest 36 Seconds Are Required For Each Question To Answer.";
                else if (int.Parse(pm.Text) > int.Parse(totalmarks.Text))
                    error.Text = "Passing Mark Can't Be Greater Than Maximum Marks.";
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");

                    try
                    {
                        con.Open();
                        SqlCommand co = new SqlCommand("CREATE TABLE [dbo].['" + test_id.Text + "']([Id] nvarchar(10) NOT NULL,[Question] NVARCHAR(200) NOT NULL,[Option1] NVARCHAR(200) NOT NULL,[Option2] NVARCHAR(200) NOT NULL,[Option3] NVARCHAR(200) NOT NULL,[Option4] NVARCHAR(200) NOT NULL,[CorrectOption] NVARCHAR(10) NOT NULL)", con);
                        co.ExecuteNonQuery();
                        string csvPath = Server.MapPath("~/") + Path.GetFileName(FileUpload1.PostedFile.FileName);
                        FileUpload1.SaveAs(csvPath);

                        DataTable dt = new DataTable();
                        dt.Columns.AddRange(new DataColumn[7] { new DataColumn("Id", typeof(string)),
            new DataColumn("Question", typeof(string)),
            new DataColumn("Option1",typeof(string)),new DataColumn("Option2",typeof(string)),new DataColumn("Option3",typeof(string)),new DataColumn("Option4",typeof(string)),new DataColumn("CorrectOption",typeof(string)), });


                        string csvData = File.ReadAllText(csvPath);
                        foreach (string row in csvData.Split('\n'))
                        {
                            if (!string.IsNullOrEmpty(row))
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (string cell in row.Split(','))
                                {
                                    dt.Rows[dt.Rows.Count - 1][i] = cell;
                                    i++;
                                }
                            }
                        }


                        SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con);

                        //Set the database table name.
                        sqlBulkCopy.DestinationTableName = "[dbo].['" + test_id.Text + "']";
                        //con.Open();
                        sqlBulkCopy.WriteToServer(dt);
                        co = new SqlCommand("insert into Test_Details values('" + test_id.Text + "','" + totalques.Text + "','" + totalmarks.Text + "','" + correctmark.Text + "','" + wrongmark.Text + "','" + course.SelectedValue + "','" + semester.SelectedIndex + "','" + 1 + "','" + date.Text + "','" + td.Text + "','" + pm.Text + "')", con);

                        co.ExecuteNonQuery();
                        error.Text = "Test Successfully Created.";

                    }
                    catch (Exception Ex)
                    {
                        error.Text = Ex.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            /*//Upload and save the file.
            
            */
        }
    }
}
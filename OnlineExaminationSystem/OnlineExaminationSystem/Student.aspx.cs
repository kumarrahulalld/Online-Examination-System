using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class Student : System.Web.UI.Page
    {
        string uname = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            uname = Session["uname"] as string;
            //Session["uname"] = uname;
        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (oldpass.Text.Length != 8)
                error.Text = "Old Password Should Of Length 8.";
            else if (newpass.Text.Length != 8)
                error.Text = "New Password Should Be Of Length 8.";
            else if (newcpass.Text.Length != 8)
                error.Text = "Confirm New Password Should Be Of Length 8.";
            else if (newpass.Text != newcpass.Text)
                error.Text = "New Password And Confirm New Password Should Be Same.";
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");
                try
                {
                    con.Open();
                    SqlCommand co = new SqlCommand("select pass from student where email='" + uname + "'", con);
                    if (co.ExecuteScalar().ToString() == oldpass.Text)
                    {
                        co = new SqlCommand("update student set pass='" + newpass.Text + "'where email='" + uname + "'", con);
                        if (co.ExecuteNonQuery() == 1)
                        {
                            error.Text = "Password Successfully Changed.";
                            newcpass.Text = "";
                            newpass.Text = "";
                            oldpass.Text = "";
                        }
                        else
                            error.Text = "Your Request Can't Be Processed Now.";
                    }
                    else
                        error.Text = "Please Check Your Password Again.";
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
        protected void Exam_Click(object sender, EventArgs e)
        {

            string str = "hello";
            //Response.Write(str);
            /*ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + str + "');", true);*/
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");
            try
            {
                //Response.Write(str);
                con.Open();
                SqlCommand co = new SqlCommand("select * from student where email='"+ uname + "'", con);
                
                SqlDataReader sr = co.ExecuteReader();
                sr.Read();
           
                Session["ourse"] = sr["Class"].ToString();
                Session["emester"] = sr["Semester"].ToString();
                Session["uname"] = uname;
                sr.Close();
                con.Close();
                Response.Write(str);
                Response.Redirect("~/Exams.aspx");
            }
            catch(Exception Ex)
            {
                error.Text = Ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        protected void resultt_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Results.aspx");
        }
    }
}
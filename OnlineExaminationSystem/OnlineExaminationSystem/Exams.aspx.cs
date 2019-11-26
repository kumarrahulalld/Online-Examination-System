using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class Exams : System.Web.UI.Page
    {
        string cour = "";
        string Sems = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");

            cour = Session["ourse"] as string;
            Sems = Session["emester"] as string;
            
            try
            {
                con.Open();
                SqlCommand co = new SqlCommand("select * from Test_Details where Course='" + cour + "' and Semester='"+ Sems + "' and Status=1", con);
               // reg.Text = co.ExecuteScalar().ToString();
                SqlDataReader sr = co.ExecuteReader();
                while (sr.Read())
                {
                    error.Text += sr["Test_Id"].ToString();
                    //if(sr.Read())

                    course.Items.Add(sr["Test_Id"].ToString());
                }
                sr.Close();
                error.Text = cour + Sems;
               
            }
            catch (Exception Ex)
            {
                reg.Text = Ex.Message + Ex.StackTrace;
            }
            finally
            {
                con.Close();
            }
        }

        protected void reg_Click(object sender, EventArgs e)
        {
            if(course.SelectedIndex==0)
            {
                error.Text = "Please Select Atleast An Exam To Start.";
            }
            else
            {
                Session["Test"] = course.SelectedItem.Text;
                Response.Redirect("~/Test.aspx");
            }
        }
    }
}
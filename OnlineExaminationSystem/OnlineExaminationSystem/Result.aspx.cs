using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");
            try
            {
                con.Open();
                string t = Session["Test"] as string;

                SqlCommand co = new SqlCommand("select * from Results where Test_Id='" + t.Trim() + "'and Name='"+Session["uname"]+"'and Submit_Time='"+Session["stamp"]+"'", con);
                SqlDataReader r = co.ExecuteReader();
                if (r.Read())
                {
                    tq.Text = (r["Total_Marks"].ToString());
                    aq.Text = (r["Attempted_Questions"].ToString());

                    lq.Text = (r["Left_Questions"].ToString());

                    cam.Text = (r["Correct_Questions"].ToString());

                    wam.Text = (r["Wrong_Questions"].ToString());

                    om.Text = (r["Marks_Obtained"].ToString());
                    ps.Text = Session["passmark"] as string;

                    if (int.Parse(Session["passmark"] as string) <= int.Parse(om.Text))
                        rs.Text = "Congratulations You Have Successfully Passed The Exam.";
                    else
                        rs.Text = "Sorry You Failed.Better Luck Next Time.";
                }
            }
            catch (Exception Ex)
            {
                tq.Text = Ex.Message + Ex.StackTrace;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
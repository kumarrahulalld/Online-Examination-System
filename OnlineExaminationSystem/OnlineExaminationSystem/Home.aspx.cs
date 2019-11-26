using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");
            try
            {
                con.Open();
                SqlCommand co = new SqlCommand("select count(*) from admin where username='" + username.Text + "' and password='"+password.Text+"'", con);
                if (co.ExecuteScalar().ToString() == "1")
                {
                    Response.Redirect("~/Admin.aspx");
                }
                else
                {
                     co = new SqlCommand("select count(*) from faculty where Email='" + username.Text + "' and Password='" + password.Text + "'", con);
                    if (co.ExecuteScalar().ToString() == "1")
                    {
                        Response.Redirect("~/Faculty_Data.aspx");
                    }
                    else
                    {
                         co = new SqlCommand("select count(*) from student where email='" + username.Text + "' and pass='" + password.Text + "'", con);
                        if (co.ExecuteScalar().ToString() == "1")
                        {
                            Session["uname"] = username.Text;
                            Response.Redirect("~/Student.aspx");
                        }
                        else
                        {
                            error.Text = "Invaild Details Please Check And Try Again.";
                        }
                    }
                }
             

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
}
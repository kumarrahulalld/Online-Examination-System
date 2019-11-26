using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class Add_Faculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            Regex text=new Regex("[a-zA-Z]");
            if (text.IsMatch(TextBox1.Text))
            {
                if (TextBox6.Text.Length != 8)
                    error.Text = "Password Should Be Of Atleast 8 Characters Long.";
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");
                    try
                    {
                        con.Open();
                        SqlCommand co = new SqlCommand("insert into faculty values('"+TextBox1.Text+"','"+sub.SelectedValue+"','"+classs.SelectedValue+"','"+sem.SelectedValue+"','"+TextBox5.Text+"','"+TextBox6.Text+"')", con);
                        co.ExecuteNonQuery();
                        error.Text = "Faculty Added Successfully.";
                        TextBox1.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        classs.SelectedIndex = 0;
                        sem.SelectedIndex = 0;
                        sub.SelectedIndex = 0;
                    }
                    catch(Exception Ex)
                    {
                        error.Text = Ex.Message;
                    }
                    finally
                    {
                        con.Close();
                    }
            }   }
            else
            {
                error.Text = "Only Alphabets Are Allowed In Name Field.";
            }
        }

        protected void classs_SelectedIndexChanged(object sender, EventArgs e)
        {
            sem.Visible = true;
        }

        protected void sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub.Visible = true;
        }
    }
}
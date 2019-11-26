using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class Remove_Faculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");
            try
            {
                con.Open();
                fac.Items.Clear();
                SqlCommand co = new SqlCommand("select * from faculty", con);
                SqlDataReader r = co.ExecuteReader();
                while (r.Read())
                {
                    fac.Items.Add(r["Name"].ToString());
                }
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

        protected void rem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");
            try
            {
                con.Open();
                SqlCommand co = new SqlCommand("delete from faculty where Name='"+fac.Text+"'", con);
                co.ExecuteNonQuery();
                error.Text = "Faculty Successfully Removed.";
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
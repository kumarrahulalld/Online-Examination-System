using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class Results : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");
            try
            {
                con.Open();
                string t = Session["uname"] as string;

                SqlDataAdapter Adp = new SqlDataAdapter("select * from Results where Name='"+t+"'", con);
                DataTable Dt = new DataTable();
                Adp.Fill(Dt);
                res.DataSource = Dt;
                res.DataBind();

            }
            catch (Exception Ex)
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}
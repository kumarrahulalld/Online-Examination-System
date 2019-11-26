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
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string c = Session["ch"] as string;
            string tb = "";
            if (c == "0")
                tb = "Test_Details";
            else if (c == "1")
                tb = "Results";
            else if (c == "2")
                tb = "student";
      
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");
            try
            {
                con.Open();
                string q = "select * from "+tb;
              
                SqlDataAdapter Adp = new SqlDataAdapter(q, con);
                
                DataTable Dt = new DataTable();
                Adp.Fill(Dt);
                res.DataSource = Dt;
                res.DataBind();

            }
            catch (Exception Ex)
            {
                error.Text += Ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
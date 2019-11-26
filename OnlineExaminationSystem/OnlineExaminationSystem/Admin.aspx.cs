using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace OnlineExaminationSystem
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["adm"].ConnectionString);
            conn.Open();
            string qry = "select username, password from admin where username ='" + username.Text + "' and password='" + password.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["AdminName"] = username.Text;
                Server.Transfer("Admin_Details.aspx");
            }
            else
                Response.Write("Error.......");
            conn.Close();
        }
    
    }
}
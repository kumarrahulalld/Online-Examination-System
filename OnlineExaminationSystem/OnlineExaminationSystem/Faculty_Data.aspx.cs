using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace OnlineExaminationSystem.img
{
    public partial class Faculty_Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
       
        }

        protected void remove_Click(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["ch"] = "0";
            Response.Redirect("~/Details.aspx");
        }

        protected void AddExam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddExam.aspx");
        }

        protected void AddStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddStudent.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["ch"] = "1";
            Response.Redirect("~/Details.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["ch"] = "2";
            Response.Redirect("~/Details.aspx");
        }
    }
}
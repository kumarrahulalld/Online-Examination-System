using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class Admin_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void AddStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddStudent.aspx");
        }

        protected void AddFaculty_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Add_Faculty.aspx");
        }

        protected void removefaculty_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Remove_Faculty.aspx");
        }

        protected void exam_Click(object sender, EventArgs e)
        {
            Session["ch"] = "0";
            Response.Redirect("~/Details.aspx");
        }

        protected void result_Click(object sender, EventArgs e)
        {
            Session["ch"] = "1";
            Response.Redirect("~/Details.aspx");
        }

        protected void student_Click(object sender, EventArgs e)
        {
            Session["ch"] = "2";
            Response.Redirect("~/Details.aspx");
        }

        protected void createexam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddExam.aspx");
        }
    }
}
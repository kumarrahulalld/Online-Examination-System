using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExaminationSystem
{
    public partial class Test : System.Web.UI.Page
    {
        static int Q=0,corr=0,wro=-1,acorr=0,awro=0,mx=0,lq=0;
        //int Q = 1;
        int TQ = 0;
        string Test_Id = "";
        static string Correct = "";
        
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Adr_Player\Desktop\project\ExamDB.mdf; Integrated Security = True; Connect Timeout = 30");
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                // Button2.Text = Session["Test"] as string;
                Timer1.Enabled = true;
                Timer1.Interval = 1000;
                Timer1.Tick += new EventHandler<EventArgs>(Timer1_Tick);
                Test_Id = Session["Test"] as string;
                try
                {
                    con.Open();
                    SqlCommand co = new SqlCommand("select * from Test_Details where Test_Id='" + Test_Id + "'", con);
                    SqlDataReader r = co.ExecuteReader();
                    if (r.Read())
                    {
                        TQ = int.Parse(r["Total_Questions"].ToString());
                        acorr = int.Parse(r["Correct_Mark"].ToString());
                        awro = int.Parse(r["Wrong_Mark"].ToString());
                        Label2.Text = (r["Duration"].ToString());
                        Session["passmark"] =(r["Passing_Mark"].ToString());
                        mx = int.Parse(r["Total_Marks"].ToString());
                        Previous.Visible = false;
                        Skip.Visible = false;
                        con.Close();
                    }
                }
                catch (Exception Ex)
                {

                    Button2.Text += Ex.Message + "load" + Ex.StackTrace;
                }
                finally
                {
                    con.Close();
                }

            }
        }
        void Timer1_Tick(object sender, EventArgs e)
        {
            int i = (Convert.ToInt16(Label1.Text));
            i = i - 1;
            Label1.Text = i.ToString();
            if (i < 0)
            {
                Timer1.Enabled = false;
                sub();
                Response.Redirect("~/Result.aspx");
            }
        }
        protected void Ques()
        {
           // Skip.Text = wro + "W" + corr + "C";
            Op1.Checked = false;
            Op2.Checked = false;
            Op3.Checked = false;
            Op4.Checked = false;
                string tstid = Test_Id.Trim();
                try
                {
                    con.Open();
                    string que = "Select * from ['" + Test_Id.Trim() + "'] where Id=" + Q;
                //Skip.Text = que;
                string a;
                    SqlCommand co = new SqlCommand(que, con);
                    SqlDataReader sr = co.ExecuteReader();
                    if ((sr.Read()))
                    {
                        //sr.Read();
                        ques.Text = "Question " + Q + ". " + sr[1].ToString();
                        Op1.Text = sr[2].ToString();
                        Op2.Text = sr[3].ToString();
                        Op3.Text = sr[4].ToString();
                        Op4.Text = sr[5].ToString();
                        Correct = (sr[6].ToString());
                    Correct = Correct[0].ToString();
                        sr.Close();
                        con.Close();
                        //Button2.Text += Correct.ToString();
                    }
                    else
                       error.Text= "Can't Fetch question";
                }
                catch (Exception Ex)
                {
                    Button2.Text += Ex.Message;
                }
                finally
                {
                    con.Close();
                }
            
        }
        protected void sub()
        {
            int mark = 0;
            mark = (corr * acorr) - (wro * awro);
            try
            {
                con.Open();
                Session["stamp"] = DateTime.Now.ToString();
                SqlCommand co = new SqlCommand("insert into Results values('"+Session["uname"]+"','"+Session["ourse"]+"','"+Session["emester"]+"','"+Test_Id.Trim()+"','"+mark+"','"+mx+"','"+(corr+wro)+"','"+(lq)+"','"+wro+"','"+corr+"','"+Session["stamp"] as string+"')",con);
                //error.Text += co.CommandText;
                co.ExecuteNonQuery();
                
                Response.Redirect("~/Result.aspx");
            }
            catch(Exception Ex)
            {
                error.Text += Ex.Message+Ex.StackTrace+"sub";
            }
            finally
            {
                con.Close();
            }
        }

        protected void Op1_CheckedChanged(object sender, EventArgs e)
        {
            Op1.Checked = true;
            Op2.Checked = false;
            Op3.Checked = false;
            Op4.Checked = false;
        }

        protected void Op2_CheckedChanged(object sender, EventArgs e)
        {
            Op1.Checked = false;
            Op2.Checked = true;
            Op3.Checked = false;
            Op4.Checked = false;
        }

        protected void Op3_CheckedChanged(object sender, EventArgs e)
        {
            Op1.Checked =false;
            Op2.Checked = false;
            Op3.Checked = true;
            Op4.Checked = false;
        }

        protected void Op4_CheckedChanged(object sender, EventArgs e)
        {
            Op1.Checked = false;
            Op2.Checked = false;
            Op3.Checked = false;
            Op4.Checked = true;
        }

        protected void Next_Click(object sender, EventArgs e)
        {
            if (Q < TQ)
            {
                if (Op1.Checked && Correct == "A" || Op2.Checked && Correct == "B" || Op3.Checked && Correct == "C" || Op4.Checked && Correct == "D")
                    corr++;
                else if (Op1.Checked == false && Op2.Checked == false && Op3.Checked == false && Op4.Checked == false)
                    lq++;
                else
                    wro++;
                Q++;

                Ques();
            }
            else
            { error.Text = "Total Question Limit Reached"; sub(); }
        }

        protected void Previous_Click(object sender, EventArgs e)
        {
            if (Q > 0)
            {
                if (Op1.Checked && Correct == "A" || Op2.Checked && Correct == "B" || Op3.Checked && Correct == "C" || Op4.Checked && Correct == "D")
                    corr++;
                else if (Op1.Checked == false && Op2.Checked == false && Op3.Checked == false && Op4.Checked == false)
                    lq++;
                else
                    wro++;

                Q--;
                Ques();
            }
            else
            {
                error.Text = "Minimum Question Limit Reached.";
            }
        }

        protected void Skip_Click(object sender, EventArgs e)
        {
            if (Q < TQ)
            {
                Q++;
                Ques();
            }
            else
            {
                error.Text = "Maximum Question Limit Reached.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Op1.Checked && Correct == "A"|| Op2.Checked && Correct == "B"|| Op3.Checked && Correct == "C"|| Op4.Checked && Correct == "D")
                corr++;
            else if (Op1.Checked == false && Op2.Checked == false && Op3.Checked == false && Op4.Checked == false)
                lq++;
            else
                wro++;
            sub();
        }
    }
}
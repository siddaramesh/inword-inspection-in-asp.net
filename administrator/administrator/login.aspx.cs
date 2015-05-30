using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace administrator
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection conn;
        SqlCommand cmd;
        
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginbutton_Click(object sender, EventArgs e)
        {
            string aa = txtUserName.Text.Trim();
            string bb = txtPassword.Text.Trim();
            int flag = 0;
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                cmd = new SqlCommand("SELECT username,pwd,admin1 from userinfo", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd.ExecuteReader();
                string[] usrnm = new string[50];
                string[] pwd1 = new string[50];
                string u, p;
                int i = 0;
                string ad = "";
                string[] admin = new string[50];
                while (dbr.Read())
                {
                    u = (string)dbr["username"];
                    usrnm[i] = u.Trim();
                    p = (string)dbr["pwd"];
                    pwd1[i] = p.Trim();
                    ad = (string)dbr["admin1"];
                    admin[i] = ad.Trim();
                    i = i + 1;
                }
                conn.Close();
                int j = 0;
                while (usrnm[j] != null)
                {
                    if (aa == usrnm[j] && bb == pwd1[j] && admin[j]=="True")
                    {
                        
                        flag = 1;
                        break; 
                    }
                    else if (aa == usrnm[j] && bb == pwd1[j] && admin[j]!="True")
                    {
                       
                       flag = 2;
                        break; 
                    }
                    j = j + 1;
                }
                if (flag == 1)
                {
                   
                    SqlCommand cmd2 = new SqlCommand("UPDATE userinfo set signin='true' where username='" + aa.Trim() + "'and pwd='" + bb.Trim() + "';", conn);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    
                    Response.Redirect("~/Default.aspx");
                }
                else if (flag == 2)
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE userinfo set signin='true' where username='" + aa.Trim() + "'and pwd='" + bb.Trim() + "';", conn);
                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();

                    Response.Redirect("~/powerA.aspx");
                }
                else
                {
                    Label1.Text = "login failure";
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}
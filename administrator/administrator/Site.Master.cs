using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace administrator
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd,cmd1;
       
        DataSet ds = new DataSet();
        string[] nm = new string[50];
        string u1,sign,s;
        int i1 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            cmd1 = new SqlCommand("SELECT name,signin from userinfo where signin='true'", conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = cmd1.ExecuteReader();
            
            while (dbr.Read())
            {
                u1 = (string)dbr["name"];
                nm[i1] = u1.Trim();
                sign = (string)dbr["signin"];
                s = sign.Trim();
                i1 = i1 + 1;
            }
            conn.Close();
            if (s == null)
            {
                Response.Redirect("~/login.aspx");
            }
            else
            {
                Label1.Text = u1;
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("SELECT username,pwd from userinfo where signin='true'", conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = cmd.ExecuteReader();
            string[] usrnm = new string[50];
            string[] pwd1 = new string[50];
            string u, p;
            int i = 0;
            while (dbr.Read())
            {
                u = (string)dbr["username"];
                usrnm[i] = u.Trim();
                
                p = (string)dbr["pwd"];
                pwd1[i] = p.Trim();
                i = i + 1;
            }
            conn.Close();
            SqlCommand cmd2 = new SqlCommand("UPDATE userinfo set signin='false' where username='" +u1.Trim() + "';", conn);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            Session.Abandon();
            Session.Remove("username");
            Session.Remove("pwd");
            Response.Redirect("~/login.aspx");

        }



    }
}

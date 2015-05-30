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
    public partial class ms_store : System.Web.UI.Page
    {
        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindnum();
            }
        }
        protected void bindnum()
        {
            string id = "";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT MAX(num) as id from store_master",conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                id = Convert.ToString(dbr["id"]);
                if (id == "")
                {
                    id = "0";
                }
            }
            conn.Close();
            short num = Convert.ToInt16(id);
            TextBox1.Text = Convert.ToString(num + 1);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            short num=Convert.ToInt16(TextBox1.Text);
            try
            {
                SqlCommand sqlcmd = new SqlCommand("INSERT into store_master values('" + num + "','" + TextBox2.Text + "')", conn1);
                conn1.Open();
                sqlcmd.ExecuteNonQuery();
                conn1.Close();

                string message = "Insert successfully";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                TextBox1.Text = "";
                TextBox2.Text = "";
                bindnum();
            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
            }
        }
    }
}
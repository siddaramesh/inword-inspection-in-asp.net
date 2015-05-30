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

    public partial class ProductionProcess : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                productionedit();

            }
        }

        protected void productionedit()
        {
            if (Session["processname"] != null && Session["finished"] != null)
            {
                CheckBox1.Checked = Convert.ToBoolean(Session["finished"]);
                TextBox1.Text = Session["processname"].ToString();
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd;
            try
            {
                if (TextBox1.Text == "" || TextBox1.Text == null)
                {
                    string message = "Process Name Should Not be Blank";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                }

                else
                {
                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);

                    cmd = new SqlCommand("INSERT INTO production_process values('" + TextBox1.Text + "','" + CheckBox1.Checked + "')", conn1);
                    conn1.Open();
                    cmd.ExecuteNonQuery();
                    conn1.Close();

                    string message = "Inserted Successfully";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

                    TextBox1.Text = "";
                    CheckBox1.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Label2.Text = ex.Message;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string processname = "";
            int flag = 0;
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("SELECT process_name from production_process", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {
                processname = Convert.ToString(dbr["process_name"]);
                if (processname == TextBox1.Text)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                string message = "Doublicate values are not allowed please enter different name";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

                TextBox1.Text = "";
            }
        }
    }
}
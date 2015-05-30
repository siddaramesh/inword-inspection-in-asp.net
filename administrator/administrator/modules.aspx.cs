using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;

using Excel = Microsoft.Office.Interop.Excel;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
using System.Data.OleDb;
using System.Data.Common;
using System.IO;
namespace administrator
{
    public partial class modules : System.Web.UI.Page
    {
        
        SqlCommand cmd, cmd1;
        string no;
        int no1, num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            try
            {
                cmd1 = new SqlCommand("SELECT id,modulename from modules order by id asc", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    no = Convert.ToString(dbr["id"]);
                    no1 = Convert.ToInt32(no);
                    num = no1;
                }
                conn1.Close();
                no1 = num + 1;
                Label2.Text = Convert.ToString(no1);
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }

            if (!IsPostBack)
            {
                binddropdownlist();
           
            }
        }
        protected void binddropdownlist()
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            try
            {
                using (conn1)
                {
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT distinct id,modulename from modules order by modulename asc";
                        sqlcmd.Connection = conn1;
                        conn1.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "id";
                        DropDownList1.DataTextField = "modulename";
                        DropDownList1.DataBind();
                        conn1.Close();

                        DropDownList1.Items.Insert(0, new ListItem("please select", "0"));
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                cmd = new SqlCommand("INSERT into modules(id,modulename)values('" + no1 + "','" + TextBox1.Text + "')", conn1);
                conn1.Open();
                cmd.ExecuteNonQuery();
                conn1.Close();
                Response.Redirect("~/modules.aspx", false);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string id = "", name = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            try
            {
                cmd1 = new SqlCommand("SELECT id,modulename from modules where modulename='" + DropDownList1.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    id = Convert.ToString(dbr["id"]);
                    name = Convert.ToString(dbr["modulename"]);
                }
                conn1.Close();
                Label2.Text = id;
                TextBox1.Text = name;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            }
        }
    }
}
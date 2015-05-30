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
using System.Threading;
namespace administrator
{
    public partial class unitofmeasure : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1,cmd2,cmd3;
        string no;
        int no1, num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                cmd1 = new SqlCommand("SELECT num,unit from unitofmeasure order by num asc", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    no = Convert.ToString(dbr["num"]);
                    no1 = Convert.ToInt32(no);
                    num = no1;
                }
                conn.Close();
                no1 = num + 1;
                Label4.Text = Convert.ToString(no1);
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
            if (!IsPostBack)
            {
                binddropdownlist();
                unitedit();
             
            }
        }
        protected void binddropdownlist()
        {
            try
            {
                using (conn)
                {
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT distinct num,unit from unitofmeasure order by num asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "num";
                        DropDownList1.DataTextField = "unit";
                        DropDownList1.DataBind();
                        conn.Close();

                        DropDownList1.Items.Insert(0, new ListItem("", "0"));
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
        protected void unitedit()
        {
            if (Session["unit"] != null && Session["description"] != null)
            {
                Label4.Text = Session["no"].ToString();
                TextBox1.Text = Session["unit"].ToString();
                TextBox2.Text = Session["description"].ToString();
                TextBox1.ReadOnly = true;
            }
            else
            {
                TextBox1.ReadOnly = false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT into unitofmeasure(num,unit,description)values('" + no1 + "','" + TextBox1.Text + "','" + TextBox2.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                string message = "Insert Successfully.";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                //Thread.Sleep(100);
                TextBox1.Text = "";
                TextBox2.Text = "";
                //Response.Redirect("~/unitofmeasure.aspx", false);
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd2 = new SqlCommand("UPDATE unitofmeasure set unit='" + TextBox1.Text + "',description='" + TextBox2.Text + "' where unit='" + TextBox1.Text + "'", conn);
                conn.Open();
                cmd3.ExecuteNonQuery();
                conn.Close();
                string message = "UPDATE Successfully.";
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
               // Response.Redirect("manufacture.aspx", false);
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
            string des = "", unit = "";
            try
            {

                SqlCommand cmd3 = new SqlCommand("SELECT num,unit,description from unitofmeasure where unit='" + DropDownList1.SelectedItem.Text.Trim() + "'", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd3.ExecuteReader();
                while (dbr.Read())
                {
                    no = Convert.ToString(dbr["num"]);
                    no1 = Convert.ToInt32(no);
                    num = no1;


                    unit = (string)dbr["unit"];
                    des = (string)dbr["description"];
                    

                }
                conn.Close();
                no1 = num;
                Label4.Text = Convert.ToString(no1);
                TextBox1.Text = unit;
                TextBox2.Text = des;

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
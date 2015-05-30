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
    public partial class poinput : System.Web.UI.Page
    {
        SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1;
        string no;
        int no1, num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                cmd1 = new SqlCommand("SELECT num,suppliername,partno,qty from poinput order by num", conn);
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
                Label5.Text = ex.Message;
            }
           
            if (!IsPostBack)
            {
                binddropdownlist();
                poedit();
               
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
                        sqlcmd.CommandText = "SELECT num,partno,description from partno order by partno asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList3.DataSource = dt;
                        DropDownList3.DataValueField = "num";
                        DropDownList3.DataTextField = "partno";
                        DropDownList3.DataBind();
                        conn.Close();

                        DropDownList3.Items.Insert(0, new ListItem("", "0"));
                    }
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT num,suppliername from supplier order by num asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList2.DataSource = dt;
                        DropDownList2.DataValueField = "num";
                        DropDownList2.DataTextField = "suppliername";
                        DropDownList2.DataBind();
                        conn.Close();

                        DropDownList2.Items.Insert(0, new ListItem("", "0"));
                    }
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT num,partno from poinput order by num asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist1
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "num";
                        DropDownList1.DataTextField = "partno";
                        DropDownList1.DataBind();
                        conn.Close();

                        DropDownList1.Items.Insert(0, new ListItem("", "0"));
                    }
                }
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }

        protected void poedit()
        {
            if (Session["partno"] != null && Session["suppliername"] != null)
            {
                Label4.Text = Session["num"].ToString();
                DropDownList2.SelectedItem.Text = Session["suppliername"].ToString();
                DropDownList3.SelectedItem.Text = Session["partno"].ToString();
                TextBox2.Text = Session["qty"].ToString();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("INSERT into poinput(num,suppliername,partno,qty)values('" + no1 + "','" + DropDownList2.SelectedItem.Text + "','" + DropDownList3.SelectedItem.Text + "','" + TextBox2.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                string message = "INSERT Successfully\n num='"+no1+"'\n suppliername='"+DropDownList2.SelectedItem.Text+"'\n PartNum='"+DropDownList3.SelectedItem.Text+"'\n Qty='"+TextBox2.Text+"'";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
       
                 Response.Redirect("~/poinput.aspx",false);
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
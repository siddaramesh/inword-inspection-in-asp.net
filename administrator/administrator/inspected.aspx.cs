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
    public partial class inspected : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1;
        string no;
        int no1, num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                cmd1 = new SqlCommand("SELECT num,name from inspectedby", conn);
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
                        sqlcmd.CommandText = "SELECT num,name from inspectedby order by name asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "num";
                        DropDownList1.DataTextField = "name";
                        DropDownList1.DataBind();
                        conn.Close();

                        DropDownList1.Items.Insert(0, new ListItem("please select", "0"));
                    }
                }
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text == "")
                {
                    Label2.Text = "* Name is Required";
                }
                else
                {
                    cmd = new SqlCommand("INSERT into inspectedby(num,name)values('" + no1 + "','" + TextBox1.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Label5.Text = "Inserted";
                    TextBox1.Text = "";
                    Response.Redirect("~/inspected.aspx");
                }
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
            
        }

       
        protected void Button2_Click1(object sender, EventArgs e)
        {
            string name, nm = "";
            try
            {

                SqlCommand cmd3 = new SqlCommand("SELECT num,name from inspectedby where name='" + DropDownList1.SelectedItem.Text.Trim() + "'", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd3.ExecuteReader();
                while (dbr.Read())
                {
                    no = Convert.ToString(dbr["num"]);
                    no1 = Convert.ToInt32(no);
                    num = no1;
                    name = (string)dbr["name"];
                    nm = name;

                }
                conn.Close();
                no1 = num;
                Label4.Text = Convert.ToString(no1);
                TextBox1.Text = nm;
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }
    }
}
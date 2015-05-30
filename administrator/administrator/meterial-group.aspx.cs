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
    public partial class meterial_group : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
       
        protected void Page_Load(object sender, EventArgs e)
        {
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
                        sqlcmd.CommandText = "SELECT group_name from material_group order by group_name asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "group_name";
                        DropDownList1.DataTextField = "group_name";
                        DropDownList1.DataBind();
                        conn.Close();

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
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd;
            try
            {
                if (TextBox1.Text == "" || TextBox1.Text == null)
                {
                    string message = "Group Name Should Not be Blank";
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

                    cmd = new SqlCommand("INSERT INTO material_group values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DropDownList1.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", conn1);
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
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    DropDownList1.SelectedItem.Text = "";
                    DropDownList2.SelectedItem.Text = "";
                }
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string groupname = "";
            int flag = 0;
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("SELECT group_name from material_group", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {
                groupname = Convert.ToString(dbr["group_name"]);
                if (groupname == TextBox1.Text)
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
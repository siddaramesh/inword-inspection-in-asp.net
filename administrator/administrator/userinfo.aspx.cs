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
    public partial class userinfo : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1;
       
      
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
                        sqlcmd.CommandText = "SELECT username from userinfo order by username asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "username";
                        DropDownList1.DataTextField = "username";
                        DropDownList1.DataBind();
                        conn.Close();

                        DropDownList1.Items.Insert(0, new ListItem("please select", "0"));
                    }
                }
            }
            catch (Exception ex)
            {
                Label6.Text = ex.Message;
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                CheckBox2.Checked = true;
                CheckBox3.Checked = true;
                CheckBox4.Checked = true;
                CheckBox5.Checked = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text == "")
                {
                    Label7.Text = "Name field is Required";
                }
                else if (TextBox2.Text == "")
                {
                    Label8.Text = "Username is Required";
                }
                else if (TextBox3.Text == "")
                {
                    Label9.Text = "Password is Required";
                }
                else
                {
                    cmd = new SqlCommand("INSERT into userinfo(name,username,pwd,admin1,read1,write,delete1,view1,inspected,approved)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + CheckBox1.Checked + "','" + CheckBox2.Checked + "','" + CheckBox3.Checked + "','" + CheckBox4.Checked + "','" + CheckBox5.Checked +"','"+CheckBox6.Checked+"','"+CheckBox7.Checked+ "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Label6.Text = "Inserted";

                    Response.Redirect("~/userinfo.aspx",false);

                }
            }
            catch (Exception ex)
            {
                Label6.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd1 = new SqlCommand("UPDATE userinfo set name='" + TextBox1.Text + "',username='" + TextBox2.Text + "',pwd='" + TextBox3.Text + "',admin1='" + CheckBox1.Checked + "',read1='" + CheckBox2.Checked + "',write='" + CheckBox3.Checked + "',delete1='" + CheckBox4.Checked + "',view1='" + CheckBox5.Checked +"',inspected='"+CheckBox6.Checked+"',approved='"+CheckBox7.Checked+ "' where username='" + TextBox2.Text + "';", conn);
                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("~/userinfo.aspx",false);
            }
            catch (Exception ex)
            {
                Label6.Text = ex.Message;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string name="", usrname="", pass="", read="", write="", delete="", admin="", view="",inspected="",approved="";
            bool adm = false, add = false, modify = false, del = false, vw = false,inspec=false,approve=false;
            try
            {

                SqlCommand cmd3 = new SqlCommand("SELECT name,username,pwd,signin,read1,write,delete1,admin1,view1,inspected,approved from userinfo where username='" + DropDownList1.SelectedItem.Text.Trim() + "'", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd3.ExecuteReader();
                while (dbr.Read())
                {
                    name =(string)dbr["name"];
                    usrname = (string)dbr["username"];
                    pass = (string)dbr["pwd"];
                    read = (string)dbr["read1"];
                    write = (string)dbr["write"];
                    delete = (string)dbr["delete1"];
                    admin = (string)dbr["admin1"];
                    view = (string)dbr["view1"];
                    inspected = (string)dbr["inspected"];
                    approved = (string)dbr["approved"];
                }
                conn.Close();
                adm = Convert.ToBoolean(admin);
                add = Convert.ToBoolean(read);
                modify = Convert.ToBoolean(write);
                del = Convert.ToBoolean(delete);
                vw = Convert.ToBoolean(view);
                inspec = Convert.ToBoolean(inspected);
                approve = Convert.ToBoolean(approved);
                TextBox1.Text = name;
                TextBox2.Text = usrname;
                TextBox3.Text = pass;
                CheckBox1.Checked = adm;
                CheckBox2.Checked = add;
                CheckBox3.Checked = modify;
                CheckBox4.Checked = del;
                CheckBox5.Checked = vw;
                CheckBox6.Checked = inspec;
                CheckBox7.Checked = approve;
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }
    }
}
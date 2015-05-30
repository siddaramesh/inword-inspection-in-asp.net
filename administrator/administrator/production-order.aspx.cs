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

namespace administrator
{
    public partial class production_order : System.Web.UI.Page
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
                        sqlcmd.CommandText = "SELECT num,partno,description from partno where inactive='False' order by partno asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //ddlpartno1
                        ddlpartno1.DataSource = dt;
                        ddlpartno1.DataValueField = "partno";
                        ddlpartno1.DataTextField = "partno";
                        ddlpartno1.DataBind();
                        //ddlpartno2
                        ddlpartno2.DataSource = dt;
                        ddlpartno2.DataValueField = "partno";
                        ddlpartno2.DataTextField = "partno";
                        ddlpartno2.DataBind();
                        //ddlpartno3
                        ddlpartno3.DataSource = dt;
                        ddlpartno3.DataValueField = "partno";
                        ddlpartno3.DataTextField = "partno";
                        ddlpartno3.DataBind();
                        //ddlpartno4
                        ddlpartno4.DataSource = dt;
                        ddlpartno4.DataValueField = "partno";
                        ddlpartno4.DataTextField = "partno";
                        ddlpartno4.DataBind();
                        //ddlpartno5
                        ddlpartno5.DataSource = dt;
                        ddlpartno5.DataValueField = "partno";
                        ddlpartno5.DataTextField = "partno";
                        ddlpartno5.DataBind();
                        //ddlpartno6
                        ddlpartno6.DataSource = dt;
                        ddlpartno6.DataValueField = "partno";
                        ddlpartno6.DataTextField = "partno";
                        ddlpartno6.DataBind();
                        //ddlpartno7
                        ddlpartno7.DataSource = dt;
                        ddlpartno7.DataValueField = "partno";
                        ddlpartno7.DataTextField = "partno";
                        ddlpartno7.DataBind();
                        //ddlpartno8
                        ddlpartno8.DataSource = dt;
                        ddlpartno8.DataValueField = "partno";
                        ddlpartno8.DataTextField = "partno";
                        ddlpartno8.DataBind();
                        //ddlpartno9
                        ddlpartno9.DataSource = dt;
                        ddlpartno9.DataValueField = "partno";
                        ddlpartno9.DataTextField = "partno";
                        ddlpartno9.DataBind();
                        //ddlpartno10
                        ddlpartno10.DataSource = dt;
                        ddlpartno10.DataValueField = "partno";
                        ddlpartno10.DataTextField = "partno";
                        ddlpartno10.DataBind();
                        //ddlpartno11
                        ddlpartno11.DataSource = dt;
                        ddlpartno11.DataValueField = "partno";
                        ddlpartno11.DataTextField = "partno";
                        ddlpartno11.DataBind();
                        //ddlpartno12
                        ddlpartno12.DataSource = dt;
                        ddlpartno12.DataValueField = "partno";
                        ddlpartno12.DataTextField = "partno";
                        ddlpartno12.DataBind();
                        //ddlpartno13
                        ddlpartno13.DataSource = dt;
                        ddlpartno13.DataValueField = "partno";
                        ddlpartno13.DataTextField = "partno";
                        ddlpartno13.DataBind();
                        //ddlpartno14
                        ddlpartno14.DataSource = dt;
                        ddlpartno14.DataValueField = "partno";
                        ddlpartno14.DataTextField = "partno";
                        ddlpartno14.DataBind();
                        //ddlpartno15
                        ddlpartno15.DataSource = dt;
                        ddlpartno15.DataValueField = "partno";
                        ddlpartno15.DataTextField = "partno";
                        ddlpartno15.DataBind();
                        //ddlpartno16
                        ddlpartno16.DataSource = dt;
                        ddlpartno16.DataValueField = "partno";
                        ddlpartno16.DataTextField = "partno";
                        ddlpartno16.DataBind();
                        //ddlpartno17
                        ddlpartno17.DataSource = dt;
                        ddlpartno17.DataValueField = "partno";
                        ddlpartno17.DataTextField = "partno";
                        ddlpartno17.DataBind();
                        //ddlpartno18
                        ddlpartno18.DataSource = dt;
                        ddlpartno18.DataValueField = "partno";
                        ddlpartno18.DataTextField = "partno";
                        ddlpartno18.DataBind();
                        //ddlpartno19
                        ddlpartno19.DataSource = dt;
                        ddlpartno19.DataValueField = "partno";
                        ddlpartno19.DataTextField = "partno";
                        ddlpartno19.DataBind();
                        //ddlpartno20
                        ddlpartno20.DataSource = dt;
                        ddlpartno20.DataValueField = "partno";
                        ddlpartno20.DataTextField = "partno";
                        ddlpartno20.DataBind();
                        //ddlpartno21
                        ddlpartno21.DataSource = dt;
                        ddlpartno21.DataValueField = "partno";
                        ddlpartno21.DataTextField = "partno";
                        ddlpartno21.DataBind();
                        //ddlpartno22
                        ddlpartno22.DataSource = dt;
                        ddlpartno22.DataValueField = "partno";
                        ddlpartno22.DataTextField = "partno";
                        ddlpartno22.DataBind();
                        //ddlpartno23
                        ddlpartno23.DataSource = dt;
                        ddlpartno23.DataValueField = "partno";
                        ddlpartno23.DataTextField = "partno";
                        ddlpartno23.DataBind();
                        //ddlpartno24
                        ddlpartno24.DataSource = dt;
                        ddlpartno24.DataValueField = "partno";
                        ddlpartno24.DataTextField = "partno";
                        ddlpartno24.DataBind();
                        //ddlpartno25
                        ddlpartno25.DataSource = dt;
                        ddlpartno25.DataValueField = "partno";
                        ddlpartno25.DataTextField = "partno";
                        ddlpartno25.DataBind();
                        //ddlpartno26
                        ddlpartno26.DataSource = dt;
                        ddlpartno26.DataValueField = "partno";
                        ddlpartno26.DataTextField = "partno";
                        ddlpartno26.DataBind();
                        //ddlpartno27
                        ddlpartno27.DataSource = dt;
                        ddlpartno27.DataValueField = "partno";
                        ddlpartno27.DataTextField = "partno";
                        ddlpartno27.DataBind();
                        //ddlpartno28
                        ddlpartno28.DataSource = dt;
                        ddlpartno28.DataValueField = "partno";
                        ddlpartno28.DataTextField = "partno";
                        ddlpartno28.DataBind();
                        //ddlpartno29
                        ddlpartno29.DataSource = dt;
                        ddlpartno29.DataValueField = "partno";
                        ddlpartno29.DataTextField = "partno";
                        ddlpartno29.DataBind();
                        //ddlpartno30
                        ddlpartno30.DataSource = dt;
                        ddlpartno30.DataValueField = "partno";
                        ddlpartno30.DataTextField = "partno";
                        ddlpartno30.DataBind();
                        //ddlpartno31
                        ddlpartno31.DataSource = dt;
                        ddlpartno31.DataValueField = "partno";
                        ddlpartno31.DataTextField = "partno";
                        ddlpartno31.DataBind();
                        //ddlpartno32
                        ddlpartno32.DataSource = dt;
                        ddlpartno32.DataValueField = "partno";
                        ddlpartno32.DataTextField = "partno";
                        ddlpartno32.DataBind();
                        //ddlpartno33
                        ddlpartno33.DataSource = dt;
                        ddlpartno33.DataValueField = "partno";
                        ddlpartno33.DataTextField = "partno";
                        ddlpartno33.DataBind();
                        //ddlpartno34
                        ddlpartno34.DataSource = dt;
                        ddlpartno34.DataValueField = "partno";
                        ddlpartno34.DataTextField = "partno";
                        ddlpartno34.DataBind();
                        //ddlpartno35
                        ddlpartno35.DataSource = dt;
                        ddlpartno35.DataValueField = "partno";
                        ddlpartno35.DataTextField = "partno";
                        ddlpartno35.DataBind();
                        //ddlpartno36
                        ddlpartno36.DataSource = dt;
                        ddlpartno36.DataValueField = "partno";
                        ddlpartno36.DataTextField = "partno";
                        ddlpartno36.DataBind();
                        //ddlpartno37
                        ddlpartno37.DataSource = dt;
                        ddlpartno37.DataValueField = "partno";
                        ddlpartno37.DataTextField = "partno";
                        ddlpartno37.DataBind();
                        //ddlpartno38
                        ddlpartno38.DataSource = dt;
                        ddlpartno38.DataValueField = "partno";
                        ddlpartno38.DataTextField = "partno";
                        ddlpartno38.DataBind();
                        //ddlpartno39
                        ddlpartno39.DataSource = dt;
                        ddlpartno39.DataValueField = "partno";
                        ddlpartno39.DataTextField = "partno";
                        ddlpartno39.DataBind();
                        //ddlpartno40
                        ddlpartno40.DataSource = dt;
                        ddlpartno40.DataValueField = "partno";
                        ddlpartno40.DataTextField = "partno";
                        ddlpartno40.DataBind();
                        //ddlpartno41
                        ddlpartno41.DataSource = dt;
                        ddlpartno41.DataValueField = "partno";
                        ddlpartno41.DataTextField = "partno";
                        ddlpartno41.DataBind();
                        //ddlpartno42
                        ddlpartno42.DataSource = dt;
                        ddlpartno42.DataValueField = "partno";
                        ddlpartno42.DataTextField = "partno";
                        ddlpartno42.DataBind();
                        //ddlpartno43
                        ddlpartno43.DataSource = dt;
                        ddlpartno43.DataValueField = "partno";
                        ddlpartno43.DataTextField = "partno";
                        ddlpartno43.DataBind();
                        //ddlpartno44
                        ddlpartno44.DataSource = dt;
                        ddlpartno44.DataValueField = "partno";
                        ddlpartno44.DataTextField = "partno";
                        ddlpartno44.DataBind();
                        //ddlpartno45
                        ddlpartno45.DataSource = dt;
                        ddlpartno45.DataValueField = "partno";
                        ddlpartno45.DataTextField = "partno";
                        ddlpartno45.DataBind();
                        //ddlpartno46
                        ddlpartno46.DataSource = dt;
                        ddlpartno46.DataValueField = "partno";
                        ddlpartno46.DataTextField = "partno";
                        ddlpartno46.DataBind();
                        //ddlpartno47
                        ddlpartno47.DataSource = dt;
                        ddlpartno47.DataValueField = "partno";
                        ddlpartno47.DataTextField = "partno";
                        ddlpartno47.DataBind();
                        //ddlpartno48
                        ddlpartno48.DataSource = dt;
                        ddlpartno48.DataValueField = "partno";
                        ddlpartno48.DataTextField = "partno";
                        ddlpartno48.DataBind();
                        //ddlpartno49
                        ddlpartno49.DataSource = dt;
                        ddlpartno49.DataValueField = "partno";
                        ddlpartno49.DataTextField = "partno";
                        ddlpartno49.DataBind();
                        //ddlpartno50
                        ddlpartno50.DataSource = dt;
                        ddlpartno50.DataValueField = "partno";
                        ddlpartno50.DataTextField = "partno";
                        ddlpartno50.DataBind();

                        conn.Close();

                        ddlpartno1.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno2.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno3.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno4.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno5.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno6.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno7.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno8.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno9.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno10.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno11.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno12.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno13.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno14.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno15.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno16.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno17.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno18.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno19.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno20.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno21.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno22.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno23.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno24.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno25.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno26.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno27.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno28.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno29.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno30.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno31.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno32.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno33.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno34.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno35.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno36.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno37.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno38.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno39.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno40.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno41.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno42.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno43.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno44.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno45.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno46.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno47.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno48.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno49.Items.Insert(0, new ListItem("please select", "0"));
                        ddlpartno50.Items.Insert(0, new ListItem("please select", "0"));

                    }
                }
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlorder.SelectedItem.Text == "Internal Order")
                {
                    lblcustomercode.Visible = false;
                   // ddlcustomercode.SelectedIndex = 0;
                    ddlcustomercode.Visible = false;

                    txtcustomername.Text = "";
                    lblcustomername.Visible = false;
                    txtcustomername.Visible = false;

                    txtcontact1.Text = "";
                    lblcontact1.Visible = false;
                    txtcontact1.Visible = false;

                    txtcontact2.Text = "";
                    lblcontact2.Visible = false;
                    txtcontact2.Visible = false;

                    txtcontact3.Text = "";
                    lblcontact3.Visible = false;
                    txtcontact3.Visible = false;

                    txtemail1.Text = "";
                    lblemail1.Visible = false;
                    txtemail1.Visible = false;

                    txtemail2.Text = "";
                    lblemail2.Visible = false;
                    txtemail2.Visible = false;

                    txtemail3.Text = "";
                    lblemail3.Visible = false;
                    txtemail3.Visible = false;

                    lblrequest.Visible = true;
                    txtrequest.Visible = true;
                }
                else
                {
                    lblcustomercode.Visible = true;
                    ddlcustomercode.Visible = true;

                    lblcustomername.Visible = true;
                    txtcustomername.Visible = true;

                    lblcontact1.Visible = true;
                    txtcontact1.Visible = true;

                    lblcontact2.Visible = true;
                    txtcontact2.Visible = true;

                    lblcontact3.Visible = true;
                    txtcontact3.Visible = true;

                    lblemail1.Visible = true;
                    txtemail1.Visible = true;

                    lblemail2.Visible = true;
                    txtemail2.Visible = true;

                    lblemail3.Visible = true;
                    txtemail3.Visible = true;

                    lblrequest.Visible = false;
                    txtrequest.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void txtcontact1_TextChanged(object sender, EventArgs e)
        {
            bool istrue;
            Regex obj = new Regex("^[0-9]{10}$");
            istrue = obj.IsMatch(txtcontact1.Text);
            if (!istrue)
            {
                string message = "Enter 10 Digit Number!!!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

                txtcontact1.Text = "";
            }
            else
            {
            }
        }

        protected void txtcontact2_TextChanged(object sender, EventArgs e)
        {
            bool istrue;
            Regex obj = new Regex("^[0-9]{10}$");
            istrue = obj.IsMatch(txtcontact2.Text);
            if (!istrue)
            {
                string message = "Enter 10 Digit Number!!!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

                txtcontact2.Text = "";
            }
            else
            {
            }
        }

        protected void txtcontact3_TextChanged(object sender, EventArgs e)
        {
            bool istrue;
            Regex obj = new Regex("^[0-9]{10}$");
            istrue = obj.IsMatch(txtcontact3.Text);
            if (!istrue)
            {
                string message = "Enter 10 Digit Number!!!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

                txtcontact3.Text = "";
            }
            else
            {
            }
        }

        protected void ddlpartno1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno1.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox1.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno2.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox4.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno3.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox7.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno4.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox10.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno5.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox13.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno6.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox16.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno7.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox19.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno8.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox22.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno9.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox25.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno10_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno10.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox28.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno11.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox31.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno12.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox34.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno13_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno13.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox37.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno14_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno14.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox40.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno15_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno15.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox43.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno16_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno16.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox46.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno17_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno17.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox49.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno18_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno18.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox52.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno19_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno19.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox55.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno20_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno20.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox58.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno21_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno21.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox61.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno22_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno22.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox64.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno23_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno23.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox67.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno24_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno24.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox70.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno25_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno25.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox73.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno26_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno26.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox76.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno27_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno27.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox79.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno28_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno28.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox82.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno29_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno29.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox85.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno30_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno30.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox88.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno31_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno31.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox91.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno32_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno32.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox94.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno33_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno33.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox97.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno34_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno34.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox100.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno35_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno35.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox103.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno36_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno36.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox106.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno37_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno37.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox109.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno38_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno38.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox112.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno39_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno39.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox115.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno40_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno40.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox118.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno41_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno41.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox121.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno42_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno42.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox124.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno43_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno43.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox127.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno44_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno44.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox130.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno45_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno45.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox133.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno46_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno46.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox136.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno47_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno47.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox139.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno48_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno48.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox142.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno49_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno49.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox145.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void ddlpartno50_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("SELECT description from partno where partno='" + ddlpartno50.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = Convert.ToString(dbr["description"]);
                }
                conn1.Close();
                TextBox148.Text = des;
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string num;
            int num1 = 0, id1 = 0;
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd, cmd1;

               cmd1 = new SqlCommand("SELECT MAX(id) as id from production_order", conn1);
                   SqlDataReader dbr;
                   conn1.Open();
                   dbr = cmd1.ExecuteReader();
                   while (dbr.Read())
                   {
                       num = Convert.ToString(dbr["id"]);
                       if (num == "")
                       {
                           num = "0";
                       }
                       num1 = Convert.ToInt32(num);
                       id1 = num1;
                   }
                   conn1.Close();
                   num1 = id1 + 1;
                   string id = Convert.ToString(num1);
                   cmd = new SqlCommand("INSERT into production_order(id,order_type,customer_code,customer_name,requested_by,order_num,order_date,contact1,contact2,contact3,email1,email2,email3)values('" + id + "','" + ddlorder.SelectedItem.Text + "','" + ddlcustomercode.SelectedItem.Text + "','" + txtcustomername.Text + "','" + txtrequest.Text + "','" + txtordernum.Text + "','" + txtorderdate.Text + "','" + txtcontact1.Text + "','" + txtcontact2.Text + "','" + txtcontact3.Text + "','" + txtemail1.Text + "','" + txtemail2.Text + "','" + txtemail3.Text + "')", conn1);
                   conn1.Open();
                   cmd.ExecuteNonQuery();
                   conn1.Close();
                   //insert to row1
                   if (ddlpartno1.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno1.SelectedItem.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + ddldeliverytype1.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd1.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row2
                   if (ddlpartno2.SelectedItem.Text != "please select" )
                   {
                       SqlCommand sqlcmd2 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno2.SelectedItem.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + ddldeliverytype2.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd2.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row3
                   if (ddlpartno3.SelectedItem.Text != "please select" )
                   {
                       SqlCommand sqlcmd3 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno3.SelectedItem.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + ddldeliverytype3.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd3.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row4
                   if (ddlpartno4.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd4 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno4.SelectedItem.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + ddldeliverytype4.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd4.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row5
                   if (ddlpartno5.SelectedItem.Text != "please select" )
                   {
                       SqlCommand sqlcmd5 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno5.SelectedItem.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + ddldeliverytype5.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd5.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row6
                   if (ddlpartno6.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd6 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno6.SelectedItem.Text + "','" + TextBox16.Text + "','" + TextBox17.Text + "','" + TextBox18.Text + "','" + ddldeliverytype6.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd6.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row7
                   if (ddlpartno7.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd7 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno7.SelectedItem.Text + "','" + TextBox19.Text + "','" + TextBox20.Text + "','" + TextBox21.Text + "','" + ddldeliverytype7.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd7.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row8
                   if (ddlpartno8.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd8 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno8.SelectedItem.Text + "','" + TextBox22.Text + "','" + TextBox23.Text + "','" + TextBox24.Text + "','" + ddldeliverytype8.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd8.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row9
                   if (ddlpartno9.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd9 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno9.SelectedItem.Text + "','" + TextBox25.Text + "','" + TextBox26.Text + "','" + TextBox27.Text + "','" + ddldeliverytype9.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd9.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row10
                   if (ddlpartno10.SelectedItem.Text != "please select" )
                   {
                       SqlCommand sqlcmd10 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno10.SelectedItem.Text + "','" + TextBox28.Text + "','" + TextBox29.Text + "','" + TextBox30.Text + "','" + ddldeliverytype10.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd10.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row11
                   if (ddlpartno11.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd11 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno11.SelectedItem.Text + "','" + TextBox31.Text + "','" + TextBox32.Text + "','" + TextBox33.Text + "','" + ddldeliverytype11.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd11.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row12
                   if (ddlpartno12.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd12 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno12.SelectedItem.Text + "','" + TextBox34.Text + "','" + TextBox35.Text + "','" + TextBox36.Text + "','" + ddldeliverytype12.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd12.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row13
                   if (ddlpartno13.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd13 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno13.SelectedItem.Text + "','" + TextBox37.Text + "','" + TextBox38.Text + "','" + TextBox39.Text + "','" + ddldeliverytype13.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd13.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row14
                   if (ddlpartno14.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd14 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno14.SelectedItem.Text + "','" + TextBox40.Text + "','" + TextBox41.Text + "','" + TextBox42.Text + "','" + ddldeliverytype14.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd14.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row15
                   if (ddlpartno15.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd15 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno15.SelectedItem.Text + "','" + TextBox43.Text + "','" + TextBox44.Text + "','" + TextBox45.Text + "','" + ddldeliverytype15.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd15.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row16
                   if (ddlpartno16.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd16 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno16.SelectedItem.Text + "','" + TextBox46.Text + "','" + TextBox47.Text + "','" + TextBox48.Text + "','" + ddldeliverytype16.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd16.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row17
                   if (ddlpartno17.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd17 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno17.SelectedItem.Text + "','" + TextBox49.Text + "','" + TextBox50.Text + "','" + TextBox51.Text + "','" + ddldeliverytype17.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd17.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row18
                   if (ddlpartno18.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd18 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno18.SelectedItem.Text + "','" + TextBox52.Text + "','" + TextBox53.Text + "','" + TextBox54.Text + "','" + ddldeliverytype18.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd18.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row19
                   if (ddlpartno19.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd19 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno19.SelectedItem.Text + "','" + TextBox55.Text + "','" + TextBox56.Text + "','" + TextBox57.Text + "','" + ddldeliverytype19.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd19.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row20
                   if (ddlpartno20.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd20 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno20.SelectedItem.Text + "','" + TextBox58.Text + "','" + TextBox59.Text + "','" + TextBox60.Text + "','" + ddldeliverytype20.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd20.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row21
                   if (ddlpartno21.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd21 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno21.SelectedItem.Text + "','" + TextBox61.Text + "','" + TextBox62.Text + "','" + TextBox63.Text + "','" + ddldeliverytype21.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd21.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row22
                   if (ddlpartno22.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd22 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno22.SelectedItem.Text + "','" + TextBox64.Text + "','" + TextBox65.Text + "','" + TextBox66.Text + "','" + ddldeliverytype22.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd22.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row23
                   if (ddlpartno23.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd23 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno23.SelectedItem.Text + "','" + TextBox67.Text + "','" + TextBox68.Text + "','" + TextBox69.Text + "','" + ddldeliverytype23.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd23.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row24
                   if (ddlpartno24.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd24 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno24.SelectedItem.Text + "','" + TextBox70.Text + "','" + TextBox71.Text + "','" + TextBox72.Text + "','" + ddldeliverytype24.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd24.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row25
                   if (ddlpartno25.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd25 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno25.SelectedItem.Text + "','" + TextBox73.Text + "','" + TextBox74.Text + "','" + TextBox75.Text + "','" + ddldeliverytype25.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd25.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row26
                   if (ddlpartno26.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd26 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno26.SelectedItem.Text + "','" + TextBox76.Text + "','" + TextBox77.Text + "','" + TextBox78.Text + "','" + ddldeliverytype26.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd26.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row27
                   if (ddlpartno27.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd27 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno27.SelectedItem.Text + "','" + TextBox79.Text + "','" + TextBox80.Text + "','" + TextBox81.Text + "','" + ddldeliverytype27.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd27.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row28
                   if (ddlpartno28.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd28 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno28.SelectedItem.Text + "','" + TextBox82.Text + "','" + TextBox83.Text + "','" + TextBox84.Text + "','" + ddldeliverytype28.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd28.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row29
                   if (ddlpartno29.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd29 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno29.SelectedItem.Text + "','" + TextBox85.Text + "','" + TextBox86.Text + "','" + TextBox87.Text + "','" + ddldeliverytype29.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd29.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row30
                   if (ddlpartno30.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd30 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno30.SelectedItem.Text + "','" + TextBox88.Text + "','" + TextBox89.Text + "','" + TextBox90.Text + "','" + ddldeliverytype30.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd30.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row31
                   if (ddlpartno31.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd31 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno31.SelectedItem.Text + "','" + TextBox91.Text + "','" + TextBox92.Text + "','" + TextBox93.Text + "','" + ddldeliverytype31.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd31.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row32
                   if (ddlpartno32.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd32 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno32.SelectedItem.Text + "','" + TextBox94.Text + "','" + TextBox95.Text + "','" + TextBox96.Text + "','" + ddldeliverytype32.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd32.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row33
                   if (ddlpartno33.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd33 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno33.SelectedItem.Text + "','" + TextBox97.Text + "','" + TextBox98.Text + "','" + TextBox99.Text + "','" + ddldeliverytype33.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd33.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row34
                   if (ddlpartno34.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd34 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno34.SelectedItem.Text + "','" + TextBox100.Text + "','" + TextBox101.Text + "','" + TextBox102.Text + "','" + ddldeliverytype34.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd34.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row35
                   if (ddlpartno35.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd35 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno35.SelectedItem.Text + "','" + TextBox103.Text + "','" + TextBox104.Text + "','" + TextBox105.Text + "','" + ddldeliverytype35.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd35.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row36
                   if (ddlpartno36.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd36 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno36.SelectedItem.Text + "','" + TextBox106.Text + "','" + TextBox107.Text + "','" + TextBox108.Text + "','" + ddldeliverytype36.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd36.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row37
                   if (ddlpartno37.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd37 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno37.SelectedItem.Text + "','" + TextBox109.Text + "','" + TextBox110.Text + "','" + TextBox111.Text + "','" + ddldeliverytype37.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd37.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row38
                   if (ddlpartno38.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd38 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno38.SelectedItem.Text + "','" + TextBox112.Text + "','" + TextBox113.Text + "','" + TextBox114.Text + "','" + ddldeliverytype38.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd38.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row39
                   if (ddlpartno39.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd39 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno39.SelectedItem.Text + "','" + TextBox115.Text + "','" + TextBox116.Text + "','" + TextBox117.Text + "','" + ddldeliverytype39.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd39.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row40
                   if (ddlpartno40.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd40 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno40.SelectedItem.Text + "','" + TextBox118.Text + "','" + TextBox119.Text + "','" + TextBox120.Text + "','" + ddldeliverytype40.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd40.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row41
                   if (ddlpartno41.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd41 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno41.SelectedItem.Text + "','" + TextBox121.Text + "','" + TextBox122.Text + "','" + TextBox123.Text + "','" + ddldeliverytype41.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd41.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row42
                   if (ddlpartno42.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd42 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno42.SelectedItem.Text + "','" + TextBox124.Text + "','" + TextBox125.Text + "','" + TextBox126.Text + "','" + ddldeliverytype42.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd42.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row43
                   if (ddlpartno43.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd43 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno43.SelectedItem.Text + "','" + TextBox127.Text + "','" + TextBox128.Text + "','" + TextBox129.Text + "','" + ddldeliverytype43.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd43.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row44
                   if (ddlpartno44.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd44 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno44.SelectedItem.Text + "','" + TextBox130.Text + "','" + TextBox131.Text + "','" + TextBox132.Text + "','" + ddldeliverytype44.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd44.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row45
                   if (ddlpartno45.SelectedItem.Text != "please select" )
                   {
                       SqlCommand sqlcmd45 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno45.SelectedItem.Text + "','" + TextBox133.Text + "','" + TextBox134.Text + "','" + TextBox135.Text + "','" + ddldeliverytype45.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd45.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row46
                   if (ddlpartno46.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd46 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno46.SelectedItem.Text + "','" + TextBox136.Text + "','" + TextBox137.Text + "','" + TextBox138.Text + "','" + ddldeliverytype46.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd46.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row47
                   if (ddlpartno47.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd47 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno47.SelectedItem.Text + "','" + TextBox139.Text + "','" + TextBox140.Text + "','" + TextBox141.Text + "','" + ddldeliverytype47.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd47.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row48
                   if (ddlpartno48.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd48 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno48.SelectedItem.Text + "','" + TextBox142.Text + "','" + TextBox143.Text + "','" + TextBox144.Text + "','" + ddldeliverytype48.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd48.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row49
                   if (ddlpartno49.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd49 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno49.SelectedItem.Text + "','" + TextBox145.Text + "','" + TextBox146.Text + "','" + TextBox147.Text + "','" + ddldeliverytype49.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd49.ExecuteNonQuery();
                       conn1.Close();
                   }
                   //insert to row50
                   if (ddlpartno50.SelectedItem.Text != "please select")
                   {
                       SqlCommand sqlcmd50 = new SqlCommand("INSERT INTO production_order_details values('" + id + "','" + txtordernum.Text + "','" + ddlpartno50.SelectedItem.Text + "','" + TextBox148.Text + "','" + TextBox149.Text + "','" + TextBox150.Text + "','" + ddldeliverytype50.SelectedItem.Text + "')", conn1);
                       conn1.Open();
                       sqlcmd50.ExecuteNonQuery();
                       conn1.Close();
                   }

                   //message box
                   string message = "Data Inserted Successfully!!!";
                   System.Text.StringBuilder sb = new System.Text.StringBuilder();
                   sb.Append("<script type = 'text/javascript'>");
                   sb.Append("window.onload=function(){");
                   sb.Append("alert('");
                   sb.Append(message);
                   sb.Append("')};");
                   sb.Append("</script>");
                   ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                  
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button2.Attributes.Add("OnClick", "Javascript:self.close();");
        }
    }
}
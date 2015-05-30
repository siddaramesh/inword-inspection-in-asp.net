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
    public partial class Charges : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                chargesedit();

            }
        }

        protected void chargesedit()
        {
            if (Session["chargename"] != null && Session["chargetype"] != null)
            {
                TextBox1.Text = Session["chargename"].ToString();
                DropDownList1.SelectedItem.Text = Session["chargetype"].ToString();
                DropDownList2.SelectedItem.Text = Session["purchaseaccount"].ToString();
                DropDownList3.SelectedItem.Text = Session["salesaccount"].ToString();
                TextBox2.Text = Session["percentage"].ToString();
                TextBox3.Text = Session["decimalplace"].ToString();
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
                if (TextBox1.Text == "" || TextBox1.Text == null)
                {
                    string message = "Charge Name Should Not be Blank";
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

                        cmd = new SqlCommand("INSERT INTO charges values('" + TextBox1.Text + "','" + DropDownList1.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "','" + DropDownList3.SelectedItem.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", conn1);
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
                        DropDownList1.SelectedItem.Text = "";
                        DropDownList2.SelectedItem.Text = "";
                        DropDownList3.SelectedItem.Text = "";
                    }
            }
            catch (Exception ex)
            {
                Label7.Text = ex.Message;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string chargename = "";
            int flag = 0;
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("SELECT charge_name from charges", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {
                chargename = Convert.ToString(dbr["charge_name"]);
                if (chargename == TextBox1.Text)
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
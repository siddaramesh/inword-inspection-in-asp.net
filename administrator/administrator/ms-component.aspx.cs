using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace administrator
{
    public partial class ms_component : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1;
        string no;
        int no1, num = 0;
        double qty1, partno1, physical1, lead1, value1, ledbin1, package1;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double qty,partno,physical,lead,value,ledbin,package;
            try
            {
                cmd1 = new SqlCommand("SELECT num from ms_component", conn);
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
                qty =Convert.ToDouble(TextBox1.Text) / 100;
                partno = Convert.ToDouble(TextBox2.Text)/100;
                physical= Convert.ToDouble(TextBox3.Text)/100;
                lead = Convert.ToDouble(TextBox4.Text)/100;
                value = Convert.ToDouble(TextBox5.Text)/100;
                ledbin = Convert.ToDouble(TextBox6.Text)/100;
                package = Convert.ToDouble(TextBox7.Text)/100;
                
                cmd = new SqlCommand("INSERT into ms_component(num,recieve_qty_counted,partno,physical_damage,lead,value_check,led_bin,package)values('" + no1 + "','" + qty + "','" + partno + "','" + physical + "','" + lead + "','" + value + "','" + ledbin + "','" + package + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Label15.Text = "Inserted";
                Response.Redirect("~/ms-component.aspx", false);
            }
            catch (Exception ex)
            {
                Label15.Text = ex.Message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * from ms_component", conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                qty1 = (double)dbr["recieve_qty_counted"];
                partno1 = (double)dbr["partno"];
                physical1 = (double)dbr["physical_damage"];
                lead1 = (double)dbr["lead"];
                value1 = (double)dbr["value_check"];
                ledbin1 = (double)dbr["led_bin"];
                package1 = (double)dbr["package"];

            }
            conn.Close();
            TextBox1.Text = Convert.ToString(qty1 * 100);
            TextBox2.Text = Convert.ToString(partno1 * 100);
            TextBox3.Text = Convert.ToString(physical1 * 100);
            TextBox4.Text = Convert.ToString(lead1 * 100);
            TextBox5.Text = Convert.ToString(value1 * 100);
            TextBox6.Text = Convert.ToString(ledbin1 * 100);
            TextBox7.Text = Convert.ToString(package1 * 100);
        }
    }
}
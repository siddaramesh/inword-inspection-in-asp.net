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
    public partial class ms_inductor : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1;
        string no;
        int no1, num = 0;
        double qty1,primary,tinning,putsize,lead,solderability,dcr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double qty, primary1, tinning1, putsize1, lead1, solderability1, dcr1;
            try
            {
                cmd1 = new SqlCommand("SELECT num from ms_inductor", conn);
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

                qty = Convert.ToDouble(TextBox1.Text) / 100;
                primary1 = Convert.ToDouble(TextBox2.Text) / 100;
                tinning1 = Convert.ToDouble(TextBox3.Text) / 100;
                putsize1 = Convert.ToDouble(TextBox4.Text) / 100;
                lead1 = Convert.ToDouble(TextBox5.Text) / 100;
                solderability1 = Convert.ToDouble(TextBox6.Text) / 100;
                dcr1 = Convert.ToDouble(TextBox7.Text) / 100;
                
                cmd = new SqlCommand("INSERT into ms_inductor(num,recieve_qty_counted,primary_inductance,tinning_soldering,put_size,lead,solderability,dcr)values('" + no1 + "','" + qty + "','" + primary1 + "','" + tinning1 + "','" + putsize1 + "','" + lead1 + "','" + solderability1 + "','" + dcr1 + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Label15.Text = "Inserted";
                Response.Redirect("~/ms-inductor.aspx", false);
            }
            catch (Exception ex)
            {
                Label15.Text = ex.Message;
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * from ms_inductor", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    qty1 = (double)dbr["recieve_qty_counted"];
                    primary = (double)dbr["primary_inductance"];
                    tinning = (double)dbr["tinning_soldering"];
                    putsize = (double)dbr["put_size"];
                    lead = (double)dbr["lead"];
                    solderability = (double)dbr["solderability"];
                    dcr = (double)dbr["dcr"];
                    
                }
                conn.Close();
                TextBox1.Text = Convert.ToString(qty1 * 100);
                TextBox2.Text = Convert.ToString(primary * 100);
                TextBox3.Text = Convert.ToString(tinning * 100);
                TextBox4.Text = Convert.ToString(putsize * 100);
                TextBox5.Text = Convert.ToString(lead * 100);
                TextBox6.Text = Convert.ToString(solderability* 100);
                TextBox7.Text = Convert.ToString(dcr * 100);
                
            }
            catch (Exception ex)
            {
                Label15.Text = ex.Message;
            }
        }

       
    }
}
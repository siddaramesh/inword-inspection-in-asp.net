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
    public partial class ms_transformer : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1;
        string no;
        int no1, num = 0;
        double qty1, primary1, leakage1, secondary1, bias1, primarytosecondary1, insulation1, isolation1, primary_marketing1, wire1, tinning1, sizeput1, lead1, solderability1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double qty, primary, leakage, secondary, bias, primarytosecondary, insulation, isolation, primary_marketing, wire, tinning, sizeput, lead, solderability;
            try
            {
                cmd1 = new SqlCommand("SELECT num from ms_transformer", conn);
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
                primary = Convert.ToDouble(TextBox2.Text) / 100;
                leakage = Convert.ToDouble(TextBox3.Text) / 100;
                secondary = Convert.ToDouble(TextBox4.Text) / 100;
                bias = Convert.ToDouble(TextBox5.Text) / 100;
                primarytosecondary = Convert.ToDouble(TextBox6.Text) / 100;
                insulation = Convert.ToDouble(TextBox7.Text) / 100;
                isolation = Convert.ToDouble(TextBox8.Text) / 100;
                primary_marketing = Convert.ToDouble(TextBox9.Text) / 100;
                wire = Convert.ToDouble(TextBox10.Text) / 100;
                tinning = Convert.ToDouble(TextBox11.Text) / 100;
                sizeput = Convert.ToDouble(TextBox12.Text) / 100;
                lead = Convert.ToDouble(TextBox13.Text) / 100;
                solderability = Convert.ToDouble(TextBox14.Text) / 100;
                cmd = new SqlCommand("INSERT into ms_transformer(num,recieve_qty_counted,primary_inductance,leakage_inductance,secondary_inductance,bias_inductance,primary_to_secondary_capacitance,insulation_test,isolation_test,primary_marketing,wire_to_leg,tinning,put_size,lead_length,solderability)values('" + no1 + "','" + qty + "','" + primary + "','" + leakage + "','" + secondary + "','" + bias + "','" + primarytosecondary + "','" + insulation + "','" + isolation + "','" + primary_marketing + "','" + wire + "','" + tinning + "','"+ sizeput+"','"+lead+"','"+solderability+"')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Label29.Text = "Inserted";
                Response.Redirect("~/ms-transformer.aspx", false);
            }
            catch (Exception ex)
            {
                Label29.Text = ex.Message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * from ms_transformer", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    qty1 = (double)dbr["recieve_qty_counted"];
                    primary1 = (double)dbr["primary_inductance"];
                    leakage1 = (double)dbr["leakage_inductance"];
                    secondary1 = (double)dbr["secondary_inductance"];
                    bias1 = (double)dbr["bias_inductance"];
                    primarytosecondary1 = (double)dbr["primary_to_secondary_capacitance"];
                    insulation1 = (double)dbr["insulation_test"];
                    isolation1 = (double)dbr["isolation_test"];
                    primary_marketing1 = (double)dbr["primary_marketing"];
                    wire1 = (double)dbr["wire_to_leg"];
                    tinning1 = (double)dbr["tinning"];
                    sizeput1 = (double)dbr["put_size"];
                    lead1 = (double)dbr["lead_length"];
                    solderability1 = (double)dbr["solderability"];
                }
                conn.Close();
                TextBox1.Text = Convert.ToString(qty1 * 100);
                TextBox2.Text = Convert.ToString(primary1 * 100);
                TextBox3.Text = Convert.ToString(leakage1 * 100);
                TextBox4.Text = Convert.ToString(secondary1 * 100);
                TextBox5.Text = Convert.ToString(bias1 * 100);
                TextBox6.Text = Convert.ToString(primarytosecondary1 * 100);
                TextBox7.Text = Convert.ToString(insulation1 * 100);
                TextBox8.Text = Convert.ToString(isolation1 * 100);
                TextBox9.Text = Convert.ToString(primary_marketing1 * 100);
                TextBox10.Text = Convert.ToString(wire1 * 100);
                TextBox11.Text = Convert.ToString(tinning1 * 100);
                TextBox12.Text = Convert.ToString(sizeput1 * 100);
                TextBox13.Text = Convert.ToString(lead1 * 100);
                TextBox14.Text = Convert.ToString(solderability1 * 100);
            }
            catch (Exception ex)
            {
                Label29.Text = ex.Message;
            }
        }
    }
}
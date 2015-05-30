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
    public partial class ms_barepcb : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1;
        string no;
        int no1, num = 0;
        double qty1, groove1, war1, edge1, feduicial1, copper1, rib1, overall1, masking1, legend1, pht1;
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double qty, groove, war, edge, feduicial, copper, rib, overall, masking, legend, pht;
            try
            {
                cmd1 = new SqlCommand("SELECT num from ms_barepcb", conn);
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
                groove = Convert.ToDouble(TextBox2.Text) / 100;
                war = Convert.ToDouble(TextBox3.Text) / 100;
                edge = Convert.ToDouble(TextBox4.Text) / 100;
                feduicial = Convert.ToDouble(TextBox5.Text) / 100;
                copper = Convert.ToDouble(TextBox6.Text) / 100;
                rib = Convert.ToDouble(TextBox7.Text) / 100;
                overall = Convert.ToDouble(TextBox8.Text) / 100;
                masking = Convert.ToDouble(TextBox9.Text) / 100;
                legend = Convert.ToDouble(TextBox10.Text) / 100;
                pht = Convert.ToDouble(TextBox11.Text) / 100;
                cmd = new SqlCommand("INSERT into ms_barepcb(num,recieve_qty_counted,v_groove,war_page,edge_cutting,feduicial_mark,copper_thick,rib,overall,masking,legend_printing,pht)values('"+no1+"','" + qty + "','" +groove + "','"+war+"','"+edge+"','"+feduicial+"','"+copper+"','"+rib+"','"+overall+"','"+masking+"','"+legend+"','"+pht+"')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Label23.Text = "Inserted";
                Response.Redirect("~/ms-barepcb.aspx",false);
            }
            catch (Exception ex)
            {
                Label23.Text = ex.Message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * from ms_barepcb", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    qty1 = (double)dbr["recieve_qty_counted"];
                    groove1 = (double)dbr["v_groove"];
                    war1 = (double)dbr["war_page"];
                    edge1 = (double)dbr["edge_cutting"];
                    feduicial1 = (double)dbr["feduicial_mark"];
                    copper1 = (double)dbr["copper_thick"];
                    rib1 = (double)dbr["rib"];
                    overall1 = (double)dbr["overall"];
                    masking1 = (double)dbr["masking"];
                    legend1 = (double)dbr["legend_printing"];
                    pht1 = (double)dbr["pht"];
                }
                conn.Close();
                TextBox1.Text = Convert.ToString(qty1 * 100);
                TextBox2.Text = Convert.ToString(groove1 * 100);
                TextBox3.Text = Convert.ToString(war1 * 100);
                TextBox4.Text = Convert.ToString(edge1 * 100);
                TextBox5.Text = Convert.ToString(feduicial1 * 100);
                TextBox6.Text = Convert.ToString(copper1 * 100);
                TextBox7.Text = Convert.ToString(rib1 * 100);
                TextBox8.Text = Convert.ToString(overall1 * 100);
                TextBox9.Text = Convert.ToString(masking1 * 100);
                TextBox10.Text = Convert.ToString(legend1 * 100);
                TextBox11.Text = Convert.ToString(pht1 * 100);
            }
            catch (Exception ex)
            {
                Label23.Text = ex.Message;
            }
        }
    }
}
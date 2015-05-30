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
    public partial class ms_consumables : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindnum();
                consumablesession();
            }
        }
        protected void bindnum()
        {
            string id = "";
            short num = 0;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand sqlcmd = new SqlCommand("SELECT MAX(num) as id from consumables", conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = sqlcmd.ExecuteReader();
            while (dbr.Read())
            {
                id = Convert.ToString(dbr["id"]);
                if (id == "")
                {
                    id = "0";
                }
                num = Convert.ToInt16(id);
            }
            conn.Close();
            id = Convert.ToString(num + 1);
            TextBox1.Text = id;

        }
        protected void consumablesession()
        {
            if (Session["consumables"] != null)
            {
                TextBox1.Text = Session["num"].ToString();
                TextBox2.Text = Session["consumables"].ToString();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            short num = Convert.ToInt16(TextBox1.Text);
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd = new SqlCommand("INSERT into consumables values('" + num + "','" + TextBox2.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("~/ms-consumables.aspx", false);
            }
            catch (Exception ex)
            {
                Label3.Text = ex.Message;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Drawing;

namespace administrator
{
    public partial class consumableshome : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = getdata("SELECT * FROM consumables order by num");
                GridView1.DataBind();
            }
        }
        private DataSet getdata(string query)
        {
            string conString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlCommand cmd = new SqlCommand(query);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataSet ds = new DataSet())
                    {
                        sda.Fill(ds);
                        return ds;
                    }
                }
            }
        }
        protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* GridViewRow row = GridView1.SelectedRow;
           Label1.Text = row.Cells[0].Text;
           Label2.Text = row.Cells[1].Text; */

            foreach (GridViewRow row1 in GridView1.Rows)
            {
                if (row1.RowIndex == GridView1.SelectedIndex)
                {
                    row1.BackColor = ColorTranslator.FromHtml("#323299");
                    row1.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    row1.ToolTip = string.Empty;
                }
                else
                {
                    row1.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row1.ForeColor = ColorTranslator.FromHtml("#000000");
                    row1.ToolTip = "Click to select this row.";
                }
            }
        }

        protected void popupnew_Click(object sender, EventArgs e)
        {
            Session["num"] = null;
            Session["consumables"] = null;
            ScriptManager.RegisterStartupScript(this, GetType(), "popupnew", "popupnew();", true);
        }

        protected void popupview_Click(object sender, EventArgs e)
        {
            string consumables = "", no = "", consumables2 = "";
            GridViewRow row = GridView1.SelectedRow;
            consumables = row.Cells[1].Text;
            string consumables1 = consumables;
            SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("SELECT * from consumables where consumables='" + consumables1 + "'", conn2);
            SqlDataReader dbr;
            conn2.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {
                no = Convert.ToString(dbr["num"]);
                consumables2 = Convert.ToString(dbr["consumables"]);
            }
            conn2.Close();
            Session["num"] = no;
            Session["consumables"] = consumables2;

            ScriptManager.RegisterStartupScript(this, GetType(), "popupedit", "popupedit();", true);
        }
    }
}
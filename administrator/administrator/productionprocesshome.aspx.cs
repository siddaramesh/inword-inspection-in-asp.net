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
    public partial class productionprocesshome : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = getdata("SELECT process_name as Process_Name FROM production_process order by process_name");
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
            Session["process_name"] = null;
            Session["finished"] = null;
            
            ScriptManager.RegisterStartupScript(this, GetType(), "popupnew", "popupnew();", true);
        }

        protected void popupedit_Click(object sender, EventArgs e)
        {
            string name = "", finished = "";
            GridViewRow row = GridView1.SelectedRow;
            name = row.Cells[0].Text;
            string process = name;
            SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("SELECT * from production_process where process_name='" + process + "'", conn2);
            SqlDataReader dbr;
            conn2.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {
                name = Convert.ToString(dbr["process_name"]);
                finished = Convert.ToString(dbr["finished"]);
               
            }
            conn2.Close();
            Session["processname"] = name;
            Session["finished"] = finished;
            ScriptManager.RegisterStartupScript(this, GetType(), "popupedit", "popupedit();", true);
        }
    }
}
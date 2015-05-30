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
    public partial class supplierhome : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = getdata("SELECT suppliername,erpno,category from supplier order by num");
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
            Session["suppliername"] = null;
            Session["category"] = null;
            Session["erpno"] = null;
            Session["manu1"] = null;
            Session["manu2"] = null;
            Session["manu3"] = null;
            Session["manu4"] = null;
            Session["manu5"] = null;
            Session["manu6"] = null;
            Session["manu7"] = null;
            Session["manu8"] = null;
            Session["manu9"] = null;
            Session["manu10"] = null;
            Session["inactive"] = null;
            ScriptManager.RegisterStartupScript(this, GetType(), "popupnew", "popupnew();", true);
        }

        protected void popupedit_Click(object sender, EventArgs e)
        {
            string no = "", erp = "", supplier = "", category = "", m1 = "", m2 = "", m3 = "", m4 = "", m5 = "", m6 = "", m7 = "", m8 = "", m9 = "", m10 = "", inactive = "";
            GridViewRow row = GridView1.SelectedRow;
            supplier = row.Cells[0].Text;
            string suppliername = supplier;
            SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("SELECT * from supplier where suppliername='" + suppliername + "'", conn2);
            SqlDataReader dbr;
            conn2.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {
                no = Convert.ToString(dbr["num"]);
                supplier = (string)dbr["suppliername"];
                category = (string)dbr["category"];
                erp = (string)dbr["erpno"];
                m1 = Convert.ToString(dbr["manu1"]);
                m2 = Convert.ToString(dbr["manu2"]);
                m3 = Convert.ToString(dbr["manu3"]);
                m4 = Convert.ToString(dbr["manu4"]);
                m5 = Convert.ToString(dbr["manu5"]);
                m6 = Convert.ToString(dbr["manu6"]);
                m7 = Convert.ToString(dbr["manu7"]);
                m8 = Convert.ToString(dbr["manu8"]);
                m9 = Convert.ToString(dbr["manu9"]);
                m10 = Convert.ToString(dbr["manu10"]);
                inactive = Convert.ToString(dbr["inactive"]);

            }
            conn2.Close();

            Session["num"] = no;
            Session["suppliername"] = supplier;
            Session["category"] = category;
            Session["erpno"] = erp;
            Session["manu1"] = m1;
            Session["manu2"] = m2;
            Session["manu3"] = m3;
            Session["manu4"] = m4;
            Session["manu5"] = m5;
            Session["manu6"] = m6;
            Session["manu7"] = m7;
            Session["manu8"] = m8;
            Session["manu9"] = m9;
            Session["manu10"] = m10;
            Session["inactive"] = inactive;

            ScriptManager.RegisterStartupScript(this, GetType(), "popupedit", "popupedit();", true);
        }
    }
}
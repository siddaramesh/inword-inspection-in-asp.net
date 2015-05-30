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
    public partial class bomhome : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = getdata("SELECT * from bom order by num");
            GridView1.DataBind();
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
            Session["bomdate"] = null;
            Session["revision_no"] = null;
            Session["revision_date"] = null;
            Session["category"] = null;
            Session["partno"] = null;
            Session["description"] = null;
            Session["approvedby"] = null;
            Session["partno1"] = null;
            Session["description1"] = null;
            Session["units"] = null;
            Session["alt1"] = null;
            Session["alt2"] = null;
            Session["alt3"] = null;
            Session["alt4"] = null;
            Session["alt5"] = null;
            Session["spq"] = null;
            Session["moq"] = null;
            Session["qty"] = null;
            Session["rate"] = null;
            Session["wastage"] = null;
            Session["amount"] = null;
            Session["process"] = null;
            Session["per"] = null;
            Session["time"] = null;
            Session["amount1"] = null;
            Session["overheadname"] = null;
            Session["per1"] = null;
            Session["amount2"] = null;
            ScriptManager.RegisterStartupScript(this, GetType(), "popupnew", "popupnew();", true);
        }

        protected void popuprefresh_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/bomhome.aspx", false);
        }

        protected void popupview_Click(object sender, EventArgs e)
        {
            string revision = "";
            string id = "", bomdate = "", revision_no = "", revision_date = "", category = "", partno = "", description = "", approved_by = "";
            string[] partno1 = new string[50];
            string[] description1 = new string[50];
            string[] units = new string[50];
            string[] alt1 = new string[50];
            string[] alt2 = new string[50];
            string[] alt3 = new string[50];
            string[] alt4 = new string[50];
            string[] alt5 = new string[50];
            string[] spq = new string[50];
            string[] moq = new string[50];
            string[] qty = new string[50];
            string[] rate = new string[50];
            string[] wastage = new string[50];
            string[] amount = new string[50];
            short[] smd = new short[50];
            short[] th = new short[50];

            string[] process = new string[20];
            string[] per = new string[20];
            string[] time = new string[20];
            string[] amount1 = new string[20];
            string[] overhead = new string[20];
            string[] per1 = new string[20];
            string[] amount2 = new string[20];
            int i = 0;
            GridViewRow row = GridView1.SelectedRow;
            revision = row.Cells[2].Text;
            string revisionno = revision;
            SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("SELECT num,bomdate,revision_no as rev,revision_date,category,partno as pno,description as des,approved_by from bom where revision_no='" + revisionno + "'", conn2);
            //SqlCommand cmd1 = new SqlCommand("SELECT num,bomdate,b.revision_no as rev,revision_date,category,b.partno as pno,b.description as des,approved_by,ba.partno as partno,ba.description as des1,units,alternate1,alternate2,alternate3,alternate4,alternate5,spq,moq,qty,rate,wastage,ba.amount as amt,process_name,bp.per as percentage,time,bp.amount as amt1,overheadname,bh.per as percentage1,bh.amount as amt2 from bom as b,bomassembly as ba,bomprocess as bp,bomoverhead bh where b.revision_no='" + revisionno + "' and ba.revision_no='"+revisionno+"' and bp.revision_no='"+revisionno+"'and bh.revision_no='"+revisionno+"'", conn2);
            SqlDataReader dbr;
            conn2.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {
                id = Convert.ToString(dbr["num"]);
                bomdate = Convert.ToString(dbr["bomdate"]);
                revision_no = Convert.ToString(dbr["rev"]);
                revision_date = Convert.ToString(dbr["revision_date"]);
                category = Convert.ToString(dbr["category"]);
                partno = Convert.ToString(dbr["pno"]);
                description = Convert.ToString(dbr["des"]);
                approved_by = Convert.ToString(dbr["approved_by"]);
            }
            conn2.Close();
            SqlCommand cmd2=new SqlCommand("SELECT partno,description as des1,units,alternate1,alternate2,alternate3,alternate4,alternate5,spq,moq,qty,rate,wastage,amount as amt,smd_pts,th_pts from bomassembly where revision_no='"+revisionno+"'",conn2);
            SqlDataReader sdr;
            conn2.Open();
            sdr=cmd2.ExecuteReader();
            while(sdr.Read())
            {
                partno1[i] = Convert.ToString(sdr["partno"]);
                description1[i] = Convert.ToString(sdr["des1"]);
                units[i] = Convert.ToString(sdr["units"]);
                alt1[i] = Convert.ToString(sdr["alternate1"]);
                alt2[i] = Convert.ToString(sdr["alternate2"]);
                alt3[i] = Convert.ToString(sdr["alternate3"]);
                alt4[i] = Convert.ToString(sdr["alternate4"]);
                alt5[i] = Convert.ToString(sdr["alternate5"]);
                spq[i] = Convert.ToString(sdr["spq"]);
                moq[i] = Convert.ToString(sdr["moq"]);
                qty[i] = Convert.ToString(sdr["qty"]);
                rate[i] = Convert.ToString(sdr["rate"]);
                wastage[i] = Convert.ToString(sdr["wastage"]);
                amount[i] = Convert.ToString(sdr["amt"]);
                smd[i] = Convert.ToInt16(sdr["smd_pts"]);
                th[i] = Convert.ToInt16(sdr["th_pts"]);
                i = i + 1;
            }
            conn2.Close();
            int j = 0;
            SqlCommand cmd3 = new SqlCommand("SELECT process_name,per as percentage,time,amount as amt1 from bomprocess where revision_no='" + revisionno + "'", conn2);
            SqlDataReader dbr1;
            conn2.Open();
            dbr1 = cmd3.ExecuteReader();
            while (dbr1.Read())
            {
                process[j] = Convert.ToString(dbr1["process_name"]);
                per[j] = Convert.ToString(dbr1["percentage"]);
                time[j] = Convert.ToString(dbr1["time"]);
                amount1[j] = Convert.ToString(dbr1["amt1"]);
                j = j + 1;
            }
            conn2.Close();
            int k = 0;
            SqlCommand cmd4 = new SqlCommand("SELECT overheadname,per as percentage1,amount as amt2 from bomoverhead where revision_no='" + revisionno + "'", conn2);
            SqlDataReader dbr2;
            conn2.Open();
            dbr2 = cmd4.ExecuteReader();
            while (dbr2.Read())
            {
                overhead[k] = Convert.ToString(dbr2["overheadname"]);
                per1[k] = Convert.ToString(dbr2["percentage1"]);
                amount2[k] = Convert.ToString(dbr2["amt2"]);
                k = k + 1;
            }
            conn2.Close();
            Session["num"] = id;
            Session["bomdate"] = bomdate;
            Session["revision_no"] = revision_no;
            Session["revision_date"] = revision_date;
            Session["category"] = category;
            Session["partno"] = partno;
            Session["description"] = description;
            Session["approvedby"] = approved_by;
            Session["partno1"] = partno1;
            Session["description1"] = description1;
            Session["units"] = units;
            Session["alt1"] = alt1;
            Session["alt2"] = alt2;
            Session["alt3"] = alt3;
            Session["alt4"] = alt4;
            Session["alt5"] = alt5;
            Session["spq"] = spq;
            Session["moq"] = moq;
            Session["qty"] = qty;
            Session["rate"] = rate;
            Session["wastage"] = wastage;
            Session["amount"] = amount;
            Session["smd"] = smd;
            Session["th"] = th;
            Session["process"] = process;
            Session["per"] = per;
            Session["time"] = time;
            Session["amount1"] = amount1;
            Session["overheadname"] = overhead;
            Session["per1"] = per1;
            Session["amount2"] = amount2;

            ScriptManager.RegisterStartupScript(this, GetType(), "popupnew", "popupnew();", true);
        }
    }
}
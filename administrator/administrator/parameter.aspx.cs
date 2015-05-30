using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;
using System.Configuration;
namespace administrator
{
    public partial class parameter : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            showreport();
        }
        private void showreport()
        {
            ReportViewer1.Reset();
            string txt = TextBox1.Text;
            DataTable dt = getdata(txt);
            ReportDataSource rds = new ReportDataSource("DataSet1",dt);
            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = "Report4.rdlc";

            ReportParameter[] rptparams = new ReportParameter[]{
                new ReportParameter("Partno",TextBox1.Text)
            };
            ReportViewer1.LocalReport.SetParameters(rptparams);
            ReportViewer1.LocalReport.Refresh();
        }
        private DataTable getdata(string no)
        {
            DataTable dt = new DataTable();
            using (conn)
            {
                SqlCommand sqlcmd = new SqlCommand("getcomponent", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@partno", SqlDbType.NVarChar).Value = no;

                SqlDataAdapter adp = new SqlDataAdapter(sqlcmd);
                adp.Fill(dt);
            }
            return dt;
        }
    }
}
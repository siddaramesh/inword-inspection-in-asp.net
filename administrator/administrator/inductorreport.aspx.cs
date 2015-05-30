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
    public partial class inductorreport : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            showreport();
            showreport1();
        }
        private void showreport()
        {
            ReportViewer1.Reset();
            string txt = TextBox1.Text;
            DataTable dt = getdata(txt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = "Report6.rdlc";
           
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
                SqlCommand sqlcmd = new SqlCommand("getinductor", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@partno", SqlDbType.NVarChar).Value = no;
               
                SqlDataAdapter adp = new SqlDataAdapter(sqlcmd);
                adp.Fill(dt);

            /*    SqlCommand sqlcmd1 = new SqlCommand("getprimary", conn);
                sqlcmd1.CommandType = CommandType.StoredProcedure;
                sqlcmd1.Parameters.Add("@partno", SqlDbType.NVarChar).Value = no;

                SqlDataAdapter dba = new SqlDataAdapter(sqlcmd1);
                dba.Fill(dt); */

            }
            return dt;
        }
        
        //Reportviewer2
        private void showreport1()
        {
            ReportViewer2.Reset();
            string txt = TextBox1.Text;
            DataTable dt = getdata1(txt);
            ReportDataSource rds = new ReportDataSource("primary", dt);
            ReportViewer2.LocalReport.DataSources.Add(rds);
            ReportViewer2.LocalReport.ReportPath = "Report7.rdlc";

            ReportParameter[] rptparams = new ReportParameter[]{
                new ReportParameter("Partno",TextBox1.Text)
               
            };
            ReportViewer2.LocalReport.SetParameters(rptparams);
            ReportViewer2.LocalReport.Refresh();
        }
        private DataTable getdata1(string no)
        {
            DataTable dt = new DataTable();
            using (conn1)
            {
                SqlCommand sqlcmd = new SqlCommand("getprimary", conn1);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@partno", SqlDbType.NVarChar).Value = no;

                SqlDataAdapter adp = new SqlDataAdapter(sqlcmd);
                adp.Fill(dt);

            }
            return dt;
        }
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;

using Excel = Microsoft.Office.Interop.Excel;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
using System.Data.OleDb;
using System.Data.Common;
using System.IO;
namespace administrator
{
    public partial class manufacture : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1;
        string no;
        int no1, num = 0;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                cmd1 = new SqlCommand("SELECT num,name from manufacture order by num asc", conn);
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
                Label4.Text = Convert.ToString(no1);
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }

            if (!IsPostBack)
            {
                binddropdownlist();
                highauthority();
            }
        }
        protected void binddropdownlist()
        {
            try
            {
                using (conn)
                {
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT distinct num,name,prefix from manufacture where inactive='False' order by prefix asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "num";
                        DropDownList1.DataTextField = "name";
                        DropDownList1.DataBind();
                        conn.Close();

                        DropDownList1.Items.Insert(0, new ListItem("please select", "0"));
                    }
                }
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }
        protected void highauthority()
        {
            string admin = "", sign = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT name,signin,admin1 from userinfo where signin='true'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd.ExecuteReader();
                while (dbr.Read())
                {
                    sign = (string)dbr["signin"];
                    admin = (string)dbr["admin1"];

                }
                if (admin == "True")
                {
                    CheckBox1.Visible = true;
                    export.Visible = true;
                    view.Visible = true;
                    FileUpload1.Visible = true;
                    import.Visible = true;
                }
                conn1.Close();
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool istrue;
            Regex obj = new Regex("^[a-zA-Z]{3}$");
            istrue = obj.IsMatch(TextBox2.Text);
            if (istrue)
            {
                Label8.Text = "";
                try
                {
                    if (TextBox2.Text == "")
                    {
                        Label8.Text = "* Manufacture Prefix is Required";
                    }
                    else if (TextBox1.Text == "")
                    {
                        Label2.Text = "* Name is Required";
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT into manufacture(num,name,prefix,inactive)values('" + no1 + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + CheckBox1.Checked + "')", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        Label5.Text = "Inserted";
                        TextBox1.Text = "";
                        Response.Redirect("~/manufacture.aspx", false);
                    }
                }
                catch (Exception ex)
                {
                    Label5.Text = ex.Message;
                }
            }
            else
            {
                Label8.Text = "* Numbers Not Allowed";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
             string  name="",pre="";
            try
            {
                
                SqlCommand cmd3 = new SqlCommand("SELECT num,name,prefix from manufacture where name='"+DropDownList1.SelectedItem.Text.Trim()+"'", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd3.ExecuteReader();
                while (dbr.Read())
                {
                    no = Convert.ToString(dbr["num"]);
                    no1 = Convert.ToInt32(no);
                    num = no1;
                   
                   
                    name=(string)dbr["name"];
                 
                    pre = (string)dbr["prefix"];
                    
                }
                conn.Close();
                no1 = num;
                Label4.Text = Convert.ToString(no1);
                TextBox1.Text=name;
                TextBox2.Text = pre;
               
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        
        }

        protected void export_Click(object sender, EventArgs e)
        {
            using (conn)
            {

                using (SqlCommand cmd = new SqlCommand("SELECT * from manufacture order by num asc"))
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    try
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        sda.SelectCommand = cmd;

                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            string path = Server.MapPath("exportedfiles\\");

                            if (!Directory.Exists(path))   // CHECK IF THE FOLDER EXISTS. IF NOT, CREATE A NEW FOLDER.
                            {
                                Directory.CreateDirectory(path);
                            }

                            File.Delete(path + "manufacture.xlsx"); // DELETE THE FILE BEFORE CREATING A NEW ONE.

                            // ADD A WORKBOOK USING THE EXCEL APPLICATION.
                            Excel.Application xlAppToExport = new Excel.Application();
                            xlAppToExport.Workbooks.Add("");

                            // ADD A WORKSHEET.
                            Excel.Worksheet xlWorkSheetToExport = default(Excel.Worksheet);
                            xlWorkSheetToExport = (Excel.Worksheet)xlAppToExport.Sheets["Sheet1"];

                            // ROW ID FROM WHERE THE DATA STARTS SHOWING.
                            int iRowCnt = 2;

                            // SHOW THE HEADER.
                            /*  xlWorkSheetToExport.Cells[1, 1] = "supplier Details"; 

                              Excel.Range range = xlWorkSheetToExport.Cells[1, 1] as Excel.Range;
                              range.EntireRow.Font.Name = "Calibri";
                              range.EntireRow.Font.Bold = true;
                              range.EntireRow.Font.Size = 20;

                              xlWorkSheetToExport.Range["A1:D1"].MergeCells = true;    */
                            // MERGE CELLS OF THE HEADER.

                            // SHOW COLUMNS ON THE TOP.
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 1] = "num";
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 2] = "prefix";
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 3] = "name";
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 4] = "inactive";


                            int i;
                            for (i = 0; i <= dt.Rows.Count - 1; i++)
                            {
                                xlWorkSheetToExport.Cells[iRowCnt, 1] = dt.Rows[i].Field<double>("num");
                                xlWorkSheetToExport.Cells[iRowCnt, 2] = dt.Rows[i].Field<string>("prefix");
                                xlWorkSheetToExport.Cells[iRowCnt, 3] = dt.Rows[i].Field<string>("name");
                                xlWorkSheetToExport.Cells[iRowCnt, 4] = dt.Rows[i].Field<string>("inactive");
                                
                                iRowCnt = iRowCnt + 1;
                            }

                            // FINALLY, FORMAT THE EXCEL SHEET USING EXCEL'S AUTOFORMAT FUNCTION.
                            Excel.Range range1 = xlAppToExport.ActiveCell.Worksheet.Cells[1, 1] as Excel.Range;
                            range1.AutoFormat(ExcelAutoFormat.xlRangeAutoFormatSimple);

                            // SAVE THE FILE IN A FOLDER.
                            xlWorkSheetToExport.SaveAs(path + "manufacture.xlsx");

                            // CLEAR.
                            xlAppToExport.Workbooks.Close();
                            xlAppToExport.Quit();
                            xlAppToExport = null;
                            xlWorkSheetToExport = null;

                            lblconform.Text = "Data Exported.";
                            lblconform.Attributes.Add("style", "color:green; font: bold 14px/16px Sans-Serif,Arial");
                            view.Attributes.Add("style", "display:block");

                        }
                    }
                    catch (Exception ex)
                    {
                        lblconform.Text = ex.Message;
                        lblconform.Attributes.Add("style", "color:red; font: bold 14px/16px Sans-Serif,Arial");
                    }
                    finally
                    {
                        sda.Dispose();
                        sda = null;
                    }
                }
            }
        }

        protected void view_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("exportedfiles\\");
            try
            {
                // CHECK IF THE FOLDER EXISTS.
                if (Directory.Exists(path))
                {
                 
                    // CHECK IF THE FILE EXISTS.
                    if (File.Exists(path + "manufacture.xlsx"))
                    {
                        // To open downloaded file location
                        string argument = @"/select, " + path + "manufacture.xlsx";
                        System.Diagnostics.Process.Start("explorer.exe", argument);
                        // SHOW (NOT DOWNLOAD) THE EXCEL FILE.
                       /* Excel.Application xlAppToView = new Excel.Application();
                        xlAppToView.Workbooks.Open(path + "manufacture.xlsx" );
                        xlAppToView.Visible = true; */
                    }
                }
            }
            catch (Exception ex)
            {
                lblconform.Text = ex.Message; //
            }
        }

        protected void import_Click(object sender, EventArgs e)
        {
            exportpartno();
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            try
            {
                //Upload and save the file
                string excelPath = Server.MapPath("~/uploaded files/") + Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(excelPath);
                string xyz = Path.GetFileName(FileUpload1.PostedFile.FileName);
                string conString = string.Empty;
                string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
                switch (extension)
                {
                    case ".xls": //Excel 97-03
                        conString = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
                        break;
                    case ".xlsx": //Excel 07 or higher
                        conString = ConfigurationManager.ConnectionStrings["Excel07+ConString"].ConnectionString;
                        break;

                }
                conString = string.Format(conString, excelPath);
                using (OleDbConnection excel_con = new OleDbConnection(conString))
                {
                    excel_con.Open();
                    string sheet1 = excel_con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null).Rows[0]["TABLE_NAME"].ToString();
                    DataTable dtExcelData = new DataTable();

                    //[OPTIONAL]: It is recommended as otherwise the data will be considered as String by default.
                    dtExcelData.Columns.AddRange(new DataColumn[4] { new DataColumn("num", typeof(double)),
                new DataColumn("prefix", typeof(string)),
                new DataColumn("name",typeof(string)),
                new DataColumn("inactive",typeof(string))});

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();


                    using (conn1)
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn1))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.manufacture";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("num", "num");
                            sqlBulkCopy.ColumnMappings.Add("prefix", "prefix");
                            sqlBulkCopy.ColumnMappings.Add("name", "name");
                            sqlBulkCopy.ColumnMappings.Add("inactive", "inactive");
                            
                            SqlCommand cmd2 = new SqlCommand("delete from manufacture", conn1);
                            conn1.Open();
                            cmd2.ExecuteNonQuery();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            conn1.Close();
                            importpartno();
                            lblconform.Text = "Data Imported.";
                            lblconform.Attributes.Add("style", "color:green; font: bold 14px/16px Sans-Serif,Arial");
                            Response.Redirect("~/manufacture.aspx", false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblconform.Text = ex.Message;
               // Label5.Text = ex.Message;
            }


        }
        protected void exportpartno()
        {
            using (conn)
            {

                using (SqlCommand cmd = new SqlCommand("SELECT * from partno order by num asc"))
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    try
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        sda.SelectCommand = cmd;

                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            string path = Server.MapPath("exportedfiles\\");

                            if (!Directory.Exists(path))   // CHECK IF THE FOLDER EXISTS. IF NOT, CREATE A NEW FOLDER.
                            {
                                Directory.CreateDirectory(path);
                            }

                            File.Delete(path + "partno.xlsx"); // DELETE THE FILE BEFORE CREATING A NEW ONE.

                            // ADD A WORKBOOK USING THE EXCEL APPLICATION.
                            Excel.Application xlAppToExport = new Excel.Application();
                            xlAppToExport.Workbooks.Add("");

                            // ADD A WORKSHEET.
                            Excel.Worksheet xlWorkSheetToExport = default(Excel.Worksheet);
                            xlWorkSheetToExport = (Excel.Worksheet)xlAppToExport.Sheets["Sheet1"];

                            // ROW ID FROM WHERE THE DATA STARTS SHOWING.
                            int iRowCnt = 2;

                            // SHOW THE HEADER.
                            /*  xlWorkSheetToExport.Cells[1, 1] = "supplier Details"; 

                              Excel.Range range = xlWorkSheetToExport.Cells[1, 1] as Excel.Range;
                              range.EntireRow.Font.Name = "Calibri";
                              range.EntireRow.Font.Bold = true;
                              range.EntireRow.Font.Size = 20;

                              xlWorkSheetToExport.Range["A1:D1"].MergeCells = true;    */
                            // MERGE CELLS OF THE HEADER.

                            // SHOW COLUMNS ON THE TOP.
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 1] = "num";
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 2] = "partno";
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 3] = "description";
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 4] = "mpn";
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 5] = "class_tl";
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 6] = "class_dc";
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 7] = "manufacture";
                            xlWorkSheetToExport.Cells[iRowCnt - 1, 8] = "inactive";

                            int i;
                            for (i = 0; i <= dt.Rows.Count - 1; i++)
                            {
                                xlWorkSheetToExport.Cells[iRowCnt, 1] = dt.Rows[i].Field<double>("num");
                                xlWorkSheetToExport.Cells[iRowCnt, 2] = dt.Rows[i].Field<string>("partno");
                                xlWorkSheetToExport.Cells[iRowCnt, 3] = dt.Rows[i].Field<string>("description");
                                xlWorkSheetToExport.Cells[iRowCnt, 4] = dt.Rows[i].Field<string>("mpn");
                                xlWorkSheetToExport.Cells[iRowCnt, 5] = dt.Rows[i].Field<string>("class_tl");
                                xlWorkSheetToExport.Cells[iRowCnt, 6] = dt.Rows[i].Field<string>("class_dc");
                                xlWorkSheetToExport.Cells[iRowCnt, 7] = dt.Rows[i].Field<string>("manufacture");
                                xlWorkSheetToExport.Cells[iRowCnt, 8] = dt.Rows[i].Field<string>("inactive");

                                iRowCnt = iRowCnt + 1;
                            }

                            // FINALLY, FORMAT THE EXCEL SHEET USING EXCEL'S AUTOFORMAT FUNCTION.
                            Excel.Range range1 = xlAppToExport.ActiveCell.Worksheet.Cells[1, 1] as Excel.Range;
                            range1.AutoFormat(ExcelAutoFormat.xlRangeAutoFormatSimple);

                            // SAVE THE FILE IN A FOLDER.
                            xlWorkSheetToExport.SaveAs(path + "partno.xlsx");

                            // CLEAR.
                            xlAppToExport.Workbooks.Close();
                            xlAppToExport.Quit();
                            xlAppToExport = null;
                            xlWorkSheetToExport = null;

                            
                            view.Attributes.Add("style", "display:block");

                        }
                       // conn.Close();
                        SqlCommand cmd2 = new SqlCommand("delete from partno", conn);
                       // conn.Open();
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        lblconform.Text = ex.Message;
                        lblconform.Attributes.Add("style", "color:red; font: bold 14px/16px Sans-Serif,Arial");
                    }
                    finally
                    {
                        sda.Dispose();
                        sda = null;
                    }
                }
            }
        }
        protected void importpartno()
        {
            SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            try
            {
                //Upload and save the file
                string excelPath = Server.MapPath("~/exportedfiles/") +"partno.xlsx";
                

                string conString = string.Empty;
                string extension = Path.GetExtension("partno.xlsx");
                switch (extension)
                {
                    case ".xls": //Excel 97-03
                        conString = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
                        break;
                    case ".xlsx": //Excel 07 or higher
                        conString = ConfigurationManager.ConnectionStrings["Excel07+ConString"].ConnectionString;
                        break;

                }
                conString = string.Format(conString, excelPath);
                using (OleDbConnection excel_con = new OleDbConnection(conString))
                {
                    excel_con.Open();
                    string sheet1 = excel_con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null).Rows[0]["TABLE_NAME"].ToString();
                    DataTable dtExcelData = new DataTable();

                    //[OPTIONAL]: It is recommended as otherwise the data will be considered as String by default.
                    dtExcelData.Columns.AddRange(new DataColumn[8] { new DataColumn("num", typeof(double)),
                new DataColumn("partno", typeof(string)),
                new DataColumn("description",typeof(string)),
                new DataColumn("mpn",typeof(string)),
                new DataColumn("class_tl",typeof(string)),
                new DataColumn("class_dc",typeof(string)),
                new DataColumn("manufacture",typeof(string)),
                new DataColumn("inactive",typeof(string))});

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();


                    using (conn2)
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn2))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.partno";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("num", "num");
                            sqlBulkCopy.ColumnMappings.Add("partno", "partno");
                            sqlBulkCopy.ColumnMappings.Add("description", "description");
                            sqlBulkCopy.ColumnMappings.Add("mpn", "mpn");
                            sqlBulkCopy.ColumnMappings.Add("class_tl", "class_tl");
                            sqlBulkCopy.ColumnMappings.Add("class_dc", "class_dc");
                            sqlBulkCopy.ColumnMappings.Add("manufacture", "manufacture");
                            sqlBulkCopy.ColumnMappings.Add("inactive", "inactive");

                            SqlCommand cmd2 = new SqlCommand("delete from partno", conn2);
                            conn2.Open();
                            cmd2.ExecuteNonQuery();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            conn2.Close();
                           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblconform.Text = ex.Message;
               // Label5.Text = ex.Message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("UPDATE manufacture set num='" + Label4.Text + "',prefix='" + TextBox2.Text + "',name='" + TextBox1.Text + "',inactive='" + CheckBox1.Checked + "' where prefix='"+TextBox2.Text+"'", conn);
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("manufacture.aspx", false);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
using System.Data.OleDb;
using System.Data.Common;

namespace administrator
{
    public partial class supplier : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd,cmd1;
        string no;
        int no1, num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                cmd1 = new SqlCommand("SELECT num,suppliername,category from supplier order by num asc", conn);
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
               // editsupplier();
                binddropdownlist();
                highauthority();
                
            }
        }
        protected void editsupplier()
        {
            if (Session["suppliername"] != null && Session["erpno"] != null)
            {
                Label4.Text = Session["num"].ToString();
                TextBox2.Text = Session["erpno"].ToString();
                TextBox1.Text = Session["suppliername"].ToString();
                DropDownList1.SelectedItem.Text = Session["category"].ToString();
                string inactive = Session["inactive"].ToString();
              //  CheckBox1.Checked = Convert.ToBoolean(inactive);
                

                if (Session["manu1"]!=null)
                {
                    string m1 = Session["manu1"].ToString();
                    DropDownList2.SelectedItem.Text = m1;
                   // DropDownList2.Text = Session["manu1"].ToString();
                }
                if (Session["manu2"]!=null)
                {
                    DropDownList4.Visible = true;
                    Label10.Visible = true;
                    Button4.Visible = true;
                    Button3.Visible = false;
                    Button14.Visible = true;
                    string m2 = Session["manu2"].ToString();
                    DropDownList4.SelectedItem.Text = m2;
                   // DropDownList4.Text = Session["manu2"].ToString();
                }
                if (Session["manu3"]!=null)
                {
                    DropDownList5.Visible = true;
                    Label11.Visible = true;
                    Button5.Visible = true;
                    Button15.Visible = true;
                    Button4.Visible = false;
                    Button14.Visible = false;
                    string m3 = Session["manu3"].ToString();
                    DropDownList5.SelectedItem.Text = m3;
                  //  DropDownList5.Text = Session["manu3"].ToString();
                }
                if (Session["manu4"]!=null)
                {
                    DropDownList6.Visible = true;
                    Label12.Visible = true;

                    Button6.Visible = true;
                    Button16.Visible = true;
                    Button5.Visible = false;
                    Button15.Visible = false;
                    DropDownList6.Text = Session["manu4"].ToString();
                }
                if (Session["manu5"]!=null)
                {
                    DropDownList7.Visible = true;
                    Label13.Visible = true;

                    Button7.Visible = true;
                    Button17.Visible = true;
                    Button6.Visible = false;
                    Button16.Visible = false;
                    DropDownList7.Text = Session["manu5"].ToString();
                }
                if (Session["manu6"]!=null)
                {
                    DropDownList8.Visible = true;
                    Label14.Visible = true;

                    Button8.Visible = true;
                    Button18.Visible = true;
                    Button7.Visible = false;
                    Button17.Visible = false;
                    DropDownList8.Text = Session["manu6"].ToString();
                }
                if (Session["manu7"]!=null)
                {
                    DropDownList9.Visible = true;
                    Label15.Visible = true;

                    Button9.Visible = true;
                    Button19.Visible = true;
                    Button8.Visible = false;
                    Button18.Visible = false;
                    DropDownList9.Text = Session["manu7"].ToString();
                }
                if (Session["manu8"]!=null)
                {
                    DropDownList10.Visible = true;
                    Label16.Visible = true;

                    Button10.Visible = true;
                    Button20.Visible = true;
                    Button9.Visible = false;
                    Button19.Visible = false;
                    DropDownList10.Text = Session["manu8"].ToString();
                }
                if (Session["manu9"]!=null)
                {
                    DropDownList11.Visible = true;
                    Label17.Visible = true;

                    Button11.Visible = true;
                    Button21.Visible = true;
                    Button10.Visible = false;
                    Button20.Visible = false;
                    DropDownList11.Text = Session["manu9"].ToString();
                }
                if (Session["manu10"]!=null)
                {
                    DropDownList12.Visible = true;
                    Label18.Visible = true;

                    Button11.Visible = false;
                    Button22.Visible = true;

                    Button21.Visible = false;
                    DropDownList12.Text = Session["manu10"].ToString();
                }


              /*  Label4.Text = Session["num"].ToString();
                DropDownList2.SelectedItem.Text = Session["suppliername"].ToString();
                DropDownList3.SelectedItem.Text = Session["partno"].ToString();
                TextBox2.Text = Session["qty"].ToString(); */
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
                        sqlcmd.CommandText = "SELECT num,suppliername from supplier order by suppliername asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList3.DataSource = dt;
                        DropDownList3.DataValueField = "num";
                        DropDownList3.DataTextField = "suppliername";
                        DropDownList3.DataBind();
                        conn.Close();

                        DropDownList3.Items.Insert(0, new ListItem(" ", "0"));
                    }
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT num,name from manufacture order by name asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist2
                        DropDownList2.DataSource = dt;
                        DropDownList2.DataValueField = "num";
                        DropDownList2.DataTextField = "name";
                        DropDownList2.DataBind();
                        conn.Close();
                        DropDownList2.Items.Insert(0, new ListItem(" ", "0"));
                        //dropdownlist4
                        DropDownList4.DataSource = dt;
                        DropDownList4.DataValueField = "num";
                        DropDownList4.DataTextField = "name";
                        DropDownList4.DataBind();
                        conn.Close();
                        DropDownList4.Items.Insert(0, new ListItem(" ", "0"));
                        //dropdownlist5
                        DropDownList5.DataSource = dt;
                        DropDownList5.DataValueField = "num";
                        DropDownList5.DataTextField = "name";
                        DropDownList5.DataBind();
                        conn.Close();
                        DropDownList5.Items.Insert(0, new ListItem(" ", "0"));
                        //dropdownlist6
                        DropDownList6.DataSource = dt;
                        DropDownList6.DataValueField = "num";
                        DropDownList6.DataTextField = "name";
                        DropDownList6.DataBind();
                        conn.Close();
                        DropDownList6.Items.Insert(0, new ListItem(" ", "0"));
                        //dropdownlist7
                        DropDownList7.DataSource = dt;
                        DropDownList7.DataValueField = "num";
                        DropDownList7.DataTextField = "name";
                        DropDownList7.DataBind();
                        conn.Close();
                        DropDownList7.Items.Insert(0, new ListItem(" ", "0"));
                        //dropdownlist8
                        DropDownList8.DataSource = dt;
                        DropDownList8.DataValueField = "num";
                        DropDownList8.DataTextField = "name";
                        DropDownList8.DataBind();
                        conn.Close();
                        DropDownList8.Items.Insert(0, new ListItem(" ", "0"));
                        //dropdownlist9
                        DropDownList9.DataSource = dt;
                        DropDownList9.DataValueField = "num";
                        DropDownList9.DataTextField = "name";
                        DropDownList9.DataBind();
                        conn.Close();
                        DropDownList9.Items.Insert(0, new ListItem(" ", "0"));
                        //dropdownlist10
                        DropDownList10.DataSource = dt;
                        DropDownList10.DataValueField = "num";
                        DropDownList10.DataTextField = "name";
                        DropDownList10.DataBind();
                        conn.Close();
                        DropDownList10.Items.Insert(0, new ListItem(" ", "0"));
                        //dropdownlist11
                        DropDownList11.DataSource = dt;
                        DropDownList11.DataValueField = "num";
                        DropDownList11.DataTextField = "name";
                        DropDownList11.DataBind();
                        conn.Close();
                        DropDownList11.Items.Insert(0, new ListItem(" ", "0"));
                        //dropdownlist12
                        DropDownList12.DataSource = dt;
                        DropDownList12.DataValueField = "num";
                        DropDownList12.DataTextField = "name";
                        DropDownList12.DataBind();
                        conn.Close();
                        DropDownList12.Items.Insert(0, new ListItem(" ", "0"));
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
            string admin="",sign = "";
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
            try
            {
                if (TextBox1.Text == "")
                {
                    Label6.Text = "* Supplier Name is Required";
                }
                else
                {
                    string message = "";
                    foreach (ListItem item in ListBox1.Items)
                    {
                        if (item.Selected)
                        {
                            message += item.Text + ",";
                        }
                    }
                    TextBox3.Text = message;

                    cmd = new SqlCommand("INSERT into supplier(num,suppliername,category,erpno,manu1,manu2,manu3,manu4,manu5,manu6,manu7,manu8,manu9,manu10,inactive)values('" + no1 + "','" + TextBox1.Text + "','" + DropDownList1.Text + "','" + TextBox2.Text + "','" + DropDownList2.SelectedItem.Text + "','" + DropDownList4.SelectedItem.Text + "','" + DropDownList5.SelectedItem.Text + "','" + DropDownList6.SelectedItem.Text + "','" + DropDownList7.SelectedItem.Text + "','" + DropDownList8.SelectedItem.Text + "','" + DropDownList9.SelectedItem.Text + "','" + DropDownList10.SelectedItem.Text + "','" + DropDownList11.SelectedItem.Text + "','" + DropDownList12.SelectedItem.Text + "','"+CheckBox1.Checked+"')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Label5.Text = "Inserted";
                    
                    TextBox1.Text = "";
                    Label6.Text = "";
                    Response.Redirect("~/supplier.aspx",false); 

                }
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string name,cat,nm="",cat1="",erp="",m1="",m2="",m3="",m4="",m5="",m6="",m7="",m8="",m9="",m10="";
            try
            {

                SqlCommand cmd3 = new SqlCommand("SELECT num,suppliername,category,erpno,manu1,manu2,manu3,manu4,manu5,manu6,manu7,manu8,manu9,manu10 from supplier where suppliername='" + DropDownList3.SelectedItem.Text.Trim() + "'", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd3.ExecuteReader();
                while (dbr.Read())
                {
                    no = Convert.ToString(dbr["num"]);
                    no1 = Convert.ToInt32(no);
                    num = no1;
                    name=(string)dbr["suppliername"];
                    nm=name;
                    cat=(string)dbr["category"];
                    cat1=cat;
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

                }
                conn.Close();
                no1 = num;
                Label4.Text = Convert.ToString(no1);
                TextBox1.Text=nm;
                DropDownList1.Text = cat1;
                TextBox2.Text = erp;
            
                if (m1 != " " && m1!="")
                {
                    
                    DropDownList2.SelectedItem.Text = m1;
                }
                if (m2 != " " && m2 != "")
                {
                    DropDownList4.Visible = true;
                    Label10.Visible = true;
                    Button4.Visible = true;
                    Button3.Visible = false;
                    Button14.Visible = true;
                    DropDownList4.SelectedItem.Text = m2;
                }
                if (m3 != " " && m3 != "")
                {
                    DropDownList5.Visible = true;
                    Label11.Visible = true;
                    Button5.Visible = true;
                    Button15.Visible = true;
                    Button4.Visible = false;
                    Button14.Visible = false;
                    DropDownList5.SelectedItem.Text = m3;
                }
                if (m4 != " " && m4 != "")
                {
                    DropDownList6.Visible = true;
                    Label12.Visible = true;
                    
                    Button6.Visible = true;
                    Button16.Visible = true;
                    Button5.Visible = false;
                    Button15.Visible = false;
                    DropDownList6.SelectedItem.Text = m4;
                }
                if (m5 != " " && m5 != "")
                {
                    DropDownList7.Visible = true;
                    Label13.Visible = true;
                    
                    Button7.Visible = true;
                    Button17.Visible = true;
                    Button6.Visible = false;
                    Button16.Visible = false;
                    DropDownList7.SelectedItem.Text = m5;
                }
                if (m6 != " " && m6 != "")
                {
                    DropDownList8.Visible = true;
                    Label14.Visible = true;
                    
                    Button8.Visible = true;
                    Button18.Visible = true;
                    Button7.Visible = false;
                    Button17.Visible = false;
                    DropDownList8.SelectedItem.Text = m6;
                }
                if (m7 != " " && m7 != "")
                {
                    DropDownList9.Visible = true;
                    Label15.Visible = true;
                    
                    Button9.Visible = true;
                    Button19.Visible = true;
                    Button8.Visible = false;
                    Button18.Visible = false;
                    DropDownList9.SelectedItem.Text = m7;
                }
                if (m8 != " " && m8 != "")
                {
                    DropDownList10.Visible = true;
                    Label16.Visible = true;
                    
                    Button10.Visible = true;
                    Button20.Visible = true;
                    Button9.Visible = false;
                    Button19.Visible = false;
                    DropDownList10.SelectedItem.Text = m8;
                }
                if (m9 != " " && m9 != "")
                {
                    DropDownList11.Visible = true;
                    Label17.Visible = true;
                    
                    Button11.Visible = true;
                    Button21.Visible = true;
                    Button10.Visible = false;
                    Button20.Visible = false;
                    DropDownList11.SelectedItem.Text = m9;
                }
                if (m10 != " " && m10 != "")
                {
                    DropDownList12.Visible = true;
                    Label18.Visible = true;
                    
                    Button11.Visible = false;
                    Button22.Visible = true;
                   
                    Button21.Visible = false;
                    DropDownList12.SelectedItem.Text = m10;
                }

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

            using (SqlCommand cmd = new SqlCommand("SELECT * from supplier order by num asc"))
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

                        File.Delete(path + "supplier.xlsx"); // DELETE THE FILE BEFORE CREATING A NEW ONE.

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
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 2] = "suppliername";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 3] = "category";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 4] = "erpno";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 5] = "manu1";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 6] = "manu2";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 7] = "manu3";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 8] = "manu4";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 9] = "manu5";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 10] = "manu6";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 11] = "manu7";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 12] = "manu8";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 13] = "manu9";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 14] = "manu10";
                        xlWorkSheetToExport.Cells[iRowCnt - 1, 15] = "inactive";
                        int i;
                        for (i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            xlWorkSheetToExport.Cells[iRowCnt, 1] = dt.Rows[i].Field<double>("num");
                            xlWorkSheetToExport.Cells[iRowCnt, 2] = dt.Rows[i].Field<string>("suppliername");
                            xlWorkSheetToExport.Cells[iRowCnt, 3] = dt.Rows[i].Field<string>("category");
                            xlWorkSheetToExport.Cells[iRowCnt, 4] = dt.Rows[i].Field<string>("erpno");
                            xlWorkSheetToExport.Cells[iRowCnt, 5] = dt.Rows[i].Field<string>("manu1");
                            xlWorkSheetToExport.Cells[iRowCnt, 6] = dt.Rows[i].Field<string>("manu2");
                            xlWorkSheetToExport.Cells[iRowCnt, 7] = dt.Rows[i].Field<string>("manu3");
                            xlWorkSheetToExport.Cells[iRowCnt, 8] = dt.Rows[i].Field<string>("manu4");
                            xlWorkSheetToExport.Cells[iRowCnt, 9] = dt.Rows[i].Field<string>("manu5");
                            xlWorkSheetToExport.Cells[iRowCnt, 10] = dt.Rows[i].Field<string>("manu6");
                            xlWorkSheetToExport.Cells[iRowCnt, 11] = dt.Rows[i].Field<string>("manu7");
                            xlWorkSheetToExport.Cells[iRowCnt, 12] = dt.Rows[i].Field<string>("manu8");
                            xlWorkSheetToExport.Cells[iRowCnt, 13] = dt.Rows[i].Field<string>("manu9");
                            xlWorkSheetToExport.Cells[iRowCnt, 14] = dt.Rows[i].Field<string>("manu10");
                            xlWorkSheetToExport.Cells[iRowCnt, 15] = dt.Rows[i].Field<string>("inactive");

                            iRowCnt = iRowCnt + 1;
                        }

                        // FINALLY, FORMAT THE EXCEL SHEET USING EXCEL'S AUTOFORMAT FUNCTION.
                        Excel.Range range1 = xlAppToExport.ActiveCell.Worksheet.Cells[1,1] as Excel.Range;
                        range1.AutoFormat(ExcelAutoFormat.xlRangeAutoFormatSimple); 

                        // SAVE THE FILE IN A FOLDER.
                        xlWorkSheetToExport.SaveAs(path + "supplier.xlsx");

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
                catch(Exception ex)
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
                    if (File.Exists(path + "supplier.xlsx"))
                    {
                        // To open downloaded file location
                        string argument = @"/select, " + path + "supplier.xlsx";
                        System.Diagnostics.Process.Start("explorer.exe", argument);
                        // SHOW (NOT DOWNLOAD) THE EXCEL FILE.
                      /*  Excel.Application xlAppToView = new Excel.Application();
                        xlAppToView.Workbooks.Open(path + "supplier.xlsx");
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
           
           
            try
            {
                //Upload and save the file
                string excelPath = Server.MapPath("~/uploaded files/") + Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(excelPath);

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
                    dtExcelData.Columns.AddRange(new DataColumn[15] { new DataColumn("num", typeof(double)),
                new DataColumn("suppliername", typeof(string)),
                new DataColumn("category",typeof(string)),
                new DataColumn("erpno",typeof(string)),
                new DataColumn("manu1",typeof(string)),
                new DataColumn("manu2",typeof(string)),
                new DataColumn("manu3",typeof(string)),
                new DataColumn("manu4",typeof(string)),
                new DataColumn("manu5",typeof(string)),
                new DataColumn("manu6",typeof(string)),
                new DataColumn("manu7",typeof(string)),
                new DataColumn("manu8",typeof(string)),
                new DataColumn("manu9",typeof(string)),
                new DataColumn("manu10",typeof(string)),
                new DataColumn("inactive",typeof(string))});

                    using (OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM [" + sheet1 + "]", excel_con))
                    {
                        oda.Fill(dtExcelData);
                    }
                    excel_con.Close();


                    using (conn)
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                        {
                            //Set the database table name
                            sqlBulkCopy.DestinationTableName = "dbo.supplier";

                            //[OPTIONAL]: Map the Excel columns with that of the database table
                            sqlBulkCopy.ColumnMappings.Add("num", "num");
                            sqlBulkCopy.ColumnMappings.Add("suppliername", "suppliername");
                            sqlBulkCopy.ColumnMappings.Add("category", "category");
                            sqlBulkCopy.ColumnMappings.Add("erpno", "erpno");
                            sqlBulkCopy.ColumnMappings.Add("manu1", "manu1");
                            sqlBulkCopy.ColumnMappings.Add("manu2", "manu2");
                            sqlBulkCopy.ColumnMappings.Add("manu3", "manu3");
                            sqlBulkCopy.ColumnMappings.Add("manu4", "manu4");
                            sqlBulkCopy.ColumnMappings.Add("manu5", "manu5");
                            sqlBulkCopy.ColumnMappings.Add("manu6", "manu6");
                            sqlBulkCopy.ColumnMappings.Add("manu7", "manu7");
                            sqlBulkCopy.ColumnMappings.Add("manu8", "manu8");
                            sqlBulkCopy.ColumnMappings.Add("manu9", "manu9");
                            sqlBulkCopy.ColumnMappings.Add("manu10", "manu10");
                            sqlBulkCopy.ColumnMappings.Add("inactive", "inactive");

                            SqlCommand cmd2 = new SqlCommand("delete from supplier", conn);
                            conn.Open();
                            cmd2.ExecuteNonQuery();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            conn.Close();
                            lblconform.Text = "Data Imported.";
                            lblconform.Attributes.Add("style", "color:green; font: bold 14px/16px Sans-Serif,Arial");
                            Response.Redirect("~/supplier.aspx", false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label10.Visible = true;
            DropDownList4.Visible = true;
            Button4.Visible = true;
            Button3.Visible = false;
            Button14.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label11.Visible = true;
            DropDownList5.Visible = true;
            Button5.Visible = true;
            Button15.Visible = true;
            Button4.Visible = false;
            Button14.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label12.Visible = true;
            DropDownList6.Visible = true;
            Button6.Visible = true;
            Button16.Visible = true;
            Button5.Visible = false;
            Button15.Visible = false;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Label13.Visible = true;
            DropDownList7.Visible = true;
            Button7.Visible = true;
            Button17.Visible = true;
            Button6.Visible = false;
            Button16.Visible = false;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Label14.Visible = true;
            DropDownList8.Visible = true;
            Button8.Visible = true;
            Button18.Visible = true;
            Button7.Visible = false;
            Button17.Visible = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Label15.Visible = true;
            DropDownList9.Visible = true;
            Button9.Visible = true;
            Button19.Visible = true;
            Button8.Visible = false;
            Button18.Visible = false;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Label16.Visible = true;
            DropDownList10.Visible = true;
            Button10.Visible = true;
            Button20.Visible = true;
            Button9.Visible = false;
            Button19.Visible = false;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Label17.Visible = true;
            DropDownList11.Visible = true;
            Button11.Visible = true;
            Button21.Visible = true;
           
            Button10.Visible = false;
            Button20.Visible = false;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Label18.Visible = true;
            DropDownList12.Visible = true;
            Button11.Visible = false;
            Button22.Visible = true;
           
            Button21.Visible = false;
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Label10.Visible = false;
            DropDownList4.Visible = false;
            Button4.Visible = false;
            Button3.Visible = true;
            Button14.Visible = false;
            DropDownList4.SelectedIndex = 0;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Label11.Visible = false;
            DropDownList5.Visible = false;
            Button5.Visible = false;
            Button4.Visible = true;
            Button14.Visible = true;
            Button15.Visible = false;
            DropDownList5.SelectedIndex = 0;
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Label12.Visible = false;
            DropDownList6.Visible = false;
            Button6.Visible = false;
            Button5.Visible = true;
            Button15.Visible = true;
            Button16.Visible = false;
            DropDownList6.SelectedIndex = 0;
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Label13.Visible = false;
            DropDownList7.Visible = false;
            Button7.Visible = false;
            Button6.Visible = true;
            Button16.Visible = true;
            Button17.Visible = false;
            DropDownList7.SelectedIndex = 0;
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Label14.Visible = false;
            DropDownList8.Visible = false;
            Button8.Visible = false;
            Button7.Visible = true;
            Button17.Visible = true;
            Button18.Visible = false;
            DropDownList8.SelectedIndex = 0;
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            Label15.Visible = false;
            DropDownList9.Visible = false;
            Button9.Visible = false;
            Button8.Visible = true;
            Button18.Visible = true;
            Button19.Visible = false;
            DropDownList9.SelectedIndex = 0;
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            Label16.Visible = false;
            DropDownList10.Visible = false;
            Button10.Visible = false;
            Button9.Visible = true;
            Button19.Visible = true;
            Button20.Visible = false;
            DropDownList10.SelectedIndex = 0;
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            Label17.Visible = false;
            DropDownList11.Visible = false;
            Button11.Visible = false;
            Button10.Visible = true;
            Button20.Visible = true;
            Button21.Visible = false;
            DropDownList11.SelectedIndex = 0;
         
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            Label18.Visible = false;
            DropDownList12.Visible = false;
            
            Button11.Visible = true;
            Button21.Visible = true;
            Button22.Visible = false;
            DropDownList12.SelectedIndex = 0;

            
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            
            
                SqlCommand cmd3 = new SqlCommand("UPDATE supplier set num='" + Label4.Text + "',suppliername='" + TextBox1.Text + "',erpno='" + TextBox2.Text + "',category='" + DropDownList1.SelectedItem.Text + "',inactive='" + CheckBox1.Checked + "',manu1='" + DropDownList2.SelectedItem.Text + "',manu2='" + DropDownList4.SelectedItem.Text + "',manu3='" + DropDownList5.SelectedItem.Text + "',manu4='" + DropDownList6.SelectedItem.Text + "',manu5='" + DropDownList7.SelectedItem.Text + "',manu6='" + DropDownList8.SelectedItem.Text + "',manu7='" + DropDownList9.SelectedItem.Text + "',manu8='" + DropDownList10.SelectedItem.Text + "',manu9='" + DropDownList11.SelectedItem.Text + "',manu10='" + DropDownList12.SelectedItem.Text + "' where suppliername='" + TextBox1.Text + "'", conn);
                conn.Open();
                cmd3.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("~/supplier.aspx", false);
            
           
        }

       


        }
    }
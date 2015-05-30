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
    public partial class partno : System.Web.UI.Page
    {
        SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1;
        string no;
        int no1, num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                cmd1 = new SqlCommand("SELECT num,partno,description from partno order by num", conn);
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
                alternate();
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
                        sqlcmd.CommandText = "SELECT num,partno,description from partno where inactive='False' order by partno asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "num";
                        DropDownList1.DataTextField = "partno";
                        DropDownList1.DataBind();
                        conn.Close();

                        DropDownList1.Items.Insert(0, new ListItem("please select", "0"));
                    }
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT num,prefix,name from manufacture where inactive='False' order by prefix asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList2.DataSource = dt;
                        DropDownList2.DataValueField = "num";
                        DropDownList2.DataTextField = "prefix";
                        DropDownList2.DataBind();
                        conn.Close();

                        DropDownList2.Items.Insert(0, new ListItem("please select", "0"));
                    }
                    using (SqlCommand sqlcmd1 = new SqlCommand())
                    {
                        sqlcmd1.CommandText = "SELECT num,unit,description from unitofmeasure order by num asc";
                        sqlcmd1.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist14
                        DropDownList14.DataSource = dt;
                        DropDownList14.DataValueField = "num";
                        DropDownList14.DataTextField = "unit";
                        DropDownList14.DataBind();
                        conn.Close();
                        DropDownList14.Items.Insert(0, new ListItem("", "0"));
                    }
                    using (SqlCommand sqlcmd2 = new SqlCommand())
                    {
                        sqlcmd2.CommandText = "SELECT id,modulename from modules order by modulename asc";
                        sqlcmd2.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist13
                        DropDownList13.DataSource = dt;
                        DropDownList13.DataValueField = "id";
                        DropDownList13.DataTextField = "modulename";
                        DropDownList13.DataBind();
                        conn.Close();
                        DropDownList13.Items.Insert(0, new ListItem("", "0"));
                    }
                    using (SqlCommand sqlcmd3 = new SqlCommand())
                    {
                        sqlcmd3.CommandText = "SELECT category from partno_category order by category asc";
                        sqlcmd3.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd3);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist19
                        DropDownList19.DataSource = dt;
                        DropDownList19.DataValueField = "category";
                        DropDownList19.DataTextField = "category";
                        DropDownList19.DataBind();
                        conn.Close();
                        DropDownList19.Items.Insert(0, new ListItem("", "0"));
                    }
                    using (SqlCommand sqlcmd4 = new SqlCommand())
                    {
                        sqlcmd4.CommandText = "SELECT store_name from store_master order by store_name";
                        sqlcmd4.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd4);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        //dropdownlist20
                        DropDownList20.DataSource = dt;
                        DropDownList20.DataValueField = "store_name";
                        DropDownList20.DataTextField = "store_name";
                        DropDownList20.DataBind();
                        conn.Close();
                        DropDownList20.Items.Insert(0, new ListItem("please select", "0"));

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
        protected void alternate()
        {
            try
            {
                using (conn2)
                {
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT id,alternate_no from alternate order by alternate_no asc";
                        sqlcmd.Connection = conn2;
                        conn2.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList3.DataSource = dt;
                        DropDownList3.DataValueField = "id";
                        DropDownList3.DataTextField = "alternate_no";
                        DropDownList3.DataBind();
                        conn2.Close();

                        DropDownList3.Items.Insert(0, new ListItem("", "0"));
                        //dropdownlist4
                        DropDownList4.DataSource = dt;
                        DropDownList4.DataValueField = "id";
                        DropDownList4.DataTextField = "alternate_no";
                        DropDownList4.DataBind();
                        conn2.Close();

                        DropDownList4.Items.Insert(0, new ListItem("", "0"));
                        //dropdownlist5
                        DropDownList5.DataSource = dt;
                        DropDownList5.DataValueField = "id";
                        DropDownList5.DataTextField = "alternate_no";
                        DropDownList5.DataBind();
                        conn2.Close();

                        DropDownList5.Items.Insert(0, new ListItem("", "0"));
                        //dropdownlist6
                        DropDownList6.DataSource = dt;
                        DropDownList6.DataValueField = "id";
                        DropDownList6.DataTextField = "alternate_no";
                        DropDownList6.DataBind();
                        conn2.Close();

                        DropDownList6.Items.Insert(0, new ListItem("", "0"));
                        //dropdownlist7
                        DropDownList7.DataSource = dt;
                        DropDownList7.DataValueField = "id";
                        DropDownList7.DataTextField = "alternate_no";
                        DropDownList7.DataBind();
                        conn2.Close();

                        DropDownList7.Items.Insert(0, new ListItem("", "0"));
                        //dropdownlist15
                        DropDownList15.DataSource = dt;
                        DropDownList15.DataValueField = "id";
                        DropDownList15.DataTextField = "alternate_no";
                        DropDownList15.DataBind();
                        conn2.Close();

                        DropDownList15.Items.Insert(0, new ListItem("", "0"));
                        //dropdownlist17
                        DropDownList17.DataSource = dt;
                        DropDownList17.DataValueField = "id";
                        DropDownList17.DataTextField = "alternate_no";
                        DropDownList17.DataBind();
                        conn2.Close();

                        DropDownList17.Items.Insert(0, new ListItem("", "0"));
                    }
                }
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool istrue;
            Regex obj = new Regex("^[A-Z]{3}[-]{1}[a-zA-Z0-9]{4,20}$");
            istrue = obj.IsMatch(TextBox1.Text);
            if (istrue)
            {
                try
                {
                    if (TextBox1.Text == "")
                    {
                        Label6.Text = "* ERP Part No is Required";
                    }
                    else if (TextBox3.Text == "")
                    {
                        Label11.Text = "* MPN Part No is Required";
                    }
                    else
                    {
                        string path = Server.MapPath("images/");
                        if (FileUpload2.HasFile)
                        {
                            string ext = Path.GetExtension(FileUpload2.FileName);
                            if (ext == ".jpg" || ext == ".png" || ext == ".gif")
                            {
                                FileUpload2.SaveAs(path + FileUpload2.FileName);
                                string name = "~/images/" + FileUpload2.FileName;
                                cmd = new SqlCommand("INSERT into partno(num,partno,description,mpn,class_tl,class_dc,manufacture,inactive,alternate1,alternate2,alternate3,alternate4,alternate5,equ1,equ2,equ3,equ4,equ5,spq,moq,package,images,modules,unitofmeasure,min,max,wastage,category,store)values('" + no1 + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + DropDownList2.SelectedItem.Text + "','" + CheckBox1.Checked + "','" + DropDownList3.SelectedItem.Text + "','" + DropDownList4.SelectedItem.Text + "','" + DropDownList5.SelectedItem.Text + "','" + DropDownList6.SelectedItem.Text + "','" + DropDownList7.SelectedItem.Text + "','" + DropDownList8.SelectedItem.Text + "','" + DropDownList9.SelectedItem.Text + "','" + DropDownList10.SelectedItem.Text + "','" + DropDownList11.SelectedItem.Text + "','" + DropDownList12.SelectedItem.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + name + "','" + DropDownList13.SelectedItem.Text + "','" + DropDownList14.SelectedItem.Text + "','"+TextBox10.Text+"','"+TextBox11.Text+"','"+TextBox12.Text+"','"+DropDownList19.SelectedItem.Text+"','"+DropDownList20.SelectedItem.Text+"')", conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                Label5.Text = "Inserted";
                                TextBox1.Text = "";
                                TextBox2.Text = "";
                                Response.Redirect("~/partno.aspx", false);
                            }
                            else
                            {
                                string message = "load .jpg .png .gif file formats only";
                                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                                sb.Append("<script type = 'text/javascript'>");
                                sb.Append("window.onload=function(){");
                                sb.Append("alert('");
                                sb.Append(message);
                                sb.Append("')};");
                                sb.Append("</script>");
                                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                }
            }
            else
            {
                string message = "partno expression was wrong!!!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string pno="", pn, description="", des,mnp="",ctl="",cdc="",manufacture="",name="";
            string alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            string e1 = "", e2 = "", e3 = "", e4 = "", e5 = "";
            string spq = "", moq = "", package = "", modules = "", uom = "", image = "";
            string min = "", max = "", wastage = "", category = "";
            try
            {
                
                SqlCommand cmd3 = new SqlCommand("SELECT pno.num,partno,description,mpn,class_tl,class_dc,manufacture,name,alternate1,alternate2,alternate3,alternate4,alternate5,equ1,equ2,equ3,equ4,equ5,spq,moq,package,modules,unitofmeasure,images,min,max,wastage,category from partno AS pno,manufacture where partno='"+DropDownList1.SelectedItem.Text.Trim()+"' AND prefix=manufacture", conn);
                SqlDataReader dbr;
                conn.Open();
                dbr = cmd3.ExecuteReader();
                while (dbr.Read())
                {
                    no = Convert.ToString(dbr["num"]);
                    no1 = Convert.ToInt32(no);
                    num = no1;
                    pn=(string)dbr["partno"];
                    pno=pn;
                    des=(string)dbr["description"];
                    description=des;
                    mnp = (string)dbr["mpn"];
                    ctl = (string)dbr["class_tl"];
                    cdc = (string)dbr["class_dc"];
                    manufacture = (string)dbr["manufacture"];
                    name = (string)dbr["name"];
                    alt1 = Convert.ToString(dbr["alternate1"]);
                    alt2 = Convert.ToString(dbr["alternate2"]);
                    alt3 = Convert.ToString(dbr["alternate3"]);
                    alt4 = Convert.ToString(dbr["alternate4"]);
                    alt5 = Convert.ToString(dbr["alternate5"]);
                    e1 = Convert.ToString(dbr["equ1"]);
                    e2 = Convert.ToString(dbr["equ2"]);
                    e3 = Convert.ToString(dbr["equ3"]);
                    e4 = Convert.ToString(dbr["equ4"]);
                    e5 = Convert.ToString(dbr["equ5"]);
                    spq = Convert.ToString(dbr["spq"]);
                    moq = Convert.ToString(dbr["moq"]);
                    package = Convert.ToString(dbr["package"]);
                    modules = Convert.ToString(dbr["modules"]);
                    uom = Convert.ToString(dbr["unitofmeasure"]);
                    image = Convert.ToString(dbr["images"]);
                    min = Convert.ToString(dbr["min"]);
                    max = Convert.ToString(dbr["max"]);
                    wastage = Convert.ToString(dbr["wastage"]);
                    category = Convert.ToString(dbr["category"]);
                }
                conn.Close();
                no1 = num;
                Label4.Text = Convert.ToString(no1);
                TextBox1.Text=pno;
                TextBox1.ReadOnly = true;
                TextBox2.Text = description;
                TextBox3.Text = mnp;
                TextBox3.ReadOnly = true;
                TextBox4.Text = ctl;
                TextBox5.Text = cdc;
                Label5.Text = "";
                DropDownList2.SelectedItem.Text = manufacture;
                TextBox6.Visible = true;
                TextBox6.Text = name;
                TextBox7.Text = spq;
                TextBox8.Text = moq;
                TextBox9.Text = package;
                TextBox10.Text = min;
                TextBox11.Text = max;
                TextBox12.Text = wastage;
                DropDownList13.SelectedItem.Text = modules;
                DropDownList14.SelectedItem.Text = uom;
                DropDownList19.SelectedItem.Text = category;
                if (alt1 != "" && alt1 != "null")
                {
                    DropDownList3.SelectedItem.Text = alt1;
                    DropDownList8.SelectedItem.Text = e1;
                }
                else
                {

                    DropDownList3.SelectedItem.Text = "";
                    DropDownList8.SelectedItem.Text = "";
                }
                if (alt2 != "" && alt2 != "null")
                {
                    Button4.Visible = false;
                    Label14.Visible = true;
                    DropDownList4.Visible = true;
                    Button5.Visible = true;
                    Button6.Visible = true;
                    DropDownList4.SelectedItem.Text = alt2;
                    DropDownList9.Visible = true;
                    DropDownList9.SelectedItem.Text = e2;
                }
                else
                {
                    Button4.Visible = true;
                    Label14.Visible = false;
                    DropDownList4.Visible = false;
                    Button5.Visible = false;
                    Button6.Visible = false;
                    DropDownList4.SelectedItem.Text = "";
                    DropDownList9.Visible = false;
                    DropDownList9.SelectedItem.Text = "";
                }
                if (alt3 != "" && alt3 != "null")
                {
                    Button5.Visible = false;
                    Button6.Visible = false;
                    Label15.Visible = true;
                    DropDownList5.Visible = true;
                    Button7.Visible = true;
                    Button8.Visible = true;
                    DropDownList5.SelectedItem.Text = alt3;
                    DropDownList10.Visible = true;
                    DropDownList10.SelectedItem.Text = e3;
                }
                else
                {
                  //  Button5.Visible = true;
                  //  Button6.Visible = true;
                    Label15.Visible = false;
                    DropDownList5.Visible = false;
                    Button7.Visible = false;
                    Button8.Visible = false;
                    DropDownList5.SelectedItem.Text = "";
                    DropDownList10.Visible = false;
                    DropDownList10.SelectedItem.Text = "";
                }
                if (alt4 != "" && alt4 != "null")
                {
                    Button7.Visible = false;
                    Button8.Visible = false;
                    Label16.Visible = true;
                    DropDownList6.Visible = true;
                    Button9.Visible = true;
                    Button10.Visible = true;
                    DropDownList6.SelectedItem.Text = alt4;
                    DropDownList11.Visible = true;
                    DropDownList11.SelectedItem.Text = e4;
                }
                else
                {
                    Label16.Visible = false;
                    DropDownList6.Visible = false;
                    Button9.Visible = false;
                    Button10.Visible = false;
                    DropDownList6.SelectedItem.Text = "";
                    DropDownList11.Visible = false;
                    DropDownList11.SelectedItem.Text = "";
                }
                if (alt5 != "" && alt5 != "null")
                {
                    Button9.Visible = false;
                    Button10.Visible = false;
                    Label17.Visible = true;
                    DropDownList7.Visible = true;
                    Button11.Visible = true;
                    Button12.Visible = true;
                    DropDownList7.SelectedItem.Text = alt5;
                    DropDownList12.Visible = true;
                    DropDownList12.SelectedItem.Text = e5;
                }
                else
                {
                    Label17.Visible = false;
                    DropDownList7.Visible = false;
                    Button11.Visible = false;
                    Button12.Visible = false;
                    DropDownList7.SelectedItem.Text = "";
                    DropDownList12.Visible = false;
                    DropDownList12.SelectedItem.Text = "";
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            }
        }

        protected void export_Click(object sender, EventArgs e)
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
                    if (File.Exists(path + "partno.xlsx"))
                    {
                        // To open downloaded file location
                        string argument = @"/select, " + path + "partno.xlsx";
                        System.Diagnostics.Process.Start("explorer.exe", argument);
                        // SHOW (NOT DOWNLOAD) THE EXCEL FILE.
                     /*   Excel.Application xlAppToView = new Excel.Application();
                        xlAppToView.Workbooks.Open(path + "partno.xlsx");
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


                    using (conn)
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
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

                            SqlCommand cmd2 = new SqlCommand("delete from partno", conn);
                            conn.Open();
                            cmd2.ExecuteNonQuery();
                            sqlBulkCopy.WriteToServer(dtExcelData);
                            conn.Close();
                            lblconform.Text = "Data Imported.";
                            lblconform.Attributes.Add("style", "color:green; font: bold 14px/16px Sans-Serif,Arial");
                            Response.Redirect("~/partno.aspx", false);
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
            string img = "";
            try
            {
                string path = Server.MapPath("images/");
                if (FileUpload2.HasFile)
                {
                    string ext = Path.GetExtension(FileUpload2.FileName);
                    if (ext == ".jpg" || ext == ".png" || ext == ".gif")
                    {
                        FileUpload2.SaveAs(path + FileUpload2.FileName);
                         img = "~/images/" + FileUpload2.FileName;
                    }
                    else
                    {
                        string message = "load .jpg .png .gif file formats only";
                        System.Text.StringBuilder sb = new System.Text.StringBuilder();
                        sb.Append("<script type = 'text/javascript'>");
                        sb.Append("window.onload=function(){");
                        sb.Append("alert('");
                        sb.Append(message);
                        sb.Append("')};");
                        sb.Append("</script>");
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                    }
                }
                SqlCommand cmd3 = new SqlCommand("UPDATE partno set num='" + Label4.Text + "',partno='" + TextBox1.Text + "',description='" + TextBox2.Text + "',mpn='" + TextBox3.Text + "',manufacture='" + DropDownList2.SelectedItem.Text + "',inactive='" + CheckBox1.Checked + "',class_tl='" + TextBox4.Text + "',class_dc='" + TextBox5.Text + "',alternate1='" + DropDownList3.SelectedItem.Text + "',alternate2='" + DropDownList4.SelectedItem.Text + "',alternate3='" + DropDownList5.SelectedItem.Text + "',alternate4='" + DropDownList6.SelectedItem.Text + "',alternate5='" + DropDownList7.SelectedItem.Text + "',equ1='" + DropDownList8.SelectedItem.Text + "',equ2='" + DropDownList9.SelectedItem.Text + "',equ3='" + DropDownList10.SelectedItem.Text + "',equ4='" + DropDownList11.SelectedItem.Text + "',equ5='" + DropDownList12.SelectedItem.Text + "',spq='"+TextBox7.Text+"',moq='"+TextBox8.Text+"',package='"+TextBox9.Text+"',modules='"+DropDownList13.SelectedItem.Text+"',unitofmeasure='"+DropDownList14.SelectedItem.Text+"',images='"+img+"',min='"+TextBox10.Text+"',max='"+TextBox11.Text+"' where partno='" + TextBox1.Text + "'", conn);
                conn.Open();
                cmd3.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("~/partno.aspx", false);
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label14.Visible = true;
            DropDownList4.Visible = true;
            DropDownList9.Visible = true;
            Button5.Visible = true;
            Button6.Visible = true;
            Button4.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label15.Visible = true;
            DropDownList5.Visible = true;
            DropDownList10.Visible = true;
            Button7.Visible = true;
            Button8.Visible = true;
            Button6.Visible = false;
            Button5.Visible = false;
           
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            DropDownList4.SelectedIndex = 0;
            Button4.Visible = true;
            Label14.Visible = false;
            DropDownList4.Visible = false;
            DropDownList9.SelectedIndex = 0;
            DropDownList9.Visible = false;
            Button5.Visible = false;
            Button6.Visible = false;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Label16.Visible = true;
            DropDownList6.Visible = true;
            DropDownList11.Visible = true;
            Button9.Visible = true;
            Button10.Visible = true;
            Button8.Visible = false;
            Button7.Visible = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            DropDownList5.SelectedIndex = 0;
            DropDownList5.Visible = false;
            DropDownList10.SelectedIndex = 0;
            DropDownList10.Visible = false;
            Label15.Visible = false;
            Button7.Visible = false;

            Label14.Visible = true;
            DropDownList4.Visible = true;
            DropDownList9.Visible = true;
            Button5.Visible = true;
            Button6.Visible = true;
            Button8.Visible = false;

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Label17.Visible = true;
            DropDownList7.Visible = true;
            DropDownList12.Visible = true;
            Button11.Visible = true;
            Button12.Visible = true;
            Button10.Visible = false;
            Button9.Visible = false;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            DropDownList6.SelectedIndex = 0;
            Label16.Visible = false;
            DropDownList6.Visible = false;
            DropDownList11.SelectedIndex = 0;
            DropDownList11.Visible = false;
            Button9.Visible = false;

            Label15.Visible = true;
            DropDownList5.Visible = true;
            DropDownList10.Visible = true;
            Button7.Visible = true;
            Button8.Visible = true;
            Button10.Visible = false;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            DropDownList7.SelectedIndex = 0;
            Label17.Visible = false;
            DropDownList7.Visible = false;
            DropDownList12.SelectedIndex = 0;
            DropDownList12.Visible = false;
            Button11.Visible = false;

            Label16.Visible = true;
            DropDownList6.Visible = true;
            Button9.Visible = true;
            Button10.Visible = true;
            Button12.Visible = false;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Label27.Visible = true;
            DropDownList15.Visible = true;
            DropDownList16.Visible = true;
            Button13.Visible = true;
            Button14.Visible = true;
            Button11.Visible = false;
            Button12.Visible = false;
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Label28.Visible = true;
            DropDownList17.Visible = true;
            DropDownList18.Visible = true;
            Button16.Visible = true;
            Button13.Visible = false;
            Button14.Visible = false;
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            //DropDownList17.SelectedIndex = 0;
            Label28.Visible = false;
            DropDownList17.Visible = false;
           // DropDownList18.SelectedIndex = 0;
            DropDownList18.Visible = false;
            Button16.Visible = false;

            Label27.Visible = true;
            DropDownList15.Visible = true;
            DropDownList16.Visible = true;
            Button13.Visible = true;
            Button14.Visible = true;
           
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
           // DropDownList15.SelectedIndex = 0;
            Label27.Visible = false;
            DropDownList15.Visible = false;
          //  DropDownList16.SelectedIndex = 0;
            DropDownList16.Visible = false;
            Button13.Visible = false;

            Label17.Visible = true;
            DropDownList7.Visible = true;
            DropDownList12.Visible = true;
            Button11.Visible = true;
            Button12.Visible = true;
            Button14.Visible = false;
        }
    }
}
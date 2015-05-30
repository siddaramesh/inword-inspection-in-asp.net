using System;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace administrator
{
    public partial class BOM : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tab1.CssClass = "Clicked";
                MainView.ActiveViewIndex = 0;
                bomid();
                binddropdownlist();
                sessiondata();
            }
        }
        protected void Tab1_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Clicked";
            Tab2.CssClass = "addbutton";
            MainView.ActiveViewIndex = 0;
        }

        protected void Tab2_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "addbutton";
            Tab2.CssClass = "Clicked";
            MainView.ActiveViewIndex = 1;
        }

        protected void bomid()
        {
            string num="";
            int num1 = 0, id1 = 0;
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd1;
            try
            {
                cmd1 = new SqlCommand("SELECT MAX(num) as id from bom", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    num = Convert.ToString(dbr["id"]);
                    if (num == "")
                    {
                        num = "0";
                    }
                    num1 = Convert.ToInt32(num);
                    id1 = num1;
                }
                conn1.Close();
                num1 = id1 + 1;
                string id = Convert.ToString(num1);
                TextBox1.Text = id;
            }
            catch (Exception ex)
            {
                Label17.Text = ex.Message;
            }
        }
        
        protected void binddropdownlist()
        {
            try
            {
                using (conn)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "SELECT * from partno_category where category='Finish Goods' or category='Sub Finish Goods'";
                        cmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //category
                        DropDownList2.DataSource = dt;
                        DropDownList2.DataValueField = "category";
                        DropDownList2.DataTextField = "category";
                        DropDownList2.DataBind();

                        conn.Close();
                        DropDownList2.Items.Insert(0, new ListItem("please select", "0"));
                    }
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT partno from partno where inactive='False' and category IN('Finish Goods','Sub Finish Goods') order by partno asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist1
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "partno";
                        DropDownList1.DataTextField = "partno";
                        DropDownList1.DataBind();
                        //ddlitemcode1
                        ddlitemcode1.DataSource = dt;
                        ddlitemcode1.DataValueField = "partno";
                        ddlitemcode1.DataTextField = "partno";
                        ddlitemcode1.DataBind();
                        //ddlitemcode2
                        ddlitemcode2.DataSource = dt;
                        ddlitemcode2.DataValueField = "partno";
                        ddlitemcode2.DataTextField = "partno";
                        ddlitemcode2.DataBind();
                        //ddlitemcode3
                        ddlitemcode3.DataSource = dt;
                        ddlitemcode3.DataValueField = "partno";
                        ddlitemcode3.DataTextField = "partno";
                        ddlitemcode3.DataBind();
                        //ddlitemcode4
                        ddlitemcode4.DataSource = dt;
                        ddlitemcode4.DataValueField = "partno";
                        ddlitemcode4.DataTextField = "partno";
                        ddlitemcode4.DataBind();
                        //ddlitemcode5
                        ddlitemcode5.DataSource = dt;
                        ddlitemcode5.DataValueField = "partno";
                        ddlitemcode5.DataTextField = "partno";
                        ddlitemcode5.DataBind();
                        //ddlitemcode6
                        ddlitemcode6.DataSource = dt;
                        ddlitemcode6.DataValueField = "partno";
                        ddlitemcode6.DataTextField = "partno";
                        ddlitemcode6.DataBind();
                        //ddlitemcode7
                        ddlitemcode7.DataSource = dt;
                        ddlitemcode7.DataValueField = "partno";
                        ddlitemcode7.DataTextField = "partno";
                        ddlitemcode7.DataBind();
                        //ddlitemcode8
                        ddlitemcode8.DataSource = dt;
                        ddlitemcode8.DataValueField = "partno";
                        ddlitemcode8.DataTextField = "partno";
                        ddlitemcode8.DataBind();
                        //ddlitemcode9
                        ddlitemcode9.DataSource = dt;
                        ddlitemcode9.DataValueField = "partno";
                        ddlitemcode9.DataTextField = "partno";
                        ddlitemcode9.DataBind();
                        //ddlitemcode10
                        ddlitemcode10.DataSource = dt;
                        ddlitemcode10.DataValueField = "partno";
                        ddlitemcode10.DataTextField = "partno";
                        ddlitemcode10.DataBind();
                        //ddlitemcode11
                        ddlitemcode11.DataSource = dt;
                        ddlitemcode11.DataValueField = "partno";
                        ddlitemcode11.DataTextField = "partno";
                        ddlitemcode11.DataBind();
                        //ddlitemcode12
                        ddlitemcode12.DataSource = dt;
                        ddlitemcode12.DataValueField = "partno";
                        ddlitemcode12.DataTextField = "partno";
                        ddlitemcode12.DataBind();
                        //ddlitemcode13
                        ddlitemcode13.DataSource = dt;
                        ddlitemcode13.DataValueField = "partno";
                        ddlitemcode13.DataTextField = "partno";
                        ddlitemcode13.DataBind();
                        //ddlitemcode14
                        ddlitemcode14.DataSource = dt;
                        ddlitemcode14.DataValueField = "partno";
                        ddlitemcode14.DataTextField = "partno";
                        ddlitemcode14.DataBind();
                        //ddlitemcode15
                        ddlitemcode15.DataSource = dt;
                        ddlitemcode15.DataValueField = "partno";
                        ddlitemcode15.DataTextField = "partno";
                        ddlitemcode15.DataBind();
                        //ddlitemcode16
                        ddlitemcode16.DataSource = dt;
                        ddlitemcode16.DataValueField = "partno";
                        ddlitemcode16.DataTextField = "partno";
                        ddlitemcode16.DataBind();
                        //ddlitemcode17
                        ddlitemcode17.DataSource = dt;
                        ddlitemcode17.DataValueField = "partno";
                        ddlitemcode17.DataTextField = "partno";
                        ddlitemcode17.DataBind();
                        //ddlitemcode18
                        ddlitemcode18.DataSource = dt;
                        ddlitemcode18.DataValueField = "partno";
                        ddlitemcode18.DataTextField = "partno";
                        ddlitemcode18.DataBind();
                        //ddlitemcode19
                        ddlitemcode19.DataSource = dt;
                        ddlitemcode19.DataValueField = "partno";
                        ddlitemcode19.DataTextField = "partno";
                        ddlitemcode19.DataBind();
                        //ddlitemcode20
                        ddlitemcode20.DataSource = dt;
                        ddlitemcode20.DataValueField = "partno";
                        ddlitemcode20.DataTextField = "partno";
                        ddlitemcode20.DataBind();
                        //ddlitemcode21
                        ddlitemcode21.DataSource = dt;
                        ddlitemcode21.DataValueField = "partno";
                        ddlitemcode21.DataTextField = "partno";
                        ddlitemcode21.DataBind();
                        //ddlitemcode22
                        ddlitemcode22.DataSource = dt;
                        ddlitemcode22.DataValueField = "partno";
                        ddlitemcode22.DataTextField = "partno";
                        ddlitemcode22.DataBind();
                        //ddlitemcode23
                        ddlitemcode23.DataSource = dt;
                        ddlitemcode23.DataValueField = "partno";
                        ddlitemcode23.DataTextField = "partno";
                        ddlitemcode23.DataBind();
                        //ddlitemcode24
                        ddlitemcode24.DataSource = dt;
                        ddlitemcode24.DataValueField = "partno";
                        ddlitemcode24.DataTextField = "partno";
                        ddlitemcode24.DataBind();
                        //ddlitemcode25
                        ddlitemcode25.DataSource = dt;
                        ddlitemcode25.DataValueField = "partno";
                        ddlitemcode25.DataTextField = "partno";
                        ddlitemcode25.DataBind();
                        //ddlitemcode26
                        ddlitemcode26.DataSource = dt;
                        ddlitemcode26.DataValueField = "partno";
                        ddlitemcode26.DataTextField = "partno";
                        ddlitemcode26.DataBind();
                        //ddlitemcode27
                        ddlitemcode27.DataSource = dt;
                        ddlitemcode27.DataValueField = "partno";
                        ddlitemcode27.DataTextField = "partno";
                        ddlitemcode27.DataBind();
                        //ddlitemcode28
                        ddlitemcode28.DataSource = dt;
                        ddlitemcode28.DataValueField = "partno";
                        ddlitemcode28.DataTextField = "partno";
                        ddlitemcode28.DataBind();
                        //ddlitemcode29
                        ddlitemcode29.DataSource = dt;
                        ddlitemcode29.DataValueField = "partno";
                        ddlitemcode29.DataTextField = "partno";
                        ddlitemcode29.DataBind();
                        //ddlitemcode30
                        ddlitemcode30.DataSource = dt;
                        ddlitemcode30.DataValueField = "partno";
                        ddlitemcode30.DataTextField = "partno";
                        ddlitemcode30.DataBind();
                        //ddlitemcode31
                        ddlitemcode31.DataSource = dt;
                        ddlitemcode31.DataValueField = "partno";
                        ddlitemcode31.DataTextField = "partno";
                        ddlitemcode31.DataBind();
                        //ddlitemcode32
                        ddlitemcode32.DataSource = dt;
                        ddlitemcode32.DataValueField = "partno";
                        ddlitemcode32.DataTextField = "partno";
                        ddlitemcode32.DataBind();
                        //ddlitemcode33
                        ddlitemcode33.DataSource = dt;
                        ddlitemcode33.DataValueField = "partno";
                        ddlitemcode33.DataTextField = "partno";
                        ddlitemcode33.DataBind();
                        //ddlitemcode34
                        ddlitemcode34.DataSource = dt;
                        ddlitemcode34.DataValueField = "partno";
                        ddlitemcode34.DataTextField = "partno";
                        ddlitemcode34.DataBind();
                        //ddlitemcode35
                        ddlitemcode35.DataSource = dt;
                        ddlitemcode35.DataValueField = "partno";
                        ddlitemcode35.DataTextField = "partno";
                        ddlitemcode35.DataBind();
                        //ddlitemcode36
                        ddlitemcode36.DataSource = dt;
                        ddlitemcode36.DataValueField = "partno";
                        ddlitemcode36.DataTextField = "partno";
                        ddlitemcode36.DataBind();
                        //ddlitemcode37
                        ddlitemcode37.DataSource = dt;
                        ddlitemcode37.DataValueField = "partno";
                        ddlitemcode37.DataTextField = "partno";
                        ddlitemcode37.DataBind();
                        //ddlitemcode38
                        ddlitemcode38.DataSource = dt;
                        ddlitemcode38.DataValueField = "partno";
                        ddlitemcode38.DataTextField = "partno";
                        ddlitemcode38.DataBind();
                        //ddlitemcode39
                        ddlitemcode39.DataSource = dt;
                        ddlitemcode39.DataValueField = "partno";
                        ddlitemcode39.DataTextField = "partno";
                        ddlitemcode39.DataBind();
                        //ddlitemcode40
                        ddlitemcode40.DataSource = dt;
                        ddlitemcode40.DataValueField = "partno";
                        ddlitemcode40.DataTextField = "partno";
                        ddlitemcode40.DataBind();
                        //ddlitemcode41
                        ddlitemcode41.DataSource = dt;
                        ddlitemcode41.DataValueField = "partno";
                        ddlitemcode41.DataTextField = "partno";
                        ddlitemcode41.DataBind();
                        //ddlitemcode42
                        ddlitemcode42.DataSource = dt;
                        ddlitemcode42.DataValueField = "partno";
                        ddlitemcode42.DataTextField = "partno";
                        ddlitemcode42.DataBind();
                        //ddlitemcode43
                        ddlitemcode43.DataSource = dt;
                        ddlitemcode43.DataValueField = "partno";
                        ddlitemcode43.DataTextField = "partno";
                        ddlitemcode43.DataBind();
                        //ddlitemcode44
                        ddlitemcode44.DataSource = dt;
                        ddlitemcode44.DataValueField = "partno";
                        ddlitemcode44.DataTextField = "partno";
                        ddlitemcode44.DataBind();
                        //ddlitemcode45
                        ddlitemcode45.DataSource = dt;
                        ddlitemcode45.DataValueField = "partno";
                        ddlitemcode45.DataTextField = "partno";
                        ddlitemcode45.DataBind();
                        //ddlitemcode46
                        ddlitemcode46.DataSource = dt;
                        ddlitemcode46.DataValueField = "partno";
                        ddlitemcode46.DataTextField = "partno";
                        ddlitemcode46.DataBind();
                        //ddlitemcode47
                        ddlitemcode47.DataSource = dt;
                        ddlitemcode47.DataValueField = "partno";
                        ddlitemcode47.DataTextField = "partno";
                        ddlitemcode47.DataBind();
                        //ddlitemcode48
                        ddlitemcode48.DataSource = dt;
                        ddlitemcode48.DataValueField = "partno";
                        ddlitemcode48.DataTextField = "partno";
                        ddlitemcode48.DataBind();
                        //ddlitemcode49
                        ddlitemcode49.DataSource = dt;
                        ddlitemcode49.DataValueField = "partno";
                        ddlitemcode49.DataTextField = "partno";
                        ddlitemcode49.DataBind();
                        //ddlitemcode50
                        ddlitemcode50.DataSource = dt;
                        ddlitemcode50.DataValueField = "partno";
                        ddlitemcode50.DataTextField = "partno";
                        ddlitemcode50.DataBind();


                        conn.Close();

                        DropDownList1.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode1.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode2.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode3.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode4.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode5.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode6.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode7.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode8.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode9.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode10.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode11.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode12.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode13.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode14.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode15.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode16.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode17.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode18.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode19.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode20.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode21.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode22.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode23.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode24.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode25.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode26.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode27.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode28.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode29.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode30.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode31.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode32.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode33.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode34.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode35.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode36.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode37.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode38.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode39.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode40.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode41.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode42.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode43.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode44.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode45.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode46.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode47.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode48.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode49.Items.Insert(0, new ListItem("please select", "0"));
                        ddlitemcode50.Items.Insert(0, new ListItem("please select", "0"));

                        //alternate partnumbers
                        alternate1.Items.Insert(0, new ListItem(" ", "0"));
                        alternate2.Items.Insert(0, new ListItem(" ", "0"));
                        alternate3.Items.Insert(0, new ListItem(" ", "0"));
                        alternate4.Items.Insert(0, new ListItem(" ", "0"));
                        alternate5.Items.Insert(0, new ListItem(" ", "0"));
                        alternate6.Items.Insert(0, new ListItem(" ", "0"));
                        alternate7.Items.Insert(0, new ListItem(" ", "0"));
                        alternate8.Items.Insert(0, new ListItem(" ", "0"));
                        alternate9.Items.Insert(0, new ListItem(" ", "0"));
                        alternate10.Items.Insert(0, new ListItem(" ", "0"));
                        alternate11.Items.Insert(0, new ListItem(" ", "0"));
                        alternate12.Items.Insert(0, new ListItem(" ", "0"));
                        alternate13.Items.Insert(0, new ListItem(" ", "0"));
                        alternate14.Items.Insert(0, new ListItem(" ", "0"));
                        alternate15.Items.Insert(0, new ListItem(" ", "0"));
                        alternate16.Items.Insert(0, new ListItem(" ", "0"));
                        alternate17.Items.Insert(0, new ListItem(" ", "0"));
                        alternate18.Items.Insert(0, new ListItem(" ", "0"));
                        alternate19.Items.Insert(0, new ListItem(" ", "0"));
                        alternate20.Items.Insert(0, new ListItem(" ", "0"));
                        alternate21.Items.Insert(0, new ListItem(" ", "0"));
                        alternate22.Items.Insert(0, new ListItem(" ", "0"));
                        alternate23.Items.Insert(0, new ListItem(" ", "0"));
                        alternate24.Items.Insert(0, new ListItem(" ", "0"));
                        alternate25.Items.Insert(0, new ListItem(" ", "0"));
                        alternate26.Items.Insert(0, new ListItem(" ", "0"));
                        alternate27.Items.Insert(0, new ListItem(" ", "0"));
                        alternate28.Items.Insert(0, new ListItem(" ", "0"));
                        alternate29.Items.Insert(0, new ListItem(" ", "0"));
                        alternate30.Items.Insert(0, new ListItem(" ", "0"));
                        alternate31.Items.Insert(0, new ListItem(" ", "0"));
                        alternate32.Items.Insert(0, new ListItem(" ", "0"));
                        alternate33.Items.Insert(0, new ListItem(" ", "0"));
                        alternate34.Items.Insert(0, new ListItem(" ", "0"));
                        alternate35.Items.Insert(0, new ListItem(" ", "0"));
                        alternate36.Items.Insert(0, new ListItem(" ", "0"));
                        alternate37.Items.Insert(0, new ListItem(" ", "0"));
                        alternate38.Items.Insert(0, new ListItem(" ", "0"));
                        alternate39.Items.Insert(0, new ListItem(" ", "0"));
                        alternate40.Items.Insert(0, new ListItem(" ", "0"));
                        alternate41.Items.Insert(0, new ListItem(" ", "0"));
                        alternate42.Items.Insert(0, new ListItem(" ", "0"));
                        alternate43.Items.Insert(0, new ListItem(" ", "0"));
                        alternate44.Items.Insert(0, new ListItem(" ", "0"));
                        alternate45.Items.Insert(0, new ListItem(" ", "0"));
                        alternate46.Items.Insert(0, new ListItem(" ", "0"));
                        alternate47.Items.Insert(0, new ListItem(" ", "0"));
                        alternate48.Items.Insert(0, new ListItem(" ", "0"));
                        alternate49.Items.Insert(0, new ListItem(" ", "0"));
                        alternate50.Items.Insert(0, new ListItem(" ", "0"));
                        alternate51.Items.Insert(0, new ListItem(" ", "0"));
                        alternate52.Items.Insert(0, new ListItem(" ", "0"));
                        alternate53.Items.Insert(0, new ListItem(" ", "0"));
                        alternate54.Items.Insert(0, new ListItem(" ", "0"));
                        alternate55.Items.Insert(0, new ListItem(" ", "0"));
                        alternate56.Items.Insert(0, new ListItem(" ", "0"));
                        alternate57.Items.Insert(0, new ListItem(" ", "0"));
                        alternate58.Items.Insert(0, new ListItem(" ", "0"));
                        alternate59.Items.Insert(0, new ListItem(" ", "0"));
                        alternate60.Items.Insert(0, new ListItem(" ", "0"));
                        alternate61.Items.Insert(0, new ListItem(" ", "0"));
                        alternate62.Items.Insert(0, new ListItem(" ", "0"));
                        alternate63.Items.Insert(0, new ListItem(" ", "0"));
                        alternate64.Items.Insert(0, new ListItem(" ", "0"));
                        alternate65.Items.Insert(0, new ListItem(" ", "0"));
                        alternate66.Items.Insert(0, new ListItem(" ", "0"));
                        alternate67.Items.Insert(0, new ListItem(" ", "0"));
                        alternate68.Items.Insert(0, new ListItem(" ", "0"));
                        alternate69.Items.Insert(0, new ListItem(" ", "0"));
                        alternate70.Items.Insert(0, new ListItem(" ", "0"));
                        alternate71.Items.Insert(0, new ListItem(" ", "0"));
                        alternate72.Items.Insert(0, new ListItem(" ", "0"));
                        alternate73.Items.Insert(0, new ListItem(" ", "0"));
                        alternate74.Items.Insert(0, new ListItem(" ", "0"));
                        alternate75.Items.Insert(0, new ListItem(" ", "0"));
                        alternate76.Items.Insert(0, new ListItem(" ", "0"));
                        alternate77.Items.Insert(0, new ListItem(" ", "0"));
                        alternate78.Items.Insert(0, new ListItem(" ", "0"));
                        alternate79.Items.Insert(0, new ListItem(" ", "0"));
                        alternate80.Items.Insert(0, new ListItem(" ", "0"));
                        alternate81.Items.Insert(0, new ListItem(" ", "0"));
                        alternate82.Items.Insert(0, new ListItem(" ", "0"));
                        alternate83.Items.Insert(0, new ListItem(" ", "0"));
                        alternate84.Items.Insert(0, new ListItem(" ", "0"));
                        alternate85.Items.Insert(0, new ListItem(" ", "0"));
                        alternate86.Items.Insert(0, new ListItem(" ", "0"));
                        alternate87.Items.Insert(0, new ListItem(" ", "0"));
                        alternate88.Items.Insert(0, new ListItem(" ", "0"));
                        alternate89.Items.Insert(0, new ListItem(" ", "0"));
                        alternate90.Items.Insert(0, new ListItem(" ", "0"));
                        alternate91.Items.Insert(0, new ListItem(" ", "0"));
                        alternate92.Items.Insert(0, new ListItem(" ", "0"));
                        alternate93.Items.Insert(0, new ListItem(" ", "0"));
                        alternate94.Items.Insert(0, new ListItem(" ", "0"));
                        alternate95.Items.Insert(0, new ListItem(" ", "0"));
                        alternate96.Items.Insert(0, new ListItem(" ", "0"));
                        alternate97.Items.Insert(0, new ListItem(" ", "0"));
                        alternate98.Items.Insert(0, new ListItem(" ", "0"));
                        alternate99.Items.Insert(0, new ListItem(" ", "0"));
                        alternate100.Items.Insert(0, new ListItem(" ", "0"));
                        alternate101.Items.Insert(0, new ListItem(" ", "0"));
                        alternate102.Items.Insert(0, new ListItem(" ", "0"));
                        alternate103.Items.Insert(0, new ListItem(" ", "0"));
                        alternate104.Items.Insert(0, new ListItem(" ", "0"));
                        alternate105.Items.Insert(0, new ListItem(" ", "0"));
                        alternate106.Items.Insert(0, new ListItem(" ", "0"));
                        alternate107.Items.Insert(0, new ListItem(" ", "0"));
                        alternate108.Items.Insert(0, new ListItem(" ", "0"));
                        alternate109.Items.Insert(0, new ListItem(" ", "0"));
                        alternate110.Items.Insert(0, new ListItem(" ", "0"));
                        alternate111.Items.Insert(0, new ListItem(" ", "0"));
                        alternate112.Items.Insert(0, new ListItem(" ", "0"));
                        alternate113.Items.Insert(0, new ListItem(" ", "0"));
                        alternate114.Items.Insert(0, new ListItem(" ", "0"));
                        alternate115.Items.Insert(0, new ListItem(" ", "0"));
                        alternate116.Items.Insert(0, new ListItem(" ", "0"));
                        alternate117.Items.Insert(0, new ListItem(" ", "0"));
                        alternate118.Items.Insert(0, new ListItem(" ", "0"));
                        alternate119.Items.Insert(0, new ListItem(" ", "0"));
                        alternate120.Items.Insert(0, new ListItem(" ", "0"));
                        alternate121.Items.Insert(0, new ListItem(" ", "0"));
                        alternate122.Items.Insert(0, new ListItem(" ", "0"));
                        alternate123.Items.Insert(0, new ListItem(" ", "0"));
                        alternate124.Items.Insert(0, new ListItem(" ", "0"));
                        alternate125.Items.Insert(0, new ListItem(" ", "0"));
                        alternate126.Items.Insert(0, new ListItem(" ", "0"));
                        alternate127.Items.Insert(0, new ListItem(" ", "0"));
                        alternate128.Items.Insert(0, new ListItem(" ", "0"));
                        alternate129.Items.Insert(0, new ListItem(" ", "0"));
                        alternate130.Items.Insert(0, new ListItem(" ", "0"));
                        alternate131.Items.Insert(0, new ListItem(" ", "0"));
                        alternate132.Items.Insert(0, new ListItem(" ", "0"));
                        alternate133.Items.Insert(0, new ListItem(" ", "0"));
                        alternate134.Items.Insert(0, new ListItem(" ", "0"));
                        alternate135.Items.Insert(0, new ListItem(" ", "0"));
                        alternate136.Items.Insert(0, new ListItem(" ", "0"));
                        alternate137.Items.Insert(0, new ListItem(" ", "0"));
                        alternate138.Items.Insert(0, new ListItem(" ", "0"));
                        alternate139.Items.Insert(0, new ListItem(" ", "0"));
                        alternate140.Items.Insert(0, new ListItem(" ", "0"));
                        alternate141.Items.Insert(0, new ListItem(" ", "0"));
                        alternate142.Items.Insert(0, new ListItem(" ", "0"));
                        alternate143.Items.Insert(0, new ListItem(" ", "0"));
                        alternate144.Items.Insert(0, new ListItem(" ", "0"));
                        alternate145.Items.Insert(0, new ListItem(" ", "0"));
                        alternate146.Items.Insert(0, new ListItem(" ", "0"));
                        alternate147.Items.Insert(0, new ListItem(" ", "0"));
                        alternate148.Items.Insert(0, new ListItem(" ", "0"));
                        alternate149.Items.Insert(0, new ListItem(" ", "0"));
                        alternate150.Items.Insert(0, new ListItem(" ", "0"));
                        alternate151.Items.Insert(0, new ListItem(" ", "0"));
                        alternate152.Items.Insert(0, new ListItem(" ", "0"));
                        alternate153.Items.Insert(0, new ListItem(" ", "0"));
                        alternate154.Items.Insert(0, new ListItem(" ", "0"));
                        alternate155.Items.Insert(0, new ListItem(" ", "0"));
                        alternate156.Items.Insert(0, new ListItem(" ", "0"));
                        alternate157.Items.Insert(0, new ListItem(" ", "0"));
                        alternate158.Items.Insert(0, new ListItem(" ", "0"));
                        alternate159.Items.Insert(0, new ListItem(" ", "0"));
                        alternate160.Items.Insert(0, new ListItem(" ", "0"));
                        alternate161.Items.Insert(0, new ListItem(" ", "0"));
                        alternate162.Items.Insert(0, new ListItem(" ", "0"));
                        alternate163.Items.Insert(0, new ListItem(" ", "0"));
                        alternate164.Items.Insert(0, new ListItem(" ", "0"));
                        alternate165.Items.Insert(0, new ListItem(" ", "0"));
                        alternate166.Items.Insert(0, new ListItem(" ", "0"));
                        alternate167.Items.Insert(0, new ListItem(" ", "0"));
                        alternate168.Items.Insert(0, new ListItem(" ", "0"));
                        alternate169.Items.Insert(0, new ListItem(" ", "0"));
                        alternate170.Items.Insert(0, new ListItem(" ", "0"));
                        alternate171.Items.Insert(0, new ListItem(" ", "0"));
                        alternate172.Items.Insert(0, new ListItem(" ", "0"));
                        alternate173.Items.Insert(0, new ListItem(" ", "0"));
                        alternate174.Items.Insert(0, new ListItem(" ", "0"));
                        alternate175.Items.Insert(0, new ListItem(" ", "0"));
                        alternate176.Items.Insert(0, new ListItem(" ", "0"));
                        alternate177.Items.Insert(0, new ListItem(" ", "0"));
                        alternate178.Items.Insert(0, new ListItem(" ", "0"));
                        alternate179.Items.Insert(0, new ListItem(" ", "0"));
                        alternate180.Items.Insert(0, new ListItem(" ", "0"));
                        alternate181.Items.Insert(0, new ListItem(" ", "0"));
                        alternate182.Items.Insert(0, new ListItem(" ", "0"));
                        alternate183.Items.Insert(0, new ListItem(" ", "0"));
                        alternate184.Items.Insert(0, new ListItem(" ", "0"));
                        alternate185.Items.Insert(0, new ListItem(" ", "0"));
                        alternate186.Items.Insert(0, new ListItem(" ", "0"));
                        alternate187.Items.Insert(0, new ListItem(" ", "0"));
                        alternate188.Items.Insert(0, new ListItem(" ", "0"));
                        alternate189.Items.Insert(0, new ListItem(" ", "0"));
                        alternate190.Items.Insert(0, new ListItem(" ", "0"));
                        alternate191.Items.Insert(0, new ListItem(" ", "0"));
                        alternate192.Items.Insert(0, new ListItem(" ", "0"));
                        alternate193.Items.Insert(0, new ListItem(" ", "0"));
                        alternate194.Items.Insert(0, new ListItem(" ", "0"));
                        alternate195.Items.Insert(0, new ListItem(" ", "0"));
                        alternate196.Items.Insert(0, new ListItem(" ", "0"));
                        alternate197.Items.Insert(0, new ListItem(" ", "0"));
                        alternate198.Items.Insert(0, new ListItem(" ", "0"));
                        alternate199.Items.Insert(0, new ListItem(" ", "0"));
                        alternate200.Items.Insert(0, new ListItem(" ", "0"));
                        alternate201.Items.Insert(0, new ListItem(" ", "0"));
                        alternate202.Items.Insert(0, new ListItem(" ", "0"));
                        alternate203.Items.Insert(0, new ListItem(" ", "0"));
                        alternate204.Items.Insert(0, new ListItem(" ", "0"));
                        alternate205.Items.Insert(0, new ListItem(" ", "0"));
                        alternate206.Items.Insert(0, new ListItem(" ", "0"));
                        alternate207.Items.Insert(0, new ListItem(" ", "0"));
                        alternate208.Items.Insert(0, new ListItem(" ", "0"));
                        alternate209.Items.Insert(0, new ListItem(" ", "0"));
                        alternate210.Items.Insert(0, new ListItem(" ", "0"));
                        alternate211.Items.Insert(0, new ListItem(" ", "0"));
                        alternate212.Items.Insert(0, new ListItem(" ", "0"));
                        alternate213.Items.Insert(0, new ListItem(" ", "0"));
                        alternate214.Items.Insert(0, new ListItem(" ", "0"));
                        alternate215.Items.Insert(0, new ListItem(" ", "0"));
                        alternate216.Items.Insert(0, new ListItem(" ", "0"));
                        alternate217.Items.Insert(0, new ListItem(" ", "0"));
                        alternate218.Items.Insert(0, new ListItem(" ", "0"));
                        alternate219.Items.Insert(0, new ListItem(" ", "0"));
                        alternate220.Items.Insert(0, new ListItem(" ", "0"));
                        alternate221.Items.Insert(0, new ListItem(" ", "0"));
                        alternate222.Items.Insert(0, new ListItem(" ", "0"));
                        alternate223.Items.Insert(0, new ListItem(" ", "0"));
                        alternate224.Items.Insert(0, new ListItem(" ", "0"));
                        alternate225.Items.Insert(0, new ListItem(" ", "0"));
                        alternate226.Items.Insert(0, new ListItem(" ", "0"));
                        alternate227.Items.Insert(0, new ListItem(" ", "0"));
                        alternate228.Items.Insert(0, new ListItem(" ", "0"));
                        alternate229.Items.Insert(0, new ListItem(" ", "0"));
                        alternate230.Items.Insert(0, new ListItem(" ", "0"));
                        alternate231.Items.Insert(0, new ListItem(" ", "0"));
                        alternate232.Items.Insert(0, new ListItem(" ", "0"));
                        alternate233.Items.Insert(0, new ListItem(" ", "0"));
                        alternate234.Items.Insert(0, new ListItem(" ", "0"));
                        alternate235.Items.Insert(0, new ListItem(" ", "0"));
                        alternate236.Items.Insert(0, new ListItem(" ", "0"));
                        alternate237.Items.Insert(0, new ListItem(" ", "0"));
                        alternate238.Items.Insert(0, new ListItem(" ", "0"));
                        alternate239.Items.Insert(0, new ListItem(" ", "0"));
                        alternate240.Items.Insert(0, new ListItem(" ", "0"));
                        alternate241.Items.Insert(0, new ListItem(" ", "0"));
                        alternate242.Items.Insert(0, new ListItem(" ", "0"));
                        alternate243.Items.Insert(0, new ListItem(" ", "0"));
                        alternate244.Items.Insert(0, new ListItem(" ", "0"));
                        alternate245.Items.Insert(0, new ListItem(" ", "0"));
                        alternate246.Items.Insert(0, new ListItem(" ", "0"));
                        alternate247.Items.Insert(0, new ListItem(" ", "0"));
                        alternate248.Items.Insert(0, new ListItem(" ", "0"));
                        alternate249.Items.Insert(0, new ListItem(" ", "0"));
                        alternate250.Items.Insert(0, new ListItem(" ", "0"));
                        
                    }
                    using (SqlCommand sqlcmd2 = new SqlCommand())
                    {
                        sqlcmd2.CommandText = "SELECT num from smdpts order by num";
                        sqlcmd2.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //smd pts1
                        smd1.DataSource = dt;
                        smd1.DataValueField = "num";
                        smd1.DataTextField = "num";
                        smd1.DataBind();
                        //smd pts2
                        smd2.DataSource = dt;
                        smd2.DataValueField = "num";
                        smd2.DataTextField = "num";
                        smd2.DataBind();
                        //smd pts3
                        smd3.DataSource = dt;
                        smd3.DataValueField = "num";
                        smd3.DataTextField = "num";
                        smd3.DataBind();
                        //smd pts4
                        smd4.DataSource = dt;
                        smd4.DataValueField = "num";
                        smd4.DataTextField = "num";
                        smd4.DataBind();
                        //smd pts5
                        smd5.DataSource = dt;
                        smd5.DataValueField = "num";
                        smd5.DataTextField = "num";
                        smd5.DataBind();
                        //smd pts6
                        smd6.DataSource = dt;
                        smd6.DataValueField = "num";
                        smd6.DataTextField = "num";
                        smd6.DataBind();
                        //smd pts7
                        smd7.DataSource = dt;
                        smd7.DataValueField = "num";
                        smd7.DataTextField = "num";
                        smd7.DataBind();
                        //smd pts8
                        smd8.DataSource = dt;
                        smd8.DataValueField = "num";
                        smd8.DataTextField = "num";
                        smd8.DataBind();
                        //smd pts9
                        smd9.DataSource = dt;
                        smd9.DataValueField = "num";
                        smd9.DataTextField = "num";
                        smd9.DataBind();
                        //smd pts10
                        smd10.DataSource = dt;
                        smd10.DataValueField = "num";
                        smd10.DataTextField = "num";
                        smd10.DataBind();
                        //smd pts11
                        smd11.DataSource = dt;
                        smd11.DataValueField = "num";
                        smd11.DataTextField = "num";
                        smd11.DataBind();
                        //smd pts12
                        smd12.DataSource = dt;
                        smd12.DataValueField = "num";
                        smd12.DataTextField = "num";
                        smd12.DataBind();
                        //smd pts13
                        smd13.DataSource = dt;
                        smd13.DataValueField = "num";
                        smd13.DataTextField = "num";
                        smd13.DataBind();
                        //smd pts14
                        smd14.DataSource = dt;
                        smd14.DataValueField = "num";
                        smd14.DataTextField = "num";
                        smd14.DataBind();
                        //smd pts15
                        smd15.DataSource = dt;
                        smd15.DataValueField = "num";
                        smd15.DataTextField = "num";
                        smd15.DataBind();
                        //smd pts16
                        smd16.DataSource = dt;
                        smd16.DataValueField = "num";
                        smd16.DataTextField = "num";
                        smd16.DataBind();
                        //smd pts17
                        smd17.DataSource = dt;
                        smd17.DataValueField = "num";
                        smd17.DataTextField = "num";
                        smd17.DataBind();
                        //smd pts18
                        smd18.DataSource = dt;
                        smd18.DataValueField = "num";
                        smd18.DataTextField = "num";
                        smd18.DataBind();
                        //smd pts19
                        smd19.DataSource = dt;
                        smd19.DataValueField = "num";
                        smd19.DataTextField = "num";
                        smd19.DataBind();
                        //smd pts20
                        smd20.DataSource = dt;
                        smd20.DataValueField = "num";
                        smd20.DataTextField = "num";
                        smd20.DataBind();
                        //smd pts21
                        smd21.DataSource = dt;
                        smd21.DataValueField = "num";
                        smd21.DataTextField = "num";
                        smd21.DataBind();
                        //smd pts22
                        smd22.DataSource = dt;
                        smd22.DataValueField = "num";
                        smd22.DataTextField = "num";
                        smd22.DataBind();
                        //smd pts23
                        smd23.DataSource = dt;
                        smd23.DataValueField = "num";
                        smd23.DataTextField = "num";
                        smd23.DataBind();
                        //smd pts24
                        smd24.DataSource = dt;
                        smd24.DataValueField = "num";
                        smd24.DataTextField = "num";
                        smd24.DataBind();
                        //smd pts25
                        smd25.DataSource = dt;
                        smd25.DataValueField = "num";
                        smd25.DataTextField = "num";
                        smd25.DataBind();
                        //smd pts26
                        smd26.DataSource = dt;
                        smd26.DataValueField = "num";
                        smd26.DataTextField = "num";
                        smd26.DataBind();
                        //smd pts27
                        smd27.DataSource = dt;
                        smd27.DataValueField = "num";
                        smd27.DataTextField = "num";
                        smd27.DataBind();
                        //smd pts28
                        smd28.DataSource = dt;
                        smd28.DataValueField = "num";
                        smd28.DataTextField = "num";
                        smd28.DataBind();
                        //smd pts29
                        smd29.DataSource = dt;
                        smd29.DataValueField = "num";
                        smd29.DataTextField = "num";
                        smd29.DataBind();
                        //smd pts30
                        smd30.DataSource = dt;
                        smd30.DataValueField = "num";
                        smd30.DataTextField = "num";
                        smd30.DataBind();
                        //smd pts31
                        smd31.DataSource = dt;
                        smd31.DataValueField = "num";
                        smd31.DataTextField = "num";
                        smd31.DataBind();
                        //smd pts32
                        smd32.DataSource = dt;
                        smd32.DataValueField = "num";
                        smd32.DataTextField = "num";
                        smd32.DataBind();
                        //smd pts33
                        smd33.DataSource = dt;
                        smd33.DataValueField = "num";
                        smd33.DataTextField = "num";
                        smd33.DataBind();
                        //smd pts34
                        smd34.DataSource = dt;
                        smd34.DataValueField = "num";
                        smd34.DataTextField = "num";
                        smd34.DataBind();
                        //smd pts35
                        smd35.DataSource = dt;
                        smd35.DataValueField = "num";
                        smd35.DataTextField = "num";
                        smd35.DataBind();
                        //smd pts36
                        smd36.DataSource = dt;
                        smd36.DataValueField = "num";
                        smd36.DataTextField = "num";
                        smd36.DataBind();
                        //smd pts37
                        smd37.DataSource = dt;
                        smd37.DataValueField = "num";
                        smd37.DataTextField = "num";
                        smd37.DataBind();
                        //smd pts38
                        smd38.DataSource = dt;
                        smd38.DataValueField = "num";
                        smd38.DataTextField = "num";
                        smd38.DataBind();
                        //smd pts39
                        smd39.DataSource = dt;
                        smd39.DataValueField = "num";
                        smd39.DataTextField = "num";
                        smd39.DataBind();
                        //smd pts40
                        smd40.DataSource = dt;
                        smd40.DataValueField = "num";
                        smd40.DataTextField = "num";
                        smd40.DataBind();
                        //smd pts41
                        smd41.DataSource = dt;
                        smd41.DataValueField = "num";
                        smd41.DataTextField = "num";
                        smd41.DataBind();
                        //smd pts42
                        smd42.DataSource = dt;
                        smd42.DataValueField = "num";
                        smd42.DataTextField = "num";
                        smd42.DataBind();
                        //smd pts43
                        smd43.DataSource = dt;
                        smd43.DataValueField = "num";
                        smd43.DataTextField = "num";
                        smd43.DataBind();
                        //smd pts44
                        smd44.DataSource = dt;
                        smd44.DataValueField = "num";
                        smd44.DataTextField = "num";
                        smd44.DataBind();
                        //smd pts45
                        smd45.DataSource = dt;
                        smd45.DataValueField = "num";
                        smd45.DataTextField = "num";
                        smd45.DataBind();
                        //smd pts46
                        smd46.DataSource = dt;
                        smd46.DataValueField = "num";
                        smd46.DataTextField = "num";
                        smd46.DataBind();
                        //smd pts47
                        smd47.DataSource = dt;
                        smd47.DataValueField = "num";
                        smd47.DataTextField = "num";
                        smd47.DataBind();
                        //smd pts48
                        smd48.DataSource = dt;
                        smd48.DataValueField = "num";
                        smd48.DataTextField = "num";
                        smd48.DataBind();
                        //smd pts49
                        smd49.DataSource = dt;
                        smd49.DataValueField = "num";
                        smd49.DataTextField = "num";
                        smd49.DataBind();
                        //smd pts50
                        smd50.DataSource = dt;
                        smd50.DataValueField = "num";
                        smd50.DataTextField = "num";
                        smd50.DataBind();

                        conn.Close();
                        smd1.Items.Insert(0, new ListItem(" ", "0"));
                        smd2.Items.Insert(0, new ListItem(" ", "0"));
                        smd3.Items.Insert(0, new ListItem(" ", "0"));
                        smd4.Items.Insert(0, new ListItem(" ", "0"));
                        smd5.Items.Insert(0, new ListItem(" ", "0"));
                        smd6.Items.Insert(0, new ListItem(" ", "0"));
                        smd7.Items.Insert(0, new ListItem(" ", "0"));
                        smd8.Items.Insert(0, new ListItem(" ", "0"));
                        smd9.Items.Insert(0, new ListItem(" ", "0"));
                        smd10.Items.Insert(0, new ListItem(" ", "0"));
                        smd11.Items.Insert(0, new ListItem(" ", "0"));
                        smd12.Items.Insert(0, new ListItem(" ", "0"));
                        smd13.Items.Insert(0, new ListItem(" ", "0"));
                        smd14.Items.Insert(0, new ListItem(" ", "0"));
                        smd15.Items.Insert(0, new ListItem(" ", "0"));
                        smd16.Items.Insert(0, new ListItem(" ", "0"));
                        smd17.Items.Insert(0, new ListItem(" ", "0"));
                        smd18.Items.Insert(0, new ListItem(" ", "0"));
                        smd19.Items.Insert(0, new ListItem(" ", "0"));
                        smd20.Items.Insert(0, new ListItem(" ", "0"));
                        smd21.Items.Insert(0, new ListItem(" ", "0"));
                        smd22.Items.Insert(0, new ListItem(" ", "0"));
                        smd23.Items.Insert(0, new ListItem(" ", "0"));
                        smd24.Items.Insert(0, new ListItem(" ", "0"));
                        smd25.Items.Insert(0, new ListItem(" ", "0"));
                        smd26.Items.Insert(0, new ListItem(" ", "0"));
                        smd27.Items.Insert(0, new ListItem(" ", "0"));
                        smd28.Items.Insert(0, new ListItem(" ", "0"));
                        smd29.Items.Insert(0, new ListItem(" ", "0"));
                        smd30.Items.Insert(0, new ListItem(" ", "0"));
                        smd31.Items.Insert(0, new ListItem(" ", "0"));
                        smd32.Items.Insert(0, new ListItem(" ", "0"));
                        smd33.Items.Insert(0, new ListItem(" ", "0"));
                        smd34.Items.Insert(0, new ListItem(" ", "0"));
                        smd35.Items.Insert(0, new ListItem(" ", "0"));
                        smd36.Items.Insert(0, new ListItem(" ", "0"));
                        smd37.Items.Insert(0, new ListItem(" ", "0"));
                        smd38.Items.Insert(0, new ListItem(" ", "0"));
                        smd39.Items.Insert(0, new ListItem(" ", "0"));
                        smd40.Items.Insert(0, new ListItem(" ", "0"));
                        smd41.Items.Insert(0, new ListItem(" ", "0"));
                        smd42.Items.Insert(0, new ListItem(" ", "0"));
                        smd43.Items.Insert(0, new ListItem(" ", "0"));
                        smd44.Items.Insert(0, new ListItem(" ", "0"));
                        smd45.Items.Insert(0, new ListItem(" ", "0"));
                        smd46.Items.Insert(0, new ListItem(" ", "0"));
                        smd47.Items.Insert(0, new ListItem(" ", "0"));
                        smd48.Items.Insert(0, new ListItem(" ", "0"));
                        smd49.Items.Insert(0, new ListItem(" ", "0"));
                        smd50.Items.Insert(0, new ListItem(" ", "0"));

                    }
                    using (SqlCommand sqlcmd3 = new SqlCommand())
                    {
                        sqlcmd3.CommandText = "SELECT num from thpts order by num";
                        sqlcmd3.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd3);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //th1
                        th1.DataSource = dt;
                        th1.DataValueField = "num";
                        th1.DataTextField = "num";
                        th1.DataBind();
                        //th2
                        th2.DataSource = dt;
                        th2.DataValueField = "num";
                        th2.DataTextField = "num";
                        th2.DataBind();
                        //th3
                        th3.DataSource = dt;
                        th3.DataValueField = "num";
                        th3.DataTextField = "num";
                        th3.DataBind();
                        //th4
                        th4.DataSource = dt;
                        th4.DataValueField = "num";
                        th4.DataTextField = "num";
                        th4.DataBind();
                        //th5
                        th5.DataSource = dt;
                        th5.DataValueField = "num";
                        th5.DataTextField = "num";
                        th5.DataBind();
                        //th6
                        th6.DataSource = dt;
                        th6.DataValueField = "num";
                        th6.DataTextField = "num";
                        th6.DataBind();
                        //th7
                        th7.DataSource = dt;
                        th7.DataValueField = "num";
                        th7.DataTextField = "num";
                        th7.DataBind();
                        //th8
                        th8.DataSource = dt;
                        th8.DataValueField = "num";
                        th8.DataTextField = "num";
                        th8.DataBind();
                        //th9
                        th9.DataSource = dt;
                        th9.DataValueField = "num";
                        th9.DataTextField = "num";
                        th9.DataBind();
                        //th10
                        th10.DataSource = dt;
                        th10.DataValueField = "num";
                        th10.DataTextField = "num";
                        th10.DataBind();
                        //th11
                        th11.DataSource = dt;
                        th11.DataValueField = "num";
                        th11.DataTextField = "num";
                        th11.DataBind();
                        //th12
                        th12.DataSource = dt;
                        th12.DataValueField = "num";
                        th12.DataTextField = "num";
                        th12.DataBind();
                        //th13
                        th13.DataSource = dt;
                        th13.DataValueField = "num";
                        th13.DataTextField = "num";
                        th13.DataBind();
                        //th14
                        th14.DataSource = dt;
                        th14.DataValueField = "num";
                        th14.DataTextField = "num";
                        th14.DataBind();
                        //th15
                        th15.DataSource = dt;
                        th15.DataValueField = "num";
                        th15.DataTextField = "num";
                        th15.DataBind();
                        //th16
                        th16.DataSource = dt;
                        th16.DataValueField = "num";
                        th16.DataTextField = "num";
                        th16.DataBind();
                        //th17
                        th17.DataSource = dt;
                        th17.DataValueField = "num";
                        th17.DataTextField = "num";
                        th17.DataBind();
                        //th18
                        th18.DataSource = dt;
                        th18.DataValueField = "num";
                        th18.DataTextField = "num";
                        th18.DataBind();
                        //th19
                        th19.DataSource = dt;
                        th19.DataValueField = "num";
                        th19.DataTextField = "num";
                        th19.DataBind();
                        //th20
                        th20.DataSource = dt;
                        th20.DataValueField = "num";
                        th20.DataTextField = "num";
                        th20.DataBind();
                        //th21
                        th21.DataSource = dt;
                        th21.DataValueField = "num";
                        th21.DataTextField = "num";
                        th21.DataBind();
                        //th22
                        th22.DataSource = dt;
                        th22.DataValueField = "num";
                        th22.DataTextField = "num";
                        th22.DataBind();
                        //th23
                        th23.DataSource = dt;
                        th23.DataValueField = "num";
                        th23.DataTextField = "num";
                        th23.DataBind();
                        //th24
                        th24.DataSource = dt;
                        th24.DataValueField = "num";
                        th24.DataTextField = "num";
                        th24.DataBind();
                        //th25
                        th25.DataSource = dt;
                        th25.DataValueField = "num";
                        th25.DataTextField = "num";
                        th25.DataBind();
                        //th26
                        th26.DataSource = dt;
                        th26.DataValueField = "num";
                        th26.DataTextField = "num";
                        th26.DataBind();
                        //th27
                        th27.DataSource = dt;
                        th27.DataValueField = "num";
                        th27.DataTextField = "num";
                        th27.DataBind();
                        //th28
                        th28.DataSource = dt;
                        th28.DataValueField = "num";
                        th28.DataTextField = "num";
                        th28.DataBind();
                        //th29
                        th29.DataSource = dt;
                        th29.DataValueField = "num";
                        th29.DataTextField = "num";
                        th29.DataBind();
                        //th30
                        th30.DataSource = dt;
                        th30.DataValueField = "num";
                        th30.DataTextField = "num";
                        th30.DataBind();
                        //th31
                        th31.DataSource = dt;
                        th31.DataValueField = "num";
                        th31.DataTextField = "num";
                        th31.DataBind();
                        //th32
                        th32.DataSource = dt;
                        th32.DataValueField = "num";
                        th32.DataTextField = "num";
                        th32.DataBind();
                        //th33
                        th33.DataSource = dt;
                        th33.DataValueField = "num";
                        th33.DataTextField = "num";
                        th33.DataBind();
                        //th34
                        th34.DataSource = dt;
                        th34.DataValueField = "num";
                        th34.DataTextField = "num";
                        th34.DataBind();
                        //th35
                        th35.DataSource = dt;
                        th35.DataValueField = "num";
                        th35.DataTextField = "num";
                        th35.DataBind();
                        //th36
                        th36.DataSource = dt;
                        th36.DataValueField = "num";
                        th36.DataTextField = "num";
                        th36.DataBind();
                        //th37
                        th37.DataSource = dt;
                        th37.DataValueField = "num";
                        th37.DataTextField = "num";
                        th37.DataBind();
                        //th38
                        th38.DataSource = dt;
                        th38.DataValueField = "num";
                        th38.DataTextField = "num";
                        th38.DataBind();
                        //th39
                        th39.DataSource = dt;
                        th39.DataValueField = "num";
                        th39.DataTextField = "num";
                        th39.DataBind();
                        //th40
                        th40.DataSource = dt;
                        th40.DataValueField = "num";
                        th40.DataTextField = "num";
                        th40.DataBind();
                        //th41
                        th41.DataSource = dt;
                        th41.DataValueField = "num";
                        th41.DataTextField = "num";
                        th41.DataBind();
                        //th42
                        th42.DataSource = dt;
                        th42.DataValueField = "num";
                        th42.DataTextField = "num";
                        th42.DataBind();
                        //th43
                        th43.DataSource = dt;
                        th43.DataValueField = "num";
                        th43.DataTextField = "num";
                        th43.DataBind();
                        //th44
                        th44.DataSource = dt;
                        th44.DataValueField = "num";
                        th44.DataTextField = "num";
                        th44.DataBind();
                        //th45
                        th45.DataSource = dt;
                        th45.DataValueField = "num";
                        th45.DataTextField = "num";
                        th45.DataBind();
                        //th46
                        th46.DataSource = dt;
                        th46.DataValueField = "num";
                        th46.DataTextField = "num";
                        th46.DataBind();
                        //th47
                        th47.DataSource = dt;
                        th47.DataValueField = "num";
                        th47.DataTextField = "num";
                        th47.DataBind();
                        //th48
                        th48.DataSource = dt;
                        th48.DataValueField = "num";
                        th48.DataTextField = "num";
                        th48.DataBind();
                        //th49
                        th49.DataSource = dt;
                        th49.DataValueField = "num";
                        th49.DataTextField = "num";
                        th49.DataBind();
                        //th50
                        th50.DataSource = dt;
                        th50.DataValueField = "num";
                        th50.DataTextField = "num";
                        th50.DataBind();

                        conn.Close();
                        th1.Items.Insert(0, new ListItem(" ", "0"));
                        th2.Items.Insert(0, new ListItem(" ", "0"));
                        th3.Items.Insert(0, new ListItem(" ", "0"));
                        th4.Items.Insert(0, new ListItem(" ", "0"));
                        th5.Items.Insert(0, new ListItem(" ", "0"));
                        th6.Items.Insert(0, new ListItem(" ", "0"));
                        th7.Items.Insert(0, new ListItem(" ", "0"));
                        th8.Items.Insert(0, new ListItem(" ", "0"));
                        th9.Items.Insert(0, new ListItem(" ", "0"));
                        th10.Items.Insert(0, new ListItem(" ", "0"));
                        th11.Items.Insert(0, new ListItem(" ", "0"));
                        th12.Items.Insert(0, new ListItem(" ", "0"));
                        th13.Items.Insert(0, new ListItem(" ", "0"));
                        th14.Items.Insert(0, new ListItem(" ", "0"));
                        th15.Items.Insert(0, new ListItem(" ", "0"));
                        th16.Items.Insert(0, new ListItem(" ", "0"));
                        th17.Items.Insert(0, new ListItem(" ", "0"));
                        th18.Items.Insert(0, new ListItem(" ", "0"));
                        th19.Items.Insert(0, new ListItem(" ", "0"));
                        th20.Items.Insert(0, new ListItem(" ", "0"));
                        th21.Items.Insert(0, new ListItem(" ", "0"));
                        th22.Items.Insert(0, new ListItem(" ", "0"));
                        th23.Items.Insert(0, new ListItem(" ", "0"));
                        th24.Items.Insert(0, new ListItem(" ", "0"));
                        th25.Items.Insert(0, new ListItem(" ", "0"));
                        th26.Items.Insert(0, new ListItem(" ", "0"));
                        th27.Items.Insert(0, new ListItem(" ", "0"));
                        th28.Items.Insert(0, new ListItem(" ", "0"));
                        th29.Items.Insert(0, new ListItem(" ", "0"));
                        th30.Items.Insert(0, new ListItem(" ", "0"));
                        th31.Items.Insert(0, new ListItem(" ", "0"));
                        th32.Items.Insert(0, new ListItem(" ", "0"));
                        th33.Items.Insert(0, new ListItem(" ", "0"));
                        th34.Items.Insert(0, new ListItem(" ", "0"));
                        th35.Items.Insert(0, new ListItem(" ", "0"));
                        th36.Items.Insert(0, new ListItem(" ", "0"));
                        th37.Items.Insert(0, new ListItem(" ", "0"));
                        th38.Items.Insert(0, new ListItem(" ", "0"));
                        th39.Items.Insert(0, new ListItem(" ", "0"));
                        th40.Items.Insert(0, new ListItem(" ", "0"));
                        th41.Items.Insert(0, new ListItem(" ", "0"));
                        th42.Items.Insert(0, new ListItem(" ", "0"));
                        th43.Items.Insert(0, new ListItem(" ", "0"));
                        th44.Items.Insert(0, new ListItem(" ", "0"));
                        th45.Items.Insert(0, new ListItem(" ", "0"));
                        th46.Items.Insert(0, new ListItem(" ", "0"));
                        th47.Items.Insert(0, new ListItem(" ", "0"));
                        th48.Items.Insert(0, new ListItem(" ", "0"));
                        th49.Items.Insert(0, new ListItem(" ", "0"));
                        th50.Items.Insert(0, new ListItem(" ", "0"));

                    }
                    using (SqlCommand sqlcmd1 = new SqlCommand())
                    {
                        sqlcmd1.CommandText = "SELECT process_name from production_process order by process_name asc";
                        sqlcmd1.Connection = conn;
                        conn.Open();

                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //ddlprocessname1
                        ddlprocessname1.DataSource = dt;
                        ddlprocessname1.DataValueField = "process_name";
                        ddlprocessname1.DataTextField = "process_name";
                        ddlprocessname1.DataBind();
                        //ddlprocessname2
                        ddlprocessname2.DataSource = dt;
                        ddlprocessname2.DataValueField = "process_name";
                        ddlprocessname2.DataTextField = "process_name";
                        ddlprocessname2.DataBind();
                        //ddlprocessname3
                        ddlprocessname3.DataSource = dt;
                        ddlprocessname3.DataValueField = "process_name";
                        ddlprocessname3.DataTextField = "process_name";
                        ddlprocessname3.DataBind();
                        //ddlprocessname4
                        ddlprocessname4.DataSource = dt;
                        ddlprocessname4.DataValueField = "process_name";
                        ddlprocessname4.DataTextField = "process_name";
                        ddlprocessname4.DataBind();
                        //ddlprocessname5
                        ddlprocessname5.DataSource = dt;
                        ddlprocessname5.DataValueField = "process_name";
                        ddlprocessname5.DataTextField = "process_name";
                        ddlprocessname5.DataBind();
                        //ddlprocessname6
                        ddlprocessname6.DataSource = dt;
                        ddlprocessname6.DataValueField = "process_name";
                        ddlprocessname6.DataTextField = "process_name";
                        ddlprocessname6.DataBind();
                        //ddlprocessname7
                        ddlprocessname7.DataSource = dt;
                        ddlprocessname7.DataValueField = "process_name";
                        ddlprocessname7.DataTextField = "process_name";
                        ddlprocessname7.DataBind();
                        //ddlprocessname8
                        ddlprocessname8.DataSource = dt;
                        ddlprocessname8.DataValueField = "process_name";
                        ddlprocessname8.DataTextField = "process_name";
                        ddlprocessname8.DataBind();
                        //ddlprocessname9
                        ddlprocessname9.DataSource = dt;
                        ddlprocessname9.DataValueField = "process_name";
                        ddlprocessname9.DataTextField = "process_name";
                        ddlprocessname9.DataBind();
                        //ddlprocessname10
                        ddlprocessname10.DataSource = dt;
                        ddlprocessname10.DataValueField = "process_name";
                        ddlprocessname10.DataTextField = "process_name";
                        ddlprocessname10.DataBind();
                        //ddlprocessname11
                        ddlprocessname11.DataSource = dt;
                        ddlprocessname11.DataValueField = "process_name";
                        ddlprocessname11.DataTextField = "process_name";
                        ddlprocessname11.DataBind();
                        //ddlprocessname12
                        ddlprocessname12.DataSource = dt;
                        ddlprocessname12.DataValueField = "process_name";
                        ddlprocessname12.DataTextField = "process_name";
                        ddlprocessname12.DataBind();
                        //ddlprocessname13
                        ddlprocessname13.DataSource = dt;
                        ddlprocessname13.DataValueField = "process_name";
                        ddlprocessname13.DataTextField = "process_name";
                        ddlprocessname13.DataBind();
                        //ddlprocessname14
                        ddlprocessname14.DataSource = dt;
                        ddlprocessname14.DataValueField = "process_name";
                        ddlprocessname14.DataTextField = "process_name";
                        ddlprocessname14.DataBind();
                        //ddlprocessname15
                        ddlprocessname15.DataSource = dt;
                        ddlprocessname15.DataValueField = "process_name";
                        ddlprocessname15.DataTextField = "process_name";
                        ddlprocessname15.DataBind();
                        //ddlprocessname16
                        ddlprocessname16.DataSource = dt;
                        ddlprocessname16.DataValueField = "process_name";
                        ddlprocessname16.DataTextField = "process_name";
                        ddlprocessname16.DataBind();
                        //ddlprocessname17
                        ddlprocessname17.DataSource = dt;
                        ddlprocessname17.DataValueField = "process_name";
                        ddlprocessname17.DataTextField = "process_name";
                        ddlprocessname17.DataBind();
                        //ddlprocessname18
                        ddlprocessname18.DataSource = dt;
                        ddlprocessname18.DataValueField = "process_name";
                        ddlprocessname18.DataTextField = "process_name";
                        ddlprocessname18.DataBind();
                        //ddlprocessname19
                        ddlprocessname19.DataSource = dt;
                        ddlprocessname19.DataValueField = "process_name";
                        ddlprocessname19.DataTextField = "process_name";
                        ddlprocessname19.DataBind();
                        //ddlprocessname19
                        ddlprocessname20.DataSource = dt;
                        ddlprocessname20.DataValueField = "process_name";
                        ddlprocessname20.DataTextField = "process_name";
                        ddlprocessname20.DataBind();

                        conn.Close();

                         ddlprocessname1.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname2.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname3.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname4.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname5.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname6.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname7.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname8.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname9.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname10.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname11.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname12.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname13.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname14.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname15.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname16.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname17.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname18.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname19.Items.Insert(0, new ListItem("please select", "0"));
                         ddlprocessname20.Items.Insert(0, new ListItem("please select", "0"));

                    }
                }
            }
            catch (Exception ex)
            {
                string message = " "+ex.Message;
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
        protected void sessiondata()
        {
           
            if (Session["revision_no"] != null)
            {
                TextBox1.Text = Session["num"].ToString();
                TextBox2.Text = Session["bomdate"].ToString();
                TextBox4.Text = Session["revision_no"].ToString();
                TextBox5.Text = Session["revision_date"].ToString();
                DropDownList2.Text = Session["category"].ToString();
                DropDownList1.Text = Session["partno"].ToString();
                TextBox6.Text = Session["description"].ToString();
                TextBox9.Text = Session["approvedby"].ToString();
               
            }
            string[] partno = (string[])Session["partno1"];
            string[] description = (string[])Session["description1"];
            string[] unit = (string[])Session["units"];
            string[] alt1 = (string[])Session["alt1"];
            string[] alt2 = (string[])Session["alt2"];
            string[] alt3 = (string[])Session["alt3"];
            string[] alt4 = (string[])Session["alt4"];
            string[] alt5 = (string[])Session["alt5"];
            string[] spq = (string[])Session["spq"];
            string[] moq = (string[])Session["moq"];
            string[] qty = (string[])Session["qty"];
            string[] rate = (string[])Session["rate"];
            string[] wastage = (string[])Session["wastage"];
            string[] amount = (string[])Session["amount"];
            string[] process = (string[])Session["process"];
            string[] per = (string[])Session["per"];
            string[] time = (string[])Session["time"];
            string[] amount1 = (string[])Session["amount1"];
            string[] overhead = (string[])Session["overheadname"];
            string[] per1 = (string[])Session["per1"];
            string[] amount2 = (string[])Session["amount2"];
            string[] smd = (string[])Session["smd"];
            string[] th = (string[])Session["th"];
            short[] smd1a = (short[])Session["smd"];
            short[] th1a = (short[])Session["th"];

            if(Session["partno1"]!=null)
            {
            for (int k = 0; k < partno.Length; k++)
            {
                if (partno[k] != null)
                {
                    if (k == 0)
                    {
                        ddlitemcode1.Text = partno[k].ToString();
                        T1.Text = description[k].ToString();
                        T2.Text = unit[k].ToString();
                        T3.Text = spq[k].ToString();
                        T4.Text = moq[k].ToString();
                        T5.Text = qty[k].ToString();
                        T6.Text = rate[k].ToString();
                        T7.Text = wastage[k].ToString();
                        T8.Text = amount[k].ToString();
                        alternate1.SelectedItem.Text = alt1[k].ToString();
                        alternate2.SelectedItem.Text = alt2[k].ToString();
                        alternate3.SelectedItem.Text = alt3[k].ToString();
                        alternate4.SelectedItem.Text = alt4[k].ToString();
                        alternate5.SelectedItem.Text = alt5[k].ToString();
                       
                    }
                    if (k == 1)
                    {
                        ddlitemcode2.Text = partno[k].ToString();
                        T9.Text = description[k].ToString();
                        T10.Text = unit[k].ToString();
                        T11.Text = spq[k].ToString();
                        T12.Text = moq[k].ToString();
                        T13.Text = qty[k].ToString();
                        T14.Text = rate[k].ToString();
                        T15.Text = wastage[k].ToString();
                        T16.Text = amount[k].ToString();

                        alternate6.SelectedItem.Text = alt1[k].ToString();
                        alternate7.SelectedItem.Text = alt2[k].ToString();
                        alternate8.SelectedItem.Text = alt3[k].ToString();
                        alternate9.SelectedItem.Text = alt4[k].ToString();
                        alternate10.SelectedItem.Text = alt5[k].ToString();
                     
                    }
                    if (k == 2)
                    {
                        ddlitemcode3.Text = partno[k].ToString();
                        T17.Text = description[k].ToString();
                        T18.Text = unit[k].ToString();
                        T19.Text = spq[k].ToString();
                        T20.Text = moq[k].ToString();
                        T21.Text = qty[k].ToString();
                        T22.Text = rate[k].ToString();
                        T23.Text = wastage[k].ToString();
                        T24.Text = amount[k].ToString();
                        alternate11.SelectedItem.Text = alt1[k].ToString();
                        alternate12.SelectedItem.Text = alt2[k].ToString();
                        alternate13.SelectedItem.Text = alt3[k].ToString();
                        alternate14.SelectedItem.Text = alt4[k].ToString();
                        alternate15.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 3)
                    {
                        ddlitemcode4.Text = partno[k].ToString();
                        T25.Text = description[k].ToString();
                        T26.Text = unit[k].ToString();
                        T27.Text = spq[k].ToString();
                        T28.Text = moq[k].ToString();
                        T29.Text = qty[k].ToString();
                        T30.Text = rate[k].ToString();
                        T31.Text = wastage[k].ToString();
                        T32.Text = amount[k].ToString();
                        alternate16.SelectedItem.Text = alt1[k].ToString();
                        alternate17.SelectedItem.Text = alt2[k].ToString();
                        alternate18.SelectedItem.Text = alt3[k].ToString();
                        alternate19.SelectedItem.Text = alt4[k].ToString();
                        alternate20.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 4)
                    {
                        ddlitemcode5.Text = partno[k].ToString();
                        T33.Text = description[k].ToString();
                        T34.Text = unit[k].ToString();
                        T35.Text = spq[k].ToString();
                        T36.Text = moq[k].ToString();
                        T37.Text = qty[k].ToString();
                        T38.Text = rate[k].ToString();
                        T39.Text = wastage[k].ToString();
                        T40.Text = amount[k].ToString();
                        alternate21.SelectedItem.Text = alt1[k].ToString();
                        alternate22.SelectedItem.Text = alt2[k].ToString();
                        alternate23.SelectedItem.Text = alt3[k].ToString();
                        alternate24.SelectedItem.Text = alt4[k].ToString();
                        alternate25.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 5)
                    {
                        ddlitemcode6.Text = partno[k].ToString();
                        T41.Text = description[k].ToString();
                        T42.Text = unit[k].ToString();
                        T43.Text = spq[k].ToString();
                        T44.Text = moq[k].ToString();
                        T45.Text = qty[k].ToString();
                        T46.Text = rate[k].ToString();
                        T47.Text = wastage[k].ToString();
                        T48.Text = amount[k].ToString();
                        alternate26.SelectedItem.Text = alt1[k].ToString();
                        alternate27.SelectedItem.Text = alt2[k].ToString();
                        alternate28.SelectedItem.Text = alt3[k].ToString();
                        alternate29.SelectedItem.Text = alt4[k].ToString();
                        alternate30.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 6)
                    {
                        ddlitemcode7.Text = partno[k].ToString();
                        T49.Text = description[k].ToString();
                        T50.Text = unit[k].ToString();
                        T51.Text = spq[k].ToString();
                        T52.Text = moq[k].ToString();
                        T53.Text = qty[k].ToString();
                        T54.Text = rate[k].ToString();
                        T55.Text = wastage[k].ToString();
                        T56.Text = amount[k].ToString();
                        alternate31.SelectedItem.Text = alt1[k].ToString();
                        alternate32.SelectedItem.Text = alt2[k].ToString();
                        alternate33.SelectedItem.Text = alt3[k].ToString();
                        alternate34.SelectedItem.Text = alt4[k].ToString();
                        alternate35.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 7)
                    {
                        ddlitemcode8.Text = partno[k].ToString();
                        T57.Text = description[k].ToString();
                        T58.Text = unit[k].ToString();
                        T59.Text = spq[k].ToString();
                        T60.Text = moq[k].ToString();
                        T61.Text = qty[k].ToString();
                        T62.Text = rate[k].ToString();
                        T63.Text = wastage[k].ToString();
                        T64.Text = amount[k].ToString();
                        alternate36.SelectedItem.Text = alt1[k].ToString();
                        alternate37.SelectedItem.Text = alt2[k].ToString();
                        alternate38.SelectedItem.Text = alt3[k].ToString();
                        alternate39.SelectedItem.Text = alt4[k].ToString();
                        alternate40.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 8)
                    {
                        ddlitemcode9.Text = partno[k].ToString();
                        T65.Text = description[k].ToString();
                        T66.Text = unit[k].ToString();
                        T67.Text = spq[k].ToString();
                        T68.Text = moq[k].ToString();
                        T69.Text = qty[k].ToString();
                        T70.Text = rate[k].ToString();
                        T71.Text = wastage[k].ToString();
                        T72.Text = amount[k].ToString();
                        alternate41.SelectedItem.Text = alt1[k].ToString();
                        alternate42.SelectedItem.Text = alt2[k].ToString();
                        alternate43.SelectedItem.Text = alt3[k].ToString();
                        alternate44.SelectedItem.Text = alt4[k].ToString();
                        alternate45.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 9)
                    {
                        ddlitemcode10.Text = partno[k].ToString();
                        T73.Text = description[k].ToString();
                        T74.Text = unit[k].ToString();
                        T75.Text = spq[k].ToString();
                        T76.Text = moq[k].ToString();
                        T77.Text = qty[k].ToString();
                        T78.Text = rate[k].ToString();
                        T79.Text = wastage[k].ToString();
                        T80.Text = amount[k].ToString();
                        alternate46.SelectedItem.Text = alt1[k].ToString();
                        alternate47.SelectedItem.Text = alt2[k].ToString();
                        alternate48.SelectedItem.Text = alt3[k].ToString();
                        alternate49.SelectedItem.Text = alt4[k].ToString();
                        alternate50.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 10)
                    {
                        ddlitemcode11.Text = partno[k].ToString();
                        T81.Text = description[k].ToString();
                        T82.Text = unit[k].ToString();
                        T83.Text = spq[k].ToString();
                        T84.Text = moq[k].ToString();
                        T85.Text = qty[k].ToString();
                        T86.Text = rate[k].ToString();
                        T87.Text = wastage[k].ToString();
                        T88.Text = amount[k].ToString();
                        alternate51.SelectedItem.Text = alt1[k].ToString();
                        alternate52.SelectedItem.Text = alt2[k].ToString();
                        alternate53.SelectedItem.Text = alt3[k].ToString();
                        alternate54.SelectedItem.Text = alt4[k].ToString();
                        alternate55.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 11)
                    {
                        ddlitemcode12.Text = partno[k].ToString();
                        T89.Text = description[k].ToString();
                        T90.Text = unit[k].ToString();
                        T91.Text = spq[k].ToString();
                        T92.Text = moq[k].ToString();
                        T93.Text = qty[k].ToString();
                        T94.Text = rate[k].ToString();
                        T95.Text = wastage[k].ToString();
                        T96.Text = amount[k].ToString();
                        alternate56.SelectedItem.Text = alt1[k].ToString();
                        alternate57.SelectedItem.Text = alt2[k].ToString();
                        alternate58.SelectedItem.Text = alt3[k].ToString();
                        alternate59.SelectedItem.Text = alt4[k].ToString();
                        alternate60.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 12)
                    {
                        ddlitemcode13.Text = partno[k].ToString();
                        T97.Text = description[k].ToString();
                        T98.Text = unit[k].ToString();
                        T99.Text = spq[k].ToString();
                        T100.Text = moq[k].ToString();
                        T101.Text = qty[k].ToString();
                        T102.Text = rate[k].ToString();
                        T103.Text = wastage[k].ToString();
                        T104.Text = amount[k].ToString();
                        alternate61.SelectedItem.Text = alt1[k].ToString();
                        alternate62.SelectedItem.Text = alt2[k].ToString();
                        alternate63.SelectedItem.Text = alt3[k].ToString();
                        alternate64.SelectedItem.Text = alt4[k].ToString();
                        alternate65.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 13)
                    {
                        ddlitemcode14.Text = partno[k].ToString();
                        T105.Text = description[k].ToString();
                        T106.Text = unit[k].ToString();
                        T107.Text = spq[k].ToString();
                        T108.Text = moq[k].ToString();
                        T109.Text = qty[k].ToString();
                        T110.Text = rate[k].ToString();
                        T111.Text = wastage[k].ToString();
                        T112.Text = amount[k].ToString();
                        alternate66.SelectedItem.Text = alt1[k].ToString();
                        alternate67.SelectedItem.Text = alt2[k].ToString();
                        alternate68.SelectedItem.Text = alt3[k].ToString();
                        alternate69.SelectedItem.Text = alt4[k].ToString();
                        alternate70.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 14)
                    {
                        ddlitemcode15.Text = partno[k].ToString();
                        T113.Text = description[k].ToString();
                        T114.Text = unit[k].ToString();
                        T115.Text = spq[k].ToString();
                        T116.Text = moq[k].ToString();
                        T117.Text = qty[k].ToString();
                        T118.Text = rate[k].ToString();
                        T119.Text = wastage[k].ToString();
                        T120.Text = amount[k].ToString();
                        alternate71.SelectedItem.Text = alt1[k].ToString();
                        alternate72.SelectedItem.Text = alt2[k].ToString();
                        alternate73.SelectedItem.Text = alt3[k].ToString();
                        alternate74.SelectedItem.Text = alt4[k].ToString();
                        alternate75.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 15)
                    {
                        ddlitemcode16.Text = partno[k].ToString();
                        T121.Text = description[k].ToString();
                        T122.Text = unit[k].ToString();
                        T123.Text = spq[k].ToString();
                        T124.Text = moq[k].ToString();
                        T125.Text = qty[k].ToString();
                        T126.Text = rate[k].ToString();
                        T127.Text = wastage[k].ToString();
                        T128.Text = amount[k].ToString();
                        alternate76.SelectedItem.Text = alt1[k].ToString();
                        alternate77.SelectedItem.Text = alt2[k].ToString();
                        alternate78.SelectedItem.Text = alt3[k].ToString();
                        alternate79.SelectedItem.Text = alt4[k].ToString();
                        alternate80.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 16)
                    {
                        ddlitemcode17.Text = partno[k].ToString();
                        T129.Text = description[k].ToString();
                        T130.Text = unit[k].ToString();
                        T131.Text = spq[k].ToString();
                        T132.Text = moq[k].ToString();
                        T133.Text = qty[k].ToString();
                        T134.Text = rate[k].ToString();
                        T135.Text = wastage[k].ToString();
                        T136.Text = amount[k].ToString();
                        alternate81.SelectedItem.Text = alt1[k].ToString();
                        alternate82.SelectedItem.Text = alt2[k].ToString();
                        alternate83.SelectedItem.Text = alt3[k].ToString();
                        alternate84.SelectedItem.Text = alt4[k].ToString();
                        alternate85.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 17)
                    {
                        ddlitemcode18.Text = partno[k].ToString();
                        T137.Text = description[k].ToString();
                        T138.Text = unit[k].ToString();
                        T139.Text = spq[k].ToString();
                        T140.Text = moq[k].ToString();
                        T141.Text = qty[k].ToString();
                        T142.Text = rate[k].ToString();
                        T143.Text = wastage[k].ToString();
                        T144.Text = amount[k].ToString();
                        alternate86.SelectedItem.Text = alt1[k].ToString();
                        alternate87.SelectedItem.Text = alt2[k].ToString();
                        alternate88.SelectedItem.Text = alt3[k].ToString();
                        alternate89.SelectedItem.Text = alt4[k].ToString();
                        alternate90.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 18)
                    {
                        ddlitemcode19.Text = partno[k].ToString();
                        T145.Text = description[k].ToString();
                        T146.Text = unit[k].ToString();
                        T147.Text = spq[k].ToString();
                        T148.Text = moq[k].ToString();
                        T149.Text = qty[k].ToString();
                        T150.Text = rate[k].ToString();
                        T151.Text = wastage[k].ToString();
                        T152.Text = amount[k].ToString();
                        alternate91.SelectedItem.Text = alt1[k].ToString();
                        alternate92.SelectedItem.Text = alt2[k].ToString();
                        alternate93.SelectedItem.Text = alt3[k].ToString();
                        alternate94.SelectedItem.Text = alt4[k].ToString();
                        alternate95.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 19)
                    {
                        ddlitemcode20.Text = partno[k].ToString();
                        T153.Text = description[k].ToString();
                        T154.Text = unit[k].ToString();
                        T155.Text = spq[k].ToString();
                        T156.Text = moq[k].ToString();
                        T157.Text = qty[k].ToString();
                        T158.Text = rate[k].ToString();
                        T159.Text = wastage[k].ToString();
                        T160.Text = amount[k].ToString();
                        alternate96.SelectedItem.Text = alt1[k].ToString();
                        alternate97.SelectedItem.Text = alt2[k].ToString();
                        alternate98.SelectedItem.Text = alt3[k].ToString();
                        alternate99.SelectedItem.Text = alt4[k].ToString();
                        alternate100.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 20)
                    {
                        ddlitemcode21.Text = partno[k].ToString();
                        T161.Text = description[k].ToString();
                        T162.Text = unit[k].ToString();
                        T163.Text = spq[k].ToString();
                        T164.Text = moq[k].ToString();
                        T165.Text = qty[k].ToString();
                        T166.Text = rate[k].ToString();
                        T167.Text = wastage[k].ToString();
                        T168.Text = amount[k].ToString();
                        alternate101.SelectedItem.Text = alt1[k].ToString();
                        alternate102.SelectedItem.Text = alt2[k].ToString();
                        alternate103.SelectedItem.Text = alt3[k].ToString();
                        alternate104.SelectedItem.Text = alt4[k].ToString();
                        alternate105.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 21)
                    {
                        ddlitemcode22.Text = partno[k].ToString();
                        T169.Text = description[k].ToString();
                        T170.Text = unit[k].ToString();
                        T171.Text = spq[k].ToString();
                        T172.Text = moq[k].ToString();
                        T173.Text = qty[k].ToString();
                        T174.Text = rate[k].ToString();
                        T175.Text = wastage[k].ToString();
                        T176.Text = amount[k].ToString();
                        alternate106.SelectedItem.Text = alt1[k].ToString();
                        alternate107.SelectedItem.Text = alt2[k].ToString();
                        alternate108.SelectedItem.Text = alt3[k].ToString();
                        alternate109.SelectedItem.Text = alt4[k].ToString();
                        alternate110.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 22)
                    {
                        ddlitemcode23.Text = partno[k].ToString();
                        T177.Text = description[k].ToString();
                        T178.Text = unit[k].ToString();
                        T179.Text = spq[k].ToString();
                        T180.Text = moq[k].ToString();
                        T181.Text = qty[k].ToString();
                        T182.Text = rate[k].ToString();
                        T183.Text = wastage[k].ToString();
                        T184.Text = amount[k].ToString();
                        alternate111.SelectedItem.Text = alt1[k].ToString();
                        alternate112.SelectedItem.Text = alt2[k].ToString();
                        alternate113.SelectedItem.Text = alt3[k].ToString();
                        alternate114.SelectedItem.Text = alt4[k].ToString();
                        alternate115.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 23)
                    {
                        ddlitemcode24.Text = partno[k].ToString();
                        T185.Text = description[k].ToString();
                        T186.Text = unit[k].ToString();
                        T187.Text = spq[k].ToString();
                        T188.Text = moq[k].ToString();
                        T189.Text = qty[k].ToString();
                        T190.Text = rate[k].ToString();
                        T191.Text = wastage[k].ToString();
                        T192.Text = amount[k].ToString();
                        alternate116.SelectedItem.Text = alt1[k].ToString();
                        alternate117.SelectedItem.Text = alt2[k].ToString();
                        alternate118.SelectedItem.Text = alt3[k].ToString();
                        alternate119.SelectedItem.Text = alt4[k].ToString();
                        alternate120.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 24)
                    {
                        ddlitemcode25.Text = partno[k].ToString();
                        T193.Text = description[k].ToString();
                        T194.Text = unit[k].ToString();
                        T195.Text = spq[k].ToString();
                        T196.Text = moq[k].ToString();
                        T197.Text = qty[k].ToString();
                        T198.Text = rate[k].ToString();
                        T199.Text = wastage[k].ToString();
                        T200.Text = amount[k].ToString();
                        alternate121.SelectedItem.Text = alt1[k].ToString();
                        alternate122.SelectedItem.Text = alt2[k].ToString();
                        alternate123.SelectedItem.Text = alt3[k].ToString();
                        alternate124.SelectedItem.Text = alt4[k].ToString();
                        alternate125.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 25)
                    {
                        ddlitemcode26.Text = partno[k].ToString();
                        T201.Text = description[k].ToString();
                        T202.Text = unit[k].ToString();
                        T203.Text = spq[k].ToString();
                        T204.Text = moq[k].ToString();
                        T205.Text = qty[k].ToString();
                        T206.Text = rate[k].ToString();
                        T207.Text = wastage[k].ToString();
                        T208.Text = amount[k].ToString();
                        alternate126.SelectedItem.Text = alt1[k].ToString();
                        alternate127.SelectedItem.Text = alt2[k].ToString();
                        alternate128.SelectedItem.Text = alt3[k].ToString();
                        alternate129.SelectedItem.Text = alt4[k].ToString();
                        alternate130.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 26)
                    {
                        ddlitemcode27.Text = partno[k].ToString();
                        T209.Text = description[k].ToString();
                        T210.Text = unit[k].ToString();
                        T211.Text = spq[k].ToString();
                        T212.Text = moq[k].ToString();
                        T213.Text = qty[k].ToString();
                        T214.Text = rate[k].ToString();
                        T215.Text = wastage[k].ToString();
                        T216.Text = amount[k].ToString();
                        alternate131.SelectedItem.Text = alt1[k].ToString();
                        alternate132.SelectedItem.Text = alt2[k].ToString();
                        alternate133.SelectedItem.Text = alt3[k].ToString();
                        alternate134.SelectedItem.Text = alt4[k].ToString();
                        alternate135.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 27)
                    {
                        ddlitemcode28.Text = partno[k].ToString();
                        T217.Text = description[k].ToString();
                        T218.Text = unit[k].ToString();
                        T219.Text = spq[k].ToString();
                        T220.Text = moq[k].ToString();
                        T221.Text = qty[k].ToString();
                        T222.Text = rate[k].ToString();
                        T223.Text = wastage[k].ToString();
                        T224.Text = amount[k].ToString();
                        alternate136.SelectedItem.Text = alt1[k].ToString();
                        alternate137.SelectedItem.Text = alt2[k].ToString();
                        alternate138.SelectedItem.Text = alt3[k].ToString();
                        alternate139.SelectedItem.Text = alt4[k].ToString();
                        alternate140.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 28)
                    {
                        ddlitemcode29.Text = partno[k].ToString();
                        T225.Text = description[k].ToString();
                        T226.Text = unit[k].ToString();
                        T227.Text = spq[k].ToString();
                        T228.Text = moq[k].ToString();
                        T229.Text = qty[k].ToString();
                        T230.Text = rate[k].ToString();
                        T231.Text = wastage[k].ToString();
                        T232.Text = amount[k].ToString();
                        alternate141.SelectedItem.Text = alt1[k].ToString();
                        alternate142.SelectedItem.Text = alt2[k].ToString();
                        alternate143.SelectedItem.Text = alt3[k].ToString();
                        alternate144.SelectedItem.Text = alt4[k].ToString();
                        alternate145.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 29)
                    {
                        ddlitemcode30.Text = partno[k].ToString();
                        T233.Text = description[k].ToString();
                        T234.Text = unit[k].ToString();
                        T235.Text = spq[k].ToString();
                        T236.Text = moq[k].ToString();
                        T237.Text = qty[k].ToString();
                        T238.Text = rate[k].ToString();
                        T239.Text = wastage[k].ToString();
                        T240.Text = amount[k].ToString();
                        alternate146.SelectedItem.Text = alt1[k].ToString();
                        alternate147.SelectedItem.Text = alt2[k].ToString();
                        alternate148.SelectedItem.Text = alt3[k].ToString();
                        alternate149.SelectedItem.Text = alt4[k].ToString();
                        alternate150.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 30)
                    {
                        ddlitemcode31.Text = partno[k].ToString();
                        T241.Text = description[k].ToString();
                        T242.Text = unit[k].ToString();
                        T243.Text = spq[k].ToString();
                        T244.Text = moq[k].ToString();
                        T245.Text = qty[k].ToString();
                        T246.Text = rate[k].ToString();
                        T247.Text = wastage[k].ToString();
                        T248.Text = amount[k].ToString();
                        alternate151.SelectedItem.Text = alt1[k].ToString();
                        alternate152.SelectedItem.Text = alt2[k].ToString();
                        alternate153.SelectedItem.Text = alt3[k].ToString();
                        alternate154.SelectedItem.Text = alt4[k].ToString();
                        alternate155.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 31)
                    {
                        ddlitemcode32.Text = partno[k].ToString();
                        T249.Text = description[k].ToString();
                        T250.Text = unit[k].ToString();
                        T251.Text = spq[k].ToString();
                        T252.Text = moq[k].ToString();
                        T253.Text = qty[k].ToString();
                        T254.Text = rate[k].ToString();
                        T255.Text = wastage[k].ToString();
                        T256.Text = amount[k].ToString();
                        alternate156.SelectedItem.Text = alt1[k].ToString();
                        alternate157.SelectedItem.Text = alt2[k].ToString();
                        alternate158.SelectedItem.Text = alt3[k].ToString();
                        alternate159.SelectedItem.Text = alt4[k].ToString();
                        alternate160.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 32)
                    {
                        ddlitemcode33.Text = partno[k].ToString();
                        T257.Text = description[k].ToString();
                        T258.Text = unit[k].ToString();
                        T259.Text = spq[k].ToString();
                        T260.Text = moq[k].ToString();
                        T261.Text = qty[k].ToString();
                        T262.Text = rate[k].ToString();
                        T263.Text = wastage[k].ToString();
                        T264.Text = amount[k].ToString();
                        alternate161.SelectedItem.Text = alt1[k].ToString();
                        alternate162.SelectedItem.Text = alt2[k].ToString();
                        alternate163.SelectedItem.Text = alt3[k].ToString();
                        alternate164.SelectedItem.Text = alt4[k].ToString();
                        alternate165.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 33)
                    {
                        ddlitemcode34.Text = partno[k].ToString();
                        T265.Text = description[k].ToString();
                        T266.Text = unit[k].ToString();
                        T267.Text = spq[k].ToString();
                        T268.Text = moq[k].ToString();
                        T269.Text = qty[k].ToString();
                        T270.Text = rate[k].ToString();
                        T271.Text = wastage[k].ToString();
                        T272.Text = amount[k].ToString();
                        alternate166.SelectedItem.Text = alt1[k].ToString();
                        alternate167.SelectedItem.Text = alt2[k].ToString();
                        alternate168.SelectedItem.Text = alt3[k].ToString();
                        alternate169.SelectedItem.Text = alt4[k].ToString();
                        alternate170.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 34)
                    {
                        ddlitemcode35.Text = partno[k].ToString();
                        T273.Text = description[k].ToString();
                        T274.Text = unit[k].ToString();
                        T275.Text = spq[k].ToString();
                        T276.Text = moq[k].ToString();
                        T277.Text = qty[k].ToString();
                        T278.Text = rate[k].ToString();
                        T279.Text = wastage[k].ToString();
                        T280.Text = amount[k].ToString();
                        alternate171.SelectedItem.Text = alt1[k].ToString();
                        alternate172.SelectedItem.Text = alt2[k].ToString();
                        alternate173.SelectedItem.Text = alt3[k].ToString();
                        alternate174.SelectedItem.Text = alt4[k].ToString();
                        alternate175.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 35)
                    {
                        ddlitemcode36.Text = partno[k].ToString();
                        T281.Text = description[k].ToString();
                        T282.Text = unit[k].ToString();
                        T283.Text = spq[k].ToString();
                        T284.Text = moq[k].ToString();
                        T285.Text = qty[k].ToString();
                        T286.Text = rate[k].ToString();
                        T287.Text = wastage[k].ToString();
                        T288.Text = amount[k].ToString();
                        alternate176.SelectedItem.Text = alt1[k].ToString();
                        alternate177.SelectedItem.Text = alt2[k].ToString();
                        alternate178.SelectedItem.Text = alt3[k].ToString();
                        alternate179.SelectedItem.Text = alt4[k].ToString();
                        alternate180.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 36)
                    {
                        ddlitemcode37.Text = partno[k].ToString();
                        T289.Text = description[k].ToString();
                        T290.Text = unit[k].ToString();
                        T291.Text = spq[k].ToString();
                        T292.Text = moq[k].ToString();
                        T293.Text = qty[k].ToString();
                        T294.Text = rate[k].ToString();
                        T295.Text = wastage[k].ToString();
                        T296.Text = amount[k].ToString();
                        alternate181.SelectedItem.Text = alt1[k].ToString();
                        alternate182.SelectedItem.Text = alt2[k].ToString();
                        alternate183.SelectedItem.Text = alt3[k].ToString();
                        alternate184.SelectedItem.Text = alt4[k].ToString();
                        alternate185.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 37)
                    {
                        ddlitemcode38.Text = partno[k].ToString();
                        T297.Text = description[k].ToString();
                        T298.Text = unit[k].ToString();
                        T299.Text = spq[k].ToString();
                        T300.Text = moq[k].ToString();
                        T301.Text = qty[k].ToString();
                        T302.Text = rate[k].ToString();
                        T303.Text = wastage[k].ToString();
                        T304.Text = amount[k].ToString();
                        alternate186.SelectedItem.Text = alt1[k].ToString();
                        alternate187.SelectedItem.Text = alt2[k].ToString();
                        alternate188.SelectedItem.Text = alt3[k].ToString();
                        alternate189.SelectedItem.Text = alt4[k].ToString();
                        alternate190.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 38)
                    {
                        ddlitemcode39.Text = partno[k].ToString();
                        T305.Text = description[k].ToString();
                        T306.Text = unit[k].ToString();
                        T307.Text = spq[k].ToString();
                        T308.Text = moq[k].ToString();
                        T309.Text = qty[k].ToString();
                        T310.Text = rate[k].ToString();
                        T311.Text = wastage[k].ToString();
                        T312.Text = amount[k].ToString();
                        alternate191.SelectedItem.Text = alt1[k].ToString();
                        alternate192.SelectedItem.Text = alt2[k].ToString();
                        alternate193.SelectedItem.Text = alt3[k].ToString();
                        alternate194.SelectedItem.Text = alt4[k].ToString();
                        alternate195.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 39)
                    {
                        ddlitemcode40.Text = partno[k].ToString();
                        T313.Text = description[k].ToString();
                        T314.Text = unit[k].ToString();
                        T315.Text = spq[k].ToString();
                        T316.Text = moq[k].ToString();
                        T317.Text = qty[k].ToString();
                        T318.Text = rate[k].ToString();
                        T319.Text = wastage[k].ToString();
                        T320.Text = amount[k].ToString();
                        alternate196.SelectedItem.Text = alt1[k].ToString();
                        alternate197.SelectedItem.Text = alt2[k].ToString();
                        alternate198.SelectedItem.Text = alt3[k].ToString();
                        alternate199.SelectedItem.Text = alt4[k].ToString();
                        alternate200.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 40)
                    {
                        ddlitemcode41.Text = partno[k].ToString();
                        T321.Text = description[k].ToString();
                        T322.Text = unit[k].ToString();
                        T323.Text = spq[k].ToString();
                        T324.Text = moq[k].ToString();
                        T325.Text = qty[k].ToString();
                        T326.Text = rate[k].ToString();
                        T327.Text = wastage[k].ToString();
                        T328.Text = amount[k].ToString();
                        alternate201.SelectedItem.Text = alt1[k].ToString();
                        alternate202.SelectedItem.Text = alt2[k].ToString();
                        alternate203.SelectedItem.Text = alt3[k].ToString();
                        alternate204.SelectedItem.Text = alt4[k].ToString();
                        alternate205.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 41)
                    {
                        ddlitemcode42.Text = partno[k].ToString();
                        T329.Text = description[k].ToString();
                        T330.Text = unit[k].ToString();
                        T331.Text = spq[k].ToString();
                        T332.Text = moq[k].ToString();
                        T333.Text = qty[k].ToString();
                        T334.Text = rate[k].ToString();
                        T335.Text = wastage[k].ToString();
                        T336.Text = amount[k].ToString();
                        alternate206.SelectedItem.Text = alt1[k].ToString();
                        alternate207.SelectedItem.Text = alt2[k].ToString();
                        alternate208.SelectedItem.Text = alt3[k].ToString();
                        alternate209.SelectedItem.Text = alt4[k].ToString();
                        alternate210.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 42)
                    {
                        ddlitemcode43.Text = partno[k].ToString();
                        T337.Text = description[k].ToString();
                        T338.Text = unit[k].ToString();
                        T339.Text = spq[k].ToString();
                        T340.Text = moq[k].ToString();
                        T341.Text = qty[k].ToString();
                        T342.Text = rate[k].ToString();
                        T343.Text = wastage[k].ToString();
                        T344.Text = amount[k].ToString();
                        alternate211.SelectedItem.Text = alt1[k].ToString();
                        alternate212.SelectedItem.Text = alt2[k].ToString();
                        alternate213.SelectedItem.Text = alt3[k].ToString();
                        alternate214.SelectedItem.Text = alt4[k].ToString();
                        alternate215.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 43)
                    {
                        ddlitemcode44.Text = partno[k].ToString();
                        T345.Text = description[k].ToString();
                        T346.Text = unit[k].ToString();
                        T347.Text = spq[k].ToString();
                        T348.Text = moq[k].ToString();
                        T349.Text = qty[k].ToString();
                        T350.Text = rate[k].ToString();
                        T351.Text = wastage[k].ToString();
                        T352.Text = amount[k].ToString();
                        alternate216.SelectedItem.Text = alt1[k].ToString();
                        alternate217.SelectedItem.Text = alt2[k].ToString();
                        alternate218.SelectedItem.Text = alt3[k].ToString();
                        alternate219.SelectedItem.Text = alt4[k].ToString();
                        alternate220.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 44)
                    {
                        ddlitemcode45.Text = partno[k].ToString();
                        T353.Text = description[k].ToString();
                        T354.Text = unit[k].ToString();
                        T355.Text = spq[k].ToString();
                        T356.Text = moq[k].ToString();
                        T357.Text = qty[k].ToString();
                        T358.Text = rate[k].ToString();
                        T359.Text = wastage[k].ToString();
                        T360.Text = amount[k].ToString();
                        alternate221.SelectedItem.Text = alt1[k].ToString();
                        alternate222.SelectedItem.Text = alt2[k].ToString();
                        alternate223.SelectedItem.Text = alt3[k].ToString();
                        alternate224.SelectedItem.Text = alt4[k].ToString();
                        alternate225.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 45)
                    {
                        ddlitemcode46.Text = partno[k].ToString();
                        T361.Text = description[k].ToString();
                        T362.Text = unit[k].ToString();
                        T363.Text = spq[k].ToString();
                        T364.Text = moq[k].ToString();
                        T365.Text = qty[k].ToString();
                        T366.Text = rate[k].ToString();
                        T367.Text = wastage[k].ToString();
                        T368.Text = amount[k].ToString();
                        alternate226.SelectedItem.Text = alt1[k].ToString();
                        alternate227.SelectedItem.Text = alt2[k].ToString();
                        alternate228.SelectedItem.Text = alt3[k].ToString();
                        alternate229.SelectedItem.Text = alt4[k].ToString();
                        alternate230.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 46)
                    {
                        ddlitemcode47.Text = partno[k].ToString();
                        T369.Text = description[k].ToString();
                        T370.Text = unit[k].ToString();
                        T371.Text = spq[k].ToString();
                        T372.Text = moq[k].ToString();
                        T373.Text = qty[k].ToString();
                        T374.Text = rate[k].ToString();
                        T375.Text = wastage[k].ToString();
                        T376.Text = amount[k].ToString();
                        alternate231.SelectedItem.Text = alt1[k].ToString();
                        alternate232.SelectedItem.Text = alt2[k].ToString();
                        alternate233.SelectedItem.Text = alt3[k].ToString();
                        alternate234.SelectedItem.Text = alt4[k].ToString();
                        alternate235.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 47)
                    {
                        ddlitemcode48.Text = partno[k].ToString();
                        T377.Text = description[k].ToString();
                        T378.Text = unit[k].ToString();
                        T379.Text = spq[k].ToString();
                        T380.Text = moq[k].ToString();
                        T381.Text = qty[k].ToString();
                        T382.Text = rate[k].ToString();
                        T383.Text = wastage[k].ToString();
                        T384.Text = amount[k].ToString();
                        alternate236.SelectedItem.Text = alt1[k].ToString();
                        alternate237.SelectedItem.Text = alt2[k].ToString();
                        alternate238.SelectedItem.Text = alt3[k].ToString();
                        alternate239.SelectedItem.Text = alt4[k].ToString();
                        alternate240.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 48)
                    {
                        ddlitemcode49.Text = partno[k].ToString();
                        T385.Text = description[k].ToString();
                        T386.Text = unit[k].ToString();
                        T387.Text = spq[k].ToString();
                        T388.Text = moq[k].ToString();
                        T389.Text = qty[k].ToString();
                        T390.Text = rate[k].ToString();
                        T391.Text = wastage[k].ToString();
                        T392.Text = amount[k].ToString();
                        alternate241.SelectedItem.Text = alt1[k].ToString();
                        alternate242.SelectedItem.Text = alt2[k].ToString();
                        alternate243.SelectedItem.Text = alt3[k].ToString();
                        alternate244.SelectedItem.Text = alt4[k].ToString();
                        alternate245.SelectedItem.Text = alt5[k].ToString();
                    }
                    if (k == 49)
                    {
                        ddlitemcode50.Text = partno[k].ToString();
                        T393.Text = description[k].ToString();
                        T394.Text = unit[k].ToString();
                        T395.Text = spq[k].ToString();
                        T396.Text = moq[k].ToString();
                        T397.Text = qty[k].ToString();
                        T398.Text = rate[k].ToString();
                        T399.Text = wastage[k].ToString();
                        T400.Text = amount[k].ToString();
                        alternate246.SelectedItem.Text = alt1[k].ToString();
                        alternate247.SelectedItem.Text = alt2[k].ToString();
                        alternate248.SelectedItem.Text = alt3[k].ToString();
                        alternate249.SelectedItem.Text = alt4[k].ToString();
                        alternate250.SelectedItem.Text = alt5[k].ToString();
                    }
                }
                }
              //  i = i + 1;
            }
            if (Session["process"] != null)
            {
                for (int j = 0; j < process.Length; j++)
                {
                    if (process[j] != null)
                    {
                        if (j == 0)
                        {
                            ddlprocessname1.Text = process[j].ToString();
                            time1.Text = time[j].ToString();
                            P1.Text = per[j].ToString();
                            P2.Text = amount1[j].ToString();
                        }
                        if (j == 1)
                        {
                            ddlprocessname2.Text = process[j].ToString();
                            time2.Text = time[j].ToString();
                            P3.Text = per[j].ToString();
                            P4.Text = amount1[j].ToString();
                        }
                        if (j == 2)
                        {
                            ddlprocessname3.Text = process[j].ToString();
                            time3.Text = time[j].ToString();
                            P5.Text = per[j].ToString();
                            P6.Text = amount1[j].ToString();
                        }
                        if (j == 3)
                        {
                            ddlprocessname4.Text = process[j].ToString();
                            time4.Text = time[j].ToString();
                            P7.Text = per[j].ToString();
                            P8.Text = amount1[j].ToString();
                        }
                        if (j == 4)
                        {
                            ddlprocessname5.Text = process[j].ToString();
                            time5.Text = time[j].ToString();
                            P9.Text = per[j].ToString();
                            P10.Text = amount1[j].ToString();
                        }
                        if (j == 5)
                        {
                            ddlprocessname6.Text = process[j].ToString();
                            time6.Text = time[j].ToString();
                            P11.Text = per[j].ToString();
                            P12.Text = amount1[j].ToString();
                        }
                        if (j == 6)
                        {
                            ddlprocessname7.Text = process[j].ToString();
                            time7.Text = time[j].ToString();
                            P13.Text = per[j].ToString();
                            P14.Text = amount1[j].ToString();
                        }
                        if (j == 7)
                        {
                            ddlprocessname8.Text = process[j].ToString();
                            time8.Text = time[j].ToString();
                            P15.Text = per[j].ToString();
                            P16.Text = amount1[j].ToString();
                        }
                        if (j == 8)
                        {
                            ddlprocessname9.Text = process[j].ToString();
                            time9.Text = time[j].ToString();
                            P17.Text = per[j].ToString();
                            P18.Text = amount1[j].ToString();
                        }
                        if (j == 9)
                        {
                            ddlprocessname10.Text = process[j].ToString();
                            time10.Text = time[j].ToString();
                            P19.Text = per[j].ToString();
                            P20.Text = amount1[j].ToString();
                        }
                        if (j == 10)
                        {
                            ddlprocessname11.Text = process[j].ToString();
                            time11.Text = time[j].ToString();
                            P21.Text = per[j].ToString();
                            P22.Text = amount1[j].ToString();
                        }
                        if (j == 11)
                        {
                            ddlprocessname12.Text = process[j].ToString();
                            time12.Text = time[j].ToString();
                            P23.Text = per[j].ToString();
                            P24.Text = amount1[j].ToString();
                        }
                        if (j == 12)
                        {
                            ddlprocessname13.Text = process[j].ToString();
                            time13.Text = time[j].ToString();
                            P25.Text = per[j].ToString();
                            P26.Text = amount1[j].ToString();
                        }
                        if (j == 13)
                        {
                            ddlprocessname14.Text = process[j].ToString();
                            time14.Text = time[j].ToString();
                            P27.Text = per[j].ToString();
                            P28.Text = amount1[j].ToString();
                        }
                        if (j == 14)
                        {
                            ddlprocessname15.Text = process[j].ToString();
                            time15.Text = time[j].ToString();
                            P29.Text = per[j].ToString();
                            P30.Text = amount1[j].ToString();
                        }
                        if (j == 15)
                        {
                            ddlprocessname16.Text = process[j].ToString();
                            time16.Text = time[j].ToString();
                            P31.Text = per[j].ToString();
                            P32.Text = amount1[j].ToString();
                        }
                        if (j == 16)
                        {
                            ddlprocessname17.Text = process[j].ToString();
                            time17.Text = time[j].ToString();
                            P33.Text = per[j].ToString();
                            P34.Text = amount1[j].ToString();
                        }
                        if (j == 17)
                        {
                            ddlprocessname18.Text = process[j].ToString();
                            time18.Text = time[j].ToString();
                            P35.Text = per[j].ToString();
                            P36.Text = amount1[j].ToString();
                        }
                        if (j == 18)
                        {
                            ddlprocessname19.Text = process[j].ToString();
                            time19.Text = time[j].ToString();
                            P37.Text = per[j].ToString();
                            P38.Text = amount1[j].ToString();
                        }
                        if (j == 19)
                        {
                            ddlprocessname20.Text = process[j].ToString();
                            time20.Text = time[j].ToString();
                            P39.Text = per[j].ToString();
                            P40.Text = amount1[j].ToString();
                        }

                    }
                }
            }
            if (Session["overheadname"] != null)
            {
                for (int i = 0; i < overhead.Length; i++)
                {
                    if (overhead[i] != null)
                    {
                        if (i == 0)
                        {
                            O1.Text = overhead[i].ToString();
                            O2.Text = per1[i].ToString();
                            O3.Text = amount2[i].ToString();
                        }
                        if (i == 1)
                        {
                            O4.Text = overhead[i].ToString();
                            O5.Text = per1[i].ToString();
                            O6.Text = amount2[i].ToString();
                        }
                        if (i == 2)
                        {
                            O7.Text = overhead[i].ToString();
                            O8.Text = per1[i].ToString();
                            O9.Text = amount2[i].ToString();
                        }
                        if (i == 3)
                        {
                            O10.Text = overhead[i].ToString();
                            O11.Text = per1[i].ToString();
                            O12.Text = amount2[i].ToString();
                        }
                        if (i == 4)
                        {
                            O13.Text = overhead[i].ToString();
                            O14.Text = per1[i].ToString();
                            O15.Text = amount2[i].ToString();
                        }
                        if (i == 5)
                        {
                            O16.Text = overhead[i].ToString();
                            O17.Text = per1[i].ToString();
                            O18.Text = amount2[i].ToString();
                        }
                        if (i == 6)
                        {
                            O19.Text = overhead[i].ToString();
                            O20.Text = per1[i].ToString();
                            O21.Text = amount2[i].ToString();
                        }
                        if (i == 7)
                        {
                            O22.Text = overhead[i].ToString();
                            O23.Text = per1[i].ToString();
                            O24.Text = amount2[i].ToString();
                        }
                        if (i == 8)
                        {
                            O25.Text = overhead[i].ToString();
                            O26.Text = per1[i].ToString();
                            O27.Text = amount2[i].ToString();
                        }
                        if (i == 9)
                        {
                            O28.Text = overhead[i].ToString();
                            O29.Text = per1[i].ToString();
                            O30.Text = amount2[i].ToString();
                        }
                        if (i == 10)
                        {
                            O31.Text = overhead[i].ToString();
                            O32.Text = per1[i].ToString();
                            O33.Text = amount2[i].ToString();
                        }
                        if (i == 11)
                        {
                            O34.Text = overhead[i].ToString();
                            O35.Text = per1[i].ToString();
                            O36.Text = amount2[i].ToString();
                        }
                        if (i == 12)
                        {
                            O37.Text = overhead[i].ToString();
                            O38.Text = per1[i].ToString();
                            O39.Text = amount2[i].ToString();
                        }
                        if (i == 13)
                        {
                            O40.Text = overhead[i].ToString();
                            O41.Text = per1[i].ToString();
                            O42.Text = amount2[i].ToString();
                        }
                        if (i == 14)
                        {
                            O43.Text = overhead[i].ToString();
                            O44.Text = per1[i].ToString();
                            O45.Text = amount2[i].ToString();
                        }
                        if (i == 15)
                        {
                            O46.Text = overhead[i].ToString();
                            O47.Text = per1[i].ToString();
                            O48.Text = amount2[i].ToString();
                        }
                        if (i == 16)
                        {
                            O49.Text = overhead[i].ToString();
                            O50.Text = per1[i].ToString();
                            O51.Text = amount2[i].ToString();
                        }
                        if (i == 17)
                        {
                            O52.Text = overhead[i].ToString();
                            O53.Text = per1[i].ToString();
                            O54.Text = amount2[i].ToString();
                        }
                        if (i == 18)
                        {
                            O55.Text = overhead[i].ToString();
                            O56.Text = per1[i].ToString();
                            O57.Text = amount2[i].ToString();
                        }
                        if (i == 19)
                        {
                            O58.Text = overhead[i].ToString();
                            O59.Text = per1[i].ToString();
                            O60.Text = amount2[i].ToString();
                        }

                    }
                }
            }
        }
        protected void ddlitemcode1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd=new SqlCommand("SELECT * from partno where partno='"+ddlitemcode1.SelectedItem.Text+"'",conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T1.Text = itemname;
            T2.Text = unit;
            T3.Text = spq;
            T4.Text = moq;
            alternate1.SelectedItem.Text = alt1;
            alternate2.SelectedItem.Text = alt2;
            alternate3.SelectedItem.Text = alt3;
            alternate4.SelectedItem.Text = alt4;
            alternate5.SelectedItem.Text = alt5;
        }

        protected void ddlitemcode2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode2.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T9.Text = itemname;
            T10.Text = unit;
            T11.Text = spq;
            T12.Text = moq;
            alternate6.SelectedItem.Text = alt1;
            alternate7.SelectedItem.Text = alt2;
            alternate8.SelectedItem.Text = alt3;
            alternate9.SelectedItem.Text = alt4;
            alternate10.SelectedItem.Text = alt5;
        }

        protected void ddlitemcode3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode3.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T17.Text = itemname;
            T18.Text = unit;
            T19.Text = spq;
            T20.Text = moq;
            alternate11.SelectedItem.Text = alt1;
            alternate12.SelectedItem.Text = alt2;
            alternate13.SelectedItem.Text = alt3;
            alternate14.SelectedItem.Text = alt4;
            alternate15.SelectedItem.Text = alt5;
            
            
        }

        protected void ddlitemcode4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode4.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T25.Text = itemname;
            T26.Text = unit;
            T27.Text = spq;
            T28.Text = moq;
            alternate16.SelectedItem.Text = alt1;
            alternate17.SelectedItem.Text = alt2;
            alternate18.SelectedItem.Text = alt3;
            alternate19.SelectedItem.Text = alt4;
            alternate20.SelectedItem.Text = alt5;
            
           
        }

        protected void ddlitemcode5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode5.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T33.Text = itemname;
            T34.Text = unit;
            T35.Text = spq;
            T36.Text = moq;
            alternate21.SelectedItem.Text = alt1;
            alternate22.SelectedItem.Text = alt2;
            alternate23.SelectedItem.Text = alt3;
            alternate24.SelectedItem.Text = alt4;
            alternate25.SelectedItem.Text = alt5;
           
           
        }

        protected void ddlitemcode6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode6.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T41.Text = itemname;
            T42.Text = unit;
            T43.Text = spq;
            T44.Text = moq;
            alternate26.SelectedItem.Text = alt1;
            alternate27.SelectedItem.Text = alt2;
            alternate28.SelectedItem.Text = alt3;
            alternate29.SelectedItem.Text = alt4;
            alternate30.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode7.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T49.Text = itemname;
            T50.Text = unit;
            T51.Text = spq;
            T52.Text = moq;
            alternate31.SelectedItem.Text = alt1;
            alternate32.SelectedItem.Text = alt2;
            alternate33.SelectedItem.Text = alt3;
            alternate34.SelectedItem.Text = alt4;
            alternate35.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode8.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T57.Text = itemname;
            T58.Text = unit;
            T59.Text = spq;
            T60.Text = moq;
            alternate36.SelectedItem.Text = alt1;
            alternate37.SelectedItem.Text = alt2;
            alternate38.SelectedItem.Text = alt3;
            alternate39.SelectedItem.Text = alt4;
            alternate40.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode9.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T65.Text = itemname;
            T66.Text = unit;
            T67.Text = spq;
            T68.Text = moq;
            alternate41.SelectedItem.Text = alt1;
            alternate42.SelectedItem.Text = alt2;
            alternate43.SelectedItem.Text = alt3;
            alternate44.SelectedItem.Text = alt4;
            alternate45.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode10_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode10.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T73.Text = itemname;
            T74.Text = unit;
            T75.Text = spq;
            T76.Text = moq;
            alternate46.SelectedItem.Text = alt1;
            alternate47.SelectedItem.Text = alt2;
            alternate48.SelectedItem.Text = alt3;
            alternate49.SelectedItem.Text = alt4;
            alternate50.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode11.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T81.Text = itemname;
            T82.Text = unit;
            T83.Text = spq;
            T84.Text = moq;
            alternate51.SelectedItem.Text = alt1;
            alternate52.SelectedItem.Text = alt2;
            alternate53.SelectedItem.Text = alt3;
            alternate54.SelectedItem.Text = alt4;
            alternate55.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode12.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T89.Text = itemname;
            T90.Text = unit;
            T91.Text = spq;
            T92.Text = moq;
            alternate56.SelectedItem.Text = alt1;
            alternate57.SelectedItem.Text = alt2;
            alternate58.SelectedItem.Text = alt3;
            alternate59.SelectedItem.Text = alt4;
            alternate60.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode13_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode13.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T97.Text = itemname;
            T98.Text = unit;
            T99.Text = spq;
            T100.Text = moq;
            alternate61.SelectedItem.Text = alt1;
            alternate62.SelectedItem.Text = alt2;
            alternate63.SelectedItem.Text = alt3;
            alternate64.SelectedItem.Text = alt4;
            alternate65.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode14_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode14.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T105.Text = itemname;
            T106.Text = unit;
            T107.Text = spq;
            T108.Text = moq;
            alternate66.SelectedItem.Text = alt1;
            alternate67.SelectedItem.Text = alt2;
            alternate68.SelectedItem.Text = alt3;
            alternate69.SelectedItem.Text = alt4;
            alternate70.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode15_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode15.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T113.Text = itemname;
            T114.Text = unit;
            T115.Text = spq;
            T116.Text = moq;
            alternate71.SelectedItem.Text = alt1;
            alternate72.SelectedItem.Text = alt2;
            alternate73.SelectedItem.Text = alt3;
            alternate74.SelectedItem.Text = alt4;
            alternate75.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode16_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode16.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T121.Text = itemname;
            T122.Text = unit;
            T123.Text = spq;
            T124.Text = moq;
            alternate76.SelectedItem.Text = alt1;
            alternate77.SelectedItem.Text = alt2;
            alternate78.SelectedItem.Text = alt3;
            alternate79.SelectedItem.Text = alt4;
            alternate80.SelectedItem.Text = alt5;
        }

        protected void ddlitemcode17_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode17.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T129.Text = itemname;
            T130.Text = unit;
            T131.Text = spq;
            T132.Text = moq;
            alternate81.SelectedItem.Text = alt1;
            alternate82.SelectedItem.Text = alt2;
            alternate83.SelectedItem.Text = alt3;
            alternate84.SelectedItem.Text = alt4;
            alternate85.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode18_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode18.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T137.Text = itemname;
            T138.Text = unit;
            T139.Text = spq;
            T140.Text = moq;
            alternate86.SelectedItem.Text = alt1;
            alternate87.SelectedItem.Text = alt2;
            alternate88.SelectedItem.Text = alt3;
            alternate89.SelectedItem.Text = alt4;
            alternate90.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode19_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode19.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T145.Text = itemname;
            T146.Text = unit;
            T147.Text = spq;
            T148.Text = moq;
            alternate91.SelectedItem.Text = alt1;
            alternate92.SelectedItem.Text = alt2;
            alternate93.SelectedItem.Text = alt3;
            alternate94.SelectedItem.Text = alt4;
            alternate95.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode20_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode20.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T153.Text = itemname;
            T154.Text = unit;
            T155.Text = spq;
            T156.Text = moq;
            alternate96.SelectedItem.Text = alt1;
            alternate97.SelectedItem.Text = alt2;
            alternate98.SelectedItem.Text = alt3;
            alternate99.SelectedItem.Text = alt4;
            alternate100.SelectedItem.Text = alt5;
          
        }

        protected void ddlitemcode21_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode21.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T161.Text = itemname;
            T162.Text = unit;
            T163.Text = spq;
            T164.Text = moq;
            alternate101.SelectedItem.Text = alt1;
            alternate102.SelectedItem.Text = alt2;
            alternate103.SelectedItem.Text = alt3;
            alternate104.SelectedItem.Text = alt4;
            alternate105.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode22_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode22.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T169.Text = itemname;
            T170.Text = unit;
            T171.Text = spq;
            T172.Text = moq;
            alternate106.SelectedItem.Text = alt1;
            alternate107.SelectedItem.Text = alt2;
            alternate108.SelectedItem.Text = alt3;
            alternate109.SelectedItem.Text = alt4;
            alternate110.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode23_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode23.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T177.Text = itemname;
            T178.Text = unit;
            T179.Text = spq;
            T180.Text = moq;
            alternate111.SelectedItem.Text = alt1;
            alternate112.SelectedItem.Text = alt2;
            alternate113.SelectedItem.Text = alt3;
            alternate114.SelectedItem.Text = alt4;
            alternate115.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode24_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode24.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T185.Text = itemname;
            T186.Text = unit;
            T187.Text = spq;
            T188.Text = moq;
            alternate116.SelectedItem.Text = alt1;
            alternate117.SelectedItem.Text = alt2;
            alternate118.SelectedItem.Text = alt3;
            alternate119.SelectedItem.Text = alt4;
            alternate120.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode25_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode25.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T193.Text = itemname;
            T194.Text = unit;
            T195.Text = spq;
            T196.Text = moq;
            alternate121.SelectedItem.Text = alt1;
            alternate122.SelectedItem.Text = alt2;
            alternate123.SelectedItem.Text = alt3;
            alternate124.SelectedItem.Text = alt4;
            alternate125.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode26_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode26.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T203.Text = itemname;
            T204.Text = unit;
            T205.Text = spq;
            T206.Text = moq;
            alternate126.SelectedItem.Text = alt1;
            alternate127.SelectedItem.Text = alt2;
            alternate128.SelectedItem.Text = alt3;
            alternate129.SelectedItem.Text = alt4;
            alternate130.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode27_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode27.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T209.Text = itemname;
            T210.Text = unit;
            T211.Text = spq;
            T212.Text = moq;
            alternate131.SelectedItem.Text = alt1;
            alternate132.SelectedItem.Text = alt2;
            alternate133.SelectedItem.Text = alt3;
            alternate134.SelectedItem.Text = alt4;
            alternate135.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode28_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode28.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T217.Text = itemname;
            T218.Text = unit;
            T219.Text = spq;
            T220.Text = moq;
            alternate136.SelectedItem.Text = alt1;
            alternate137.SelectedItem.Text = alt2;
            alternate138.SelectedItem.Text = alt3;
            alternate139.SelectedItem.Text = alt4;
            alternate140.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode29_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode29.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T225.Text = itemname;
            T226.Text = unit;
            T227.Text = spq;
            T228.Text = moq;
            alternate141.SelectedItem.Text = alt1;
            alternate142.SelectedItem.Text = alt2;
            alternate143.SelectedItem.Text = alt3;
            alternate144.SelectedItem.Text = alt4;
            alternate145.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode30_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode30.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T233.Text = itemname;
            T234.Text = unit;
            T235.Text = spq;
            T236.Text = moq;
            alternate146.SelectedItem.Text = alt1;
            alternate147.SelectedItem.Text = alt2;
            alternate148.SelectedItem.Text = alt3;
            alternate149.SelectedItem.Text = alt4;
            alternate150.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode31_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode31.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T241.Text = itemname;
            T242.Text = unit;
            T243.Text = spq;
            T244.Text = moq;
            alternate151.SelectedItem.Text = alt1;
            alternate152.SelectedItem.Text = alt2;
            alternate153.SelectedItem.Text = alt3;
            alternate154.SelectedItem.Text = alt4;
            alternate155.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode32_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode32.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T249.Text = itemname;
            T250.Text = unit;
            T251.Text = spq;
            T252.Text = moq;
            alternate156.SelectedItem.Text = alt1;
            alternate157.SelectedItem.Text = alt2;
            alternate158.SelectedItem.Text = alt3;
            alternate159.SelectedItem.Text = alt4;
            alternate160.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode33_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode33.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T257.Text = itemname;
            T258.Text = unit;
            T259.Text = spq;
            T260.Text = moq;
            alternate161.SelectedItem.Text = alt1;
            alternate162.SelectedItem.Text = alt2;
            alternate163.SelectedItem.Text = alt3;
            alternate164.SelectedItem.Text = alt4;
            alternate165.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode34_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode34.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T265.Text = itemname;
            T266.Text = unit;
            T267.Text = spq;
            T268.Text = moq;
            alternate166.SelectedItem.Text = alt1;
            alternate167.SelectedItem.Text = alt2;
            alternate168.SelectedItem.Text = alt3;
            alternate169.SelectedItem.Text = alt4;
            alternate170.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode35_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode35.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T273.Text = itemname;
            T274.Text = unit;
            T275.Text = spq;
            T276.Text = moq;
            alternate171.SelectedItem.Text = alt1;
            alternate172.SelectedItem.Text = alt2;
            alternate173.SelectedItem.Text = alt3;
            alternate174.SelectedItem.Text = alt4;
            alternate175.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode36_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode36.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T281.Text = itemname;
            T282.Text = unit;
            T283.Text = spq;
            T284.Text = moq;
            alternate176.SelectedItem.Text = alt1;
            alternate177.SelectedItem.Text = alt2;
            alternate178.SelectedItem.Text = alt3;
            alternate179.SelectedItem.Text = alt4;
            alternate180.SelectedItem.Text = alt5;
           
           
        }

        protected void ddlitemcode37_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode37.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T289.Text = itemname;
            T290.Text = unit;
            T291.Text = spq;
            T292.Text = moq;
            alternate181.SelectedItem.Text = alt1;
            alternate182.SelectedItem.Text = alt2;
            alternate183.SelectedItem.Text = alt3;
            alternate184.SelectedItem.Text = alt4;
            alternate185.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode38_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode38.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T297.Text = itemname;
            T298.Text = unit;
            T299.Text = spq;
            T300.Text = moq;
            alternate186.SelectedItem.Text = alt1;
            alternate187.SelectedItem.Text = alt2;
            alternate188.SelectedItem.Text = alt3;
            alternate189.SelectedItem.Text = alt4;
            alternate190.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode39_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode39.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T305.Text = itemname;
            T306.Text = unit;
            T307.Text = spq;
            T308.Text = moq;
            alternate191.SelectedItem.Text = alt1;
            alternate192.SelectedItem.Text = alt2;
            alternate193.SelectedItem.Text = alt3;
            alternate194.SelectedItem.Text = alt4;
            alternate195.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode40_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode40.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T313.Text = itemname;
            T314.Text = unit;
            T315.Text = spq;
            T316.Text = moq;
            alternate196.SelectedItem.Text = alt1;
            alternate197.SelectedItem.Text = alt2;
            alternate198.SelectedItem.Text = alt3;
            alternate199.SelectedItem.Text = alt4;
            alternate200.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode41_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode41.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T321.Text = itemname;
            T322.Text = unit;
            T323.Text = spq;
            T324.Text = moq;
            alternate201.SelectedItem.Text = alt1;
            alternate202.SelectedItem.Text = alt2;
            alternate203.SelectedItem.Text = alt3;
            alternate204.SelectedItem.Text = alt4;
            alternate205.SelectedItem.Text = alt5;
         
        }

        protected void ddlitemcode42_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode42.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T329.Text = itemname;
            T230.Text = unit;
            T231.Text = spq;
            T232.Text = moq;
            alternate206.SelectedItem.Text = alt1;
            alternate207.SelectedItem.Text = alt2;
            alternate208.SelectedItem.Text = alt3;
            alternate209.SelectedItem.Text = alt4;
            alternate210.SelectedItem.Text = alt5;
       
           
        }

        protected void ddlitemcode43_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode43.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T337.Text = itemname;
            T338.Text = unit;
            T339.Text = spq;
            T340.Text = moq;
            alternate211.SelectedItem.Text = alt1;
            alternate212.SelectedItem.Text = alt2;
            alternate213.SelectedItem.Text = alt3;
            alternate214.SelectedItem.Text = alt4;
            alternate215.SelectedItem.Text = alt5;
            
        }

        protected void ddlitemcode44_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode44.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T345.Text = itemname;
            T346.Text = unit;
            T347.Text = spq;
            T348.Text = moq;
            alternate216.SelectedItem.Text = alt1;
            alternate217.SelectedItem.Text = alt2;
            alternate218.SelectedItem.Text = alt3;
            alternate219.SelectedItem.Text = alt4;
            alternate220.SelectedItem.Text = alt5;
         
        }

        protected void ddlitemcode45_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode45.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T353.Text = itemname;
            T354.Text = unit;
            T355.Text = spq;
            T356.Text = moq;
            alternate221.SelectedItem.Text = alt1;
            alternate222.SelectedItem.Text = alt2;
            alternate223.SelectedItem.Text = alt3;
            alternate224.SelectedItem.Text = alt4;
            alternate225.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode46_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode46.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T361.Text = itemname;
            T362.Text = unit;
            T363.Text = spq;
            T364.Text = moq;
            alternate226.SelectedItem.Text = alt1;
            alternate227.SelectedItem.Text = alt2;
            alternate228.SelectedItem.Text = alt3;
            alternate229.SelectedItem.Text = alt4;
            alternate230.SelectedItem.Text = alt5;
         
        }

        protected void ddlitemcode47_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode47.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T369.Text = itemname;
            T370.Text = unit;
            T371.Text = spq;
            T372.Text = moq;
            alternate231.SelectedItem.Text = alt1;
            alternate232.SelectedItem.Text = alt2;
            alternate233.SelectedItem.Text = alt3;
            alternate234.SelectedItem.Text = alt4;
            alternate235.SelectedItem.Text = alt5;
           
        }

        protected void ddlitemcode48_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode48.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T377.Text = itemname;
            T378.Text = unit;
            T379.Text = spq;
            T380.Text = moq;
            alternate236.SelectedItem.Text = alt1;
            alternate237.SelectedItem.Text = alt2;
            alternate238.SelectedItem.Text = alt3;
            alternate239.SelectedItem.Text = alt4;
            alternate240.SelectedItem.Text = alt5;
           
           
        }

        protected void ddlitemcode49_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode49.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T385.Text = itemname;
            T386.Text = unit;
            T387.Text = spq;
            T388.Text = moq;
            alternate241.SelectedItem.Text = alt1;
            alternate242.SelectedItem.Text = alt2;
            alternate243.SelectedItem.Text = alt3;
            alternate244.SelectedItem.Text = alt4;
            alternate245.SelectedItem.Text = alt5;
          
        }

        protected void ddlitemcode50_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemname = "", unit = "", spq = "", moq = "", alt1 = "", alt2 = "", alt3 = "", alt4 = "", alt5 = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from partno where partno='" + ddlitemcode50.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                itemname = Convert.ToString(dbr["description"]);
                unit = Convert.ToString(dbr["unitofmeasure"]);
                spq = Convert.ToString(dbr["spq"]);
                moq = Convert.ToString(dbr["moq"]);
                alt1 = Convert.ToString(dbr["alternate1"]);
                alt2 = Convert.ToString(dbr["alternate2"]);
                alt3 = Convert.ToString(dbr["alternate3"]);
                alt4 = Convert.ToString(dbr["alternate4"]);
                alt5 = Convert.ToString(dbr["alternate5"]);
            }
            conn1.Close();
            T393.Text = itemname;
            T394.Text = unit;
            T395.Text = spq;
            T396.Text = moq;
            alternate246.SelectedItem.Text = alt1;
            alternate247.SelectedItem.Text = alt2;
            alternate248.SelectedItem.Text = alt3;
            alternate249.SelectedItem.Text = alt4;
            alternate250.SelectedItem.Text = alt5;
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT description from partno where partno='" + DropDownList1.SelectedItem.Text + "'", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                des = Convert.ToString(dbr["description"]);
            }
            conn1.Close();
            TextBox6.Text = des;
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string num="";
            int num1 = 0, id1 = 0;
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd, cmd1;
            try
            {
                cmd1 = new SqlCommand("SELECT MAX(num) as id from bom", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    num = Convert.ToString(dbr["id"]);
                    if (num == "")
                    {
                        num = "0";
                    }
                    num1 = Convert.ToInt32(num);
                    id1 = num1;
                }
                conn1.Close();
                num1 = id1 + 1;
                string id = Convert.ToString(num1);
                TextBox1.Text = id;
                cmd = new SqlCommand("INSERT into bom(num,bomdate,revision_no,revision_date,category,partno,description,approved_by)values('" + id + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + DropDownList2.SelectedItem.Text + "','" + DropDownList1.SelectedItem.Text + "','" + TextBox6.Text + "','" + TextBox9.Text + "')", conn1);
                conn1.Open();
                cmd.ExecuteNonQuery();
                conn1.Close();

                //insert to row1
                if (ddlitemcode1.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode1.SelectedItem.Text + "','" + T1.Text + "','" + T2.Text + "','" + alternate1.SelectedItem.Text + "','"+alternate2.SelectedItem.Text+"','"+alternate3.SelectedItem.Text+"','"+alternate4.SelectedItem.Text+"','"+alternate5.SelectedItem.Text+"','"+T3.Text+"','"+T4.Text+"','"+T5.Text+"','"+T6.Text+"','"+T7.Text+"','"+T8.Text+"','"+smd1.SelectedItem.Text+"','"+th1.SelectedItem.Text+"')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row2
                if (ddlitemcode2.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode2.SelectedItem.Text + "','" + T9.Text + "','" + T10.Text + "','" + alternate6.SelectedItem.Text + "','" + alternate7.SelectedItem.Text + "','" + alternate8.SelectedItem.Text + "','" + alternate9.SelectedItem.Text + "','" + alternate10.SelectedItem.Text + "','" + T11.Text + "','" + T12.Text + "','" + T13.Text + "','" + T14.Text + "','" + T15.Text + "','" + T16.Text + "','" + smd2.SelectedItem.Text + "','" + th2.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row3
                if (ddlitemcode3.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode3.SelectedItem.Text + "','" + T17.Text + "','" + T18.Text + "','" + alternate11.SelectedItem.Text + "','" + alternate12.SelectedItem.Text + "','" + alternate13.SelectedItem.Text + "','" + alternate14.SelectedItem.Text + "','" + alternate15.SelectedItem.Text + "','" + T19.Text + "','" + T20.Text + "','" + T21.Text + "','" + T22.Text + "','" + T23.Text + "','" + T24.Text + "','" + smd3.SelectedItem.Text + "','" + th3.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row4
                if (ddlitemcode4.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode4.SelectedItem.Text + "','" + T25.Text + "','" + T26.Text + "','" + alternate16.SelectedItem.Text + "','" + alternate17.SelectedItem.Text + "','" + alternate18.SelectedItem.Text + "','" + alternate19.SelectedItem.Text + "','" + alternate20.SelectedItem.Text + "','" + T27.Text + "','" + T28.Text + "','" + T29.Text + "','" + T30.Text + "','" + T31.Text + "','" + T32.Text + "','" + smd4.SelectedItem.Text + "','" + th4.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row5
                if (ddlitemcode5.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode5.SelectedItem.Text + "','" + T33.Text + "','" + T34.Text + "','" + alternate21.SelectedItem.Text + "','" + alternate22.SelectedItem.Text + "','" + alternate23.SelectedItem.Text + "','" + alternate24.SelectedItem.Text + "','" + alternate25.SelectedItem.Text + "','" + T35.Text + "','" + T36.Text + "','" + T37.Text + "','" + T38.Text + "','" + T39.Text + "','" + T40.Text + "','" + smd5.SelectedItem.Text + "','" + th5.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row6
                if (ddlitemcode6.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode6.SelectedItem.Text + "','" + T41.Text + "','" + T42.Text + "','" + alternate26.SelectedItem.Text + "','" + alternate27.SelectedItem.Text + "','" + alternate28.SelectedItem.Text + "','" + alternate29.SelectedItem.Text + "','" + alternate30.SelectedItem.Text + "','" + T43.Text + "','" + T44.Text + "','" + T45.Text + "','" + T46.Text + "','" + T47.Text + "','" + T48.Text + "','" + smd6.SelectedItem.Text + "','" + th6.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row7
                if (ddlitemcode7.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode7.SelectedItem.Text + "','" + T49.Text + "','" + T50.Text + "','" + alternate31.SelectedItem.Text + "','" + alternate32.SelectedItem.Text + "','" + alternate33.SelectedItem.Text + "','" + alternate34.SelectedItem.Text + "','" + alternate35.SelectedItem.Text + "','" + T51.Text + "','" + T52.Text + "','" + T53.Text + "','" + T54.Text + "','" + T55.Text + "','" + T56.Text + "','" + smd7.SelectedItem.Text + "','" + th7.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row8
                if (ddlitemcode8.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode8.SelectedItem.Text + "','" + T57.Text + "','" + T58.Text + "','" + alternate36.SelectedItem.Text + "','" + alternate37.SelectedItem.Text + "','" + alternate38.SelectedItem.Text + "','" + alternate39.SelectedItem.Text + "','" + alternate40.SelectedItem.Text + "','" + T59.Text + "','" + T60.Text + "','" + T61.Text + "','" + T62.Text + "','" + T63.Text + "','" + T64.Text + "','" + smd8.SelectedItem.Text + "','" + th8.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row9
                if (ddlitemcode9.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode9.SelectedItem.Text + "','" + T65.Text + "','" + T66.Text + "','" + alternate41.SelectedItem.Text + "','" + alternate42.SelectedItem.Text + "','" + alternate43.SelectedItem.Text + "','" + alternate44.SelectedItem.Text + "','" + alternate45.SelectedItem.Text + "','" + T67.Text + "','" + T68.Text + "','" + T69.Text + "','" + T70.Text + "','" + T71.Text + "','" + T72.Text + "','" + smd9.SelectedItem.Text + "','" + th9.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row10
                if (ddlitemcode10.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode10.SelectedItem.Text + "','" + T73.Text + "','" + T74.Text + "','" + alternate46.SelectedItem.Text + "','" + alternate47.SelectedItem.Text + "','" + alternate48.SelectedItem.Text + "','" + alternate49.SelectedItem.Text + "','" + alternate50.SelectedItem.Text + "','" + T75.Text + "','" + T76.Text + "','" + T77.Text + "','" + T78.Text + "','" + T79.Text + "','" + T80.Text + "','" + smd10.SelectedItem.Text + "','" + th10.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row11
                if (ddlitemcode11.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode11.SelectedItem.Text + "','" + T81.Text + "','" + T82.Text + "','" + alternate51.SelectedItem.Text + "','" + alternate52.SelectedItem.Text + "','" + alternate53.SelectedItem.Text + "','" + alternate54.SelectedItem.Text + "','" + alternate55.SelectedItem.Text + "','" + T83.Text + "','" + T84.Text + "','" + T85.Text + "','" + T86.Text + "','" + T87.Text + "','" + T88.Text + "','" + smd11.SelectedItem.Text + "','" + th11.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row12
                if (ddlitemcode12.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode12.SelectedItem.Text + "','" + T89.Text + "','" + T90.Text + "','" + alternate56.SelectedItem.Text + "','" + alternate57.SelectedItem.Text + "','" + alternate58.SelectedItem.Text + "','" + alternate59.SelectedItem.Text + "','" + alternate60.SelectedItem.Text + "','" + T91.Text + "','" + T92.Text + "','" + T93.Text + "','" + T94.Text + "','" + T95.Text + "','" + T96.Text + "','" + smd12.SelectedItem.Text + "','" + th12.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row13
                if (ddlitemcode13.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode13.SelectedItem.Text + "','" + T97.Text + "','" + T98.Text + "','" + alternate61.SelectedItem.Text + "','" + alternate62.SelectedItem.Text + "','" + alternate63.SelectedItem.Text + "','" + alternate64.SelectedItem.Text + "','" + alternate65.SelectedItem.Text + "','" + T99.Text + "','" + T100.Text + "','" + T101.Text + "','" + T102.Text + "','" + T103.Text + "','" + T104.Text + "','" + smd13.SelectedItem.Text + "','" + th13.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row14
                if (ddlitemcode14.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode14.SelectedItem.Text + "','" + T105.Text + "','" + T106.Text + "','" + alternate66.SelectedItem.Text + "','" + alternate67.SelectedItem.Text + "','" + alternate68.SelectedItem.Text + "','" + alternate69.SelectedItem.Text + "','" + alternate70.SelectedItem.Text + "','" + T107.Text + "','" + T108.Text + "','" + T109.Text + "','" + T110.Text + "','" + T111.Text + "','" + T112.Text + "','" + smd14.SelectedItem.Text + "','" + th14.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row15
                if (ddlitemcode15.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode15.SelectedItem.Text + "','" + T113.Text + "','" + T114.Text + "','" + alternate71.SelectedItem.Text + "','" + alternate72.SelectedItem.Text + "','" + alternate73.SelectedItem.Text + "','" + alternate74.SelectedItem.Text + "','" + alternate75.SelectedItem.Text + "','" + T115.Text + "','" + T116.Text + "','" + T117.Text + "','" + T118.Text + "','" + T119.Text + "','" + T120.Text + "','" + smd15.SelectedItem.Text + "','" + th15.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row16
                if (ddlitemcode16.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode16.SelectedItem.Text + "','" + T121.Text + "','" + T122.Text + "','" + alternate76.SelectedItem.Text + "','" + alternate77.SelectedItem.Text + "','" + alternate78.SelectedItem.Text + "','" + alternate79.SelectedItem.Text + "','" + alternate80.SelectedItem.Text + "','" + T123.Text + "','" + T124.Text + "','" + T125.Text + "','" + T126.Text + "','" + T127.Text + "','" + T128.Text + "','" + smd16.SelectedItem.Text + "','" + th16.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row17
                if (ddlitemcode17.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode17.SelectedItem.Text + "','" + T129.Text + "','" + T130.Text + "','" + alternate81.SelectedItem.Text + "','" + alternate82.SelectedItem.Text + "','" + alternate83.SelectedItem.Text + "','" + alternate84.SelectedItem.Text + "','" + alternate85.SelectedItem.Text + "','" + T131.Text + "','" + T132.Text + "','" + T133.Text + "','" + T134.Text + "','" + T135.Text + "','" + T136.Text + "','" + smd17.SelectedItem.Text + "','" + th17.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row18
                if (ddlitemcode18.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode18.SelectedItem.Text + "','" + T137.Text + "','" + T138.Text + "','" + alternate86.SelectedItem.Text + "','" + alternate87.SelectedItem.Text + "','" + alternate88.SelectedItem.Text + "','" + alternate89.SelectedItem.Text + "','" + alternate90.SelectedItem.Text + "','" + T139.Text + "','" + T140.Text + "','" + T141.Text + "','" + T142.Text + "','" + T143.Text + "','" + T144.Text + "','" + smd18.SelectedItem.Text + "','" + th18.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row19
                if (ddlitemcode19.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode19.SelectedItem.Text + "','" + T145.Text + "','" + T146.Text + "','" + alternate91.SelectedItem.Text + "','" + alternate92.SelectedItem.Text + "','" + alternate93.SelectedItem.Text + "','" + alternate94.SelectedItem.Text + "','" + alternate95.SelectedItem.Text + "','" + T147.Text + "','" + T148.Text + "','" + T149.Text + "','" + T150.Text + "','" + T151.Text + "','" + T152.Text + "','" + smd19.SelectedItem.Text + "','" + th19.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row20
                if (ddlitemcode20.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode20.SelectedItem.Text + "','" + T153.Text + "','" + T154.Text + "','" + alternate96.SelectedItem.Text + "','" + alternate97.SelectedItem.Text + "','" + alternate98.SelectedItem.Text + "','" + alternate99.SelectedItem.Text + "','" + alternate100.SelectedItem.Text + "','" + T155.Text + "','" + T156.Text + "','" + T157.Text + "','" + T158.Text + "','" + T159.Text + "','" + T160.Text + "','" + smd20.SelectedItem.Text + "','" + th20.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row21
                if (ddlitemcode21.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode21.SelectedItem.Text + "','" + T161.Text + "','" + T162.Text + "','" + alternate101.SelectedItem.Text + "','" + alternate102.SelectedItem.Text + "','" + alternate103.SelectedItem.Text + "','" + alternate104.SelectedItem.Text + "','" + alternate105.SelectedItem.Text + "','" + T163.Text + "','" + T164.Text + "','" + T165.Text + "','" + T166.Text + "','" + T167.Text + "','" + T168.Text + "','" + smd21.SelectedItem.Text + "','" + th21.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row22
                if (ddlitemcode22.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode22.SelectedItem.Text + "','" + T169.Text + "','" + T170.Text + "','" + alternate106.SelectedItem.Text + "','" + alternate107.SelectedItem.Text + "','" + alternate108.SelectedItem.Text + "','" + alternate109.SelectedItem.Text + "','" + alternate110.SelectedItem.Text + "','" + T171.Text + "','" + T172.Text + "','" + T173.Text + "','" + T174.Text + "','" + T175.Text + "','" + T176.Text + "','" + smd22.SelectedItem.Text + "','" + th22.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row23
                if (ddlitemcode23.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode23.SelectedItem.Text + "','" + T177.Text + "','" + T178.Text + "','" + alternate111.SelectedItem.Text + "','" + alternate112.SelectedItem.Text + "','" + alternate113.SelectedItem.Text + "','" + alternate114.SelectedItem.Text + "','" + alternate115.SelectedItem.Text + "','" + T179.Text + "','" + T180.Text + "','" + T181.Text + "','" + T182.Text + "','" + T183.Text + "','" + T184.Text + "','" + smd23.SelectedItem.Text + "','" + th23.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row24
                if (ddlitemcode24.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode24.SelectedItem.Text + "','" + T185.Text + "','" + T186.Text + "','" + alternate116.SelectedItem.Text + "','" + alternate117.SelectedItem.Text + "','" + alternate118.SelectedItem.Text + "','" + alternate119.SelectedItem.Text + "','" + alternate120.SelectedItem.Text + "','" + T187.Text + "','" + T188.Text + "','" + T189.Text + "','" + T190.Text + "','" + T191.Text + "','" + T192.Text + "','" + smd24.SelectedItem.Text + "','" + th24.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row25
                if (ddlitemcode25.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode25.SelectedItem.Text + "','" + T193.Text + "','" + T194.Text + "','" + alternate121.SelectedItem.Text + "','" + alternate122.SelectedItem.Text + "','" + alternate123.SelectedItem.Text + "','" + alternate124.SelectedItem.Text + "','" + alternate125.SelectedItem.Text + "','" + T195.Text + "','" + T196.Text + "','" + T197.Text + "','" + T198.Text + "','" + T199.Text + "','" + T200.Text + "','" + smd25.SelectedItem.Text + "','" + th25.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row26
                if (ddlitemcode26.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode26.SelectedItem.Text + "','" + T201.Text + "','" + T202.Text + "','" + alternate126.SelectedItem.Text + "','" + alternate127.SelectedItem.Text + "','" + alternate128.SelectedItem.Text + "','" + alternate129.SelectedItem.Text + "','" + alternate130.SelectedItem.Text + "','" + T203.Text + "','" + T204.Text + "','" + T205.Text + "','" + T206.Text + "','" + T207.Text + "','" + T208.Text + "','" + smd26.SelectedItem.Text + "','" + th26.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row27
                if (ddlitemcode27.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode27.SelectedItem.Text + "','" + T209.Text + "','" + T210.Text + "','" + alternate131.SelectedItem.Text + "','" + alternate132.SelectedItem.Text + "','" + alternate133.SelectedItem.Text + "','" + alternate134.SelectedItem.Text + "','" + alternate135.SelectedItem.Text + "','" + T211.Text + "','" + T212.Text + "','" + T213.Text + "','" + T214.Text + "','" + T215.Text + "','" + T216.Text + "','" + smd27.SelectedItem.Text + "','" + th27.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row28
                if (ddlitemcode28.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode28.SelectedItem.Text + "','" + T217.Text + "','" + T218.Text + "','" + alternate136.SelectedItem.Text + "','" + alternate137.SelectedItem.Text + "','" + alternate138.SelectedItem.Text + "','" + alternate139.SelectedItem.Text + "','" + alternate140.SelectedItem.Text + "','" + T219.Text + "','" + T220.Text + "','" + T221.Text + "','" + T222.Text + "','" + T223.Text + "','" + T224.Text + "','" + smd28.SelectedItem.Text + "','" + th28.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row29
                if (ddlitemcode29.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode29.SelectedItem.Text + "','" + T225.Text + "','" + T226.Text + "','" + alternate141.SelectedItem.Text + "','" + alternate142.SelectedItem.Text + "','" + alternate143.SelectedItem.Text + "','" + alternate144.SelectedItem.Text + "','" + alternate145.SelectedItem.Text + "','" + T227.Text + "','" + T228.Text + "','" + T229.Text + "','" + T230.Text + "','" + T231.Text + "','" + T232.Text + "','" + smd29.SelectedItem.Text + "','" + th29.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row30
                if (ddlitemcode30.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode30.SelectedItem.Text + "','" + T233.Text + "','" + T234.Text + "','" + alternate146.SelectedItem.Text + "','" + alternate147.SelectedItem.Text + "','" + alternate148.SelectedItem.Text + "','" + alternate149.SelectedItem.Text + "','" + alternate150.SelectedItem.Text + "','" + T235.Text + "','" + T236.Text + "','" + T237.Text + "','" + T238.Text + "','" + T239.Text + "','" + T240.Text + "','" + smd30.SelectedItem.Text + "','" + th30.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row31
                if (ddlitemcode31.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode31.SelectedItem.Text + "','" + T241.Text + "','" + T242.Text + "','" + alternate151.SelectedItem.Text + "','" + alternate152.SelectedItem.Text + "','" + alternate153.SelectedItem.Text + "','" + alternate154.SelectedItem.Text + "','" + alternate155.SelectedItem.Text + "','" + T243.Text + "','" + T244.Text + "','" + T245.Text + "','" + T246.Text + "','" + T247.Text + "','" + T248.Text + "','" + smd31.SelectedItem.Text + "','" + th31.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row32
                if (ddlitemcode32.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode32.SelectedItem.Text + "','" + T249.Text + "','" + T250.Text + "','" + alternate156.SelectedItem.Text + "','" + alternate157.SelectedItem.Text + "','" + alternate158.SelectedItem.Text + "','" + alternate159.SelectedItem.Text + "','" + alternate160.SelectedItem.Text + "','" + T251.Text + "','" + T252.Text + "','" + T253.Text + "','" + T254.Text + "','" + T255.Text + "','" + T256.Text + "','" + smd32.SelectedItem.Text + "','" + th32.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row33
                if (ddlitemcode33.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode33.SelectedItem.Text + "','" + T257.Text + "','" + T258.Text + "','" + alternate161.SelectedItem.Text + "','" + alternate162.SelectedItem.Text + "','" + alternate163.SelectedItem.Text + "','" + alternate164.SelectedItem.Text + "','" + alternate165.SelectedItem.Text + "','" + T259.Text + "','" + T260.Text + "','" + T261.Text + "','" + T262.Text + "','" + T263.Text + "','" + T264.Text + "','" + smd33.SelectedItem.Text + "','" + th33.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row34
                if (ddlitemcode34.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode34.SelectedItem.Text + "','" + T265.Text + "','" + T266.Text + "','" + alternate166.SelectedItem.Text + "','" + alternate167.SelectedItem.Text + "','" + alternate168.SelectedItem.Text + "','" + alternate169.SelectedItem.Text + "','" + alternate170.SelectedItem.Text + "','" + T267.Text + "','" + T268.Text + "','" + T269.Text + "','" + T270.Text + "','" + T271.Text + "','" + T272.Text + "','" + smd34.SelectedItem.Text + "','" + th34.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row35
                if (ddlitemcode35.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode35.SelectedItem.Text + "','" + T273.Text + "','" + T274.Text + "','" + alternate171.SelectedItem.Text + "','" + alternate172.SelectedItem.Text + "','" + alternate173.SelectedItem.Text + "','" + alternate174.SelectedItem.Text + "','" + alternate175.SelectedItem.Text + "','" + T275.Text + "','" + T276.Text + "','" + T277.Text + "','" + T278.Text + "','" + T279.Text + "','" + T280.Text + "','" + smd35.SelectedItem.Text + "','" + th35.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row36
                if (ddlitemcode36.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode36.SelectedItem.Text + "','" + T281.Text + "','" + T282.Text + "','" + alternate176.SelectedItem.Text + "','" + alternate177.SelectedItem.Text + "','" + alternate178.SelectedItem.Text + "','" + alternate179.SelectedItem.Text + "','" + alternate180.SelectedItem.Text + "','" + T283.Text + "','" + T284.Text + "','" + T285.Text + "','" + T286.Text + "','" + T287.Text + "','" + T288.Text + "','" + smd36.SelectedItem.Text + "','" + th36.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row37
                if (ddlitemcode37.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode37.SelectedItem.Text + "','" + T289.Text + "','" + T290.Text + "','" + alternate181.SelectedItem.Text + "','" + alternate182.SelectedItem.Text + "','" + alternate183.SelectedItem.Text + "','" + alternate184.SelectedItem.Text + "','" + alternate185.SelectedItem.Text + "','" + T291.Text + "','" + T292.Text + "','" + T293.Text + "','" + T294.Text + "','" + T295.Text + "','" + T296.Text + "','" + smd37.SelectedItem.Text + "','" + th37.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row38
                if (ddlitemcode38.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode38.SelectedItem.Text + "','" + T297.Text + "','" + T298.Text + "','" + alternate186.SelectedItem.Text + "','" + alternate187.SelectedItem.Text + "','" + alternate188.SelectedItem.Text + "','" + alternate189.SelectedItem.Text + "','" + alternate190.SelectedItem.Text + "','" + T299.Text + "','" + T300.Text + "','" + T301.Text + "','" + T302.Text + "','" + T303.Text + "','" + T304.Text + "','" + smd38.SelectedItem.Text + "','" + th38.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row39
                if (ddlitemcode39.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode39.SelectedItem.Text + "','" + T305.Text + "','" + T306.Text + "','" + alternate191.SelectedItem.Text + "','" + alternate192.SelectedItem.Text + "','" + alternate193.SelectedItem.Text + "','" + alternate194.SelectedItem.Text + "','" + alternate195.SelectedItem.Text + "','" + T307.Text + "','" + T308.Text + "','" + T309.Text + "','" + T310.Text + "','" + T311.Text + "','" + T312.Text + "','" + smd39.SelectedItem.Text + "','" + th39.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row40
                if (ddlitemcode40.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode40.SelectedItem.Text + "','" + T313.Text + "','" + T314.Text + "','" + alternate196.SelectedItem.Text + "','" + alternate197.SelectedItem.Text + "','" + alternate198.SelectedItem.Text + "','" + alternate199.SelectedItem.Text + "','" + alternate200.SelectedItem.Text + "','" + T315.Text + "','" + T316.Text + "','" + T317.Text + "','" + T318.Text + "','" + T319.Text + "','" + T320.Text + "','" + smd40.SelectedItem.Text + "','" + th40.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row41
                if (ddlitemcode41.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode41.SelectedItem.Text + "','" + T321.Text + "','" + T322.Text + "','" + alternate201.SelectedItem.Text + "','" + alternate202.SelectedItem.Text + "','" + alternate203.SelectedItem.Text + "','" + alternate204.SelectedItem.Text + "','" + alternate205.SelectedItem.Text + "','" + T323.Text + "','" + T324.Text + "','" + T325.Text + "','" + T326.Text + "','" + T327.Text + "','" + T328.Text + "','" + smd41.SelectedItem.Text + "','" + th41.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row42
                if (ddlitemcode42.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode42.SelectedItem.Text + "','" + T329.Text + "','" + T330.Text + "','" + alternate206.SelectedItem.Text + "','" + alternate207.SelectedItem.Text + "','" + alternate208.SelectedItem.Text + "','" + alternate209.SelectedItem.Text + "','" + alternate210.SelectedItem.Text + "','" + T331.Text + "','" + T332.Text + "','" + T333.Text + "','" + T334.Text + "','" + T335.Text + "','" + T336.Text + "','" + smd42.SelectedItem.Text + "','" + th42.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row43
                if (ddlitemcode43.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode43.SelectedItem.Text + "','" + T337.Text + "','" + T338.Text + "','" + alternate211.SelectedItem.Text + "','" + alternate212.SelectedItem.Text + "','" + alternate213.SelectedItem.Text + "','" + alternate214.SelectedItem.Text + "','" + alternate215.SelectedItem.Text + "','" + T339.Text + "','" + T340.Text + "','" + T341.Text + "','" + T342.Text + "','" + T343.Text + "','" + T344.Text + "','" + smd43.SelectedItem.Text + "','" + th43.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row44
                if (ddlitemcode44.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode44.SelectedItem.Text + "','" + T345.Text + "','" + T346.Text + "','" + alternate216.SelectedItem.Text + "','" + alternate217.SelectedItem.Text + "','" + alternate218.SelectedItem.Text + "','" + alternate219.SelectedItem.Text + "','" + alternate220.SelectedItem.Text + "','" + T347.Text + "','" + T348.Text + "','" + T349.Text + "','" + T350.Text + "','" + T351.Text + "','" + T352.Text + "','" + smd44.SelectedItem.Text + "','" + th44.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row45
                if (ddlitemcode45.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode45.SelectedItem.Text + "','" + T353.Text + "','" + T354.Text + "','" + alternate221.SelectedItem.Text + "','" + alternate222.SelectedItem.Text + "','" + alternate223.SelectedItem.Text + "','" + alternate224.SelectedItem.Text + "','" + alternate225.SelectedItem.Text + "','" + T355.Text + "','" + T356.Text + "','" + T357.Text + "','" + T358.Text + "','" + T359.Text + "','" + T360.Text + "','" + smd45.SelectedItem.Text + "','" + th45.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row46
                if (ddlitemcode46.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode46.SelectedItem.Text + "','" + T361.Text + "','" + T362.Text + "','" + alternate226.SelectedItem.Text + "','" + alternate227.SelectedItem.Text + "','" + alternate228.SelectedItem.Text + "','" + alternate229.SelectedItem.Text + "','" + alternate230.SelectedItem.Text + "','" + T363.Text + "','" + T364.Text + "','" + T365.Text + "','" + T366.Text + "','" + T367.Text + "','" + T368.Text + "','" + smd46.SelectedItem.Text + "','" + th46.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row47
                if (ddlitemcode47.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode47.SelectedItem.Text + "','" + T369.Text + "','" + T370.Text + "','" + alternate231.SelectedItem.Text + "','" + alternate232.SelectedItem.Text + "','" + alternate233.SelectedItem.Text + "','" + alternate234.SelectedItem.Text + "','" + alternate235.SelectedItem.Text + "','" + T371.Text + "','" + T372.Text + "','" + T373.Text + "','" + T374.Text + "','" + T375.Text + "','" + T376.Text + "','" + smd47.SelectedItem.Text + "','" + th47.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row48
                if (ddlitemcode48.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode48.SelectedItem.Text + "','" + T377.Text + "','" + T378.Text + "','" + alternate236.SelectedItem.Text + "','" + alternate237.SelectedItem.Text + "','" + alternate238.SelectedItem.Text + "','" + alternate239.SelectedItem.Text + "','" + alternate240.SelectedItem.Text + "','" + T379.Text + "','" + T380.Text + "','" + T381.Text + "','" + T382.Text + "','" + T383.Text + "','" + T384.Text + "','" + smd48.SelectedItem.Text + "','" + th48.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row49
                if (ddlitemcode49.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode49.SelectedItem.Text + "','" + T385.Text + "','" + T386.Text + "','" + alternate241.SelectedItem.Text + "','" + alternate242.SelectedItem.Text + "','" + alternate243.SelectedItem.Text + "','" + alternate244.SelectedItem.Text + "','" + alternate245.SelectedItem.Text + "','" + T387.Text + "','" + T388.Text + "','" + T389.Text + "','" + T390.Text + "','" + T391.Text + "','" + T392.Text + "','" + smd49.SelectedItem.Text + "','" + th49.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row50
                if (ddlitemcode50.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomassembly values('" + id + "','" + TextBox4.Text + "','" + ddlitemcode50.SelectedItem.Text + "','" + T393.Text + "','" + T394.Text + "','" + alternate246.SelectedItem.Text + "','" + alternate247.SelectedItem.Text + "','" + alternate248.SelectedItem.Text + "','" + alternate249.SelectedItem.Text + "','" + alternate250.SelectedItem.Text + "','" + T395.Text + "','" + T396.Text + "','" + T397.Text + "','" + T398.Text + "','" + T399.Text + "','" + T400.Text + "','" + smd50.SelectedItem.Text + "','" + th50.SelectedItem.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }


                //insert data in bomprocess table
                //insert to row1
                if ( ddlprocessname1.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname1.SelectedItem.Text + "','" + P1.Text + "','" + time1.Text + "','" + P2.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row2
                if (ddlprocessname2.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname2.SelectedItem.Text + "','" + P3.Text + "','" + time2.Text + "','" + P4.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row3
                if (ddlprocessname3.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname3.SelectedItem.Text + "','" + P5.Text + "','" + time3.Text + "','" + P6.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row4
                if (ddlprocessname4.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname4.SelectedItem.Text + "','" + P7.Text + "','" + time4.Text + "','" + P8.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row5
                if (ddlprocessname5.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname5.SelectedItem.Text + "','" + P9.Text + "','" + time5.Text + "','" + P10.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row6
                if (ddlprocessname6.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname6.SelectedItem.Text + "','" + P11.Text + "','" + time6.Text + "','" + P12.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row7
                if (ddlprocessname7.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname7.SelectedItem.Text + "','" + P13.Text + "','" + time7.Text + "','" + P14.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row8
                if (ddlprocessname8.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname8.SelectedItem.Text + "','" + P15.Text + "','" + time8.Text + "','" + P16.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row9
                if (ddlprocessname9.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname9.SelectedItem.Text + "','" + P17.Text + "','" + time9.Text + "','" + P18.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row10
                if (ddlprocessname10.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname10.SelectedItem.Text + "','" + P19.Text + "','" + time10.Text + "','" + P20.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row11
                if (ddlprocessname11.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname11.SelectedItem.Text + "','" + P21.Text + "','" + time11.Text + "','" + P22.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row12
                if (ddlprocessname12.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname12.SelectedItem.Text + "','" + P23.Text + "','" + time12.Text + "','" + P24.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row13
                if (ddlprocessname13.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname13.SelectedItem.Text + "','" + P25.Text + "','" + time13.Text + "','" + P26.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row14
                if (ddlprocessname14.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname14.SelectedItem.Text + "','" + P27.Text + "','" + time14.Text + "','" + P28.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row15
                if (ddlprocessname15.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname15.SelectedItem.Text + "','" + P29.Text + "','" + time15.Text + "','" + P30.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row16
                if (ddlprocessname16.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname16.SelectedItem.Text + "','" + P31.Text + "','" + time16.Text + "','" + P32.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row17
                if (ddlprocessname17.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname17.SelectedItem.Text + "','" + P33.Text + "','" + time17.Text + "','" + P34.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row18
                if (ddlprocessname18.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname18.SelectedItem.Text + "','" + P35.Text + "','" + time18.Text + "','" + P36.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row19
                if (ddlprocessname19.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname19.SelectedItem.Text + "','" + P37.Text + "','" + time19.Text + "','" + P38.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row20
                if (ddlprocessname20.SelectedItem.Text != "please select")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomprocess values('" + id + "','" + TextBox4.Text + "','" + ddlprocessname20.SelectedItem.Text + "','" + P39.Text + "','" + time20.Text + "','" + P40.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
               
                //insert data to bomoverhead table
                //insert to row1
                if (O1.Text!= "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O1.Text + "','" + O2.Text + "','" + O3.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row2
                if (O4.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O4.Text + "','" + O5.Text + "','" + O6.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row3
                if (O7.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O7.Text + "','" + O8.Text + "','" + O9.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row4
                if (O10.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O10.Text + "','" + O11.Text + "','" + O12.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row5
                if (O13.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O13.Text + "','" + O14.Text + "','" + O15.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row6
                if (O16.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O16.Text + "','" + O17.Text + "','" + O18.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row7
                if (O19.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O19.Text + "','" + O20.Text + "','" + O21.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row8
                if (O22.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O22.Text + "','" + O23.Text + "','" + O24.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row9
                if (O25.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O25.Text + "','" + O26.Text + "','" + O27.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row10
                if (O28.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O28.Text + "','" + O29.Text + "','" + O30.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row11
                if (O31.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O31.Text + "','" + O32.Text + "','" + O33.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row12
                if (O34.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O34.Text + "','" + O35.Text + "','" + O36.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row13
                if (O37.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O37.Text + "','" + O38.Text + "','" + O39.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row14
                if (O40.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O40.Text + "','" + O41.Text + "','" + O42.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row15
                if (O43.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O43.Text + "','" + O44.Text + "','" + O45.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row16
                if (O46.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O46.Text + "','" + O47.Text + "','" + O48.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row17
                if (O49.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O49.Text + "','" + O50.Text + "','" + O51.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row18
                if (O52.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O52.Text + "','" + O53.Text + "','" + O54.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row19
                if (O55.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O55.Text + "','" + O56.Text + "','" + O57.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }
                //insert to row20
                if (O58.Text != "")
                {
                    SqlCommand sqlcmd1 = new SqlCommand("INSERT INTO bomoverhead values('" + id + "','" + TextBox4.Text + "','" + O58.Text + "','" + O59.Text + "','" + O60.Text + "')", conn1);
                    conn1.Open();
                    sqlcmd1.ExecuteNonQuery();
                    conn1.Close();
                }

            }
            catch (Exception ex)
            {
                Label17.Text = ex.Message;
            }
        }

    }
}
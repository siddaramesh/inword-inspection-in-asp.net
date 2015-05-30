using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace administrator
{
    public partial class jobcard : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tab1.CssClass = "Clicked";
                MainView.ActiveViewIndex = 0;
                binddropdownlist();
               
            }
        }

        protected void Tab1_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "Clicked";
            Tab2.CssClass = "addbutton";
            Tab3.CssClass = "addbutton";
            MainView.ActiveViewIndex = 0;
        }

        protected void Tab2_Click(object sender, EventArgs e)
        {
            Tab1.CssClass = "addbutton";
            Tab2.CssClass = "Clicked";
            Tab3.CssClass = "addbutton";
            MainView.ActiveViewIndex = 1;
        }

        protected void Tab3_Click(object sender, EventArgs e)
        {
            Tab3.CssClass = "Clicked";
            Tab1.CssClass = "addbutton";
            Tab2.CssClass = "addbutton";
            MainView.ActiveViewIndex = 2;
        }
        protected void binddropdownlist()
        {
            try
            {
                using (conn)
                {
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT task from task order by task";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //row 1
                        ddltask1.DataSource = dt;
                        ddltask1.DataTextField = "task";
                        ddltask1.DataValueField = "task";
                        ddltask1.DataBind();
                        //row 2
                        ddltask2.DataSource = dt;
                        ddltask2.DataTextField = "task";
                        ddltask2.DataValueField = "task";
                        ddltask2.DataBind();
                        //row 3
                        ddltask3.DataSource = dt;
                        ddltask3.DataTextField = "task";
                        ddltask3.DataValueField = "task";
                        ddltask3.DataBind();
                        //row 4
                        ddltask4.DataSource = dt;
                        ddltask4.DataTextField = "task";
                        ddltask4.DataValueField = "task";
                        ddltask4.DataBind();
                        //row 5
                        ddltask5.DataSource = dt;
                        ddltask5.DataTextField = "task";
                        ddltask5.DataValueField = "task";
                        ddltask5.DataBind();
                        //row 6
                        ddltask6.DataSource = dt;
                        ddltask6.DataTextField = "task";
                        ddltask6.DataValueField = "task";
                        ddltask6.DataBind();
                        //row 7
                        ddltask7.DataSource = dt;
                        ddltask7.DataTextField = "task";
                        ddltask7.DataValueField = "task";
                        ddltask7.DataBind();
                        //row 8
                        ddltask8.DataSource = dt;
                        ddltask8.DataTextField = "task";
                        ddltask8.DataValueField = "task";
                        ddltask8.DataBind();
                        //row 9
                        ddltask9.DataSource = dt;
                        ddltask9.DataTextField = "task";
                        ddltask9.DataValueField = "task";
                        ddltask9.DataBind();
                        //row 10
                        ddltask10.DataSource = dt;
                        ddltask10.DataTextField = "task";
                        ddltask10.DataValueField = "task";
                        ddltask10.DataBind();
                        //row 11
                        ddltask11.DataSource = dt;
                        ddltask11.DataTextField = "task";
                        ddltask11.DataValueField = "task";
                        ddltask11.DataBind();
                        //row 12
                        ddltask12.DataSource = dt;
                        ddltask12.DataTextField = "task";
                        ddltask12.DataValueField = "task";
                        ddltask12.DataBind();
                        //row 13
                        ddltask13.DataSource = dt;
                        ddltask13.DataTextField = "task";
                        ddltask13.DataValueField = "task";
                        ddltask13.DataBind();
                        //row 14
                        ddltask14.DataSource = dt;
                        ddltask14.DataTextField = "task";
                        ddltask14.DataValueField = "task";
                        ddltask14.DataBind();
                        //row 15
                        ddltask15.DataSource = dt;
                        ddltask15.DataTextField = "task";
                        ddltask15.DataValueField = "task";
                        ddltask15.DataBind();
                        //row 16
                        ddltask16.DataSource = dt;
                        ddltask16.DataTextField = "task";
                        ddltask16.DataValueField = "task";
                        ddltask16.DataBind();
                        //row 17
                        ddltask17.DataSource = dt;
                        ddltask17.DataTextField = "task";
                        ddltask17.DataValueField = "task";
                        ddltask17.DataBind();
                        //row 18
                        ddltask18.DataSource = dt;
                        ddltask18.DataTextField = "task";
                        ddltask18.DataValueField = "task";
                        ddltask18.DataBind();
                        //row 19
                        ddltask19.DataSource = dt;
                        ddltask19.DataTextField = "task";
                        ddltask19.DataValueField = "task";
                        ddltask19.DataBind();
                        //row 20
                        ddltask20.DataSource = dt;
                        ddltask20.DataTextField = "task";
                        ddltask20.DataValueField = "task";
                        ddltask20.DataBind();

                        conn.Close();
                        ddltask1.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask2.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask3.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask4.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask5.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask6.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask7.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask8.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask9.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask10.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask11.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask12.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask13.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask14.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask15.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask16.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask17.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask18.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask19.Items.Insert(0, new ListItem("please select", "0"));
                        ddltask20.Items.Insert(0, new ListItem("please select", "0"));

                    }
                }
            }
            catch (Exception ex)
            {
                Label39.Text = ex.Message;
            }
        }
    }
}
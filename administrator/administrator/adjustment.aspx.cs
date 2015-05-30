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
    public partial class adjustment : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd, cmd1,cmd2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                binddropdownlist();
            }
        }
        protected void binddropdownlist()
        {
            try
            {
                using (conn)
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.CommandText = "SELECT partno from partno order by partno";
                        cmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //itemno 1
                        itemno1.DataSource = dt;
                        itemno1.DataValueField = "partno";
                        itemno1.DataTextField = "partno";
                        itemno1.DataBind();
                        //itemno 2
                        itemno2.DataSource = dt;
                        itemno2.DataValueField = "partno";
                        itemno2.DataTextField = "partno";
                        itemno2.DataBind();
                        //itemno 3
                        itemno3.DataSource = dt;
                        itemno3.DataValueField = "partno";
                        itemno3.DataTextField = "partno";
                        itemno3.DataBind();
                        //itemno 4
                        itemno4.DataSource = dt;
                        itemno4.DataValueField = "partno";
                        itemno4.DataTextField = "partno";
                        itemno4.DataBind();
                        //itemno 5
                        itemno5.DataSource = dt;
                        itemno5.DataValueField = "partno";
                        itemno5.DataTextField = "partno";
                        itemno5.DataBind();
                        //itemno 6
                        itemno6.DataSource = dt;
                        itemno6.DataValueField = "partno";
                        itemno6.DataTextField = "partno";
                        itemno6.DataBind();
                        //itemno 7
                        itemno7.DataSource = dt;
                        itemno7.DataValueField = "partno";
                        itemno7.DataTextField = "partno";
                        itemno7.DataBind();
                        //itemno 8
                        itemno8.DataSource = dt;
                        itemno8.DataValueField = "partno";
                        itemno8.DataTextField = "partno";
                        itemno8.DataBind();
                        //itemno 9
                        itemno9.DataSource = dt;
                        itemno9.DataValueField = "partno";
                        itemno9.DataTextField = "partno";
                        itemno9.DataBind();
                        //itemno 10
                        itemno10.DataSource = dt;
                        itemno10.DataValueField = "partno";
                        itemno10.DataTextField = "partno";
                        itemno10.DataBind();

                        conn.Close();
                        itemno1.Items.Insert(0, new ListItem("please select", "0"));
                        itemno2.Items.Insert(0, new ListItem("please select", "0"));
                        itemno3.Items.Insert(0, new ListItem("please select", "0"));
                        itemno4.Items.Insert(0, new ListItem("please select", "0"));
                        itemno5.Items.Insert(0, new ListItem("please select", "0"));
                        itemno6.Items.Insert(0, new ListItem("please select", "0"));
                        itemno7.Items.Insert(0, new ListItem("please select", "0"));
                        itemno8.Items.Insert(0, new ListItem("please select", "0"));
                        itemno9.Items.Insert(0, new ListItem("please select", "0"));
                        itemno10.Items.Insert(0, new ListItem("please select", "0"));

                    }
                    using (cmd1 = new SqlCommand())
                    {
                        cmd1.CommandText = "SELECT adjustment from adjustment order by num";
                        cmd1.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //adj1
                        adj1.DataSource = dt;
                        adj1.DataValueField = "adjustment";
                        adj1.DataTextField = "adjustment";
                        adj1.DataBind();
                        //adj2
                        adj2.DataSource = dt;
                        adj2.DataValueField = "adjustment";
                        adj2.DataTextField = "adjustment";
                        adj2.DataBind();
                        //adj3
                        adj3.DataSource = dt;
                        adj3.DataValueField = "adjustment";
                        adj3.DataTextField = "adjustment";
                        adj3.DataBind();
                        //adj4
                        adj4.DataSource = dt;
                        adj4.DataValueField = "adjustment";
                        adj4.DataTextField = "adjustment";
                        adj4.DataBind();
                        //adj5
                        adj5.DataSource = dt;
                        adj5.DataValueField = "adjustment";
                        adj5.DataTextField = "adjustment";
                        adj5.DataBind();
                        //adj6
                        adj6.DataSource = dt;
                        adj6.DataValueField = "adjustment";
                        adj6.DataTextField = "adjustment";
                        adj6.DataBind();
                        //adj7
                        adj7.DataSource = dt;
                        adj7.DataValueField = "adjustment";
                        adj7.DataTextField = "adjustment";
                        adj7.DataBind();
                        //adj8
                        adj8.DataSource = dt;
                        adj8.DataValueField = "adjustment";
                        adj8.DataTextField = "adjustment";
                        adj8.DataBind();
                        //adj9
                        adj9.DataSource = dt;
                        adj9.DataValueField = "adjustment";
                        adj9.DataTextField = "adjustment";
                        adj9.DataBind();
                        //adj10
                        adj10.DataSource = dt;
                        adj10.DataValueField = "adjustment";
                        adj10.DataTextField = "adjustment";
                        adj10.DataBind();

                        conn.Close();
                        adj1.Items.Insert(0, new ListItem("please select", "0"));
                        adj2.Items.Insert(0, new ListItem("please select", "0"));
                        adj3.Items.Insert(0, new ListItem("please select", "0"));
                        adj4.Items.Insert(0, new ListItem("please select", "0"));
                        adj5.Items.Insert(0, new ListItem("please select", "0"));
                        adj6.Items.Insert(0, new ListItem("please select", "0"));
                        adj7.Items.Insert(0, new ListItem("please select", "0"));
                        adj8.Items.Insert(0, new ListItem("please select", "0"));
                        adj9.Items.Insert(0, new ListItem("please select", "0"));
                        adj10.Items.Insert(0, new ListItem("please select", "0"));

                    }
                    using (cmd2 = new SqlCommand())
                    {
                        cmd2.CommandText = "SELECT store_name from store_master order by store_name";
                        cmd2.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //store1
                        store1.DataSource = dt;
                        store1.DataValueField = "store_name";
                        store1.DataTextField = "store_name";
                        store1.DataBind();
                        //store2
                        store2.DataSource = dt;
                        store2.DataValueField = "store_name";
                        store2.DataTextField = "store_name";
                        store2.DataBind();
                        //store3
                        store3.DataSource = dt;
                        store3.DataValueField = "store_name";
                        store3.DataTextField = "store_name";
                        store3.DataBind();
                        //store4
                        store4.DataSource = dt;
                        store4.DataValueField = "store_name";
                        store4.DataTextField = "store_name";
                        store4.DataBind();
                        //store5
                        store5.DataSource = dt;
                        store5.DataValueField = "store_name";
                        store5.DataTextField = "store_name";
                        store5.DataBind();
                        //store6
                        store6.DataSource = dt;
                        store6.DataValueField = "store_name";
                        store6.DataTextField = "store_name";
                        store6.DataBind();
                        //store7
                        store7.DataSource = dt;
                        store7.DataValueField = "store_name";
                        store7.DataTextField = "store_name";
                        store7.DataBind();
                        //store8
                        store8.DataSource = dt;
                        store8.DataValueField = "store_name";
                        store8.DataTextField = "store_name";
                        store8.DataBind();
                        //store9
                        store9.DataSource = dt;
                        store9.DataValueField = "store_name";
                        store9.DataTextField = "store_name";
                        store9.DataBind();
                        //store10
                        store10.DataSource = dt;
                        store10.DataValueField = "store_name";
                        store10.DataTextField = "store_name";
                        store10.DataBind();

                        conn.Close();
                        store1.Items.Insert(0, new ListItem("please select", "0"));
                        store2.Items.Insert(0, new ListItem("please select", "0"));
                        store3.Items.Insert(0, new ListItem("please select", "0"));
                        store4.Items.Insert(0, new ListItem("please select", "0"));
                        store5.Items.Insert(0, new ListItem("please select", "0"));
                        store6.Items.Insert(0, new ListItem("please select", "0"));
                        store7.Items.Insert(0, new ListItem("please select", "0"));
                        store8.Items.Insert(0, new ListItem("please select", "0"));
                        store9.Items.Insert(0, new ListItem("please select", "0"));
                        store10.Items.Insert(0, new ListItem("please select", "0"));

                    }
                }
            }
            catch (Exception ex)
            {
                Label11.Text = ex.Message;
            }
        }
    }
}
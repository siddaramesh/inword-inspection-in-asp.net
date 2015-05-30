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
    public partial class bare_pcb : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd1;
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
                    using (SqlCommand sqlcmd = new SqlCommand())
                    {
                        sqlcmd.CommandText = "SELECT num,suppliername,category from supplier order by suppliername asc";
                        sqlcmd.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList1.DataSource = dt;
                        DropDownList1.DataValueField = "num";
                        DropDownList1.DataTextField = "suppliername";
                        DropDownList1.DataBind();
                        conn.Close();

                        DropDownList1.Items.Insert(0, new ListItem("please select", "0"));


                    }
                    using (SqlCommand sqlcmd1 = new SqlCommand())
                    {
                        sqlcmd1.CommandText = "SELECT num,partno,description from partno order by partno asc";
                        sqlcmd1.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList2.DataSource = dt;
                        DropDownList2.DataValueField = "num";
                        DropDownList2.DataTextField = "partno";
                        DropDownList2.DataBind();
                        conn.Close();

                        DropDownList2.Items.Insert(0, new ListItem("please select", "0"));


                    }
                    using (SqlCommand sqlcmd2 = new SqlCommand())
                    {
                        sqlcmd2.CommandText = "SELECT num,name from inspectedby order by name asc";
                        sqlcmd2.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList3.DataSource = dt;
                        DropDownList3.DataValueField = "num";
                        DropDownList3.DataTextField = "name";
                        DropDownList3.DataBind();
                        conn.Close();

                        DropDownList3.Items.Insert(0, new ListItem("please select", "0"));


                    }
                    using (SqlCommand sqlcmd3 = new SqlCommand())
                    {
                        sqlcmd3.CommandText = "SELECT num,name from approvedby order by name asc";
                        sqlcmd3.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd3);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist3
                        DropDownList4.DataSource = dt;
                        DropDownList4.DataValueField = "num";
                        DropDownList4.DataTextField = "name";
                        DropDownList4.DataBind();
                        conn.Close();

                        DropDownList4.Items.Insert(0, new ListItem("please select", "0"));


                    }
                }
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cat = "";
            cmd1 = new SqlCommand("SELECT num,suppliername,category from supplier where suppliername='" + DropDownList1.SelectedItem.Text.Trim() + "';", conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {
                cat = (string)dbr["category"];
            }
            Label3.Text = cat;
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string des = "";
            cmd1 = new SqlCommand("SELECT num,partno,description from partno where partno='" + DropDownList2.SelectedItem.Text.Trim() + "';", conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {
                des = (string)dbr["description"];
            }
            TextBox5.Text = des;
        }
    }
}
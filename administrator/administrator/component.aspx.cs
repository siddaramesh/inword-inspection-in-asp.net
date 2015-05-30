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
    public partial class component : System.Web.UI.Page
    {
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        SqlCommand cmd1;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string des = "",inspected="",approved="";
            cmd1 = new SqlCommand("SELECT name,inspected,approved from userinfo where signin='true'", conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {
                des = (string)dbr["name"];
                inspected = (string)dbr["inspected"];
                approved = (string)dbr["approved"];
            }
            conn.Close();
            if (inspected == "True")
            {
                Label28.Text = des;
            }
            else
            {
                Label28.Text = "";
            }
            if (approved == "True")
            {
                Label29.Text = des;
            }
            else
            {
                Label29.Text = "";
            }

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
                        DropDownList1.DataValueField = "suppliername";
                        DropDownList1.DataTextField = "suppliername";
                        DropDownList1.DataBind();
                        conn.Close();

                        DropDownList1.Items.Insert(0, new ListItem("please select", "0"));


                    }
              /*      using (SqlCommand sqlcmd1 = new SqlCommand())
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


                    } */
                    using (SqlCommand sqlcmd2 = new SqlCommand())
                    {
                        sqlcmd2.CommandText = "SELECT distinct partno from partno order by partno asc";
                        sqlcmd2.Connection = conn;
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(sqlcmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //dropdownlist8
                        DropDownList8.DataSource = dt;
                        DropDownList8.DataValueField = "partno";
                        DropDownList8.DataTextField = "partno";
                        DropDownList8.DataBind();
                        conn.Close();
                        DropDownList8.Items.Insert(0,new ListItem(" ", "0"));

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
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);

                    string des = "", module = "", image = "";
                    cmd1 = new SqlCommand("SELECT num,partno,description,modules,images from partno where partno='" + DropDownList2.SelectedItem.Text.Trim() + "';", conn1);
                    SqlDataReader dbr;
                    conn1.Open();
                    dbr = cmd1.ExecuteReader();
                    while (dbr.Read())
                    {
                        des = (string)dbr["description"];
                        module = Convert.ToString(dbr["modules"]);
                        image = Convert.ToString(dbr["images"]);
                    }
                    conn1.Close();
                    if (module == "Electronic Components")
                    {
                        SqlCommand cmd2 = new SqlCommand("INSERT into components values('" + DropDownList1.SelectedItem.Text + "','" + Label3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + testreport.SelectedItem.Text + "','" + Label13.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox5.Text + "','" + TextBox16.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + Label28.Text + "','" + Label29.Text + "','" + TextBox4.Text + "','" + partnoverification.SelectedItem.Text + "','" + physicaldamage.SelectedItem.Text + "','" + TextBox13.Text + "','" + DropDownList5.SelectedItem.Text + "','" + DropDownList6.SelectedItem.Text + "','" + image + "','" + TextBox11.Text + "','" + Label24.Text + "','" + Label26.Text + "','" + Label34.Text + "','" + Label36.Text + "','" + Label38.Text + "','" + Label40.Text + "','" + Label42.Text + "')", conn1);
                        conn1.Open();
                        cmd2.ExecuteNonQuery();
                        conn1.Close();
                        Response.Redirect("~/component.aspx", false);
                    }
                    else if (module == "Led")
                    {
                        SqlCommand cmd3 = new SqlCommand("INSERT into led values('" + DropDownList1.SelectedItem.Text + "','" + Label3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + testreport.SelectedItem.Text + "','" + Label13.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox5.Text + "','" + TextBox16.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + Label28.Text + "','" + Label29.Text + "','" + TextBox10.Text + "','" + DropDownList3.SelectedItem.Text + "','" + DropDownList4.SelectedItem.Text + "','" + TextBox12.Text + "','" + DropDownList7.SelectedItem.Text + "','" + TextBox15.Text + "','" + image + "','" + TextBox14.Text + "','" + Label51.Text + "','" + Label53.Text + "','" + Label55.Text + "','" + Label57.Text + "','" + Label59.Text + "','" + Label61.Text + "','" + Label63.Text + "')", conn1);
                        conn1.Open();
                        cmd3.ExecuteNonQuery();
                        conn1.Close();
                        Response.Redirect("~/component.aspx", false);  
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
            conn.Close();
            Label3.Text = cat;
            Label86.Text = "";
            using (conn)
            {
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.CommandText = "SELECT distinct po.num as no, su.suppliername,po.partno as partno from supplier as su,poinput as po where su.suppliername='"+DropDownList1.SelectedItem.Text+"' and su.suppliername=po.suppliername";
                    sqlcmd.Connection = conn;
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //dropdownlist2
                    DropDownList2.DataSource = dt;
                    DropDownList2.DataValueField = "partno";
                    DropDownList2.DataTextField = "partno";
                    DropDownList2.DataBind();
                    conn.Close();

                    DropDownList2.Items.Insert(0, new ListItem("", "0"));
                }
            }
            
        }
        

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        
            try
            {
                string partno = "";
                int flag = 0;
                string des = "",module="",image="";
                cmd1 = new SqlCommand("SELECT num,partno,description,modules,images from partno where partno='" + DropDownList2.SelectedItem.Text.Trim() + "';", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = (string)dbr["description"];
                    module = Convert.ToString(dbr["modules"]);
                    image = Convert.ToString(dbr["images"]);
                }
                conn1.Close();
                TextBox5.Text = des;
                if (module == "Electronic Components")
                {
                    SqlCommand sqlcmd2 = new SqlCommand("SELECT comp_partno from components", conn1);
                    SqlDataReader dbr2;
                    conn1.Open();
                    dbr2 = sqlcmd2.ExecuteReader();
                    while (dbr2.Read())
                    {
                        partno = (string)dbr2["comp_partno"];
                        if (partno == DropDownList2.SelectedItem.Text)
                        {
                            flag = 1;
                            break;
                        }

                    }
                    if (flag == 1)
                    {
                        Label86.Text = "Selected PartNum already exist in the table, please select different partNum";
                    }
                    else
                    {
                        electronic.Visible = true;
                        electronic1.Visible = true;
                        Image1.ImageUrl = image;
                        Label86.Text = "";
                    }
                }
                else
                {
                    electronic.Visible = false;
                    electronic1.Visible = false;
                    Image1.ImageUrl = "";
                }
                if (module == "Led")
                {
                    SqlCommand sqlcmd3 = new SqlCommand("SELECT led_partno from led", conn1);
                    SqlDataReader dbr3;
                    conn1.Open();
                    dbr3 = sqlcmd3.ExecuteReader();
                    while (dbr3.Read())
                    {
                        partno = (string)dbr3["led_partno"];
                        if (partno == DropDownList2.SelectedItem.Text)
                        {
                            flag = 1;
                            break;
                        }

                    }
                    if (flag == 1)
                    {
                        Label86.Text = "Selected PartNum already exist in the table, please select different partNum";
                    }
                    else
                    {
                        led.Visible = true;
                        led1.Visible = true;
                        Image2.ImageUrl = image;
                        Label86.Text = "";
                    }
                }
                else
                {
                    led.Visible = false;
                    led1.Visible = false;
                    Image2.ImageUrl = "";
                }
                if (module == "Inductor")
                {

                    SqlCommand sqlcmd1 = new SqlCommand("SELECT inductor_partno from inductor", conn1);
                    SqlDataReader dbr1;
                    conn1.Open();
                    dbr1 = sqlcmd1.ExecuteReader();
                    while (dbr1.Read())
                    {
                        partno = (string)dbr1["inductor_partno"];
                        if (partno == DropDownList2.SelectedItem.Text)
                        {
                            flag = 1;
                            break;
                        }

                    }
                    if (flag == 1)
                    {
                        Label86.Text = "Selected PartNum already exist in the table, please select different partNum";
                    }
                    else
                    {
                        inductor.Visible = true;
                        inductor1.Visible = true;
                        Label86.Text = "";
                    }
                }
                else
                {
                    inductor.Visible = false;
                    inductor1.Visible = false;
                
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }


        }

        protected void physicaldamage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (physicaldamage.SelectedItem.Text == "Yes")
            {
                Label30.Visible = true;
                TextBox13.Visible = true;
            }
            else
            {
                Label30.Visible = false;
                TextBox13.Visible = false;
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( DropDownList4.SelectedItem.Text == "Yes")
            {
                Label46.Visible = true;
                TextBox12.Visible = true;
            }
            else
            {
                Label46.Visible = false;
                TextBox12.Visible = false;
            }
        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {
             SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);

             try
             {
                 string module = "";
                 cmd1 = new SqlCommand("SELECT num,partno,description,modules,images from partno where partno='" + DropDownList2.SelectedItem.Text.Trim() + "';", conn1);
                 SqlDataReader dbr;
                 conn1.Open();
                 dbr = cmd1.ExecuteReader();
                 while (dbr.Read())
                 {

                     module = Convert.ToString(dbr["modules"]);

                 }
                 conn1.Close();

                 if (module == "Electronic Components")
                 {
                     TextBox4.Text = TextBox8.Text;
                 }
                 if (module == "Led")
                 {
                     TextBox10.Text = TextBox8.Text;
                 }
                 if (module == "Inductor")
                 {
                     TextBox17.Text = TextBox8.Text;
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

        protected void partnoverification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (partnoverification.SelectedItem.Text == "No")
            {
                Label34.Text = "REJECTED";
            }
            else
            {
                Label34.Text = "ACCEPTED";
            }
        }

        protected void TextBox13_TextChanged(object sender, EventArgs e)
        {
            Label36.Text = TextBox13.Text;
        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList5.SelectedItem.Text == "No")
            {
                Label38.Text = "REJECTED";
            }
            else
            {
                Label38.Text = "ACCEPTED";
            }
        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList6.SelectedItem.Text == "No")
            {
                Label40.Text = "REJECTED";
            }
            else
            {
                Label40.Text = "ACCEPTED";
            }
        }

        protected void TextBox11_TextChanged(object sender, EventArgs e)
        {
            double qtyrecieve, qtyaccepted,res;
            qtyrecieve = Convert.ToDouble(TextBox4.Text);
            qtyaccepted = Convert.ToDouble(TextBox11.Text);
            res = qtyrecieve - qtyaccepted;
            Label42.Text = Convert.ToString(res);

            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);

            try
            {
                double invoice, recieve, order, res1, res2;
                string qty = "";
                cmd1 = new SqlCommand("SELECT distinct suppliername,partno,qty from poinput where suppliername='" + DropDownList1.SelectedItem.Text + "'and partno='" + DropDownList2.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {

                    qty = Convert.ToString(dbr["qty"]);

                }
                conn1.Close();
                invoice = Convert.ToDouble(TextBox8.Text);
                recieve = Convert.ToDouble(TextBox4.Text);
                order = Convert.ToDouble(qty);
                res1 = recieve - invoice;
                res2 = recieve - order;
                Label24.Text = Convert.ToString(res1);
                Label26.Text = Convert.ToString(res2);

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

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList3.SelectedItem.Text == "No")
            {
                Label55.Text = "REJECTED";
            }
            else
            {
                Label55.Text = "ACCEPTED";
            }
        }

        protected void TextBox12_TextChanged(object sender, EventArgs e)
        {
            Label57.Text = TextBox12.Text;
        }

        protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList7.SelectedItem.Text == "No")
            {
                Label59.Text = "REJECTED";
            }
            else
            {
                Label59.Text = "ACCEPTED";
            }
        }

        protected void TextBox15_TextChanged(object sender, EventArgs e)
        {
            Label61.Text = TextBox15.Text;
        }

        protected void TextBox14_TextChanged(object sender, EventArgs e)
        {
            double qtyrecieve, qtyaccepted, res;
            qtyrecieve = Convert.ToDouble(TextBox10.Text);
            qtyaccepted = Convert.ToDouble(TextBox14.Text);
            res = qtyrecieve - qtyaccepted;
            Label63.Text = Convert.ToString(res);

            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);

            try
            {
                double invoice, recieve, order, res1, res2;
                string qty = "";
                cmd1 = new SqlCommand("SELECT distinct suppliername,partno,qty from poinput where suppliername='" + DropDownList1.SelectedItem.Text + "'and partno='" + DropDownList2.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {

                    qty = Convert.ToString(dbr["qty"]);

                }
                conn1.Close();
                invoice = Convert.ToDouble(TextBox8.Text);
                recieve = Convert.ToDouble(TextBox10.Text);
                order = Convert.ToDouble(qty);
                res1 = recieve - invoice;
                res2 = recieve - order;
                Label51.Text = Convert.ToString(res1);
                Label53.Text = Convert.ToString(res2);

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

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void testreport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testreport.SelectedItem.Text == "No")
            {
                var id = Guid.NewGuid().ToString();
                TextBox16.Text = id;
            }
            else
            {
                TextBox16.Text = "";
            }
        }

        protected void popup1_Click(object sender, EventArgs e)
        {
            Int32 min=0, max=0;
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("SELECT min,max from partno where partno='" + DropDownList2.SelectedItem.Text + "';", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {

                min = Convert.ToInt32(dbr["min"]);
                max = Convert.ToInt32(dbr["max"]);

            }
            conn1.Close();
            Session["min"] = min;
            Session["max"] = max;
            Session["data"] = TextBox8.Text;
           ScriptManager.RegisterStartupScript(this, GetType(), "select", "select();", true);
           
        }

        
        protected void TextBox21_TextChanged(object sender, EventArgs e)
        {
            
            Label79.Text = TextBox21.Text;
        }

        protected void popup2_Click(object sender, EventArgs e)
        {
            

            Int32 min = 0, max = 0;
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("SELECT min,max from partno where partno='" + DropDownList2.SelectedItem.Text + "';", conn1);
            SqlDataReader dbr;
            conn1.Open();
            dbr = cmd1.ExecuteReader();
            while (dbr.Read())
            {

                min = Convert.ToInt32(dbr["min"]);
                max = Convert.ToInt32(dbr["max"]);

            }
            conn1.Close();
            Session["min"] = min;
            Session["max"] = max;
            ScriptManager.RegisterStartupScript(this, GetType(), "dcr", "dcr();", true);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["dcroutofrange"] != null)
            {
                Label83.Text = Session["dcroutofrange"].ToString();
                TextBox20.Text = Session["dcroutofrange"].ToString();
            }
            if (Session["leadno"] != null)
            {
                Label81.Text = Session["leadno"].ToString();
                TextBox19.Text = Session["leadno"].ToString();
            }
            if (Session["tinningno"] != null)
            {
                Label77.Text = Session["tinningno"].ToString();
                TextBox18.Text = Session["tinningno"].ToString();
            }
            if (Session["outofrange"] != null)
            {
                primary.Text = Session["outofrange"].ToString();
                Label75.Text = Session["outofrange"].ToString();
            }

            /*  double qtyrecieve, qtyaccepted, res;
              qtyrecieve = Convert.ToDouble(TextBox10.Text);
              qtyaccepted = Convert.ToDouble(TextBox14.Text);
              res = qtyrecieve - qtyaccepted;
              Label63.Text = Convert.ToString(res); */

            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);

            try
            {
                double invoice, recieve, order, res1, res2;
                string qty = "";
                cmd1 = new SqlCommand("SELECT distinct suppliername,partno,qty from poinput where suppliername='" + DropDownList1.SelectedItem.Text + "'and partno='" + DropDownList2.SelectedItem.Text + "'", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {

                    qty = Convert.ToString(dbr["qty"]);

                }
                conn1.Close();
                invoice = Convert.ToDouble(TextBox8.Text);
                recieve = Convert.ToDouble(TextBox17.Text);
                order = Convert.ToDouble(qty);
                res1 = recieve - invoice;
                res2 = recieve - order;
                Label71.Text = Convert.ToString(res1);
                Label73.Text = Convert.ToString(res2);

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

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);

                string des = "", module = "", image = "";
                cmd1 = new SqlCommand("SELECT num,partno,description,modules,images from partno where partno='" + DropDownList2.SelectedItem.Text.Trim() + "';", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = (string)dbr["description"];
                    module = Convert.ToString(dbr["modules"]);
                    image = Convert.ToString(dbr["images"]);
                }
                conn1.Close();
                if (module == "Electronic Components")
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT into components values('" + DropDownList1.SelectedItem.Text + "','" + Label3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + testreport.SelectedItem.Text + "','" + Label13.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox5.Text + "','" + TextBox16.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + Label28.Text + "','" + Label29.Text + "','" + TextBox4.Text + "','" + partnoverification.SelectedItem.Text + "','" + physicaldamage.SelectedItem.Text + "','" + TextBox13.Text + "','" + DropDownList5.SelectedItem.Text + "','" + DropDownList6.SelectedItem.Text + "','" + image + "','" + TextBox11.Text + "','" + Label24.Text + "','" + Label26.Text + "','" + Label34.Text + "','" + Label36.Text + "','" + Label38.Text + "','" + Label40.Text + "','" + Label42.Text + "')", conn1);
                    conn1.Open();
                    cmd2.ExecuteNonQuery();
                    conn1.Close();
                    Response.Redirect("~/component.aspx", false);
                }
                else if (module == "Led")
                {
                    SqlCommand cmd3 = new SqlCommand("INSERT into led values('" + DropDownList1.SelectedItem.Text + "','" + Label3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + testreport.SelectedItem.Text + "','" + Label13.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox5.Text + "','" + TextBox16.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + Label28.Text + "','" + Label29.Text + "','" + TextBox10.Text + "','" + DropDownList3.SelectedItem.Text + "','" + DropDownList4.SelectedItem.Text + "','" + TextBox12.Text + "','" + DropDownList7.SelectedItem.Text + "','" + TextBox15.Text + "','" + image + "','" + TextBox14.Text + "','" + Label51.Text + "','" + Label53.Text + "','" + Label55.Text + "','" + Label57.Text + "','" + Label59.Text + "','" + Label61.Text + "','" + Label63.Text + "')", conn1);
                    conn1.Open();
                    cmd3.ExecuteNonQuery();
                    conn1.Close();
                    Response.Redirect("~/component.aspx", false);
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);

                string des = "", module = "", image = "";
                cmd1 = new SqlCommand("SELECT num,partno,description,modules,images from partno where partno='" + DropDownList2.SelectedItem.Text.Trim() + "';", conn1);
                SqlDataReader dbr;
                conn1.Open();
                dbr = cmd1.ExecuteReader();
                while (dbr.Read())
                {
                    des = (string)dbr["description"];
                    module = Convert.ToString(dbr["modules"]);
                    image = Convert.ToString(dbr["images"]);
                }
                conn1.Close();
                if (module == "Electronic Components")
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT into components values('" + DropDownList1.SelectedItem.Text + "','" + Label3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + testreport.SelectedItem.Text + "','" + Label13.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox5.Text + "','" + TextBox16.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + Label28.Text + "','" + Label29.Text + "','" + TextBox4.Text + "','" + partnoverification.SelectedItem.Text + "','" + physicaldamage.SelectedItem.Text + "','" + TextBox13.Text + "','" + DropDownList5.SelectedItem.Text + "','" + DropDownList6.SelectedItem.Text + "','" + image + "','" + TextBox11.Text + "','" + Label24.Text + "','" + Label26.Text + "','" + Label34.Text + "','" + Label36.Text + "','" + Label38.Text + "','" + Label40.Text + "','" + Label42.Text + "')", conn1);
                    conn1.Open();
                    cmd2.ExecuteNonQuery();
                    conn1.Close();
                    Response.Redirect("~/component.aspx", false);
                }
                else if (module == "Led")
                {
                    SqlCommand cmd3 = new SqlCommand("INSERT into led values('" + DropDownList1.SelectedItem.Text + "','" + Label3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + testreport.SelectedItem.Text + "','" + Label13.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox5.Text + "','" + TextBox16.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + Label28.Text + "','" + Label29.Text + "','" + TextBox10.Text + "','" + DropDownList3.SelectedItem.Text + "','" + DropDownList4.SelectedItem.Text + "','" + TextBox12.Text + "','" + DropDownList7.SelectedItem.Text + "','" + TextBox15.Text + "','" + image + "','" + TextBox14.Text + "','" + Label51.Text + "','" + Label53.Text + "','" + Label55.Text + "','" + Label57.Text + "','" + Label59.Text + "','" + Label61.Text + "','" + Label63.Text + "')", conn1);
                    conn1.Open();
                    cmd3.ExecuteNonQuery();
                    conn1.Close();
                    Response.Redirect("~/component.aspx", false);
                }
                else if (module == "Inductor")
                {
                    string[] lbl = new string[20];
                    string[] txtbox = new string[20];

                    string[] plbl = new string[20];
                    string[] ptxtbox = new string[20];
                    int j = 0;
                    for (int i = 1; i <= 20; i++)
                    {
                        if (j != 20)
                        {
                            if (Session["ptextbox" + i] != null)
                            {
                                ptxtbox[j] = Session["ptextbox" + i].ToString();

                            }
                            if (Session["plabel" + i] != null)
                            {
                                plbl[j] = Session["plabel" + i].ToString();
                            }
                        }
                        j = j + 1;
                    }
                    j = 0;
                    for (int i = 1; i <= 20; i++)
                    {
                        if (j != 20)
                        {
                            if (Session["dcrtextbox" + i] != null)
                            {
                                txtbox[j] = Session["dcrtextbox" + i].ToString();

                            }
                            if (Session["dcrlabel" + i] != null)
                            {
                                lbl[j] = Session["dcrlabel" + i].ToString();
                            }
                        }
                        j = j + 1;
                    }

                    string min = "";
                    string max = "";
                    if (Session["dcrmin"] != null)
                    {
                        min = Session["dcrmin"].ToString();

                    }
                    else
                    {
                        min = "";
                    }
                    if (Session["dcrmax"] != null)
                    {
                        max = Session["dcrmax"].ToString();
                    }
                    else
                    {
                        max = "";
                    }

                 /*   if (Session["dcrtextbox1"] != null)
                    {
                        txtbox[0] = Session["dcrtextbox1"].ToString();
                    }
                    if (Session["dcrtextbox2"] != null)
                    {
                        txtbox[1] = Session["dcrtextbox2"].ToString();
                    }
                    if (Session["dcrtextbox3"] != null)
                    {
                        txtbox[2] = Session["dcrtextbox3"].ToString();
                    }
                    if (Session["dcrtextbox4"] != null)
                    {
                        txtbox[3] = Session["dcrtextbox4"].ToString();
                    }
                    if (Session["dcrtextbox5"] != null)
                    {
                        txtbox[4] = Session["dcrtextbox5"].ToString();
                    }
                    if (Session["dcrtextbox6"] != null)
                    {
                        txtbox[5] = Session["dcrtextbox6"].ToString();
                    }
                    if (Session["dcrtextbox7"] != null)
                    {
                        txtbox[6] = Session["dcrtextbox7"].ToString();
                    }
                    if (Session["dcrtextbox8"] != null)
                    {
                        txtbox[7] = Session["dcrtextbox8"].ToString();
                    }
                    if (Session["dcrtextbox9"] != null)
                    {
                        txtbox[8] = Session["dcrtextbox9"].ToString();
                    }
                    if (Session["dcrtextbox10"] != null)
                    {
                        txtbox[9] = Session["dcrtextbox10"].ToString();
                    }
                    if (Session["dcrtextbox11"] != null)
                    {
                        txtbox[10] = Session["dcrtextbox11"].ToString();
                    }
                    if (Session["dcrtextbox12"] != null)
                    {
                        txtbox[11] = Session["dcrtextbox12"].ToString();
                    }
                    if (Session["dcrtextbox13"] != null)
                    {
                        txtbox[12] = Session["dcrtextbox13"].ToString();
                    }
                    if (Session["dcrtextbox14"] != null)
                    {
                        txtbox[13] = Session["dcrtextbox14"].ToString();
                    }
                    if (Session["dcrtextbox15"] != null)
                    {
                        txtbox[14] = Session["dcrtextbox15"].ToString();
                    }
                    if (Session["dcrtextbox16"] != null)
                    {
                        txtbox[15] = Session["dcrtextbox16"].ToString();
                    }
                    if (Session["dcrtextbox17"] != null)
                    {
                        txtbox[16] = Session["dcrtextbox17"].ToString();
                    }
                    if (Session["dcrtextbox18"] != null)
                    {
                        txtbox[17] = Session["dcrtextbox18"].ToString();
                    }
                    if (Session["dcrtextbox19"] != null)
                    {
                        txtbox[18] = Session["dcrtextbox19"].ToString();
                    }
                    if (Session["dcrtextbox20"] != null)
                    {
                        txtbox[19] = Session["dcrtextbox20"].ToString();
                    }

                    //label result
                    if (Session["dcrlabel1"] != null)
                    {
                        lbl[0] = Session["dcrlabel1"].ToString();
                    }
                    if (Session["dcrlabel2"] != null)
                    {
                        lbl[1] = Session["dcrlabel2"].ToString();
                    }
                    if (Session["dcrlabel3"] != null)
                    {
                        lbl[2] = Session["dcrlabel3"].ToString();
                    }
                    if (Session["dcrlabel4"] != null)
                    {
                        lbl[3] = Session["dcrlabel4"].ToString();
                    }
                    if (Session["dcrlabel5"] != null)
                    {
                        lbl[4] = Session["dcrlabel5"].ToString();
                    }
                    if (Session["dcrlabel6"] != null)
                    {
                        lbl[5] = Session["dcrlabel6"].ToString();
                    }
                    if (Session["dcrlabel7"] != null)
                    {
                        lbl[6] = Session["dcrlabel7"].ToString();
                    }
                    if (Session["dcrlabel8"] != null)
                    {
                        lbl[7] = Session["dcrlabel8"].ToString();
                    }
                    if (Session["dcrlabel9"] != null)
                    {
                        lbl[8] = Session["dcrlabel9"].ToString();
                    }
                    if (Session["dcrlabel10"] != null)
                    {
                        lbl[9] = Session["dcrlabel10"].ToString();
                    }
                    if (Session["dcrlabel11"] != null)
                    {
                        lbl[10] = Session["dcrlabel11"].ToString();
                    }
                    if (Session["dcrlabel12"] != null)
                    {
                        lbl[11] = Session["dcrlabel12"].ToString();
                    }
                    if (Session["dcrlabel13"] != null)
                    {
                        lbl[12] = Session["dcrlabel13"].ToString();
                    }
                    if (Session["dcrlabel14"] != null)
                    {
                        lbl[13] = Session["dcrlabel14"].ToString();
                    }
                    if (Session["dcrlabel15"] != null)
                    {
                        lbl[14] = Session["dcrlabel15"].ToString();
                    }
                    if (Session["dcrlabel16"] != null)
                    {
                        lbl[15] = Session["dcrlabel16"].ToString();
                    }
                    if (Session["dcrlabel17"] != null)
                    {
                        lbl[16] = Session["dcrlabel17"].ToString();
                    }
                    if (Session["dcrlabel18"] != null)
                    {
                        lbl[17] = Session["dcrlabel18"].ToString();
                    }
                    if (Session["dcrlabel19"] != null)
                    {
                        lbl[18] = Session["dcrlabel19"].ToString();
                    }
                    if (Session["dcrlabel20"] != null)
                    {
                        lbl[19] = Session["dcrlabel20"].ToString();
                    }
                    */
                    
                        for (int i = 0; i < txtbox.Length; i++)
                        {
                            SqlCommand cmd4 = new SqlCommand("INSERT into inductor values('" + DropDownList1.SelectedItem.Text + "','" + Label3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + testreport.SelectedItem.Text + "','" + Label13.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox5.Text + "','" + TextBox16.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + Label28.Text + "','" + Label29.Text + "','" + TextBox17.Text + "','" + min + "','" + max + "','" + ptxtbox[i] + "','" + plbl[i] + "','" + Label75.Text + "','" + Label77.Text + "','" + Label79.Text + "','" + Label81.Text + "','" + min + "','" + max + "','" + txtbox[i] + "','" + lbl[i] + "','" + Label83.Text + "','" + Label71.Text + "','" + Label73.Text + "','" + Label75.Text + "','" + Label77.Text + "','" + Label79.Text + "','" + Label81.Text + "','" + Label83.Text + "','" + Label84.Text + "')", conn1);
                            conn1.Open();
                            cmd4.ExecuteNonQuery();
                            conn1.Close();
                        }
                    
                  /*  for (int i = 1; i < txtbox.Length; i++)
                    {
                        SqlCommand cmd5 = new SqlCommand("INSERT into inductor(primary_min,primary_max,primary_values,primary_result,dcr_min,dcr_max,dcr_values,dcr_result)values('" + min + "','" + max + "','" + ptxtbox[i] + "','" + plbl[i] + "','" + min + "','" + max + "','" + txtbox[i] + "','" + lbl[i] + "')", conn1);
                        conn1.Open();
                        cmd5.ExecuteNonQuery();
                        conn1.Close();
                    } */
                    Response.Redirect("~/component.aspx", false); 
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

        protected void Button5_Click(object sender, EventArgs e)
        {
            string module = "";
            string suppliername = "", category = "", invoiceno = "", dcno = "", supplieddate = "", testreport1 = "", reportno = "", partno = "", description = "";
            string lotno = "", inspectiondate = "", qtyordered = "", qtyrecieved = "", remarks = "", approvedby = "", inspectedby = "", recieveqtycounted = "", topverification = "";
            string physicaddamage = "", physicalremark = "", leadsolderability = "", packageverification = "", image = "", qtyaccepted = "";
            string recieve_vs_invoice = "", recieve_vs_ordered = "",toppartnoverification = "", physicaldamageresult = "", leadsolderabilityresult = "", packageverificationresult = "", quantityresult = "";

            try
            {
                SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                SqlCommand cmd3 = new SqlCommand("SELECT modules from partno where partno='" + DropDownList8.SelectedItem.Text + "'", conn2);
                SqlDataReader dbr;
                conn2.Open();
                dbr = cmd3.ExecuteReader();
                while (dbr.Read())
                {
                    module = Convert.ToString(dbr["modules"]);
                }
                conn2.Close();
                if (module == "Electronic Components")
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT * from components where comp_partno='" + DropDownList8.SelectedItem.Text + "'", conn2);
                    SqlDataReader sdr;
                    conn2.Open();
                    sdr = cmd2.ExecuteReader();
                    while (sdr.Read())
                    {
                        suppliername = Convert.ToString(sdr["comp_supplier_name"]);
                        category = Convert.ToString(sdr["comp_category"]);
                        invoiceno = Convert.ToString(sdr["comp_supp_invoice_no"]);
                        dcno = Convert.ToString(sdr["comp_supp_dc_no"]);
                        supplieddate = Convert.ToString(sdr["comp_supp_date"]);
                        testreport1 = Convert.ToString(sdr["comp_test_report"]);
                        reportno = Convert.ToString(sdr["comp_report_no"]);
                        partno = Convert.ToString(sdr["comp_partno"]);
                        description = Convert.ToString(sdr["comp_description"]);
                        lotno = Convert.ToString(sdr["comp_lot_no"]);
                        inspectiondate = Convert.ToString(sdr["comp_inspection_date"]);
                        qtyordered = Convert.ToString(sdr["comp_quantity_ordered"]);
                        qtyrecieved = Convert.ToString(sdr["comp_quantity_recieved"]);
                        remarks = Convert.ToString(sdr["comp_qty_remarks"]);
                        inspectedby = Convert.ToString(sdr["comp_inspectedby"]);
                        approvedby = Convert.ToString(sdr["comp_approvedby"]);
                        recieveqtycounted = Convert.ToString(sdr["comp_recieve_qty_counted"]);
                        topverification = Convert.ToString(sdr["comp_partno_top_verification"]);
                        physicaddamage = Convert.ToString(sdr["comp_physical_damage"]);
                        physicalremark = Convert.ToString(sdr["comp_remarks"]);
                        leadsolderability = Convert.ToString(sdr["comp_lead_solderability"]);
                        packageverification = Convert.ToString(sdr["comp_package_verification_order_vs_recieved"]);
                        image = Convert.ToString(sdr["comp_image"]);
                        qtyaccepted = Convert.ToString(sdr["comp_qty_accepted"]);
                        recieve_vs_invoice = Convert.ToString(sdr["comp_recieve_qty_counted_vs_invoice_qty"]);
                        recieve_vs_ordered = Convert.ToString(sdr["comp_recieve_qty_counted_vs_ordered_qty"]);
                        toppartnoverification = Convert.ToString(sdr["partno_top_mark_verification_result"]);
                        physicaldamageresult = Convert.ToString(sdr["physical_damage_result"]);
                        leadsolderabilityresult = Convert.ToString(sdr["lead_solderability_result"]);
                        packageverificationresult = Convert.ToString(sdr["package_verification_result"]);
                        quantityresult = Convert.ToString(sdr["quantity_rejected_total"]);
                    }
                    conn2.Close();
                    DropDownList1.Text = suppliername;
                    Label3.Text = category;
                    TextBox1.Text = invoiceno;
                    TextBox2.Text = dcno;
                    TextBox3.Text = supplieddate;
                    testreport.SelectedItem.Text = testreport1;
                    Label13.Text = reportno;
                    DropDownList2.Text = partno;
                    TextBox5.Text = description;
                    TextBox16.Text = lotno;
                    TextBox6.Text = inspectiondate;
                    TextBox7.Text = qtyordered;
                    TextBox8.Text = qtyrecieved;
                    TextBox9.Text = remarks;
                    Label28.Text = inspectedby;
                    Label29.Text = approvedby;
                    TextBox4.Text = recieveqtycounted;
                    physicaldamage.SelectedItem.Text = physicaddamage;
                    partnoverification.SelectedItem.Text = topverification;
                    TextBox13.Text = physicalremark;
                    DropDownList5.SelectedItem.Text = leadsolderability;

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

       
    }
}
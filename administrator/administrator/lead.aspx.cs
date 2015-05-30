using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace administrator
{
    public partial class lead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList21.SelectedItem.Text == "Yes")
            {
                DropDownList1.Text = "1";
                DropDownList2.Text = "1";
                DropDownList3.Text = "1";
                DropDownList4.Text = "1";
                DropDownList5.Text = "1";
                DropDownList6.Text = "1";
                DropDownList7.Text = "1";
                DropDownList8.Text = "1";
                DropDownList9.Text = "1";
                DropDownList10.Text = "1";
                DropDownList11.Text = "1";
                DropDownList12.Text = "1";
                DropDownList13.Text = "1";
                DropDownList14.Text = "1";
                DropDownList15.Text = "1";
                DropDownList16.Text = "1";
                DropDownList17.Text = "1";
                DropDownList18.Text = "1";
                DropDownList19.Text = "1";
                DropDownList20.Text = "1";
            }
            else
            {
                DropDownList1.Text = "2";
                DropDownList2.Text = "2";
                DropDownList3.Text = "2";
                DropDownList4.Text = "2";
                DropDownList5.Text = "2";
                DropDownList6.Text = "2";
                DropDownList7.Text = "2";
                DropDownList8.Text = "2";
                DropDownList9.Text = "2";
                DropDownList10.Text = "2";
                DropDownList11.Text = "2";
                DropDownList12.Text = "2";
                DropDownList13.Text = "2";
                DropDownList14.Text = "2";
                DropDownList15.Text = "2";
                DropDownList16.Text = "2";
                DropDownList17.Text = "2";
                DropDownList18.Text = "2";
                DropDownList19.Text = "2";
                DropDownList20.Text = "2";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int yes = 0, no = 0;
            if (DropDownList1.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList2.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList3.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList4.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList5.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList6.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList7.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList8.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList9.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList10.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList11.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList12.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList13.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList14.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList15.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList16.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList17.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList18.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList19.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }
            if (DropDownList20.SelectedItem.Text == "Yes")
            {
                yes = yes + 1;
            }
            else
            {
                no = no + 1;
            }

            Label23.Text = yes.ToString();
            Label25.Text = no.ToString();
            Session["leadyes"] = Label23.Text;
            Session["leadno"] = Label25.Text;
            if (Label25.Text == "0")
            {
                DropDownList21.Text = "1";
            }
            else
            {
                DropDownList21.Text = "2";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["leadyes"] = Label23.Text;
            Session["leadno"] = Label25.Text;
            ScriptManager.RegisterStartupScript(this, GetType(), "lead", "leadreturn();", true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;

namespace administrator
{
    public partial class dcr : System.Web.UI.Page
    {
        string min = "", max = "";
        double mi, ma;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["min"] != null && Session["max"] != null)
            {
                min = Session["min"].ToString();
                max = Session["max"].ToString();
                mi = Convert.ToDouble(min);
                ma = Convert.ToDouble(max);
                Label7.Text = min;
                Label8.Text = max;
                Label11.Text = min;
                Label12.Text = max;

                Label15.Text = min;
                Label16.Text = max;
                Label19.Text = min;
                Label20.Text = max;

                Label23.Text = min;
                Label24.Text = max;
                Label27.Text = min;
                Label28.Text = max;

                Label31.Text = min;
                Label32.Text = max;
                Label35.Text = min;
                Label36.Text = max;

                Label39.Text = min;
                Label40.Text = max;
                Label43.Text = min;
                Label44.Text = max;

                Label47.Text = min;
                Label48.Text = max;
                Label51.Text = min;
                Label52.Text = max;

                Label55.Text = min;
                Label56.Text = max;
                Label59.Text = min;
                Label60.Text = max;

                Label63.Text = min;
                Label64.Text = max;
                Label67.Text = min;
                Label68.Text = max;

                Label71.Text = min;
                Label72.Text = max;
                Label75.Text = min;
                Label76.Text = max;

                Label79.Text = min;
                Label80.Text = max;
                Label83.Text = min;
                Label84.Text = max;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" || TextBox2.Text == "0" || TextBox3.Text == "0" || TextBox4.Text == "0" || TextBox5.Text == "0" || TextBox6.Text == "0" || TextBox7.Text == "0" || TextBox8.Text == "0" || TextBox9.Text == "0" || TextBox10.Text == "0" || TextBox11.Text == "0" || TextBox12.Text == "0" || TextBox13.Text == "0" || TextBox14.Text == "0" || TextBox15.Text == "0" || TextBox16.Text == "0" || TextBox17.Text == "0" || TextBox18.Text == "0" || TextBox19.Text == "0" || TextBox20.Text == "0")
            {
                Label87.Text = "Your Not Yet Finished, Textbox's are still empty OR values must be greaterthan Zero";
            }
            else
            {
                double txt1 = 0;
                txt1 = Convert.ToDouble(TextBox1.Text);
                if (txt1 < mi)
                {
                    Label9.Text = "LESSTHAN";

                }
                else if (txt1 > ma)
                {
                    Label9.Text = "MORETHAN";

                }
                else
                {
                    Label9.Text = "OK";

                }
                //
                double txt2 = 0;
                txt2 = Convert.ToDouble(TextBox2.Text);
                if (txt2 < mi)
                {
                    Label13.Text = "LESSTHAN";

                }
                else if (txt2 > ma)
                {
                    Label13.Text = "MORETHAN";

                }
                else
                {
                    Label13.Text = "OK";

                }
                //
                double txt3 = 0;
                txt3 = Convert.ToDouble(TextBox3.Text);
                if (txt3 < mi)
                {
                    Label17.Text = "LESSTHAN";

                }
                else if (txt3 > ma)
                {
                    Label17.Text = "MORETHAN";

                }
                else
                {
                    Label17.Text = "OK";

                }
                //
                double txt = 0;
                txt = Convert.ToDouble(TextBox4.Text);
                if (txt < mi)
                {
                    Label21.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label21.Text = "MORETHAN";

                }
                else
                {
                    Label21.Text = "OK";

                }


                txt = Convert.ToDouble(TextBox5.Text);
                if (txt < mi)
                {
                    Label25.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label25.Text = "MORETHAN";

                }
                else
                {
                    Label25.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox6.Text);
                if (txt < mi)
                {
                    Label29.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label29.Text = "MORETHAN";

                }
                else
                {
                    Label29.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox7.Text);
                if (txt < mi)
                {
                    Label33.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label33.Text = "MORETHAN";

                }
                else
                {
                    Label33.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox8.Text);
                if (txt < mi)
                {
                    Label37.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label37.Text = "MORETHAN";

                }
                else
                {
                    Label37.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox9.Text);
                if (txt < mi)
                {
                    Label41.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label41.Text = "MORETHAN";

                }
                else
                {
                    Label41.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox10.Text);
                if (txt < mi)
                {
                    Label45.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label45.Text = "MORETHAN";

                }
                else
                {
                    Label45.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox11.Text);
                if (txt < mi)
                {
                    Label49.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label49.Text = "MORETHAN";

                }
                else
                {
                    Label49.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox12.Text);
                if (txt < mi)
                {
                    Label53.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label53.Text = "MORETHAN";

                }
                else
                {
                    Label53.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox13.Text);
                if (txt < mi)
                {
                    Label57.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label57.Text = "MORETHAN";

                }
                else
                {
                    Label57.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox14.Text);
                if (txt < mi)
                {
                    Label61.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label61.Text = "MORETHAN";

                }
                else
                {
                    Label61.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox15.Text);
                if (txt < mi)
                {
                    Label65.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label65.Text = "MORETHAN";

                }
                else
                {
                    Label65.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox16.Text);
                if (txt < mi)
                {
                    Label69.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label69.Text = "MORETHAN";

                }
                else
                {
                    Label69.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox17.Text);
                if (txt < mi)
                {
                    Label73.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label73.Text = "MORETHAN";

                }
                else
                {
                    Label73.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox18.Text);
                if (txt < mi)
                {
                    Label77.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label77.Text = "MORETHAN";

                }
                else
                {
                    Label77.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox19.Text);
                if (txt < mi)
                {
                    Label81.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label81.Text = "MORETHAN";

                }
                else
                {
                    Label81.Text = "OK";

                }

                txt = Convert.ToDouble(TextBox20.Text);
                if (txt < mi)
                {
                    Label85.Text = "LESSTHAN";

                }
                else if (txt > ma)
                {
                    Label85.Text = "MORETHAN";

                }
                else
                {
                    Label85.Text = "OK";

                }
                int min = 0, max = 0, ok = 0;
                if (Label9.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label9.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label13.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label13.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label17.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label17.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label21.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label21.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label25.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label25.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label29.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label29.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label33.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label33.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label37.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label37.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label41.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label41.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label45.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label45.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label49.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label49.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label53.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label53.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label57.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label57.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label61.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label61.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label65.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label65.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label69.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label69.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label73.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label73.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label77.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label77.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label81.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label81.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                if (Label85.Text == "LESSTHAN")
                {
                    min = min + 1;
                }
                else if (Label85.Text == "MORETHAN")
                {
                    max = max + 1;
                }
                else
                {
                    ok = ok + 1;
                }

                Label93.Text = Convert.ToString(ok);
                Label89.Text = Convert.ToString(min);
                Label91.Text = Convert.ToString(max);
                TextBox21.Text = Convert.ToString(min + max);
                Label87.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string min = "", max = "";
                min = Session["min"].ToString();
                max = Session["max"].ToString();
                Session["dcrmin"] = min;
                Session["dcrmax"] = max;
            }
            catch (Exception ex)
            {
                Label87.Text = ex.Message;
            }
            //textbox values
            Session["dcrtextbox1"] = TextBox1.Text;
            Session["dcrtextbox2"] = TextBox2.Text;
            Session["dcrtextbox3"] = TextBox3.Text;
            Session["dcrtextbox4"] = TextBox4.Text;
            Session["dcrtextbox5"] = TextBox5.Text;
            Session["dcrtextbox6"] = TextBox6.Text;
            Session["dcrtextbox7"] = TextBox7.Text;
            Session["dcrtextbox8"] = TextBox8.Text;
            Session["dcrtextbox9"] = TextBox9.Text;
            Session["dcrtextbox10"] = TextBox10.Text;
            Session["dcrtextbox11"] = TextBox11.Text;
            Session["dcrtextbox12"] = TextBox12.Text;
            Session["dcrtextbox13"] = TextBox13.Text;
            Session["dcrtextbox14"] = TextBox14.Text;
            Session["dcrtextbox15"] = TextBox15.Text;
            Session["dcrtextbox16"] = TextBox16.Text;
            Session["dcrtextbox17"] = TextBox17.Text;
            Session["dcrtextbox18"] = TextBox18.Text;
            Session["dcrtextbox19"] = TextBox19.Text;
            Session["dcrtextbox20"] = TextBox20.Text;
            //label values
            Session["dcrlabel1"] = Label9.Text;
            Session["dcrlabel2"] = Label13.Text;
            Session["dcrlabel3"] = Label17.Text;
            Session["dcrlabel4"] = Label21.Text;
            Session["dcrlabel5"] = Label25.Text;
            Session["dcrlabel6"] = Label29.Text;
            Session["dcrlabel7"] = Label33.Text;
            Session["dcrlabel8"] = Label37.Text;
            Session["dcrlabel9"] = Label41.Text;
            Session["dcrlabel10"] = Label45.Text;
            Session["dcrlabel11"] = Label49.Text;
            Session["dcrlabel12"] = Label53.Text;
            Session["dcrlabel13"] = Label57.Text;
            Session["dcrlabel14"] = Label61.Text;
            Session["dcrlabel15"] = Label65.Text;
            Session["dcrlabel16"] = Label69.Text;
            Session["dcrlabel17"] = Label73.Text;
            Session["dcrlabel18"] = Label77.Text;
            Session["dcrlabel19"] = Label81.Text;
            Session["dcrlabel20"] = Label85.Text;

            Session["dcroutofrange"] = TextBox21.Text;
            ScriptManager.RegisterStartupScript(this, GetType(), "dcrreturn", "dcrreturn();", true);
        }
    }
}
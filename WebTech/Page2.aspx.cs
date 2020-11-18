using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTech
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string text1 = Request.QueryString.Get("firstText");
                string text2 = Request.QueryString.Get("secondText");
                if (!string.IsNullOrEmpty(text1) || !string.IsNullOrEmpty(text2))
                {
                    P1.Visible = true; firstText.Visible = true; secondText.Visible = true; 
                    firstText.InnerText = !string.IsNullOrEmpty(text1) ? "First Text :" + text1 : "There is no value";
                    secondText.InnerText = !string.IsNullOrEmpty(text2) ? "Second Text :" + text2 : "There is no value";
                }
                sessionCount.InnerText ="There is " + Application["totalSession"].ToString()+" Session state.";
            }
            if(Session["FirstText"] != null)
                sessionValue.InnerHtml ="there is  "+ Session["FirstText"].ToString()+" in Session[FirstText]";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckBox1.Checked = !CheckBox1.Checked;
        }
    }
}
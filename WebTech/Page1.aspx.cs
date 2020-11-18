using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTech
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie myCookie = new HttpCookie("DefaultValue");
                myCookie.Value = "Page one say hello";
                myCookie.Expires = DateTime.Now.AddHours(1);
                Response.Cookies.Add(myCookie);
                ViewState["LikeCount"] = 0;
            }
        }

        protected void btn_move_Click(object sender, EventArgs e)
        {
            if (txt_first.Text != string.Empty)
            {
                lbl_error.Visible = false;
                txt_second.Text = txt_first.Text;
                txt_first.Text = string.Empty;
                return;
            }
            lbl_error.Text = "There was no text in the fisrt field";
            lbl_error.Visible = true;
        }

        protected void btnToHidden_Click(object sender, EventArgs e)
        {
            if (txt_second.Text != string.Empty)
            {
                txtSecondHiddenField.Value = txt_second.Text;
                txt_second.Text = string.Empty;
                lbl_error.Visible = false;
                return;
            }
            lbl_error.Text = "Text second should not be empty";
            lbl_error.Visible = true;
        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            ViewState["LikeCount"] = (int)ViewState["LikeCount"] + 1;
            lblLike.Text = (int)ViewState["LikeCount"] == 1 ? "Liked" : ViewState["LikeCount"] + " Liked";
        }

        protected void btnCookie_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie = Request.Cookies["DefaultValue"];
            if (myCookie != null)
                txt_first.Text = myCookie.Value;
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("Page2.aspx?firstText={0}&secondText={1}", txt_first.Text, txt_second.Text));
        }

        protected void btnRetreveFromHidden_Click1(object sender, EventArgs e)
        {
            if (txtSecondHiddenField.Value != String.Empty)
                txt_second.Text = txtSecondHiddenField.Value;
        }

        protected void btnSession_Click(object sender, EventArgs e)
        {
            Session["FirstText"] = txt_first.Text;
            txt_first.Text = string.Empty;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_12_27_webformV2.L1_MasterPage
{
    public partial class _1_07_02_FindControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "網頁裡面幾個控制項?" + this.Page.Controls.Count;//這裡只有算MasterPage我也不知道怎算的

            Label1.Text += "<br>這個控制項是:" +Page.Controls[0].ToString();//這裡名稱抓的是類別名稱(好像多了一些東西)
            Label1.Text += "<br>控制項ClientID是:" + Page.Controls[0].ClientID;//ClientID好像在ASP.NETc96u.35j/4ul4yji4m/4
            Button Btn = this.Page.Controls[0].FindControl("Button1") as Button;//也可以FindControl(MasterPageID我不知道...)繼續連鎖find到BTN
            Label1.Text += ("<br>" + Btn.Text);
        }
    }
}
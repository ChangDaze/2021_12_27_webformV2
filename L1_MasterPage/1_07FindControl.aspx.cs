using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_12_27_webformV2.L1_MasterPage
{
    public partial class _1_07FindControl1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button Btn = this.Master.FindControl("Button1") as Button;//空開類別不能用，控制項倒是能直接找

            Response.Write("<br>2. 在ContentPlaceHolder1裡面，抓取MasterPage網頁的Button---" + Btn.Text);//好像是會塞在ContentPlaceHolder1
        }
    }
}
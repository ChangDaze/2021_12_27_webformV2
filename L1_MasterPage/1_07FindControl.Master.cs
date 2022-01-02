using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_12_27_webformV2.L1_MasterPage
{
    public partial class _1_07FindControl : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<br>1.在網頁裡面，抓取MasterPage的Button---" + Button1.Text);
            //會接續下去的樣子?跟aspx分開response?
        }
    }
}
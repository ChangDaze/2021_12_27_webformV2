using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_12_27_webformV2.L1_MasterPage
{
    public partial class _1_9動態MasterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("1-9動態MasterPage成果.aspx?MP=1");
            //用query string來區別，但還是要提供一個with MasterPage的網頁讓它切換(不能用沒有Master的網頁切)，切的時候要注意在Page_PreInit階段(設MasterPage在這階段)，用this.MasterPageFile =..來設
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("1-9動態MasterPage成果.aspx?MP=2");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_12_27_webformV2.L1_MasterPage
{
    public partial class _1_9動態MasterPage成果 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if(Request["MP"] == "1")
            {
                this.MasterPageFile = @"~/L1_MasterPage/1-9動態MasterPage(1).Master";
            }
            else
            {
                this.MasterPageFile = @"~/L1_MasterPage/1-9動態MasterPage(2).Master";
            }
        }
    }
}
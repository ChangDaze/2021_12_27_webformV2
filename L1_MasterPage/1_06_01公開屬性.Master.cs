using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_12_27_webformV2.L1_MasterPage
{
    public partial class _1_06_01公開屬性 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public Image ImageForTest
        {
            //公開屬性，讓別人可以直接抓來改之類的?
            get { return Image1; }
            set { Image1 = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_12_27_webformV2.L7_DataBinding
{
    public partial class _05_06_01_dropdownlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Text = ListBox1.SelectedItem.Text;//兩個都要開AutoPostBack才會更新
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Text;
            ListBox1.DataSourceID = "SqlDataSource2";
            ListBox1.DataTextField = "Food_name";
            ListBox1.DataValueField = "Food_name";
            //DataSourceID = "SqlDataSource2"
        }
    }
}
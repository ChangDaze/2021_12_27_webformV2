using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021_12_27_webformV2.L1_MasterPage
{
    public partial class _1_8用Master如何抓控制項 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string saveDir = "upload";//Path.Combine也有點費...如果有多餘的斜線可能就會視為根目錄的樣子，導致生出來的目錄是錯的..
            string appPath = Request.PhysicalApplicationPath;
            string tempfileName = "";
            System.Text.StringBuilder myLabel = new System.Text.StringBuilder();

            for (int i = 1; i <= Request.Files.Count; i++)
            {
                FileUpload myFL = new FileUpload();
                myFL = (FileUpload)this.Master.FindControl("ContentPlaceHolder1").FindControl("FileUpload" + i);
                //用Master的一般網頁的控制項好像也歸類在Master底下，要到ContentPlaceHolder1裡找(這裡ContentPlaceHolder1又不是用ID了...)

                if (myFL.HasFile)
                {
                    string fileName = myFL.FileName;
                    string pathToCheck = Path.Combine(appPath, saveDir, fileName);

                    if (System.IO.File.Exists(pathToCheck))//防重複檔名
                    {
                        int my_counter = 2;
                        while (System.IO.File.Exists(pathToCheck))
                        {
                            tempfileName = my_counter.ToString() + "_" + fileName;
                            pathToCheck = Path.Combine(appPath, saveDir, tempfileName);
                            my_counter ++;
                        }

                        fileName = tempfileName;
                        Label1.Text += Label1.Text + "<br>抱歉，您上傳的檔名發生衝突，檔名修改如下---- " + fileName;
                    }

                    string savePath = Path.Combine(appPath, saveDir, fileName);
                    myFL.SaveAs(savePath);
                    myLabel.Append("<br>檔名---- " + fileName);
                }
            }



            Label2.Text = "上傳成功<hr>" + myLabel.ToString();
        }
    }
}
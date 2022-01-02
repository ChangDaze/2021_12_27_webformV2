<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1-9動態MasterPage.aspx.cs" Inherits="_2021_12_27_webformV2.L1_MasterPage._1_9動態MasterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            color: #FFFFFF;
            font-weight: bold;
            background-color: #800000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <p>您好，請選擇您想要的主版頁面（ .master檔案）？？<br /></p>
         ......搭配下一個 <span class="style1">放成果用畫面</span>來互動
         <hr />
        <asp:Button ID="Button1" runat="server" 
             Text="           1. 選擇 MasterPage1.master" onclick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="2. 選擇 MasterPage2.master" 
             onclick="Button2_Click" />
    
    </div>
    </form>
</body>
</html>

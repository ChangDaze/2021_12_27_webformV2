<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="範例A.aspx.cs" Inherits="_2021_12_27_webformV2.L2_SiteMap.Test.範例A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            SiteMap:<asp:SiteMapPath ID="SiteMapPath1" runat="server">
            </asp:SiteMapPath>
        </p>
        <p>
            Menu:</p>
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:Menu>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        TreeView:<br />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:TreeView>
    </form>
</body>
</html>

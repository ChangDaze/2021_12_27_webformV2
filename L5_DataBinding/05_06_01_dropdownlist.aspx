<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="05_06_01_dropdownlist.aspx.cs" Inherits="_2021_12_27_webformV2.L7_DataBinding._05_06_01_dropdownlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            食物種類:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="food_class" DataValueField="food_class" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:testConnectionString3 %>" SelectCommand="SELECT DISTINCT [food_class] FROM [Food_Menu]"></asp:SqlDataSource>
            <br />
            <br />
            分類有關的菜名:<asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:testConnectionString3 %>" SelectCommand="SELECT [food_class], [Food_name] FROM [Food_Menu] WHERE ([food_class] = @food_class)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="food_class" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            剛剛選的食物種類:<asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            點菜:<asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

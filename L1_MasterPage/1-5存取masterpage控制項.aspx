<%@ Page Title="" Language="C#" MasterPageFile="~/L1_MasterPage/1-2master檔.Master" AutoEventWireup="true" CodeBehind="1-5存取masterpage控制項.aspx.cs" Inherits="_2021_12_27_webformV2.L1_MasterPage._1_5存取masterpage控制項" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="抓取標題列textbox資料" OnClick="Button1_Click" /><br>
    執行結果:<asp:Label ID="Label1" runat="server" ></asp:Label>
</asp:Content>

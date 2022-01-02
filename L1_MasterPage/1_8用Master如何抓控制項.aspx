<%@ Page Title="" Language="C#" MasterPageFile="~/L1_MasterPage/1_07FindControl.Master" AutoEventWireup="true" CodeBehind="1_8用Master如何抓控制項.aspx.cs" Inherits="_2021_12_27_webformV2.L1_MasterPage._1_8用Master如何抓控制項" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p><br /></p>
    <p style="background-color: #FFFF00">*** MasterPage   （放在「內容頁面」裡頭）***</p>
    1.
    <asp:FileUpload ID="FileUpload1" runat="server" /><br />
    2.
    <asp:FileUpload ID="FileUpload2" runat="server" /><br />
    <hr />&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Multi-Files ~ UPLOAD!  大量檔案，批次上傳！" onclick="Button1_Click" />
    <p>
    <asp:Label ID="Label1" runat="server" ForeColor="#FF3300"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" ForeColor="darkblue"></asp:Label>
    </p>

</asp:Content>

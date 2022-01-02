<%@ Page Title="" Language="C#" MasterPageFile="~/L1_MasterPage/1_06_01公開屬性.Master" AutoEventWireup="true" CodeBehind="1_06_01公開屬性(1).aspx.cs" Inherits="_2021_12_27_webformV2.L1_MasterPage._1_06_01公開屬性_1_" %>

<%--要存取MasterPage的公開屬性要手動加入@MasterType指示詞在最上方--%>
<%@ MasterType VirtualPath ="~/L1_MasterPage/1_06_01公開屬性.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

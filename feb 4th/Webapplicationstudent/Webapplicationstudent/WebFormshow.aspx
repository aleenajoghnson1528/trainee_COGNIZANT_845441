<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormshow.aspx.cs" Inherits="Webapplicationstudent.WebFormshow" %>
<asp:Content ID="Mycon" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Button ID="Button1" runat="server" Text="Button1" onclick="Button1_click1"/>
<asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
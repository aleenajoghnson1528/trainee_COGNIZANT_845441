<%@ Page Language="C#"    MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Webformupdate.aspx.cs" Inherits="Webapplicationstudent.Webformupdate" %>

<asp:Content ID="Mycon" ContentPlaceHolderID="MainContent" runat="server">

  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click" />
</asp:Content>

                           
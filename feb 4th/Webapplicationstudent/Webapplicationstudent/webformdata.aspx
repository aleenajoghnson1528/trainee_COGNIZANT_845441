<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webformdata.aspx.cs" Inherits="Webapplicationstudent.webformdata" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent"  runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />


    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    
</asp:Content>

 

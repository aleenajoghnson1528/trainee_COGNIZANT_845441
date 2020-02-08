<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webformupdate.aspx.cs" Inherits="task_employee_6th.webformupdate" %>


<asp:Content ID="Mycon" ContentPlaceHolderID="MainContent" runat="server">

 
      <asp:GridView ID="GridView1" runat="server"></asp:GridView>
     <asp:Label ID="Label2" runat="server" Text="enter id"></asp:Label>
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
     <asp:Label ID="Label3" runat="server" Text="enter new domain"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click" />
</asp:Content>

                  
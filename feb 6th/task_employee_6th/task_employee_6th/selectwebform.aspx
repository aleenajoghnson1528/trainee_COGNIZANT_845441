<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="selectwebform.aspx.cs" Inherits="task_employee_6th.selectwebform" %>

<asp:Content ID="Mycon" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter id:"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
  
<asp:Button ID="Button1" runat="server" Text="Button1" onclick="Button1_click1"/>
    
<asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Label ID="Label2" runat="server" ></asp:Label>
</asp:Content>
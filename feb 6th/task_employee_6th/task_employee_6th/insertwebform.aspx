<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insertwebform.aspx.cs" Inherits="task_employee_6th.insertwebform" %>

<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent"  runat="server">
    <asp:Label ID="ID" runat="server" Text="ID"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="enter  valid id" ForeColor="Red" ValidationGroup="vg" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="NAME" runat="server" Text="NAME"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="enter your name" ForeColor="Red" ValidationGroup="vg" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="LOCATION" runat="server" Text="LOCATION"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Renter your correct location" ForeColor="Red" ValidationGroup="vg" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="DOMAIN" runat="server" Text="DOMAIN"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="enter your correct tech domain" ForeColor="Red" ValidationGroup="vg" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="STARTDATE" runat="server" Text="STARTDATE"></asp:Label>
     <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="enter your correct start date" ForeColor="Red" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>

    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
   

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:TextBox ID="newlabel" runat="server"></asp:TextBox>
</asp:Content>
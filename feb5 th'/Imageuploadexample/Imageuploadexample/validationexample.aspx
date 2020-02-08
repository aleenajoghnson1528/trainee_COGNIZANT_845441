<%@ Page Language="C#" MasterpageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="validationexample.aspx.cs" Inherits="Imageuploadexample.validationexample" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="must enter a name" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="vg">Enter name</asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="vg" ForeColor="#FF6600">Enter name</asp:TextBox>
         <br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="age between 18 and 60" ControlToValidate="TextBox2" ForeColor="Red" MaximumValue="90" MinimumValue="20" Type="Integer" ValidationGroup="vg"></asp:RangeValidator>
         <br />
        <asp:TextBox ID="TextBox2" runat="server" ForeColor="#FF6600">enter age</asp:TextBox>
         <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="enter valid email id" ControlToValidate="TextBox3" ForeColor="#CC0000" ValidationGroup="vg" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
         <br />
        <asp:TextBox ID="TextBox3" runat="server" ForeColor="#FF6600" ValidationGroup="vg" TextMode="Email">Enter Email id</asp:TextBox>
         <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="please enter password in correct format" ControlToValidate="TextBox4" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator>
         <br />
        <asp:TextBox ID="TextBox4" runat="server" ForeColor="#FF6600" ValidationGroup="vg" TextMode="Password">enter password</asp:TextBox>
         <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password doesn't match" ControlToValidate="TextBox5" ValidationGroup="vg" ForeColor="Red" Operator="NotEqual"></asp:CompareValidator>
         <br />
        <asp:TextBox ID="TextBox5" runat="server" ForeColor="#FF6600" ValidationGroup="vg" TextMode="Password">confirm password</asp:TextBox>
         <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="vg" />
         <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" ValidationGroup="vg" />
        </div>

      <div class="jumbotron">
          <asp:TextBox ID="lblmsg" runat="server"></asp:TextBox>
          </div>
</asp:Content>

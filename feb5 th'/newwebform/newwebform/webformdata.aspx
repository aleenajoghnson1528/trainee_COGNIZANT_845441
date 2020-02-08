<%@ Page Language="C#" MasterpageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webformdata.aspx.cs" Inherits="newwebform.webformdata" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
        <br />
        <asp:TextBox ID="TxtName" runat="server" ></asp:TextBox>
         <br />
        <asp:Label ID="Label2" runat="server" Text="Enter DOB"></asp:Label>
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
         <br />
        <asp:Label ID="Label3" runat="server" Text="gender"></asp:Label>
         <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="145px">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
        </asp:RadioButtonList>
         <br />
        <asp:Label ID="Label4" runat="server" Text="Tick mark Hobbies"></asp:Label>
         <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Width="135px">
            <asp:ListItem>reading</asp:ListItem>
            <asp:ListItem>gardening</asp:ListItem>
            <asp:ListItem>music</asp:ListItem>
            <asp:ListItem>travelling</asp:ListItem>
        </asp:CheckBoxList>
         <br />
        <asp:Label ID="Label5" runat="server" Text="studies:"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Width="135px">
            <asp:ListItem>10th</asp:ListItem>
            <asp:ListItem>12th</asp:ListItem>
            <asp:ListItem>BTECH</asp:ListItem>
            <asp:ListItem>MTECH</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" BackColor="#CC0066" />
        <br/>
</div>

     <div class="jumbotron">
          <asp:Label ID="lblDisplay" runat="server" Text="text"></asp:Label>
         </div>

</asp:Content>
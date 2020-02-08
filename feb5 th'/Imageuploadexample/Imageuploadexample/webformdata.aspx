<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webformdata.aspx.cs" Inherits="Imageuploadexample.webformdata" %>

<asp:Content ID="ID123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
    <asp:FileUpload ID="FileUpload1" runat="server" />
   <br />
    <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
         <br />
    <br />
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
        <ItemTemplate>
            <asp:Image ID="image1"
                ImageUrl='<%# Eval("Name", "~/resources/{0}") %>'
                width="350px" Height="350px" runat="server" />
            <%# Eval("Name") %>
        </ItemTemplate>


    </asp:DataList>
</div>
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Session"></asp:Label>
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="List"></asp:Label>
<br />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>
    <br />
    <center><h3>To Request a Book:</h3></center>
    <asp:Label ID="Label3" runat="server" Text="Enter Bookid:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Book request" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Display"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" Text="Enter Issue Id:"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox5" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <br />
    <br />
    <p>
        <asp:Label ID="Label6" runat="server" Text="Enter Issue date:"></asp:Label>
    </p>
    <asp:Calendar ID="Calendar4" runat="server"></asp:Calendar>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    <asp:Label ID="Label7" runat="server" Text="Enter end date:"></asp:Label>
    </p>
    <asp:Calendar ID="Calendar3" runat="server" OnSelectionChanged="Page_Load"></asp:Calendar>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <p>
        &nbsp;</p>
    <asp:Button ID="Button2" runat="server" BorderStyle="Solid" OnClick="Button2_Click1" Text="Submit" />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="Msg"></asp:Label>
    </p>
    <br />
<br />
</asp:Content>

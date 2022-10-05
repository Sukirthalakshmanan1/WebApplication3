<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication3.WebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter userid:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox1" runat="server" BorderStyle="Dotted" Font-Italic="True" Height="26px" TextMode="Email"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="Enter  Password:"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server" BorderColor="#3333FF" Font-Bold="True" TextMode="Password"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" BorderStyle="Solid" OnClick="Button1_Click" Text="Sign up" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button2" runat="server" BorderStyle="Solid" OnClick="Button2_Click" Text="Login" />
<br />
<asp:Label ID="Label3" runat="server" Text="Msg"></asp:Label>
<br />
<br />
</asp:Content>

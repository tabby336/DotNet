<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FizzBuzz.aspx.cs" Inherits="WebFormsProject.FizzBuzz1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="numTextBox" runat="server"></asp:TextBox> <br /><br />
        <asp:Button ID="getNumerButton" Text="FizzBuzzMe!" runat="server" OnClick="FizzBuzzButton_OnClick" /> <br /><br />
        <asp:Label ID="FizzBuzzLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>

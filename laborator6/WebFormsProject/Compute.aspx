<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Compute.aspx.cs" Inherits="WebFormsProject.Compute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Super sum computer!! <br /> <br />
        <asp:textbox ID="textNum1" runat="server" Height="20px" Width="100px" style="margin-right: 10px"></asp:textbox> <br /> <br />
        <asp:textbox ID="textNum2" runat="server" Height="20px" Width="100px" style="margin-right: 10px"></asp:textbox> <br /> <br />
        <asp:textbox ID="textNum3" runat="server" Height="20px" Width="100px" style="margin-right: 10px"></asp:textbox> <br /> <br />
        <asp:Button ID="computeButton" Text="Add" runat="server" OnClick="ComputeButton_OnClick" /> <br /> <br />
        <asp:Label ID="resultLabel" runat="server" style="background-color:lightgreen" ></asp:Label> <br />
    </div>
    </form>

    

</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AspDemo.aspx.cs" Inherits="Demo1.AspDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>

    <asp:Label runat="server" Text="Label"></asp:Label>
    <asp:TextBox runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>

</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="MyNameApp.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EP-1650047</title>
	<link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="name-box">
        <h1>Name: Muhammad Kamran Ansari</h1>
        <h1>Seat No.: EP-1650047</h1>
    </div>
    <form id="form1" runat="server">
        <div class="input-text">
			<asp:Label CssClass="label" ID="Label1" runat="server" Text="Value 1"></asp:Label>
            <asp:TextBox CssClass="text" ID="Value1" runat="server"></asp:TextBox><br />
			<asp:Label CssClass="label" ID="Label2" runat="server" Text="Value 2"></asp:Label>
            <asp:TextBox CssClass="text" ID="Value2" runat="server"></asp:TextBox><br />
			<asp:Button CssClass="button" ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
			<asp:Button CssClass="button" ID="Multiply" runat="server" Text="Multiply" OnClick="Multiply_Click" />
			<asp:Button CssClass="button" ID="Subtract" runat="server" Text="Subtract" OnClick="Subtract_Click" />
			<asp:Button CssClass="button" ID="Divide" runat="server" Text="Divide" OnClick="Divide_Click" />
        </div>
		<asp:Label CssClass="label" ID="Label3" runat="server" Text="Result"></asp:Label>
		<asp:TextBox CssClass="text" ID="Result" runat="server" ReadOnly="true"></asp:TextBox>
    </form>
</body>
</html>

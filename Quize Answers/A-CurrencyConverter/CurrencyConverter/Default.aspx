<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CurrencyConverter.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Convert&nbsp;&nbsp;
        <asp:TextBox ID="TxtCanada" runat="server"></asp:TextBox>
&nbsp; Canadian Dollars to&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownCurrency" runat="server" Height="17px" Width="113px">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" Text="OK" Width="63px" />
&nbsp;&nbsp;
        <asp:Button ID="BtnGraph" runat="server" OnClick="BtnGraph_Click" Text="Show Graph" />
        <br />
        <br />
        <asp:Image ID="ImgGraph" runat="server" Height="120px" Width="254px" />
        <br />
        <br />
        <asp:Label ID="LblResult" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaStore.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        The Chiarelli Pizzeria<br />
        <br />
        <asp:RadioButton ID="RdoBaby" runat="server" GroupName="Size" Text="Baby $10" />
        <br />
        <asp:RadioButton ID="RdoMama" runat="server" GroupName="Size" Text="Mama $13" />
        <br />
        <asp:RadioButton ID="RdoPapa" runat="server" GroupName="Size" Text="Papa $16" />
        <br />
        <br />
        <asp:RadioButton ID="RdoThin" runat="server" GroupName="Type" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="RdoDeep" runat="server" GroupName="Type" Text="Deep Dish (+$2.00)" />
        <br />
        <br />
        <asp:CheckBox ID="ChkPepperoni" runat="server" Text="Pepperoni" />
        <br />
        <asp:CheckBox ID="ChkOnions" runat="server" Text="Onions" />
        <br />
        <asp:CheckBox ID="ChkGreen" runat="server" Text="Green Peppers" />
        <br />
        <asp:CheckBox ID="ChkRed" runat="server" Text="Red Peppers" />
        <br />
        <asp:CheckBox ID="ChkAnchovies" runat="server" Text="Anchovies" />
        <br />
        <br />
        Special Deal: Save $2.00 when you add pepperoni, green peppers and anchovies OR <br />
        pepperoni, red peppers and onions to your pizza<br />
        <br />
        <asp:Button ID="BtnPurchase" runat="server" OnClick="BtnPurchase_Click" Text="Purchase" />
        <br />
        <br />
        Total: <asp:Label ID="LblTotal" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>

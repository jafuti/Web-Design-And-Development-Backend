<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BirthdayCardMaker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 290px;
        }
        .auto-style2 {
            position: absolute;
            top: 16px;
            left: 313px;
            height: 422px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

    <div class="auto-style1">

    <!-- Here are the controls: -->
    Choose a background color:<br />
    <asp:DropDownList ID="lstBackColor" runat="server" Width="94px" Height="22px"/><br /><br />
    Choose a font:<br />
    <asp:DropDownList ID="lstFontName" runat="server" Width="94px" Height="22px" /><br /><br />
    Specify a numeric font size:<br />
    <asp:TextBox ID="txtFontSize" runat="server" /><br /><br />
        <br />
        <br /><br />
    <asp:CheckBox ID="chkPicture" runat="server" Text="Add the Default Picture"></asp:CheckBox><br /><br />
    Enter the greeting text below:<br />
    <asp:TextBox ID="txtGreeting" runat="server" Width="240px" Height="85px" TextMode="MultiLine" /><br /><br />
    <asp:Button ID="cmdUpdate" OnClick="cmdUpdate_Click" runat="server" Width="71px" Height="24px" Text="Update" />

    </div>

     <!-- Here is the card: -->
    <asp:Panel ID="pnlCard" runat="server" Width="339px" HorizontalAlign="Center" CssClass="auto-style2">
    <br />&nbsp;
    <asp:Label ID="lblGreeting" runat="server" Width="256px" Height="150px" /><br /><br /><br />
    <asp:Image ID="imgDefault" runat="server" Width="212px" Height="160px" ImageUrl="~/images/birthdaycake.png" />
    </asp:Panel>
   

    </form>
</body>
</html>

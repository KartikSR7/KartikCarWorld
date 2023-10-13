<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Did You sold this car if Yes! Please press &#39;Yes&#39; this would delete this car from your list.<br />
            <br />
        </div>
        <asp:Button ID="btnYes" runat="server" Text="Yes" Width="164px" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" Text="No" Width="180px" OnClick="btnNo_Click" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>

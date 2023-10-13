<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Carcollection.aspx.cs" Inherits="Carcollection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p class="auto-style1">
            &nbsp;</p>
        <p>
            &nbsp;Brand Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBrandName" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Model Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtModelNAme" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Colour&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtColour" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 606px; top: 794px; position: absolute; width: 156px;" Text="Ok" OnClick="btnOk_Click" />
        </p>
        <p>
            Condition&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCondition" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            PreviousOwners&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPreviousOwners" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            RegNo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRegNo" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            MilesDriven&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtMIilesDriven" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            FuelType&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFuelType" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 894px; top: 794px; position: absolute; width: 134px; background-color: #CCCCCC;" Text="Cancel" OnClick="btnCancel_Click" />
            Year Of Manufactured:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlYearManufactured" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPrice" runat="server" Width="148px"></asp:TextBox>
        &nbsp;</p>
        <p>
            &nbsp;</p>
        Date Added&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>

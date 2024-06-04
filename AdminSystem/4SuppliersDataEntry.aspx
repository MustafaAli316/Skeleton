<%@ Page Language="C#" AutoEventWireup="true" CodeFile="4SuppliersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This Is Suppliers Page<asp:Label ID="lblSuppliersId" runat="server" style="z-index: 1; left: 161px; top: 95px; position: absolute; right: 1023px" Text="Suppliers ID"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="txtSuppliersId" runat="server" style="z-index: 1; left: 400px; top: 97px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSuppliersName" runat="server" style="z-index: 1; left: 399px; top: 143px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblContact" runat="server" style="z-index: 1; left: 160px; top: 183px; position: absolute" Text="Contact"></asp:Label>
        <asp:TextBox ID="txtContact" runat="server" style="z-index: 1; left: 397px; top: 184px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 160px; top: 232px; position: absolute" Text="Email"></asp:Label>
        </p>
        <asp:Label ID="lblSuppliersName" runat="server" style="z-index: 1; left: 160px; top: 141px; position: absolute" Text="Suppliers Name"></asp:Label>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 396px; top: 232px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 157px; top: 280px; position: absolute" Text="Address"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 396px; top: 278px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 156px; top: 331px; position: absolute" Text="Post Code"></asp:Label>
            <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 395px; top: 333px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 156px; top: 380px; position: absolute" Text="City"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 393px; top: 382px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblCountry" runat="server" style="z-index: 1; left: 155px; top: 422px; position: absolute" Text="Country"></asp:Label>
            <asp:TextBox ID="txtCountry" runat="server" style="z-index: 1; left: 391px; top: 423px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 152px; top: 469px; position: absolute" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 389px; top: 470px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 300px; top: 533px; position: absolute" Text="Active" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 620px; top: 563px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 230px; top: 613px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 360px; top: 613px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>

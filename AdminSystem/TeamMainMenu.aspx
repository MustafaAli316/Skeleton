<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome to Zudio
        </div>
        <asp:Button ID="btnCustomer" runat="server" height="26px" OnClick="btnCustomer_Click" style="z-index: 1; top: 71px; position: absolute; width: 64px; left: 242px" Text="Customer" />
        <asp:Button ID="btnStock" runat="server" height="26px" style="z-index: 1; left: 318px; top: 70px; position: absolute; right: 412px" Text="Stock" width="64px" OnClick="btnStock_Click" />
        <asp:Button ID="btnStaff" runat="server" height="26px" style="z-index: 1; left: 393px; top: 70px; position: absolute" Text="Staff" width="64px" />
        <asp:Button ID="btnOrder" runat="server" height="26px" style="z-index: 1; left: 164px; top: 70px; position: absolute" Text="Order" width="64px" />
        <p>
            <asp:Button ID="btnSupplier" runat="server" height="26px" style="z-index: 1; left: 468px; top: 70px; position: absolute" Text="Supplier" width="64px" />
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 17px; top: 344px; position: absolute; height: 22px; width: 72px" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 110px; top: 344px; position: absolute; width: 72px; height: 22px" Text="Clear Filter" />
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 4px; top: 11px; position: absolute; height: 227px; width: 372px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 12px; top: 259px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 66px; top: 259px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 390px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 137px; top: 259px; position: absolute" Text="Delete" />
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 15px; top: 309px; position: absolute" Text="Enter the First Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 160px; top: 306px; position: absolute; height: 22px"></asp:TextBox>
    </form>
</body>
</html>

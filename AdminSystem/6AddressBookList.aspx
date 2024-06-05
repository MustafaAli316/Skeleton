<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6AddressBookList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 371px; position: absolute" Text="Add" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 96px; top: 370px; position: absolute" Text="Edit" />
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 14px; top: 63px; position: absolute; height: 284px; width: 279px; margin-top: 6px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>
        <p>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 175px; top: 370px; position: absolute" Text="Delete" />
        </p>
        <asp:Label ID="LblShoesDescription" runat="server" style="z-index: 1; left: 14px; top: 455px; position: absolute" Text="Enter a Shoes Description "></asp:Label>
        <asp:TextBox ID="txtShoesDescription" runat="server" style="z-index: 1; left: 189px; top: 456px; position: absolute;"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 25px; top: 514px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 151px; top: 514px; position: absolute" Text="Clear Filter" />
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 570px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>

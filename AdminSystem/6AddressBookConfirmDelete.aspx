<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6AddressBookConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 74px; top: 397px; position: absolute; width: 149px" Text="Yes" />
         <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left : 308px ; top: 395px; position: absolute; width: 176px; right: 1806px" Text="No" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 46px; top: 222px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <p>
            &nbsp;</p>
       
    </form>
</body>
</html>

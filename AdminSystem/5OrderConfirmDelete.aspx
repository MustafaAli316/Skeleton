<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblConfirmationMessage" runat="server" Text="Are you sure you want to delete this order?" Style="z-index: 1; left: 50%; top: 100px; position: absolute; transform: translateX(-50%);"></asp:Label>

        <asp:Button ID="btnYes" runat="server" Text="Yes" Style="z-index: 1; left: 30%; top: 150px; position: absolute; width: 120px; height: 40px;" OnClick="btnYes_Click" />
        
        <asp:Button ID="btnNo" runat="server" Text="No" Style="z-index: 1; left: 70%; top: 150px; position: absolute; width: 120px; height: 40px;" OnClick="btnNo_Click" />
        
        <div>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrderList" runat="server" Style="z-index: 1; left: 50%; top: 58px; position: absolute; width: 400px; height: 400px; transform: translateX(-50%);">
        </asp:ListBox>
      
       <asp:Button ID="btnAdd" runat="server" Text="Add" Style="z-index: 1; left: 30%; top: 470px; position: absolute; width: 80px; height: 30px; transform: translateX(-50%);" />
        
        <asp:Button ID="btnEdit" runat="server" Text="Edit" Style="z-index: 1; left: 50%; top: 470px; position: absolute; width: 80px; height: 30px; transform: translateX(-50%);" />
        
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Style="z-index: 1; left: 70%; top: 470px; position: absolute; width: 80px; height: 30px; transform: translateX(-50%);" />
        <asp:Label ID="lblEror" runat="server" Text="[lblError]" Style="z-index: 1; left: 50%; top: 520px; position: absolute; transform: translateX(-50%);"></asp:Label>
        
        <div>
        </div>
    </form>
</body>
</html>
>

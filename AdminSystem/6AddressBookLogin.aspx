<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6AddressBookLogin.aspx.cs" Inherits="_6AddressBookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 339px; top: 373px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnLogin" runat="server"  style="z-index: 1; left: 261px; top: 374px; position: absolute" Text="Login" OnClick="btnLogin_Click" />
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 47px; top: 265px; position: absolute" Text="Password : "></asp:Label>
        <p>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 259px; top: 212px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 479px; top: 237px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 260px; top: 271px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 28px; top: 112px; position: absolute" Text="Stock Login Page"></asp:Label>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 44px; top: 214px; position: absolute" Text="UserName : "></asp:Label>
        </p>
    </form>
</body>
</html>

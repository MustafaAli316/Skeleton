<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Customer Login Page<asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 12px; top: 76px; position: absolute" Text="UserName"></asp:Label>
        <p>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 13px; top: 144px; position: absolute" Text="Password"></asp:Label>
        </p>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 112px; top: 77px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 114px; top: 144px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 83px; top: 216px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; top: 217px; position: absolute; width: 47px; left: 149px; height: 25px" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 283px; top: 103px; position: absolute"></asp:Label>
    </form>
</body>
</html>

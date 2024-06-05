<%@ Page Language="C#" AutoEventWireup="true" CodeFile="2CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 22px; top: 27px; position: absolute" Text="CustomerId"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 110px; top: 29px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 22px; top: 68px; position: absolute; height: 19px" Text="FirstName" width="72px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 110px; top: 64px; position: absolute"></asp:TextBox>

        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 22px; top: 103px; position: absolute" Text="LastName"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 110px; top: 101px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 15px; top: 147px; position: absolute" Text="EmailAddress"></asp:Label>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 110px; top: 146px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 25px; top: 190px; position: absolute; height: 16px; right: 657px" Text="Address"></asp:Label>
 
            <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 20px; top: 236px; position: absolute; height: 14px" Text="DateOfBirth"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 110px; top: 191px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 110px; top: 237px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkLoyalCustomer" runat="server" style="z-index: 1; left: 122px; top: 280px; position: absolute" Text="Loyal Customer" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 331px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 85px; top: 383px; position: absolute" Text="Cancel" />
       
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 377px; top: 29px; position: absolute; height: 25px; width: 75px" Text="Find" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 16px; top: 383px; position: absolute" Text="OK" />
       
        <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 341px; top: 384px; position: absolute" Text="Return To Main Menu " />
       
    </form>
</body>
</html>

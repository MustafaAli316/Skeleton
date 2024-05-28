<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="OrderForm" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtOrderID" runat="server" OnTextChanged="txtOrderID_TextChanged" style="z-index: 1; left: 130px; top: 34px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 26px; top: 70px; position: absolute" Text="Order Date"></asp:Label>
        <p>
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 26px; top: 36px; position: absolute; bottom: 437px" Text="Order ID"></asp:Label>
        </p>
        <asp:TextBox ID="txtOrderDate" runat="server" height="22px" style="z-index: 1; left: 130px; top: 69px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" height="22px" style="z-index: 1; left: 130px; top: 99px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 26px; top: 135px; position: absolute" Text="Product ID"></asp:Label>
        <p>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 26px; top: 101px; position: absolute; width: 61px; bottom: 372px" Text="Quantity"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtCourierCompany" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 130px; top: 162px; position: absolute; width: 128px; height: 22px; margin-bottom: 0px"></asp:TextBox>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 130px; top: 134px; position: absolute; width: 128px; height: 22px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCourierCompany" runat="server" style="z-index: 1; left: 18px; top: 168px; position: absolute; width: 111px; height: 27px" Text="Courier Company"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox1" runat="server" height="22px" style="z-index: 1; left: 132px; top: 194px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkOrderCompleted" runat="server" style="z-index: 1; top: 228px; position: absolute; left: 108px" Text="Order Status" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 258px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 56px; top: 292px; position: absolute" Text="OK" width="51px" />
        <asp:Label ID="lblTotal" runat="server" style="z-index: 1; left: 26px; top: 200px; position: absolute; height: 17px; width: 43px" Text="Total"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 140px; top: 290px; position: absolute; height: 26px; width: 51px" Text="Cancel" />
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="OrderForm" runat="server">
        <div class="auto-style1">
        <div>
        </div>
        <asp:TextBox ID="txtOrderID" runat="server" OnTextChanged="txtOrderID_TextChanged" style="z-index: 1; left: 233px; top: 58px; position: absolute; width: 455px; height: 47px;"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 26px; top: 147px; position: absolute; height: 58px; width: 185px;" Text="Order Date"></asp:Label>
        <p>
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 26px; top: 62px; position: absolute; bottom: 996px; width: 185px; right: 2162px;" Text="Order ID" height="58px"></asp:Label>
        </p>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 233px; top: 144px; position: absolute; width: 455px; height: 47px;"></asp:TextBox>
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 26px; top: 309px; position: absolute; height: 58px;" Text="Product ID" width="185px"></asp:Label>
        <p style="width: 1px">
            &nbsp;</p>
        <p class="auto-style1">
            <asp:TextBox ID="txtCourierCompany" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 233px; top: 391px; position: absolute; width: 455px; height: 47px; margin-bottom: 0px"></asp:TextBox>
        <asp:TextBox ID="txtTotal" runat="server" style="z-index: 1; left: 233px; top: 478px; position: absolute; width: 455px; height: 47px;"></asp:TextBox>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 26px; top: 222px; position: absolute; width: 185px; bottom: 841px" Text="Quantity" height="58px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 233px; top: 214px; position: absolute; height: 47px; width: 455px;"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCourierCompany" runat="server" style="z-index: 1; left: 26px; top: 390px; position: absolute; width: 185px; height: 58px" Text="Courier Company"></asp:Label>
        <asp:Label ID="lblTotal" runat="server" style="z-index: 1; left: 26px; top: 481px; position: absolute; height: 58px; width: 185px" Text="Total"></asp:Label>
        </p>
        <asp:CheckBox ID="chkOrderCompleted" runat="server" style="z-index: 1; top: 544px; position: absolute; left: 26px; height: 44px; text-align: center;" Text="Order Status" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 46px; top: 682px; position: absolute" Text="OK" width="115px" height="66px" />
        <p>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 233px; top: 288px; position: absolute; width: 455px; height: 47px"></asp:TextBox>
            </p>
        <p>
            &nbsp;</p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 244px; top: 677px; position: absolute; height: 66px; width: 115px" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 619px; position: absolute; height: 39px;" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>

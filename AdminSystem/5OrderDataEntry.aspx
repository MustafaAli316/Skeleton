<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Form</title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="OrderForm" runat="server">
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 26px; top: 62px; position: absolute; width: 120px;" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" OnTextChanged="txtOrderID_TextChanged" style="z-index: 1; left: 160px; top: 58px; position: absolute; width: 200px; height: 30px;"></asp:TextBox>
            
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 26px; top: 147px; position: absolute; width: 120px;" Text="Order Date"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 160px; top: 144px; position: absolute; width: 200px; height: 30px;"></asp:TextBox>

            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 26px; top: 222px; position: absolute; width: 120px;" Text="Product ID"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 160px; top: 218px; position: absolute; width: 200px; height: 30px;"></asp:TextBox>

            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 26px; top: 309px; position: absolute; width: 120px;" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 160px; top: 305px; position: absolute; width: 200px; height: 30px;"></asp:TextBox>

            <asp:Label ID="lblCourierCompany" runat="server" style="z-index: 1; left: 26px; top: 390px; position: absolute; width: 120px;" Text="Courier Company"></asp:Label>
            <asp:TextBox ID="txtCourierCompany" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 160px; top: 386px; position: absolute; width: 200px; height: 30px;"></asp:TextBox>

            <asp:Label ID="lblTotal" runat="server" style="z-index: 1; left: 26px; top: 481px; position: absolute; width: 120px;" Text="Total"></asp:Label>
            <asp:TextBox ID="txtTotal" runat="server" style="z-index: 1; left: 160px; top: 477px; position: absolute; width: 200px; height: 30px;"></asp:TextBox>

            <asp:CheckBox ID="chkOrderCompleted" runat="server" style="z-index: 1; left: 26px; top: 544px; position: absolute;" Text="Order Status" />

            <asp:Button ID="btnFind" runat="server" Text="Find" style="z-index: 1; left: 160px; top: 600px; position: absolute; height: 40px; width: 80px;" OnClick="btnFind_Click" />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 250px; top: 600px; position: absolute; height: 40px; width: 80px;" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 340px; top: 600px; position: absolute; height: 40px; width: 80px;" Text="Cancel" OnClick="btnCancel_Click" />
            
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 660px; position: absolute; width: 400px; color: red;" Text=""></asp:Label>
        
        </div>
    </form>
</body>
</html>

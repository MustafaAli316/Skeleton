<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6AddressBookDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtShoesNo" runat="server" style="z-index: 1; left: 196px; top: 129px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblShoesNo" runat="server" style="z-index: 1; left: 28px; top: 129px; position: absolute" Text="ShoesNo"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblShoesBrand" runat="server" style="z-index: 1; left: 28px; top: 184px; position: absolute" Text="ShoesBrand"></asp:Label>
            <asp:TextBox ID="txtShoesBrand" runat="server" style="z-index: 1; left: 196px; top: 180px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblShoesDesc" runat="server" style="z-index: 1; left: 28px; top: 254px; position: absolute" Text="ShoesDesc"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 196px; top: 129px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 196px; top: 129px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtShoesDesc" runat="server" style="z-index: 1; left: 196px; top: 256px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblShoesColour" runat="server" style="z-index: 1; left: 28px; top: 364px; position: absolute" Text="ShoesColour"></asp:Label>
        </p>
        <p>
            &nbsp;
            <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 196px; top: 129px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox12" runat="server" style="z-index: 1; left: 194px; top: 256px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox13" runat="server" style="z-index: 1; left: 194px; top: 256px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtShoesColour" runat="server" style="z-index: 1; left: 196px; top: 364px; position: absolute"></asp:TextBox>
        </p>
        <p>
                       <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 28px; top: 419px; position: absolute" Text="DateAdded"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 196px; top: 422px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 28px; top: 474px; position: absolute" Text="Price"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 196px; top: 471px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblAvailable" runat="server" style="z-index: 1; left: 28px; top: 529px; position: absolute" Text="Available"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtAvaiable" runat="server" style="z-index: 1; left: 196px; top: 532px; position: absolute"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 228px; top: 605px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 639px; position: absolute; bottom: 165px;"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 50px; top: 768px; position: absolute; right: 1402px;" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 154px; top: 768px; position: absolute" Text="Cancel" />
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 351px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Supplier ID"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 82px; top: 15px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblCompanyName" runat="server" height="19px" style="z-index: 1; left: 9px; top: 51px; position: absolute" Text="Company Name" width="70px"></asp:Label>
        <asp:TextBox ID="txtCompanyName" runat="server" style="z-index: 1; left: 82px; top: 52px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCompanyAddress" runat="server" height="19px" style="z-index: 1; left: 9px; top: 85px; position: absolute" Text="Company Address" width="70px"></asp:Label>
        <asp:TextBox ID="txtCompanyAddress" runat="server" style="z-index: 1; left: 83px; top: 85px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblContactNumber" runat="server" height="19px" style="z-index: 1; left: 10px; top: 117px; position: absolute" Text="Contact Number" width="70px"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 242px; top: 14px; position: absolute" Text="Find" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtContactNumber" runat="server" style="z-index: 1; left: 83px; top: 118px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 82px; top: 149px; position: absolute" width="128"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" height="19px" style="z-index: 1; left: 10px; top: 149px; position: absolute" Text="Order Date" width="70px"></asp:Label>
            <asp:Label ID="lblUnitCost" runat="server" height="19px" style="z-index: 1; left: 10px; top: 178px; position: absolute" Text="UnitCost" width="70px"></asp:Label>
            <asp:TextBox ID="txtUnitCost" runat="server" style="z-index: 1; left: 82px; top: 176px; position: absolute"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkLocationLocal" runat="server" style="z-index: 1; left: 10px; top: 205px; position: absolute" Text="Local" />
        <asp:CheckBox ID="chkLocationInt" runat="server" style="z-index: 1; left: 132px; top: 205px; position: absolute" Text="International" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 236px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 18px; top: 282px; position: absolute; width: 33px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 73px; top: 283px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>

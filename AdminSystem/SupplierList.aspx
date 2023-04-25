<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 12px; top: 406px; position: absolute" Text="Enter a Company Address"></asp:Label>
        <asp:TextBox ID="txtCompanyAddress" runat="server" style="z-index: 1; left: 192px; top: 407px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 88px; top: 441px; position: absolute" Text="Clear" />
        <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 3px; top: 2px; position: absolute; height: 351px; width: 686px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 9px; top: 361px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 63px; top: 363px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 9px; top: 479px; position: absolute; width: 56px;"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 126px; top: 363px; position: absolute" Text="Delete" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 10px; top: 439px; position: absolute" Text="Apply" />
    </form>
</body>
</html>

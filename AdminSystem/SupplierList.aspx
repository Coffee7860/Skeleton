<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 3px; top: 2px; position: absolute; height: 351px; width: 686px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 9px; top: 361px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 63px; top: 363px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 400px; position: absolute"></asp:Label>
    </form>
</body>
</html>


<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="align-items:center">
            This is Customer List Page.</div>
        <p>
            <asp:ListBox ID="lstBox" runat="server" Height="258px" style="margin-left: 375px" Width="341px"></asp:ListBox>
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" Height="29px" Style="margin-left: 282px; margin-top: 0px" Text="Add" Width="63px" OnClick="btnAdd_Click" />
    &nbsp;<asp:Button ID="btnEdit" runat="server" Height="29px" Text="Edit" Style="margin-left: 83px" Width="63px" OnClick="btnEdit_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btmDelete" runat="server" Height="27px" Text="Delete" Width="63px" OnClick="btmDelete_Click" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label runat="server" Text="" ID="lblError"></asp:Label>
    </form>
</body>
</html>

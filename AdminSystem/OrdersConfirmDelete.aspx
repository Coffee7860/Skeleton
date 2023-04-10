<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 72px;
            left: 10px;
            right: 1782px;
        }
        .auto-style2 {
            position: absolute;
            top: 72px;
            left: 58px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Are you sure you want to delete this record ?<br />
            <br />
            <asp:Button ID="btnYes" runat="server" CssClass="auto-style1" OnClick="btnYes_Click" style="z-index: 1; height: 26px" Text="Yes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNo" runat="server" CssClass="auto-style2" height="26px" OnClick="btnNo_Click" style="z-index: 1" Text="No" width="37px" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

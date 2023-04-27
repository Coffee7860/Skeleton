<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Are you sure you want to delete this record ?<br />
            <br />
            <asp:Button ID="Yes" runat="server" Text="Yes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="No" runat="server" Text="No" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
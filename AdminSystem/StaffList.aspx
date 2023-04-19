<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is Staff List Page.</div>
        <p>
            <asp:ListBox ID="ListBox1" runat="server" Height="258px" style="margin-left: 375px" Width="341px"></asp:ListBox>
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="39px" style="margin-left: 282px; margin-top: 0px" Text="Add" Width="83px" />
    &nbsp;<asp:Button ID="Button3" runat="server" Height="39px" Text="Edit" style="margin-left: 83px" Width="83px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Height="37px" Text="Delete" Width="83px" />
    </form>
</body>
</html>

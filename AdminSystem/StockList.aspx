<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Height="258px" style="margin-left: 375px" Width="341px"></asp:ListBox>
        </div>
        <asp:Button ID="Button1" runat="server" Height="63px" style="margin-left: 312px; margin-top: 33px" Text="Add" Width="66px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="63px" style="margin-left: 74px; margin-top: 0px" Text="Edit" Width="66px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="63px" Text="Delete" style="margin-left: 86px" Width="66px" />
    </form>
</body>
</html>

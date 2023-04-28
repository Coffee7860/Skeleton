

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             This is Customer Viewer Page.</div>
        <p>

            <asp:ListBox ID="lstBox" runat="server" Height="310px" style="margin-left: 102px" Width="285px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNext" runat="server" Height="41px" Style="margin-left: 28px" Text="Next" Width="83px" OnClick="btnNext_Click" />
&nbsp;
        <asp:Button runat="server" Text="Previous" ID="btnPrevious" Height="41px" style="margin-left: 28px"  Width="83px"></asp:Button></div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" style="margin-left: 292px" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" style="margin-left: 31px" Text="Edit" Width="71px" />
&nbsp;
            <asp:Button ID="btnDelete" runat="server" style="margin-left: 27px" Text="Delete" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>


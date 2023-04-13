<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 15px;
            left: 10px;
            z-index: 1;
            width: 270px;
            height: 298px;
        }
        .auto-style2 {
            position: absolute;
            top: 338px;
            left: 10px;
        }
        .auto-style3 {
            position: absolute;
            top: 338px;
            left: 58px;
        }
        .auto-style4 {
            position: absolute;
            top: 502px;
            left: 10px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 338px;
            left: 106px;
        }
        .auto-style6 {
            position: absolute;
            top: 395px;
            left: 131px;
        }
        .auto-style7 {
            position: absolute;
            top: 433px;
            left: 10px;
        }
        .auto-style8 {
            position: absolute;
            top: 433px;
            left: 74px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" CssClass="auto-style1"></asp:ListBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" style="z-index: 1" Text="Add" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" OnClick="btnEdit_Click" style="z-index: 1" Text="Edit" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" CssClass="auto-style5" OnClick="btnDelete_Click" style="z-index: 1" Text="Delete" />
            <br />
            <br />
            <br />
            Enter a Postcode:-&nbsp;
            <asp:TextBox ID="txtFilter" runat="server" CssClass="auto-style6" style="z-index: 1"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" CssClass="auto-style7" OnClick="btnApply_Click" style="z-index: 1" Text="Apply" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" CssClass="auto-style8" OnClick="btnClear_Click" style="z-index: 1" Text="Clear" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" CssClass="auto-style4" Text="[lblError]"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

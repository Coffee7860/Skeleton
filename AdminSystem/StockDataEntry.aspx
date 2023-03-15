<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 53px;
            left: 10px;
        }
        .auto-style2 {
            position: absolute;
            top: 53px;
            left: 265px;
            z-index: 1;
            width: 283px;
        }
        </style>
</head>
<body>
    This is Stocks Data Entry Page 
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderNumber" runat="server" CssClass="auto-style1" style="z-index: 1" Text="Stock Number"></asp:Label>
            <asp:TextBox ID="txtOrderNumber" runat="server" CssClass="auto-style2"></asp:TextBox>

           
           
        </div>
        Stock Brand Name
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 103px" Width="279px"></asp:TextBox>
        <br />
        StockQuantity
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 141px" Width="279px"></asp:TextBox>
        <br />
        ProductPrice&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 144px" Width="278px"></asp:TextBox>
        <br />
        Stock Date_In
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 143px" Width="273px"></asp:TextBox>
        <br />
        Stock Date_Out
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 130px" Width="276px"></asp:TextBox>
        <br />
        <br />
        Stock Delivered&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="Delivered" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:CheckBox ID="No" runat="server" />
        
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancel" />
        
        <br />
    </form>
</body>
</html>

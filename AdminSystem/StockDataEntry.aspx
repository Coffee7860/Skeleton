<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .auto-style2 {}
    </style>
    
</head>
<body>
    This is Stocks Data Entry Page 
    <form id="form1" runat="server">

        <div>
            
            <br />
            
            <asp:Label ID="lblStockId" runat="server"  Text="Stock ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStockId" runat="server" CssClass="auto-style2" Width="276px"></asp:TextBox> 
        
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Find" OnClick="Button3_Click" />
        
            <br /><br />
        
        <asp:Label ID="Label1" runat="server" Text="Stock Brand Name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server" style="margin-left: 103px" Width="279px"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="StockQuantity"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 141px" Width="279px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="ProductPrice "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 144px" Width="278px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Stock Date_In"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 143px" Width="273px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Stock Date_Out"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server" style="margin-left: 130px" Width="276px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Stock Delivered"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        &nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:CheckBox ID="No" runat="server" />
        
        &nbsp;&nbsp;&nbsp;&nbsp;
       <asp:CheckBox ID="Delivered" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
        
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        
        <br />
            </div>
    </form>
</body>
</html>

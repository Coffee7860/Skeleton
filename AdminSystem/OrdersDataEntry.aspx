<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
            left: 122px;
            z-index: 1;
            width: 125px;
        }
        .auto-style3 {
            position: absolute;
            top: 91px;
            left: 10px;
        }
        .auto-style4 {
            position: absolute;
            top: 91px;
            left: 122px;
        }
        .auto-style5 {
            position: absolute;
            top: 129px;
            left: 10px;
        }
        .auto-style6 {
            position: absolute;
            top: 167px;
            left: 10px;
        }
        .auto-style7 {
            position: absolute;
            top: 205px;
            left: 10px;
        }
        .auto-style8 {
            position: absolute;
            top: 129px;
            left: 122px;
        }
        .auto-style9 {
            position: absolute;
            top: 167px;
            left: 122px;
        }
        .auto-style10 {
            position: absolute;
            top: 205px;
            left: 122px;
        }
        .auto-style11 {
            position: absolute;
            top: 243px;
            left: 10px;
        }
        .auto-style13 {
            position: absolute;
            top: 281px;
            left: 10px;
        }
        .auto-style14 {
            position: absolute;
            top: 319px;
            left: 10px;
        }
        .auto-style15 {
            position: absolute;
            top: 319px;
            left: 90px;
        }
        .auto-style16 {
            position: absolute;
            top: 53px;
            left: 282px;
        }
        .auto-style17 {
            position: absolute;
            top: 281px;
            left: 118px;
        }
        .auto-style18 {
            position: absolute;
            top: 281px;
            left: 294px;
        }
    </style>
</head>
<body>
    This is Order Entry Page
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderNumber" runat="server" CssClass="auto-style1" style="z-index: 1" Text="Order Number"></asp:Label>
            <asp:TextBox ID="txtOrderNumber" runat="server" CssClass="auto-style2"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" CssClass="auto-style16" OnClick="btnFind_Click" style="z-index: 1" Text="Find" />

            <br /><br />
            
            <asp:Label ID="lblOrderDate" runat="server" CssClass="auto-style3" style="z-index: 1" Text="Date" height="19px" width="91px"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server" CssClass="auto-style4" style="z-index: 1" width="128px"></asp:TextBox>

            <br /><br />
          
            <asp:Label ID="lblOrderAddress" runat="server" CssClass="auto-style5" style="z-index: 1" Text="Address" height="19px" width="91px"></asp:Label>
            <asp:TextBox ID="txtOrderAddress" runat="server" CssClass="auto-style8" style="z-index: 1" width="128px"></asp:TextBox>

            <br /><br />
            
            <asp:Label ID="lblOrderPoscode" runat="server" CssClass="auto-style6" style="z-index: 1" Text="Postcode" height="19px" width="91px"></asp:Label>
            <asp:TextBox ID="txtOrderPostcode" runat="server" CssClass="auto-style9" style="z-index: 1" width="128px"></asp:TextBox>

            <br /><br />
            
            <asp:Label ID="lblOrderCountyCode" runat="server" CssClass="auto-style7" style="z-index: 1" Text="County Code" height="19px" width="91px"></asp:Label>
            <asp:TextBox ID="txtOrderCountycode" runat="server" CssClass="auto-style10" style="z-index: 1" width="128px"></asp:TextBox>

            <br />

            <br /><br />

            <asp:CheckBox ID="chkOrderDelivered" runat="server" CssClass="auto-style11" style="z-index: 1" Text="Delivered" />

            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrderTotalAmount" runat="server" CssClass="auto-style17" style="z-index: 1"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server" CssClass="auto-style18" style="z-index: 1" Text="[Error]"></asp:Label>
            <br />
            <asp:Label ID="lblOrderTotalAmount" runat="server" CssClass="auto-style13" style="z-index: 1" Text="Total Amount"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" CssClass="auto-style14" OnClick="btnOK_Click" style="z-index: 1" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" CssClass="auto-style15" OnClick="Button2_Click" style="z-index: 1" Text="Cancel" />
            <br />
        
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>


<body>
    Customer Entry Page
   
    <form id="form1" runat="server">
        <div id="txtPhoneNumber">
            <br /><br /><br />
            <asp:Label runat="server" Text="CustomerID" ID="lblCustomerID"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtCustomerId"></asp:TextBox>
            <asp:Button runat="server" Text="Find By ID" OnClick="Unnamed3_Click" ID="btnFind"></asp:Button>
                 <br />
           <br />
            <asp:Label runat="server" Text="FirstName" ID="lblFirstName"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>
           
           <br /><br />
            <asp:Label runat="server" Text="LastName" ID="lblLastName"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>

            <br /><br />
            <asp:Label runat="server" Text="Phone Number" ID="lblPhoneNumber"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtPhoneNumber"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server" Text="Email Address" ID="ctl21"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>

            <br /><br />
            <asp:Label runat="server" Text="Password" ID="ctl27"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>

            <br />
            <br />
            <asp:Label runat="server" Text="[lblError]" ID="lblError"></asp:Label>
             <br />
            <br />
             <br />
            <br />
            <asp:Button runat="server" Text="OK" ID="btnOk" OnClick="btnOk_Click"></asp:Button>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" Text="Cancel" ID="btnCancel" OnClick="btnCancel_Click"></asp:Button>
            
        </div>
    </form>
</body></html>


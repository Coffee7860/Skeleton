using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Creating a new instance of clsOrders
        clsOrders order = new clsOrders();
        //Capturing the order number 
        string OrderAddress = txtOrderAddress.Text;
        string OrderPostcode = txtOrderPostcode.Text;
        string OrderDate = txtOrderDate.Text;

        string Error = "";
        Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
        if (Error == "")
        {
            order.OrderAddress = OrderAddress;
            order.OrderPostcode = OrderPostcode;
            order.OrderDate = Convert.ToDateTime(OrderDate);
            //store the address in the session object.
            Session["order"] = order;
            //navigate to viewer page
            Response.Redirect("OrdersViewer.aspx");
        }
        else
        {
            //Display The Error Message
            lblError.Text = Error;
        }
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrders order = new clsOrders();
        Int32 OrderNumber;
        Boolean Found = false;
        OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
        Found = order.Find(OrderNumber);
        if(Found == true)
        {
            txtOrderNumber.Text = order.OrderNumber.ToString();
            txtOrderDate.Text = order.OrderDate.ToString();
            txtOrderAddress.Text = order.OrderAddress.ToString();
            txtOrderCountycode.Text = order.OrderCountyCode.ToString();
            txtOrderPostcode.Text = order.OrderPostcode.ToString();
            chkOrderDelivered.Checked = order.OrderDeliveryStatus;
            chkOrderProcessing.Checked = order.OrderDeliveryStatus;
            txtOrderTotalAmount.Text = order.OrderTotalAmount.ToString();
        }
    }
}
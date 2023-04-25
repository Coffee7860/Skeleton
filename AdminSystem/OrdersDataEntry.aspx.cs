using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private readonly int OrderNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Creating a new instance of clsOrders
        clsOrders order = new clsOrders();

        //Capturing the order Address
        string OrderAddress = txtOrderAddress.Text;
        //capturing The Order Postcode
        string OrderPostcode = txtOrderPostcode.Text;
        //cApturing The Order Date
        string OrderDate = txtOrderDate.Text;
        //captuing The Order County code
        string OrderCountyCode = txtOrderCountycode.Text;
        //Capturing The Order Total Amount
        string OrderTotalAmount = txtOrderTotalAmount.Text;
        //capturing the order number
        //string OrderNumber = txtOrderNumber.Text;
        
        //Variable to store Any Error Message
        string Error = "";

        //Validate the data
        Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
        if (Error == "")
        {
            //Capture the Order Number 
            order.OrderNumber = OrderNumber;
            //capturing The Order Adddress
            order.OrderAddress = OrderAddress;
            //Capturing the Order Postcode
            order.OrderPostcode = OrderPostcode;
            //Capturing The Order Date
            order.OrderDate = Convert.ToDateTime(OrderDate);
            //Capturing the Order Countycode
            order.OrderCountyCode = Convert.ToInt32(OrderCountyCode);
            //Capturing the Order Total Amount
            order.OrderTotalAmount = Convert.ToInt32(OrderTotalAmount);
            //Capturing the OrderDelivery Status
            order.OrderDeliveryStatus = chkOrderDelivered.Checked;

            //create A new instance Of the Order Collection.
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new Record (OrderNumber = -1 then add the data)
            if (OrderNumber == -1)
            {
                //set the thisOrderProperty
                OrderList.ThisOrder = order;
                //Add the new record
                OrderList.Add();
            }
            //else it must be an update
            else
            {
                //find the record to update 
                OrderList.ThisOrder.Find(OrderNumber);
                //Set The ThisOrder Property
                OrderList.ThisOrder = order;
                //Update the Record
                OrderList.Update();
            }
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //Display The Error Message
            lblError.Text = Error;
        }
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersDataEntry.aspx");
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
           // chkOrderProcessing.Checked = order.OrderDeliveryStatus;
            txtOrderTotalAmount.Text = order.OrderTotalAmount.ToString();
        }
    }
}
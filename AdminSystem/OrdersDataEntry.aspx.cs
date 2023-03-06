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
        order.OrderAddress = TxtOrderAddress.Text;
        //store the address in the session object.
        Session["order"] = order;
        //navigate to viewer page
        Response.Redirect("OrdersViewer.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}
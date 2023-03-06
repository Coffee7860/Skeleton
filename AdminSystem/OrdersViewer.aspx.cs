using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create new instance 
        clsOrders order = new clsOrders();
        //get the data from the sesion object
        order = (clsOrders)Session["order"];
        //Display the order address from the entry
        Response.Write(order.OrderAddress);
    }
}
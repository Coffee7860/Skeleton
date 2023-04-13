using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //varible to store the primary key value of the record to be deleted
    Int32 OrderNumber;
    //event handler for the page load
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order to be deleted from the session object
        OrderNumber = Convert.ToInt32(Session["OrderNumber"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the order class
        clsOrderCollection Order = new clsOrderCollection();

        //find the record to delete
        Order.ThisOrder.Find(OrderNumber);
        //Delete the record using primary key
        Order.Delete();

        //Redirect back to the main page
        Response.Redirect("OrdersList.aspx");
    }





    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirect back to the main page
        Response.Redirect("OrdersList.aspx");
    }
}
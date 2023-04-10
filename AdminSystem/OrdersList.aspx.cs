using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with the page level scope 
    Int32 OrderNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order To be processed
        OrderNumber = Convert.ToInt32(Session["OrderNumber"]);
        if (IsPostBack == false)
        {
            //if this is not a new a record
            if(OrderNumber != -1)
            {
                //display the current data for the record selected.
                DisplayOrder();
            }
        }
    }
    void DisplayOrder()
    {
        //create an instance of the Order Collection.
        clsOrderCollection Order = new clsOrderCollection();
        //set the data source to list of Order in the collection.
        lstOrderList.DataSource = Order.OrderList;
        //set the name of the primary key.
        lstOrderList.DataValueField = "OrderNumber";
        //set the data field to display
        lstOrderList.DataTextField = "OrderPostcode";
        //bind the data to the list.
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderNumber"] = -1;
        //redirect  to the data entry page 
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 OrderNumber;
        //if the record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit the record.
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session Object.
            Session["OrderNumber"] = OrderNumber;
            //Redirect to the edit Page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else
        {
            //If no record is selected then it will diplay error.
            lblError.Text = "Please Select A record To edit From the List";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 OrderNumber;
        //If a record has been selected from the list
        if(lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the Data in the session Object
            Session["OrderNUmber"] = OrderNumber;

            //redirect to the delete Page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else
        {
            //if no record has been seleted 
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
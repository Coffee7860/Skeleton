using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Customer_Id"] = -1;
        //redirect  to the data entry page 
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
       
        Int32 CustomerID;
        if (lstBox.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstBox.SelectedValue);
            Session["OrderNumber"] = CustomerID;
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else
        {
            //If no record is selected then it will diplay error.
            lblError.Text = "Please Select A record To edit From the List";
        }
    }

    protected void btmDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //If a record has been selected from the list
        if (lstBox.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstBox.SelectedValue);
            //store the Data in the session Object
            Session["CustomerId"] = CustomerID;

            //redirect to the delete Page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            //if no record has been seleted 
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
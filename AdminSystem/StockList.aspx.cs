using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with the page level scope 
    Int32 StocksId;
    

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order To be processed
        StocksId = Convert.ToInt32(Session["StocksId"]);
        if (IsPostBack == false)
        {
            //if this is not a new a record
            if (StocksId != -1)
            {
                //display the current data for the record selected.
                DisplayStock();
            }
        }
    }
        
            void DisplayStock()
            {
                //create an instance of the Order Collection.
                clsStockCollection Stocks = new clsStockCollection();
        //set the data source to list of Order in the collection.
        ListBox1.DataSource = Stocks.StocksList;
        //set the name of the primary key.
        ListBox1.DataValueField = "StocksId";
        //set the data field to display
        ListBox1.DataTextField = "StockQuantity";
        //bind the data to the list.
        ListBox1.DataBind();
            }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["StocksId"] = -1;
        //redirect  to the data entry page 
        Response.Redirect("StockDataEntry.aspx");
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StocksId;
        //if the record has been selected from the list
        if (ListBox1.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit the record.
            StocksId = Convert.ToInt32(ListBox1.SelectedValue);
            //store the data in the session Object.
            Session["StocksId"] = StocksId;
            //Redirect to the edit Page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            //If no record is selected then it will diplay error.
            Label1.Text = "Please Select A record To edit From the List";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StocksId;
        //If a record has been selected from the list
        if (ListBox1.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StocksId = Convert.ToInt32(ListBox1.SelectedValue);
            //store the Data in the session Object
            Session["StocksId"] = StocksId;

            //redirect to the delete Page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            //if no record has been seleted 
            //display an error
            Label1.Text = "Please select a record to delete from the list";
        }
    }
}
    

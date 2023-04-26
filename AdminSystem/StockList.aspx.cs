using ClassLibrary;
using System;
using System.Collections.Generic;
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
            void DisplayStock()
            {
                //create an instance of the Order Collection.
                clsStockCollection Stock = new clsStockCollection();
                //set the data source to list of Order in the collection.
                lstStockList.DataSource = Stock.StocksList;
                //set the name of the primary key.
                lstStockList.DataValueField = "StocksId";
                //set the data field to display
                lstStockList.DataTextField = "StockQuantity";
                //bind the data to the list.
                lstStockList.DataBind();
            }
        }
    }
}
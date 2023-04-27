using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //varible to store the primary key value of the record to be deleted
    Int32 StocksId;
    //event handler for the page load
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order to be deleted from the session object
        StocksId = Convert.ToInt32(Session["StocksId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the order class
        clsStockCollection stocks = new clsStockCollection();

        //find the record to delete
        stocks.ThisStock.Find(StocksId);
        //Delete the record using primary key
        stocks.Delete();

        //Redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}
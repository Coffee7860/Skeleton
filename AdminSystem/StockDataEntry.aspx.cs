using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private readonly int StocksId;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStocks stocks= new clsStocks();
        
        string Stocks_BrandName = TextBox5.Text;
        
        string StockQuantity = TextBox1.Text;
        
        string ProductPrice = TextBox2.Text;
        
        string Stock_In_Date = TextBox3.Text;
        
        string Stock_Out_Date = TextBox4.Text;
        
        //string StocksId = txtStockId.Text;

        //Variable to store Any Error Message
        string Error = "";

        //Validate the data
        Error = stocks.Valid(Stocks_BrandName, Stock_In_Date);
        if (Error == "")
        {
            
            stocks.StocksId = Convert.ToInt32(StocksId);
           
            stocks.Stock_BrandName = Stocks_BrandName;
            
            stocks.StockQuantity = Convert.ToInt32(StockQuantity);

            stocks.Stock_In_Date = Convert.ToDateTime(Stock_In_Date);
            
            stocks.Stock_Out_Date = Convert.ToDateTime(Stock_Out_Date);
            
            stocks.PruductPrice = Convert.ToInt32(ProductPrice);

            stocks.StocksDeliveryStatus = Delivered.Checked;

            //create A new instance Of the Stock Collection.
            clsStockCollection StocksList = new clsStockCollection();

            //if this is a new Record (OrderNumber = -1 then add the data)
            if (StocksId == -1)
            {
                //set the thisstockProperty
                StocksList.ThisStock = stocks;
                //Add the new record
                StocksList.Add();
            }
            //else it must be an update
            else
            {
                //find the record to update 
                StocksList.ThisStock.Find(StocksId);
                //Set The ThisOrder Property
                StocksList.ThisStock = stocks;
                //Update the Record
                StocksList.Update();
            }
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //Display The Error Message
            Label7.Text = Error;
        }

    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockDataEntry.aspx");
    }




    protected void Button3_Click(object sender, EventArgs e)
    {
        clsStocks stocks = new clsStocks();
        Int32 StocksId;
        Boolean Found = false;
        StocksId = Convert.ToInt32(txtStockId.Text);
        Found = stocks.Find(StocksId);
        if (Found == true)
        {
            txtStockId.Text = stocks.StocksId.ToString();
            TextBox1.Text = stocks.StockQuantity.ToString();
            TextBox2.Text = stocks.PruductPrice.ToString();
            TextBox3.Text = stocks.Stock_In_Date.ToString();
            TextBox4.Text = stocks.Stock_Out_Date.ToString();
            Delivered.Checked = stocks.StocksDeliveryStatus;
            TextBox5.Text = stocks.StocksId.ToString();
        }
    }
}
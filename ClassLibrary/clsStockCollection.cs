using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //Private Data Member from the list
        List<clsStocks> mStocksList = new List<clsStocks>();
        public List<clsStocks> StocksList
        {
            get
            {
                //return the private member
                return mStocksList;
            }
            set
            {
                //set the private member
                mStocksList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private member
                return mStocksList.Count;
            }
            set
            {

            }
        }
        clsStocks mThisStock = new clsStocks();
        public clsStocks ThisStock
        {
            get
            {
                //Return the private member 
                return mThisStock;
            }
            set
            {
                //set the private member
                mThisStock = value;
            }
        }

        public clsStockCollection()
        {
            //Variable for the index
            Int32 Index = 0;
            //Variable to store The record Count
            Int32 RecordCount = 0;
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();

            //Execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the arraylist with the data table
            PopulateArray(DB);

            //Get the Count Of records
            RecordCount = DB.Count;

            //While there are record to process
            while (Index < RecordCount)
            {
                ////create a blank order
                clsStocks stocks = new clsStocks();

                //read in the fields from the current record
                stocks.StocksId = Convert.ToInt32(DB.DataTable.Rows[Index]["StocksId"]);
                stocks.Stock_In_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Stock_In_Date"]);
                stocks.Stock_Out_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Stock_Out_Date"]);
                stocks.Stock_BrandName = Convert.ToString(DB.DataTable.Rows[Index]["Stock_BrandName"]);
                stocks.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                stocks.StocksDeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["StocksDeliveryStatus"]);
                stocks.PruductPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["PruductPrice"]);

                //add the record to the private data member
                mStocksList.Add(stocks);
                //point at the next Record
                Index++;
            }
        }

        public int Add()
        {
            //Adds a new record to the database based on the value of the ThisStocks
            //Connect To databse
            clsDataConnection DB = new clsDataConnection();

            //set the parameter for the stored procedure
            DB.AddParameter("@Stock_BrandName", mThisStock.Stock_BrandName);
            DB.AddParameter("@Stock_In_Date", mThisStock.Stock_In_Date);
            DB.AddParameter("@Stock_Out_Date", mThisStock.Stock_Out_Date);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@StocksDeliveryStatus", mThisStock.StocksDeliveryStatus);
            DB.AddParameter("@PruductPrice", mThisStock.PruductPrice);

            //execute the query returning the primary key 
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update an existing record based on the value of ThisStock
            //Connect to database
            clsDataConnection DB = new clsDataConnection();

            //set the parameter for the stored procedure.
            DB.AddParameter("@Stock_BrandName", mThisStock.Stock_BrandName);
            DB.AddParameter("@Stock_In_Date", mThisStock.Stock_In_Date);
            DB.AddParameter("@Stock_Out_Date", mThisStock.Stock_Out_Date);
            DB.AddParameter("@StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("@StocksDeliveryStatus", mThisStock.StocksDeliveryStatus);
            DB.AddParameter("@PruductPrice", mThisStock.PruductPrice);
            DB.AddParameter("@StocksId", mThisStock.StocksId);

            //execute the stored procedure.
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //delete the record pointed by thisStock
            //Connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StocksId", mThisStock.StocksId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }
        private void PopulateArray(clsDataConnection DB)
        {
            //Populate the arrayylist based on the data table in the parameter DB
            //Variable for the index 
            Int32 Index = 0;

            //variable to Store the record count 
            Int32 RecordCount;

            //Get the count of the record
            RecordCount = DB.Count;
            //clear the private Arraylist
            mStocksList = new List<clsStocks>();

            //while there are record to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsStocks stocks = new clsStocks();

                //read tin the field from the current record 
                stocks.StocksId = Convert.ToInt32(DB.DataTable.Rows[Index]["StocksId"]);
                stocks.Stock_In_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Stock_In_Date"]);
                stocks.Stock_Out_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Stock_Out_Date"]);
                stocks.Stock_BrandName = Convert.ToString(DB.DataTable.Rows[Index]["Stock_BrandName"]);
                stocks.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                stocks.StocksDeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["StocksDeliveryStatus"]);
                stocks.PruductPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["PruductPrice"]);

                //Add the record to the private data member
                mStocksList.Add(stocks);
                //Point at the next record
                Index++;
            }
        }
    }
}
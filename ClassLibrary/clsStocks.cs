using System;

namespace ClassLibrary
{
    public class clsStocks
    {
        private Boolean mStocksDeliveryStatus;
       
        public bool StocksDeliveryStatus
        {
            get
            {
                //return the private data
                return mStocksDeliveryStatus;
            }
            set
            {
                //set the priavte data
                mStocksDeliveryStatus = value;
            }
        }
        private int mStockQuantity;
        public int StockQuantity
        {
            get
            {
                //return the private data
                return mStockQuantity;
            }
            set
            {
                //set the priavte data
                mStockQuantity = value;
            }
        }
        private float mProductPrice;
        public float PruductPrice
        {
            get
            {
                //return the private data
                return  mProductPrice;
            }
            set
            {
                //set the priavte data
                mProductPrice = value;
            }
        }
        private DateTime mStock_In_Date;
        public DateTime Stock_In_Date
        {
            get
            {
                //return the private data
                return mStock_In_Date;
            }
            set
            {
                //set the priavte data
                mStock_In_Date = value;
            }
        }
        private DateTime mStock_Out_Date;
        public DateTime Stock_Out_Date
        {
            get
            {
                //return the private data
                return mStock_Out_Date;
            }
            set
            {
                //set the priavte data
                   mStock_Out_Date = value;
            }
        }
        private string mStock_BrandName;
        public string Stock_BrandName
        {
            get
            {
                //return the private data
                return mStock_BrandName;
            }
            set
            {
                //set the priavte data
                mStock_BrandName = value;
            }
        }
        private int mStocksId;
        public int StocksId
        {
            get
            {
                //return the private data
                return mStocksId;
            }
            set
            {
                //set the priavte data
                mStocksId = value;
            }
        }
        

        public bool Find(int stocksId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order number to search for
            DB.AddParameter("@StocksId", stocksId);
            //execute the stored procedure
            DB.Execute("sproc_tblstock_FilterByStocksId");

            //if one record is found (there should be only one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mStocksId = Convert.ToInt32(DB.DataTable.Rows[0]["StocksId"]);
                mStock_In_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Stock_In_Date"]);
                mStock_Out_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Stock-Out_Date"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mProductPrice = Convert.ToInt32(DB.DataTable.Rows[0]["ProductPrice"]);
                mStocksDeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["StocksDeliveryStatus"]);
                mStock_BrandName = Convert.ToString(DB.DataTable.Rows[0]["Stock_BrandName"]);

                //return that everything working ok
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string stock_BrandName, string stock_In_Date)
        {
            //create a string variable to store the error
            string Error = "";
            //create a temporary variable to store date value
            DateTime DateTemp;

            try
            {
                //copy the order date value to then data temp variable
                DateTemp = Convert.ToDateTime(stock_In_Date);
                //check to see if the date is less than present date
                if (DateTemp < DateTime.Now.Date)
                {
                    //Record The error
                    Error = Error + "the Date Cannot be in the past: ";
                }

                //check to see if the date is greater than present date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be in future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The Date was not a valid date";
            }

            //check if the Brand Name is blank
            if (stock_BrandName.Length == 0)
            {
                //record the error
                Error = Error + "The Stock_BrandName May not be blank: ";
            }
            if (stock_BrandName.Length > 20)
            {
                //record the error
                Error = Error + "The Brand Name Must be Less than 20 Character: ";
            }
            //return the error message 
            return Error;
        }
    }
}
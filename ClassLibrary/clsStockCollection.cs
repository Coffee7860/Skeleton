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
    }
}
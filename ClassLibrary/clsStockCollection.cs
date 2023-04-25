using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public List<clsStocks> StocksList { get; set; }
        public int Count { get; set; }
        public clsStocks ThisStock { get; set; }
    }
}
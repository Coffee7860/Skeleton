﻿using System;

namespace ClassLibrary
{
    public class clsStocks
    {
        public bool StocksDeliveryStatus { get; set; }
        public int ProductQuantity { get; set; }
        public float PruductPrice { get; set; }
        public DateTime Stock_In_Date { get; set; }
        public DateTime Stock_Out_Date { get; set; }
        public string Stock_BrandName { get; set; }
        public int StocksId { get; set; }
        public int StocksQuantity { get; set; }

        public bool Find(int stocksId)
        {
            throw new NotImplementedException();
        }
    }
}
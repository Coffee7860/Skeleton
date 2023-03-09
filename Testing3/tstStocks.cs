using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStocks
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStocks stocks = new clsStocks();
            Assert.IsNotNull(stocks);
        }

        [TestMethod]
        public void StocksDeliveryStatusPropertyOK()
        {
            clsStocks stocks = new clsStocks();
            Boolean TestData = true;
            stocks.StocksDeliveryStatus = TestData;
            Assert.AreEqual(stocks.StocksDeliveryStatus, TestData);
        }

        [TestMethod]
        public void ProductQuantityPropertyOK()
        {
            clsStocks stocks = new clsStocks();
            Int32 TestData = 10;
            stocks.ProductQuantity = TestData;
            Assert.AreEqual(stocks.ProductQuantity, TestData);
        }

        [TestMethod]
        public void PruductPricePropertyOK()
        {
            clsStocks stocks = new clsStocks();
            float TestData = 100;
            stocks.PruductPrice = TestData;
            Assert.AreEqual(stocks.PruductPrice, TestData);
        }

        [TestMethod]
        public void Stock_In_DatePropertyOK()
        {
            clsStocks stocks = new clsStocks(); 
            DateTime TestData = DateTime.Now.Date;
            stocks.Stock_In_Date = TestData;
            Assert.AreEqual(stocks.Stock_In_Date, TestData);
        }

        [TestMethod]
        public void Stock_Out_DatePropertyOK()
        {
            clsStocks stocks = new clsStocks();
            DateTime TestData = DateTime.Now.Date;
            stocks.Stock_Out_Date = TestData;
            Assert.AreEqual(stocks.Stock_Out_Date, TestData);
        }

        [TestMethod]
        public void Stock_BrandNamePropertyOK()
        {
            clsStocks stocks = new clsStocks();
            string TestData = "Boss";
            stocks.Stock_BrandName = TestData;
            Assert.AreEqual(stocks.Stock_BrandName, TestData);
        }

    }
}


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
        public void StockQuantityPropertyOK()
        {
            clsStocks stocks = new clsStocks();
            Int32 TestData = 10;
            stocks.StockQuantity = TestData;
            Assert.AreEqual(stocks.StockQuantity, TestData);
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
        [TestMethod]
        public void StocksIdPropertyOK()
        {
            clsStocks stocks = new clsStocks();
            Int32 TestData = 1;
            stocks.StocksId = TestData;
            Assert.AreEqual(stocks.StocksId, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStocks stocks = new clsStocks();
            Boolean Found = false;
            Int32 StocksId = 1;
            Found = stocks.Find(StocksId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStocksIdNoFound()
        {
            clsStocks stocks = new clsStocks();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StocksId = 1;
            Found = stocks.Find(StocksId);
            if (stocks.StocksId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStocksQuantityFound()
        {
            clsStocks stocks = new clsStocks();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StocksId = 100;
            Found = stocks.Find(StocksId);
            if (stocks.StockQuantity != 100)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStocks_BrandNameFound()
        {
            clsStocks stocks = new clsStocks();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StocksId = 1;
            Found = stocks.Find(StocksId);
            if (stocks.Stock_BrandName != "Boss")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPruductPriceFound()
        {
            clsStocks stocks = new clsStocks();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StocksId = 2;
            Found = stocks.Find(StocksId);
            if (stocks.PruductPrice != 100)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStock_In_DateFound()
        {
            clsStocks stocks = new clsStocks();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StocksId = 1;
            Found = stocks.Find(StocksId);
            if (stocks.Stock_In_Date != Convert.ToDateTime("20.03.2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryStatusFound()
        {
            clsStocks stocks = new clsStocks();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StocksId = 1;
            Found = stocks.Find(StocksId);
            if (stocks.StocksDeliveryStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStock_out_DateFound()
        {
            clsStocks stocks = new clsStocks();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StocksId = 1;
            Found = stocks.Find(StocksId);
            if (stocks.Stock_Out_Date != Convert.ToDateTime("22.03.2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //invoke the method
            Error = stocks.Valid(StockQuantity, PruductPrice, Stock_In_Date);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }
    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStocks
    {
        // Good Test Data
        //Create some test Data to pass to the Method
        string Stock_BrandName = "Boss";
        string Stock_In_Date = DateTime.Now.Date.ToString();

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
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Stock_In_DateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 10 year
            TestDate = TestDate.AddYears(-10);
            //convert the date vaiable to a string variable
            string Stock_In_Date = TestDate.ToString();
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Stock_In_DateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date vaiable to a string variable
            string Stock_In_Date = TestDate.ToString();
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Stock_In_DateMin()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date vaiable to a string variable
            string Stock_In_Date = TestDate.ToString();
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Stock_In_DatePlusOne()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date vaiable to a string variable
            string Stock_In_Date = TestDate.ToString();
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Stock_In_DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 10 years
            TestDate = TestDate.AddYears(10);
            //convert the date vaiable to a string variable
            string Stock_In_Date = TestDate.ToString();
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Stock_In_DateInvalidDate()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //set the OrderDate to a non date value
            string Stock_In_Date = "this is not a Date!";
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Stock_BrandNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //this should fail
            string Stock_BrandName = "";
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Stock_BrandNameMin()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //this should pass
            string Stock_BrandName = "b";
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Stock_BrandNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //this should pass
            string Stock_BrandName = "aa";
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Stock_BrandNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //this should pass
            string Stock_BrandName = "";
            Stock_BrandName = Stock_BrandName.PadRight(47, 'a');
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Stock_BrandNameMax()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //this should pass
            string Stock_BrandName = "";
            Stock_BrandName = Stock_BrandName.PadRight(48, 'a');
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Stock_BrandNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //this should fail
            string Stock_BrandName = "";
            Stock_BrandName = Stock_BrandName.PadRight(49, 'a');
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Stock_BrandNameMid()
        {
            //create an instance of the class we want to create
            clsStocks stocks = new clsStocks();
            //String variable to store any error
            String Error = "";
            //this should pass
            string Stock_BrandName = "";
            Stock_BrandName = Stock_BrandName.PadRight(24, 'a');
            //invoke the method
            Error = stocks.Valid(Stock_BrandName, Stock_In_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}

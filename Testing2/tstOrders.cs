using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrders
    {
        // Good Test Data
        //Create some test Data to pass to the Method
        string OrderAddress = "21, abc";
        string OrderPostcode = "LE5 3KT";
        string OrderDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsOrders order = new clsOrders();
            Assert.IsNotNull(order);
        }
        
        [TestMethod]
        public void OrderDeliveryStatusPropertyOK()
        {
            clsOrders order = new clsOrders();
            Boolean TestData = true;
            order.OrderDeliveryStatus = TestData;
            Assert.AreEqual(order.OrderDeliveryStatus, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrders order = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            order.OrderDate = TestData;
            Assert.AreEqual(order.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderAddressPropertyOK() 
        {
            clsOrders order = new clsOrders();
            string TestData = "21, abc";
            order.OrderAddress = TestData;
            Assert.AreEqual(order.OrderAddress, TestData);
        }

        [TestMethod]
        public void OrderPostcodePropertyOK() 
        {
            clsOrders order = new clsOrders();
            string TestData = "LE5 3KT";
            order.OrderPostcode = TestData;
            Assert.AreEqual(order.OrderPostcode, TestData);
        }

        [TestMethod]
        public void OrderCountyCodePropertyOK() 
        {
            clsOrders order = new clsOrders();
            Int32 TestData = 2;
            order.OrderCountyCode = TestData;
            Assert.AreEqual(order.OrderCountyCode, TestData);
        }

        [TestMethod]
        public void OrderTotalAmountPropertyOK()
        {
            clsOrders order = new clsOrders();
            Int32 TestData = 100;
            order.OrderTotalAmount = TestData;
            Assert.AreEqual(order.OrderTotalAmount, TestData);
        }

        [TestMethod]
        public void OrderNumberPropertyOK()
        {
            clsOrders order = new clsOrders();
            Int32 TestData = 1;
            order.OrderNumber = TestData;
            Assert.AreEqual(order.OrderNumber, TestData);
        }
        
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrders order = new clsOrders();
            Boolean Found = false;
            Int32 OrderNumber = 11;
            Found = order.Find(OrderNumber);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNumberfound()
        {
            clsOrders order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 11;
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderNumber != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrders order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 11;
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderDate != Convert.ToDateTime("24/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderAddressFound()
        {
            clsOrders order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 11;
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderAddress != "5, Canvendish Road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderPostcodeFound()
        {
            clsOrders order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 11;
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderPostcode != "LS2 3AR")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderCountyCodeFound()
        {
            clsOrders order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 11;
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderCountyCode != 826)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalAmountFound()
        {
            clsOrders order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 11;
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderTotalAmount != 200)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDeliveryStatusFound()
        {
            clsOrders order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 11;
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderDeliveryStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrders order = new clsOrders();
            String Error = "";
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrders order = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-10);
            string OrderDate = TestDate.ToString();
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne() 
        {
            clsOrders order = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin() 
        {
            clsOrders order = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrders order = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax() 
        {
            clsOrders order = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(10);
            string OrderDate = TestDate.ToString();
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidDate()
        {
            clsOrders order = new clsOrders();
            String Error = "";
            string OrderDate = "this is not a Date!";
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMinLessOne()
        {
            clsOrders order = new clsOrders();
            String Error = "";
            string OrderPostcode = "";
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMin() 
        {
            clsOrders order = new clsOrders();
            String Error = "";
            string OrderPostcode = "le";
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMinplusOne() 
        {
            clsOrders order = new clsOrders();
            String Error = "";
            string OrderPostcode = "le4l5al";
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMax()
        {
            clsOrders order = new clsOrders();
            String Error = "";
            string OrderPostcode = "leL45ALLEL";
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMaxplusOne() 
        {
            clsOrders order = new clsOrders();
            String Error = "";
            string OrderPostcode = "LE45AlLAKLD";
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMid()
        {
            clsOrders order = new clsOrders();
            String Error = "";
            string OrderPostcode = "Le4 5al";
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            Assert.AreEqual(Error, "");
        }
    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrders
    {
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
    }
}

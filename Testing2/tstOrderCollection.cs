using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();
            TestItem.OrderAddress = "12,ad";
            TestItem.OrderNumber = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderPostcode = "LE3 5WE";
            TestItem.OrderDeliveryStatus = true;
            TestItem.OrderTotalAmount = 1;
            TestItem.OrderCountyCode = 1;
            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }
        /*
        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Int32 SomeCount = 2;
            AllOrder.Count = SomeCount;
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }
        */
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrders TestOrders = new clsOrders();
            TestOrders.OrderAddress = "12,Asd";
            TestOrders.OrderNumber = 1;
            TestOrders.OrderDate = DateTime.Now.Date;
            TestOrders.OrderPostcode = "LE4 7DF";
            TestOrders.OrderDeliveryStatus = true;
            TestOrders.OrderTotalAmount = 1;
            TestOrders.OrderCountyCode = 1;
            AllOrder.ThisOrder = TestOrders;
            Assert.AreEqual(AllOrder.ThisOrder, TestOrders);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();
            TestItem.OrderAddress = "12,ad";
            TestItem.OrderNumber = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderPostcode = "LE3 5WE";
            TestItem.OrderDeliveryStatus = true;
            TestItem.OrderTotalAmount = 1;
            TestItem.OrderCountyCode = 1;
            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }
        /*
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.AreEqual(AllOrder.Count, 2);
        }
        */

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderAddress = "12,ad";
            TestItem.OrderNumber = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderPostcode = "LE3 5WE";
            TestItem.OrderDeliveryStatus = true;
            TestItem.OrderTotalAmount = 1;
            TestItem.OrderCountyCode = 1;
            AllOrder.ThisOrder = TestItem;
            PrimaryKey = AllOrder.Add();
            TestItem.OrderNumber = PrimaryKey;
            AllOrder.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
    }
}

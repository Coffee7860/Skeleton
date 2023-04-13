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
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item to test data
            clsOrders TestItem = new clsOrders();

            //variable to store the primary key 
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.OrderAddress = "12,ad";
            TestItem.OrderNumber = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderPostcode = "LE3 5WE";
            TestItem.OrderDeliveryStatus = true;
            TestItem.OrderTotalAmount = 1;
            TestItem.OrderCountyCode = 1;

            //set ThisOrder to the TestData
            AllOrder.ThisOrder = TestItem;

            //Add the record 
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderNumber = PrimaryKey;
            //find the record using the primary key
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create.
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of the test data
            clsOrders TestItem = new clsOrders();
            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //Set its Properties.
            TestItem.OrderAddress = "12,ad";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderPostcode = "LE3 5WE";
            TestItem.OrderDeliveryStatus = true;
            TestItem.OrderTotalAmount = 1;
            TestItem.OrderCountyCode = 1;

            //set ThisOrder to the Testdata
            AllOrder.ThisOrder = TestItem;

            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderNumber = PrimaryKey;

            //modify the test data
            TestItem.OrderAddress = "13,df";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderPostcode = "LE8 11HJ";
            TestItem.OrderDeliveryStatus = false;
            TestItem.OrderCountyCode = 10;
            TestItem.OrderTotalAmount = 10;

            //set the record based on the new test data
            AllOrder.ThisOrder = TestItem;
            
            //update the record
            AllOrder.Update();
            //find the record using priamry key
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see thisorder match the test data
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of the testdata
            clsOrders TestItem = new clsOrders();

            //variable yto store the primary key
            Int32 PrimaryKey = 0;

            //Set its Properties
            TestItem.OrderNumber = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderPostcode = "LE3 5WE";
            TestItem.OrderDeliveryStatus = true;
            TestItem.OrderAddress = "12,ad";
            TestItem.OrderCountyCode = 1;
            TestItem.OrderTotalAmount = 1;

            //set ThisOrder to the TestData
            AllOrder.ThisOrder = TestItem;
            //Add the record.
            PrimaryKey = AllOrder.Add();

            //set the primary key of the test data
            TestItem.OrderNumber = PrimaryKey;
            //find the record using the primary key
            AllOrder.ThisOrder.Find(PrimaryKey);

            //Delete the record 
            AllOrder.Delete();
            //now find the record 
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found.
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPostcodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create an instance of the filtered Data
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            //apply a blank string (should return all Record)
            FilteredOrders.ReportByPostcode("");

            //test to see that the two value are the same
            Assert.AreNotEqual(AllOrder.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByPostcodeNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //Apply a postcode that doesn't exits
            FilteredOrders.ReportByPostcode("xxx xxx");
            //test to see that there are no Record
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByPostcodeTestDataFound()
        {

            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //variable to store outcome
            Boolean OK = true;

            //Applying a postcode That doesn't exits
            FilteredOrders.ReportByPostcode("yyy yyy");
            //check that the correct number of record are found
            if(FilteredOrders.Count ==2)
            {
                //check that the first Record is ID 57
                if (FilteredOrders.OrderList[0].OrderNumber != 57)
                {
                    OK = false;
                }
                //check that the first record is ID 58
                if (FilteredOrders.OrderList[1].OrderNumber != 58)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no record
            Assert.IsTrue(OK);
        }
    }
}

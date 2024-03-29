﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exits
            Assert.IsNotNull(AllStocks);
        }
        [TestMethod]
        public void StocksListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsStocks> TestList = new List<clsStocks>();

            //add an item to the list
            //create the item of the data
            clsStocks TestItem = new clsStocks();
            //set its properties
            TestItem.StocksId = 1;
            TestItem.Stock_In_Date = DateTime.Now.Date;
            TestItem.Stock_Out_Date = DateTime.Now.Date;
            TestItem.StocksDeliveryStatus = true;
            TestItem.PruductPrice = 100;
            TestItem.Stock_BrandName = "Boss";
            TestItem.StockQuantity = 10;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StocksList = TestList;
            //test to see that the two value are the same 
            Assert.AreEqual(AllStocks.StocksList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Int32 SomeCount = 0;
            AllStocks.Count = SomeCount;
            Assert.AreEqual(AllStocks.Count, SomeCount);
        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStocks TestStocks = new clsStocks();
            //set the properties of the test object
            TestStocks.StocksId = 1;
            TestStocks.Stock_In_Date = DateTime.Now.Date;
            TestStocks.Stock_Out_Date = DateTime.Now.Date;
            TestStocks.StocksDeliveryStatus = true;
            TestStocks.PruductPrice = 100;
            TestStocks.Stock_BrandName = "Boss";
            TestStocks.StockQuantity = 10;
            //assign the data to the property
            AllStocks.ThisStock = TestStocks;
            //test to see that the two value are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStocks);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this cse the data need to be a list of objects
            List<clsStocks> TestList = new List<clsStocks>();
            //add an item to the list
            //create the item of test data
            clsStocks TestItem = new clsStocks();
            //set its properties
            TestItem.StocksId = 1;
            TestItem.Stock_In_Date = DateTime.Now.Date;
            TestItem.Stock_Out_Date = DateTime.Now.Date;
            TestItem.StocksDeliveryStatus = true;
            TestItem.PruductPrice = 100;
            TestItem.Stock_BrandName = "Boss";
            TestItem.StockQuantity = 10;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StocksList = TestList;
            //test to see that the two value are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.AreEqual(AllStocks.Count, 2);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item to test data
            clsStocks TestItem = new clsStocks();

            //variable to store the primary key 
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.StocksId = 1;
            TestItem.Stock_In_Date = DateTime.Now.Date;
            TestItem.Stock_Out_Date = DateTime.Now.Date;
            TestItem.StocksDeliveryStatus = true;
            TestItem.PruductPrice = 100;
            TestItem.Stock_BrandName = "Boss";
            TestItem.StockQuantity = 10;
            //set ThisOrder to the TestData
            AllStocks.ThisStock = TestItem;

            //Add the record 
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StocksId = PrimaryKey;
            //find the record using the primary key
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create.
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of the test data
            clsStocks TestItem = new clsStocks();
            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //Set its Properties.
            TestItem.StockQuantity = 10;
            TestItem.Stock_In_Date = DateTime.Now.Date;
            TestItem.Stock_Out_Date = DateTime.Now.Date;
            TestItem.Stock_BrandName = "Boss";
            TestItem.StocksDeliveryStatus = true;
            TestItem.PruductPrice = 100;
            

            //set ThisOrder to the Testdata
            AllStocks.ThisStock = TestItem;

            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.StocksId = PrimaryKey;

            //modify the test data
            TestItem.StockQuantity = 10;
            TestItem.Stock_In_Date = DateTime.Now.Date;
            TestItem.Stock_Out_Date = DateTime.Now.Date;
            TestItem.Stock_BrandName = "Gucci";
            TestItem.StocksDeliveryStatus = true;
            TestItem.PruductPrice = 120;

            //set the record based on the new test data
            AllStocks.ThisStock = TestItem;

            //update the record
            AllStocks.Update();
            //find the record using priamry key
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see thisorder match the test data
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of the testdata
            clsStocks TestItem = new clsStocks();

            //variable yto store the primary key
            Int32 PrimaryKey = 0;

            //Set its Properties
            TestItem.StocksId = 1;
            TestItem.StockQuantity = 10;
            TestItem.Stock_In_Date = DateTime.Now.Date;
            TestItem.Stock_Out_Date = DateTime.Now.Date;
            TestItem.Stock_BrandName = "Boss";
            TestItem.StocksDeliveryStatus = true;
            TestItem.PruductPrice = 100;

            //set ThisOrder to the TestData
            AllStocks.ThisStock = TestItem;
            //Add the record.
            PrimaryKey = AllStocks.Add();

            //set the primary key of the test data
            TestItem.StocksId = PrimaryKey;
            //find the record using the primary key
            AllStocks.ThisStock.Find(PrimaryKey);

            //Delete the record 
            AllStocks.Delete();
            //now find the record 
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found.
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStock_BrandNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered Data
            clsStockCollection FilteredStocks = new clsStockCollection();

            //apply a blank string (should return all Record)
            FilteredStocks.ReportByStock_BrandName("");

            //test to see that the two value are the same
            Assert.AreNotEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByPostcodeNoneFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //Apply a postcode that doesn't exits
            FilteredStocks.ReportByStock_BrandName("xxx");
            //test to see that there are no Record
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByPostcodeTestDataFound()
        {

            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //variable to store outcome
            Boolean OK = true;

            //Applying a postcode That doesn't exits
            FilteredStocks.ReportByStock_BrandName("Boss");
            //check that the correct number of record are found
            if (FilteredStocks.Count == 2)
            {
                //check that the first Record is ID 57
                if (FilteredStocks.StocksList[0].StocksId != 3)
                {
                    OK = false;
                }
                //check that the first record is ID 58
                if (FilteredStocks.StocksList[1].StocksId != 4)
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

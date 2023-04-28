using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Address = "Address001";
            TestItem.CustomerId = 1;
            TestItem.FirstName = "a";
            TestItem.LastName = "aa";
            TestItem.PhoneNumber = 0000;
            TestItem.Password = "1234";
            TestItem.DateJoined = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCustomer.mCustomerList = TestList;
            Assert.AreEqual(AllCustomer.mCustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Address = "Address001";
            TestItem.CustomerId = 1;
            TestItem.FirstName = "a";
            TestItem.LastName = "aa";
            TestItem.PhoneNumber = 0000;
            TestItem.Password = "1234";
            TestItem.DateJoined = DateTime.Now.Date;
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this cse the data need to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Address = "Address001";
            TestItem.CustomerId = 1;
            TestItem.FirstName = "a";
            TestItem.LastName = "aa";
            TestItem.PhoneNumber = 0000;
            TestItem.Password = "1234";
            TestItem.DateJoined = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.mCustomerList = TestList;
            //test to see that the two value are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        //[TestMethod]
       /* public void AddMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestCustomer.Address = "Address001";
            TestCustomer.CustomerId = 1;
            TestCustomer.FirstName = "a";
            TestCustomer.LastName = "aa";
            TestCustomer.PhoneNumber = "0000";
            TestCustomer.Password = "1234";
            TestCustomer.DateJoined = DateTime.Now.Date;
            PrimaryKey = AllCustomer.Add();
            TestCustomer.CustomerId = PrimaryKey;
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }*/


    }
}

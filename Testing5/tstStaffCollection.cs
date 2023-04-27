using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exits
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();

            //add an item to the list
            //create the item of the data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffId = 1;
            TestItem.FirstName = "Shalini";
            TestItem.LastName = "Desai";
            TestItem.StaffAvailableStatus = true;
            TestItem.ContactNum = "2387014789";
            TestItem.Address = "23 gedding road";
            TestItem.JoinDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two value are the same 
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this cse the data need to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffId = 1;
            TestItem.FirstName = "Shalini";
            TestItem.LastName = "Desai";
            TestItem.StaffAvailableStatus = true;
            TestItem.ContactNum = "2387014789";
            TestItem.Address = "23 gedding road";
            TestItem.JoinDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two value are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.AreEqual(AllStaff.Count, 2);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item to test data
            clsStaff TestItem = new clsStaff();

            //variable to store the primary key 
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.StaffId = 1;
            TestItem.FirstName = "Shalini";
            TestItem.LastName = "Desai";
            TestItem.StaffAvailableStatus = true;
            TestItem.ContactNum = "2387014789";
            TestItem.Address = "23 gedding road";
            TestItem.JoinDate = DateTime.Now.Date;

            //set ThisOrder to the TestData
            AllStaff.ThisStaff = TestItem;

            //Add the record 
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record using the primary key
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create.
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //Set its Properties.
            TestItem.FirstName = "Shalini";
            TestItem.LastName = "Desai";
            TestItem.StaffAvailableStatus = true;
            TestItem.ContactNum = "2387014789";
            TestItem.Address = "23 gedding road";
            TestItem.JoinDate = DateTime.Now.Date;


            //set ThisOrder to the Testdata
            AllStaff.ThisStaff = TestItem;

            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;

            //modify the test data
            TestItem.FirstName = "Shalini";
            TestItem.LastName = "Desai";
            TestItem.StaffAvailableStatus = true;
            TestItem.ContactNum = "0723423523";
            TestItem.Address = "24 gedding road";
            TestItem.JoinDate = DateTime.Now.Date;

            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;

            //update the record
            AllStaff.Update();
            //find the record using priamry key
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see thisorder match the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the testdata
            clsStaff TestItem = new clsStaff();

            //variable yto store the primary key
            Int32 PrimaryKey = 0;

            //Set its Properties
            TestItem.StaffId = 1;
            TestItem.FirstName = "Shalini";
            TestItem.LastName = "Desai";
            TestItem.StaffAvailableStatus = true;
            TestItem.ContactNum = "2387014789";
            TestItem.Address = "23 gedding road";
            TestItem.JoinDate = DateTime.Now.Date;

            //set ThisOrder to the TestData
            AllStaff.ThisStaff = TestItem;
            //Add the record.
            PrimaryKey = AllStaff.Add();

            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record using the primary key
            AllStaff.ThisStaff.Find(PrimaryKey);

            //Delete the record 
            AllStaff.Delete();
            //now find the record 
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found.
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByLastName("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByLastNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByLastName("xxxxxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByLastNameTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaff.ReportByLastName("Desai");
            if (FilteredStaff.Count == 2)
            {
                if (FilteredStaff.StaffList[0].StaffId != 3)
                {
                    OK = false;
                }
                if (FilteredStaff.StaffList[1].StaffId != 4)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
    }

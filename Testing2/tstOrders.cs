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
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //test to see that it exits
            Assert.IsNotNull(order);
        }
        
        [TestMethod]
        public void OrderDeliveryStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //create  some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            order.OrderDeliveryStatus = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(order.OrderDeliveryStatus, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //create  some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            order.OrderDate = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(order.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderAddressPropertyOK() 
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //create  some test data to assign to the property
            string TestData = "21, abc";
            //assign the data to the property
            order.OrderAddress = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(order.OrderAddress, TestData);
        }

        [TestMethod]
        public void OrderPostcodePropertyOK() 
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //create  some test data to assign to the property
            string TestData = "LE5 3KT";
            //assign the data to the property
            order.OrderPostcode = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(order.OrderPostcode, TestData);
        }

        [TestMethod]
        public void OrderCountyCodePropertyOK() 
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //create  some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            order.OrderCountyCode = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(order.OrderCountyCode, TestData);
        }

        [TestMethod]
        public void OrderTotalAmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //create  some test data to assign to the property
            Int32 TestData = 100;
            //assign the data to the property
            order.OrderTotalAmount = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(order.OrderTotalAmount, TestData);
        }

        [TestMethod]
        public void OrderNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //create  some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            order.OrderNumber = TestData;
            //test to see that the two value are the same
            Assert.AreEqual(order.OrderNumber, TestData);
        }
        
        //find methods

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the method
            Found = order.Find(OrderNumber);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNumberfound()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the property 
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderNumber != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the property 
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderDate != Convert.ToDateTime("12/02/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderAddressFound()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the property 
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderAddress != "01,Discovery  road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderPostcodeFound()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the property 
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderPostcode != "LE3 6AL")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderCountyCodeFound()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the property 
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderCountyCode != 886)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalAmountFound()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the property 
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderTotalAmount != 100)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDeliveryStatusFound()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNumber = 1;
            //invoke the property 
            Found = order.Find(OrderNumber);
            // check the order number
            if (order.OrderDeliveryStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //Validation testing methods 

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 10 year
            TestDate = TestDate.AddYears(-10);
            //convert the date vaiable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne() 
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date vaiable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin() 
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date vaiable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date vaiable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax() 
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 10 years
            TestDate = TestDate.AddYears(10);
            //convert the date vaiable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidDate()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //set the OrderDate to a non date value
            string OrderDate = "this is not a Date!";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should fail
            string OrderPostcode = "";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMin() 
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this sholud pass
            string OrderPostcode = "le";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMinplusOne() 
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should pass
            string OrderPostcode = "le41";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should pass
            string OrderPostcode = "leL45ALLE";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMax()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should pass
            string OrderPostcode = "leL45ALLEL";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMaxplusOne() 
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should fail
            string OrderPostcode = "LE45AlLAKLD";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPostcodeMid()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should pass
            string OrderPostcode = "Le45al";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should fail
            string OrderAddress = "";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMin()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should pass
            string OrderAddress = "b";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should pass
            string OrderAddress = "aa";
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should pass
            string OrderAddress = "";
            OrderAddress = OrderAddress.PadRight(47, 'a');
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMax()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should pass
            string OrderAddress = "";
            OrderAddress = OrderAddress.PadRight(48, 'a');
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should fail
            string OrderAddress = "";
            OrderAddress = OrderAddress.PadRight(49, 'a');
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderAddressMid()
        {
            //create an instance of the class we want to create
            clsOrders order = new clsOrders();
            //String variable to store any error
            String Error = "";
            //this should pass
            string OrderAddress = ""; 
            OrderAddress = OrderAddress.PadRight(24, 'a');
            //invoke the method
            Error = order.Valid(OrderAddress, OrderPostcode, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}

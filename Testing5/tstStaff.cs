using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staff = new clsStaff();
            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void StaffAvailableStatusPropertyOK()
        {
            clsStaff staff = new clsStaff();
            Boolean TestData = true;
            staff.StaffAvailableStatus = TestData;
            Assert.AreEqual(staff.StaffAvailableStatus, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsStaff staff = new clsStaff();
            String TestData = "Shalini";
            staff.FirstName = TestData;
            Assert.AreEqual(staff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "Desai";
            staff.LastName = TestData;
            Assert.AreEqual(staff.LastName, TestData);
        }

        [TestMethod]
        public void ContactNumPropertyOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "07384325723";
            staff.ContactNum = TestData;
            Assert.AreEqual(staff.ContactNum, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsStaff staff = new clsStaff();
            String TestData = "leicester";
            staff.Address = TestData;
            Assert.AreEqual(staff.Address, TestData);
        }

        [TestMethod]
        public void JoinDatePropertyOK()
        {
            clsStaff staff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            staff.JoinDate = TestData;
            Assert.AreEqual(staff.joinDate, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            clsStaff staff = new clsStaff();
            Int32 TestData = 1;
            staff.StaffId = TestData;
            Assert.AreEqual(staff.StaffId, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 1;
            Found = staff.Find(StaffId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 1;
            Found = staff.Find(StaffId);
            if (staff.StaffId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 100;
            Found = staff.Find(StaffId);
            if (staff.FirstName != "Shalini")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStocks_BrandNameFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 100;
            Found = staff.Find(StaffId);
            if (staff.LastName != "Desai")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContactFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 100;
            Found = staff.Find(StaffId);
            if (staff.ContactNum != "07384325723")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 100;
            Found = staff.Find(StaffId);
            if (staff.Address != "Leicester")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestJoinDateFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 100;
            Found = staff.Find(StaffId);
            if (staff.JoinDate != Convert.ToDateTime("20.03.2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffAvailabeFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 100;
            Found = staff.Find(StaffId);
            if (staff.StaffAvailableStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff stocks = new clsStaff();
            //String variable to store any error
            String Error = "";
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void JoinDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 10 year
            TestDate = TestDate.AddYears(-10);
            //convert the date vaiable to a string variable
            string JoinDate = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JoinDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date vaiable to a string variable
            string JoinDate = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinDateMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date vaiable to a string variable
            string JoinDate = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JoinDatePlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date vaiable to a string variable
            string JoinDate = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 10 years
            TestDate = TestDate.AddYears(10);
            //convert the date vaiable to a string variable
            string JoinDate = TestDate.ToString();
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinDateInvalidDate()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //set the OrderDate to a non date value
            string JoinDate = "this is not a Date!";
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //this should fail
            string FirstName = "";
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //this should pass
            string FirstName = "b";
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //this should pass
            string FirstName = "aa";
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(47, 'a');
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(48, 'a');
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNamePlusOne()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //this should fail
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff staff = new clsStaff();
            //String variable to store any error
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(24, 'a');
            //invoke the method
            Error = staff.Valid(FirstName, JoinDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}

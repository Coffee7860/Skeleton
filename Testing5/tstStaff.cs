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
        public void DateJoinedPropertyOK()
        {
            clsStaff staff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            staff.DateJoined = TestData;
            Assert.AreEqual(staff.DateJoined, TestData);
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
        public void TestDateJoinedFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 100;
            Found = staff.Find(StaffId);
            if (staff.DateJoined != Convert.ToDateTime("20.03.2023"))
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
    }
}

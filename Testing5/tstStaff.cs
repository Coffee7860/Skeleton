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
            String TestData = "Shabnam";
            staff.FirstName = TestData;
            Assert.AreEqual(staff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "Majid Adam Lala";
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
    }
}

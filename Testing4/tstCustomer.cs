using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
         string goodFirstName = "Tomisin";
        string goodLastName = "Oloniyo";
        string goodPhoneNumber = "0901234";
        string goodEmailID = "to@olo.com";
        string goodAddress = "down south";
        string goodPassword = "downsouth";
        string goodDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerAvailableStatusPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.CustomerAvailableStatus = TestData;
            Assert.AreEqual(ACustomer.CustomerAvailableStatus, TestData);
           
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = goodFirstName;
            ACustomer.FirstName = TestData;
            Assert.AreEqual(ACustomer.FirstName, TestData);
           
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData =goodLastName;
            ACustomer.LastName = TestData;
            Assert.AreEqual(ACustomer.LastName, TestData);

        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 123;
            ACustomer.PhoneNumber = TestData;
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);

        }

        [TestMethod]
        public void EmailIdOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = goodEmailID;
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);

        }

        [TestMethod]
        public void PasswordOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = goodPassword;
            ACustomer.Password = TestData;
            Assert.AreEqual(ACustomer.Password, TestData);

        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = goodAddress;
            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);

        }

        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            clsCustomer staff = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            staff.DateJoined = TestData;
            Assert.AreEqual(staff.DateJoined, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerId = TestData;
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void EmailIdPropertyOK()
        {
            clsCustomer staff = new clsCustomer();
            Int32 TestData = 1;
            staff.EmailId = TestData;
            Assert.AreEqual(staff.EmailId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer staff = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 1;
            Found = staff.Find(5);
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerId != 1)
            {
                OK = false;
            }
            else
            {
                Assert.IsTrue(OK);
            }
            
        }

        [TestMethod]
        public void TestEmailIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmailId = 1;
            Found = ACustomer.Find(EmailId);
            if (ACustomer.EmailId != 1)
            {
                OK = false;
            }
            else
            {
                Assert.IsTrue(OK);
            }

        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.FirstName != goodFirstName)
            {
                OK = false;
            }
            else
            {
                Assert.IsTrue(OK);
            }
            
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.LastName != goodLastName)
            {
                OK = false;
            }
            else
            {
                Assert.IsTrue(OK);
            }

        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.PhoneNumber != 123)
            {
                OK = false;
            }
            else
            {
                OK = true; Assert.IsTrue(OK);
            }

         
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Address != goodAddress)
            {
                OK = false;
            }
            else
            {
                OK = true; Assert.IsTrue(OK);
            }


        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.DateJoined != DateTime.Now.Date)
            {
                OK = false;
            }
            else
            {
                OK = true; Assert.IsTrue(OK);
            }


        }

        [TestMethod]
        public void TestStaffAvailabeFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerAvailableStatus != true)
            {
                OK = false;
            }
            else
            {
               Assert.IsTrue(OK);
            }
            
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(goodFirstName,goodLastName,goodEmailID,goodAddress,goodPassword,goodPhoneNumber,goodDate);
            Assert.AreEqual(Error, "");
        }
    }
}

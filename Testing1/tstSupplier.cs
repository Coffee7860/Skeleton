using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstSupplier
    {
        //Good Test Data
        string CompanyName = "Avou";
        string CompanyAddress = "LE12";
        string ContactNumber = "099943";
        string OrderDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier supplier = new clsSupplier();
            Assert.IsNotNull(supplier);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsSupplier supplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            supplier.OrderDate = TestData;
            Assert.AreEqual(supplier.OrderDate, TestData);
       
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            clsSupplier supplier = new clsSupplier();
            Int32 TestData = 2;
            supplier.SupplierId = TestData;
            Assert.AreEqual(supplier.SupplierId, TestData);
        }
        [TestMethod]
        public void CompanyNamePropertyOK()
        {
            clsSupplier supplier = new clsSupplier();
            String TestData = "versace";
            supplier.CompanyName = TestData;
            Assert.AreEqual(supplier.CompanyName, TestData);
        }
        [TestMethod]
        public void CompanyAddressPropertyOK()
        {
            clsSupplier supplier = new clsSupplier();
            String TestData = "LO2 3BE";
            supplier.CompanyAddress = TestData;
            Assert.AreEqual(supplier.CompanyAddress, TestData);
        }
        [TestMethod]
        public void ContactNumberPropertyOK()
        {
            clsSupplier supplier = new clsSupplier();
            String TestData = "05554152";
            supplier.ContactNumber = TestData;
            Assert.AreEqual(supplier.ContactNumber, TestData);
        }
        [TestMethod]
        public void UnitCostPropertyOK()
        {
            clsSupplier supplier = new clsSupplier();
            Int32 TestData = 155;
            supplier.UnitCost = TestData;
            Assert.AreEqual(supplier.UnitCost, TestData);
        }
        [TestMethod]
        public void LocationPropertyOK()
        {
            clsSupplier supplier = new clsSupplier();
            Boolean TestData = true;
            supplier.Location = TestData;
            Assert.AreEqual(supplier.Location, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier supplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierId = 2;
            Found = supplier.Find(SupplierId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierIdNoFound()
        {
            clsSupplier supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = supplier.Find(SupplierId);
            if(supplier.SupplierId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            clsSupplier supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = supplier.Find(SupplierId);
            if (supplier.OrderDate != Convert.ToDateTime("1.02.2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCompanyNameFound()
        {
            clsSupplier supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = supplier.Find(SupplierId);
            if (supplier.CompanyName != "Apollo_comp")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCompanyAddressFound()
        {
            clsSupplier supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = supplier.Find(SupplierId);
            if (supplier.CompanyAddress != "LO2 3BE")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContactNumberFound()
        {
            clsSupplier supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = supplier.Find(SupplierId);
            if (supplier.ContactNumber != "05503123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUnitCostFound()
        {
            clsSupplier supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = supplier.Find(SupplierId);
            if (supplier.UnitCost != 88)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLocationFound()
        {
            clsSupplier supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = supplier.Find(SupplierId);
            if (supplier.Location != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CompanyNameMinLessOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyName = "";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CompanyNameMin()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyName = "a";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyNameMinPlusOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyName = "aa";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyNameMaxLessOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyNameMax()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyNameMid()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyNameMaxPlusOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CompanyNameExtremeMax()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyName = "";
            CompanyName = CompanyName.PadRight(500,'a');
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string OrderDate = TestDate.ToString();
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlussOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string OrderDate = TestDate.ToString();
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            string OrderDate = "This is not a date";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CompanyAddressMinLessOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyAddress = "";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CompanyAddressMin()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyAddress = "a";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyAddressMinPlusOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyAddress = "aa";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyAddressMaxLessOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyAddressMax()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CompanyAddressMaxPlusOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyAddress = "";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CompanyAddressMid()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string CompanyAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMinLessOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string ContactNumber = "";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMin()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string ContactNumber = "a";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string ContactNumber = "aa";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMaxLessOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(49,'a');
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMax()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(50, 'a');
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMaxPlusOne()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string ContactNumber = "";
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ContactNumberMid()
        {
            clsSupplier supplier = new clsSupplier();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(25, 'a');
            Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
            Assert.AreEqual(Error, "");
        }
    }
}

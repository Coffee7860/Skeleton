using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstSupplier
    {
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
        public void SupplierIDPropertyOK()
        {
            clsSupplier supplier = new clsSupplier();
            Int32 TestData = 1;
            supplier.SupplierID = TestData;
            Assert.AreEqual(supplier.SupplierID, TestData);
        }
        [TestMethod]
        public void CompanyNameOK()
        {
            clsSupplier supplier = new clsSupplier();
            String TestData = "versace";
            supplier.CompanyName = TestData;
            Assert.AreEqual(supplier.CompanyName, TestData);
        }
        [TestMethod]
        public void CompanyAddressOK()
        {
            clsSupplier supplier = new clsSupplier();
            String TestData = "LO2 3BE";
            supplier.CompanyAddress = TestData;
            Assert.AreEqual(supplier.CompanyAddress, TestData);
        }
        [TestMethod]
        public void ContactNumberOK()
        {
            clsSupplier supplier = new clsSupplier();
            String TestData = "05554152";
            supplier.ContactNumber = TestData;
            Assert.AreEqual(supplier.ContactNumber, TestData);
        }
        [TestMethod]
        public void UnitCostOK()
        {
            clsSupplier supplier = new clsSupplier();
            Int32 TestData = 155;
            supplier.UnitCost = TestData;
            Assert.AreEqual(supplier.UnitCost, TestData);
        }
        [TestMethod]
        public void LocationOK()
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
            if(supplier.SupplierID !=2)
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
            if (supplier.OrderDate != Convert.ToDateTime("01 / 02 / 2023"))
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
            if (supplier.CompanyName != "Test Town")
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
            if (supplier.CompanyAddress != "LE3 5JK")
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
            if (supplier.ContactNumber != "0000")
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
            if (supplier.UnitCost != 150)
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







    }
}

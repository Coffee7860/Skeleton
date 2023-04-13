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
    }
}

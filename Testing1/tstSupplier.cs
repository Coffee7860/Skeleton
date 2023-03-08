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
        public void Order_datePropertyOK()
        {
            clsSupplier supplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            supplier.Order_date = TestData;
            Assert.AreEqual(supplier.Order_date, TestData);
       
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            clsSupplier supplier = new clsSupplier();
            Int32 TestData = 1;
            supplier.SupplierId = TestData;
            Assert.AreEqual(supplier.SupplierId, TestData);
        }
        [TestMethod]
        public void Company_nameOK()
        {
            clsSupplier supplier = new clsSupplier();
            String TestData = "versace";
            supplier.Company_name = TestData;
            Assert.AreEqual(supplier.Company_name, TestData);
        }
        [TestMethod]
        public void Company_addressOK()
        {
            clsSupplier supplier = new clsSupplier();
            String TestData = "LO2 3BE";
            supplier.Company_address = TestData;
            Assert.AreEqual(supplier.Company_address, TestData);
        }
        [TestMethod]
        public void Contact_numberOK()
        {
            clsSupplier supplier = new clsSupplier();
            String TestData = "05554152";
            supplier.Contact_number = TestData;
            Assert.AreEqual(supplier.Contact_number, TestData);
        }
        [TestMethod]
        public void Unit_costOK()
        {
            clsSupplier supplier = new clsSupplier();
            Int32 TestData = 155;
            supplier.Unit_cost = TestData;
            Assert.AreEqual(supplier.Unit_cost, TestData);
        }
        [TestMethod]
        public void Perfume_IDOK()
        {
            clsSupplier supplier = new clsSupplier();
            Int32 TestData = 1;
            supplier.Perfume_ID = TestData;
            Assert.AreEqual(supplier.Perfume_ID, TestData);
        }





    }
}

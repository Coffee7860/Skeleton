using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);
        }
        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.Location = true;
            TestItem.SupplierId = 1;
            TestItem.CompanyName = "a";
            TestItem.CompanyAddress = "aa";
            TestItem.ContactNumber = "0000";
            TestItem.UnitCost = 11;
            TestItem.OrderDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }
        /*[TestMethod]
        public void CountPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Int32 SomeCount = 2;
            AllSuppliers.Count = SomeCount;
            Assert.AreEqual(AllSuppliers.Count, SomeCount);
        }*/
        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.Location = true;
            TestSupplier.SupplierId = 1;
            TestSupplier.CompanyName = "aaa";
            TestSupplier.CompanyAddress = "aaaa";
            TestSupplier.ContactNumber = "000000";
            TestSupplier.UnitCost = 77;
            TestSupplier.OrderDate = DateTime.Now.Date;
            AllSuppliers.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.Location = true;
            TestItem.SupplierId = 1;
            TestItem.CompanyName = "aaa";
            TestItem.CompanyAddress = "aaaa";
            TestItem.ContactNumber = "000000";
            TestItem.UnitCost = 77;
            TestItem.OrderDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }
        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.AreEqual(AllSuppliers.Count, 2);
        }*/
    }
}

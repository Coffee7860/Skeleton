using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mclsSupplierList = new List<clsSupplier>();
        public List<clsSupplier> SupplierList
        {
            get 
            {
                return mclsSupplierList;
            }
            set 
            {
                mclsSupplierList = value;
            }
        }
        public int Count 
        { 
            get 
            {
                return mclsSupplierList.Count;
            }
            set 
            { 
                //
            } 
        }
        public clsSupplier ThisSupplier { get; set; }
        /*public clsSupplierCollection()
        {
            clsSupplier TestItem = new clsSupplier();
            TestItem.Location = true;
            TestItem.SupplierId = 1;
            TestItem.CompanyName = "a";
            TestItem.CompanyAddress = "aa";
            TestItem.ContactNumber = "0000";
            TestItem.UnitCost = 11;
            TestItem.OrderDate = DateTime.Now.Date;
            mclsSupplierList.Add(TestItem);
            TestItem = new clsSupplier();
            TestItem.Location = true;
            TestItem.SupplierId = 2;
            TestItem.CompanyName = "b";
            TestItem.CompanyAddress = "bb";
            TestItem.ContactNumber = "1200";
            TestItem.UnitCost = 91;
            TestItem.OrderDate = DateTime.Now.Date;
            mclsSupplierList.Add(TestItem);
        }*/
        public clsSupplierCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_TblSupplier_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsSupplier supplier = new clsSupplier();
                supplier.Location = Convert.ToBoolean(DB.DataTable.Rows[Index]["Location"]);
                supplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                supplier.CompanyAddress = Convert.ToString(DB.DataTable.Rows[Index]["CompanyAddress"]);
                supplier.CompanyName = Convert.ToString(DB.DataTable.Rows[Index]["CompanyName"]);
                supplier.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["ContactNumber"]);
                supplier.UnitCost = Convert.ToInt32(DB.DataTable.Rows[Index]["UnitCost"]);
                supplier.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                mclsSupplierList.Add(supplier);
                Index++;
            }
        }
    }
}
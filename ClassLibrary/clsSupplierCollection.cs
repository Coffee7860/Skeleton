using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();
        List<clsSupplier> mclsSupplierList = new List<clsSupplier>();
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return mclsSupplierList;
                return mSupplierList;
            }
            set
            {
                //mclsSupplierList = value;
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                //return mclsSupplierList.Count;
                return mSupplierList.Count;
            }
            set
            {
                //
            }
        }
        public clsSupplier ThisSupplier
        { get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@CompanyName", mThisSupplier.CompanyName);
            DB.AddParameter("@CompanyAddress", mThisSupplier.CompanyAddress);
            DB.AddParameter("@ContactNumber", mThisSupplier.ContactNumber);
            DB.AddParameter("@OrderDate", mThisSupplier.OrderDate);
            DB.AddParameter("@UnitCost", mThisSupplier.UnitCost);
            DB.AddParameter("@Location", mThisSupplier.Location);
            DB.Execute("sproc_TblSupplier_Update");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.Execute("sproc_TblSupplier_Delete");
        }


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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_TblSupplier_SelectAll");
            PopulateArray(DB);
            /*Int32 Index = 0;
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
                //mclsSupplierList.Add(supplier);
                mSupplierList.Add(supplier);
                Index++;
            }*/
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CompanyName", mThisSupplier.CompanyName);
            DB.AddParameter("@CompanyAddress", mThisSupplier.CompanyAddress);
            DB.AddParameter("@ContactNumber", mThisSupplier.ContactNumber);
            DB.AddParameter("@OrderDate", mThisSupplier.OrderDate);
            DB.AddParameter("@UnitCost", mThisSupplier.UnitCost);
            DB.AddParameter("@Location", mThisSupplier.Location);
            return DB.Execute("sproc_TblSupplier_Insert");
        }

       

        public void ReportByCompanyAddress(string CompanyAddress)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CompanyAddress", CompanyAddress);
            DB.Execute("sproc_TblSupplier_FilterByCompanyAddress");
            PopulateArray(DB);
        }
       
        void PopulateArray(clsDataConnection DB) 
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            //mclsSupplierList = new List<clsSupplier>();
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
                mSupplierList.Add(supplier);
                //mclsSupplierList.Add(supplier);
                Index++;
            }
        }
        
    }
}
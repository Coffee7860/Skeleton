using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public DateTime OrderDate 
        {
            get 
            {
                return mOrderDate;
            }
            set 
            {
                mOrderDate = value;
            } 
        }
        public Int32 SupplierID 
        {
            get
            {
                return mSupplierId;
            }
            set
            {
                mSupplierId = value;
            }
        }
        public string CompanyName 
        {
            get
            {
                return mCompanyName;
            }
          set
            {
                mCompanyName = value;
            }
        }
        public string CompanyAddress
        { 
            get 
            {
                return mCompanyAddress;
            }
            set
            {
                mCompanyAddress = value;
            } 
        }
        public string ContactNumber 
        {
            get 
            {
                return mContactNumber;
            }
            set
            {
                mContactNumber = value;
            } 
        }
        public int UnitCost 
        {
            get
            {
                return mUnitCost;
            }
            set
            {
                mUnitCost = value;
            }
        }
        public bool Location {
            get
            {
                return mLocation;
            }
            set
            {
                mLocation = value;
            }
        }

        public bool Find(int supplierId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId",SupplierID);
            DB.Execute("sproc_TblSupplier_FilterBySupplierId");
            if (DB.Count == 1)
            {
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mCompanyName = Convert.ToString(DB.DataTable.Rows[0]["CompanyName"]);
                mCompanyAddress = Convert.ToString(DB.DataTable.Rows[0]["CompanyAddress"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mUnitCost = Convert.ToInt32(DB.DataTable.Rows[0]["UnitCost"]);
                mLocation = Convert.ToBoolean(DB.DataTable.Rows[0]["Location"]);
                return true;
            }
            else
            {
                return false;
            }
        }
        private Int32 mSupplierId;
        private DateTime mOrderDate;
        private string mCompanyName;
        private string mCompanyAddress;
        private string mContactNumber;
        private Int32 mUnitCost;
        private bool mLocation;
    }
}
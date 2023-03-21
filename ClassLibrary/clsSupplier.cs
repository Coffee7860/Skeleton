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
            mSupplierId = 2;
            mOrderDate = Convert.ToDateTime("01 / 02 / 2023");
            mCompanyName = "Test Town";
            mCompanyAddress = "LE3 5JK";
            mContactNumber = "0000";
            mUnitCost = 150;
            mLocation = true;
            return true;
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
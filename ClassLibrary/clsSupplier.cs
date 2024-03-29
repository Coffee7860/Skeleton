﻿using System;



namespace ClassLibrary

{

    public class clsSupplier

    {

        private DateTime mOrderDate;

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



        private Int32 mSupplierId;

        public int SupplierId

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

        public string Valid(string companyName, string companyAddress, string contactNumber, string orderDate)
        {
            String Error = "";
            DateTime DateTemp;
            
            try
            {
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The OrderDate can not be in the past ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The OrderDate can not be in the future ";
                }
            }
            catch
            {
                Error = Error + "The Date was not a valid date";
            }
            if (companyName.Length == 0)
            {
                Error = Error + "Company name can not be blank ";
            }
            if (companyName.Length > 50)
            {
                Error = Error + "Company name can not be longer than 50 characters ";
            }

            if (companyAddress.Length == 0)
            {
                Error = Error + "The Address may not be blank ";
            }
            if (companyAddress.Length > 50)
            {
                Error = Error + "The Address may not be more than 50 characters ";
            }
            if (contactNumber.Length == 0)
            {
                Error = Error + "The Contact Number may not be blank ";
            }
            if (contactNumber.Length > 50)
            {
                Error = Error + "The Contact Number may not be more than 50 characters ";
            }
            return Error;
        }

        private string mCompanyName;

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

        private string mCompanyAddress;

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



        private string mContactNumber;

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

        private Int32 mUnitCost;

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

        private Boolean mLocation;

        public bool Location
        {

            get

            {

                return mLocation;

            }

            set

            {

                mLocation = value;

            }

        }



        public bool Find(int SupplierId)

        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierId", SupplierId);

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

    }

}
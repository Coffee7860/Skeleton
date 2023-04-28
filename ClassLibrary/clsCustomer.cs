using System;
using System.Collections.Generic;
using System.Globalization;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool CustomerAvailableStatus { get; set; }

        private string mFirstName;
        public string FirstName { 
            get 
            {
                return mFirstName;
                    }
            set
            {
                mFirstName = value;
            }
                }
       
        private string mLastName;
        public string LastName {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        private Int32 mPhoneNumber;
        public Int32 PhoneNumber {
            get
            {
                return mPhoneNumber;
            }

            set
            {
                mPhoneNumber = value;
            }
                
                }

        private string mEmail;
        public string Email {
            get 
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            } 
                }

        private string mPassword;
        public string Password {
            get 
            {
                return mPassword;
            }

            set
            {
                mPassword = value;
            }
            }

        private string mAddress;
        public string Address {
            get 
            {
                return mAddress;
            } 
            set
            {
                mAddress = value;
            }
                }

        private DateTime mDateJoined;
        public DateTime DateJoined
        {
            get

            {

                return mDateJoined;

            }

            set

            {

                mDateJoined = value;

            }
        }

        private Int32 mCustomerId;
        public int CustomerId {
            get

            {

                return mCustomerId;

            }

            set

            {

                mCustomerId = value;

            }
        }

        private Int32 mEmailId;
        public int EmailId
        {
            get

            {

                return mEmailId;

            }

            set

            {

                mEmailId = value;

            }
        }

        public bool Find(int customerId)
        {
            mEmail = "Oloniyo@tome.com";
            mFirstName = "Tomisin";
            mLastName = "Oloniyo";
            mPhoneNumber = 1234;
            mPassword = "Password";
            mDateJoined = DateTime.Now;
            mAddress = "address";

            return true;

            //clsDataConnection DB = new clsDataConnection();
            //DB.AddParameter("@Customer_Id", customerId);
            //DB.Execute("sproc_tblCustomer_Find");
            //if (DB.Count == 1)
            //{
            //    mFirstName = Convert.ToString(DB.DataTable.Rows[0]["First Name"]);
            //    mLastName = Convert.ToString(DB.DataTable.Rows[0]["Last Name"]);
            //    mEmail = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
            //    mPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["Phone Number"]);
            //    mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public string Valid(string goodFirstName, string goodLastName, string goodEmailID, string goodAddress, string goodPassword, string goodPhoneNumber, string goodOrderDate)
        {
            String Error = "";
            DateTime DateTemp;

            try
            {
                DateTemp = Convert.ToDateTime(goodOrderDate);
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
            if (goodFirstName.Length == 0)
            {
                Error = Error + "First name can not be blank ";
            }
            if (goodFirstName.Length > 50)
            {
                Error = Error + "first name can not be longer than 50 characters ";
            }
            if (goodLastName.Length == 0)
            {
                Error = Error + "last Name may not be blank ";
            }
            if (goodLastName.Length > 50)
            {
                Error = Error + "Last Name may not be more than 50 characters ";
            }
            if (goodAddress.Length == 0)
            {
                Error = Error + "The Address may not be blank ";
            }
            if (goodAddress.Length > 50)
            {
                Error = Error + "The Address may not be more than 50 characters ";
            }
            if (goodEmailID.Length == 0)
            {
                Error = Error + "The Email may not be blank ";
            }
            if (goodEmailID.Length > 50)
            {
                Error = Error + "The Email may not be more than 50 characters ";
            }
            if (goodPhoneNumber.Length == 0)
            {
                Error = Error + "The Phone Number may not be blank ";
            }
            if (goodPhoneNumber.Length > 50)
            {
                Error = Error + "The Phone Number may not be more than 50 characters ";
            }
            if (goodPassword.Length == 0)
            {
                Error = Error + "The Password may not be blank ";
            }
            if (goodPassword.Length > 50)
            {
                Error = Error + "The Password may not be more than 50 characters ";
            }
            return Error;
        }

      
    }
}
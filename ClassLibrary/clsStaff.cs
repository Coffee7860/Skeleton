using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Boolean mStaffAvailable;
        public bool StaffAvailableStatus
        {
            get
            {
                //return the private data
                return mStaffAvailable;
            }
            set
            {
                //set the priavte data
                mStaffAvailable = value;
            }
        }
        private string mFirstName;
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the priavte data
                mFirstName = value;
            }
        }
        private string mLastName;
        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the priavte data
                mLastName = value;
            }
        }
        private string mContactNum;
        public string ContactNum
        {
            get
            {
                //return the private data
                return mContactNum;
            }
            set
            {
                //set the priavte data
                mContactNum = value;
            }
        }

        private String mAddress;
        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the priavte data
                mAddress = value;
            }
        }
        private DateTime mJoinDate;
        public DateTime JoinDate
        {
            get
            {
                //return the private data
                return mJoinDate;
            }
            set
            {
                //set the priavte data
                mJoinDate = value;
            }
        }
        private int mStaffId;
        public int StaffId
        {
            get
            {
                //return the private data
                return mStaffId;
            }
            set
            {
                //set the priavte data
                mStaffId = value;
            }
        }

        public bool Find(int staffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order number to search for
            DB.AddParameter("@StaffId", staffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");

            //if one record is found (there should be only one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mJoinDate = Convert.ToDateTime(DB.DataTable.Rows[0]["JoinDate"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastNAme"]);
                mContactNum = Convert.ToString(DB.DataTable.Rows[0]["ContactNum"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mStaffAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffAvailable"]);

                //return that everything working ok
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string firstName, string joinDate)
        {
            //create a string variable to store the error
            string Error = "";
            //create a temporary variable to store date value
            DateTime DateTemp;

            try
            {
                //copy the order date value to then data temp variable
                DateTemp = Convert.ToDateTime(joinDate);
                //check to see if the date is less than present date
                if (DateTemp < DateTime.Now.Date)
                {
                    //Record The error
                    Error = Error + "the Date Cannot be in the past: ";
                }

                //check to see if the date is greater than present date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be in future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The Date was not a valid date";
            }

            
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The firstName May not be blank: ";
            }
            if (firstName.Length > 20)
            {
                //record the error
                Error = Error + "The Name Must be Less than 20 Character: ";
            }
            //return the error message 
            return Error;
        }
    }
    }
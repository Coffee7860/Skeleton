using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //Private Data Member from the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private member
                return mStaffList;
            }
            set
            {
                //set the private member
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private member
                return mStaffList.Count;
            }
            set
            {

            }
        }

        clsStaff mThisStaff = new clsStaff();
        public clsStaff ThisStaff
        {
            get
            {
                //Return the private member 
                return mThisStaff;
            }
            set
            {
                //set the private member
                mThisStaff = value;
            }
        }


        public clsStaffCollection()
        {

            //Variable for the index
            Int32 Index = 0;
            //Variable to store The record Count
            Int32 RecordCount = 0;
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();

            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the arraylist with the data table
            PopulateArray(DB);

            //Get the Count Of records
            RecordCount = DB.Count;

            //While there are record to process
            while (Index < RecordCount)
            {
                ////create a blank order
                clsStaff staff = new clsStaff();

                //read in the fields from the current record
                staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                staff.JoinDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["JoinDate"]);
                staff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                staff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                staff.StaffAvailableStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffAvailableStatus"]);
                staff.ContactNum = Convert.ToString(DB.DataTable.Rows[Index]["ContactNum"]);
                staff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);

                //add the record to the private data member
                mStaffList.Add(staff);
                //point at the next Record
                Index++;
            }
        }

        public int Add()
        {
            //Adds a new record to the database based on the value of the ThisStocks
            //Connect To databse
            clsDataConnection DB = new clsDataConnection();

            //set the parameter for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@ContactNum", mThisStaff.ContactNum);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@StaffAvailableStatus", mThisStaff.StaffAvailableStatus);
            DB.AddParameter("@JoinDate", mThisStaff.JoinDate);

            //execute the query returning the primary key 
            return DB.Execute("sproc_tblStaff_Insert");
        }
        public void Update()
        {
            //update an existing record based on the value of ThisStock
            //Connect to database
            clsDataConnection DB = new clsDataConnection();

            //set the parameter for the stored procedure.
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@ContactNum", mThisStaff.ContactNum);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@StaffAvailableStatus", mThisStaff.StaffAvailableStatus);
            DB.AddParameter("@JoinDate", mThisStaff.JoinDate);
            DB.AddParameter("@StaffId", mThisStaff.StaffId);

            //execute the stored procedure.
            DB.Execute("sproc_tblStaff_Update");
        }
        public void Delete()
        {
            //delete the record pointed by thisStock
            //Connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }
        private void PopulateArray(clsDataConnection DB)
        {
            //Populate the arrayylist based on the data table in the parameter DB
            //Variable for the index 
            Int32 Index = 0;

            //variable to Store the record count 
            Int32 RecordCount;

            //Get the count of the record
            RecordCount = DB.Count;
            //clear the private Arraylist
            mStaffList = new List<clsStaff>();

            //while there are record to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsStaff staff = new clsStaff();

                //read the field from the current record 
                staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                staff.JoinDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["JoinDate"]);
                staff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                staff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                staff.StaffAvailableStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffAvailableStatus"]);
                staff.ContactNum = Convert.ToString(DB.DataTable.Rows[Index]["ContactNum"]);
                staff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);

                //Add the record to the private data member
                mStaffList.Add(staff);
                //Point at the next record
                Index++;
            }
        }
        public void ReportByLastName(string LastName)
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@LastName", LastName);

            DB.Execute("sproc_tblStaff_FilterByLastName");

            PopulateArray(DB);
        }
    }
}
    
    
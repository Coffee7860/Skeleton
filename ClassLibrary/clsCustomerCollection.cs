using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public List<clsCustomer> mCustomerList=new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        List<clsCustomer> mclsCustomerList = new List<clsCustomer>();


        public List<clsCustomer> CustomerList {
            get
            {
                //return the private member
                return mCustomerList;
            }
            set
            {
                //set the private member
                mCustomerList = value;
            }
        }
        public int Count {
            get
            {
                //return the private member
                return mCustomerList.Count;
            }
            set
            {

            }
        }


        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //Adds a new record to the database based on the value of the ThisOrder
            //Connect To databse
            clsDataConnection DB = new clsDataConnection();

            //set the parameter for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email_Id", mThisCustomer.EmailId);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Password", mThisCustomer.Password);
          

            //execute the query returning the primary key 
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //Connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Customer_Id", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //update an existing record based on the value of ThisOrder
            //Connect to database
            clsDataConnection DB = new clsDataConnection();

            //set the parameter for the stored procedure.
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email_Id", mThisCustomer.EmailId);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Password", mThisCustomer.Password);

            //execute the stored procedure.
            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}
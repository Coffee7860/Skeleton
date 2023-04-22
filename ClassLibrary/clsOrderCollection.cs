using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //Private Data Member from the list
        List<clsOrders> mOrderList = new List<clsOrders>();
        public List<clsOrders> OrderList 
        { 
            get
            {
                //return the private member
                return mOrderList;
            }
            set
            {
                //set the private member
                mOrderList = value;
            }
        }

        public int Count 
        {
            get
            {
                //return the private member
                return mOrderList.Count;
            }
            set
            {

            }
        }

        //private data member ThisOrder
        clsOrders mThisOrder = new clsOrders();
        //Public Propety For ThisOrder
        public clsOrders ThisOrder 
        {
            get 
            {
                //Return the private member 
                return mThisOrder;
            }
            set
            {
                //set the private member
                mThisOrder = value;
            } 
        }

        //Constructor For the class
        public clsOrderCollection()
        {
            //Variable for the index
            Int32 Index = 0;
            //Variable to store The record Count
            Int32 RecordCount = 0;
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();

            //Execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //populate the arraylist with the data table
            PopulateArray(DB);

            //Get the Count Of records
            RecordCount = DB.Count;
            
            //While there are record to process
            while (Index < RecordCount)
            {
                ////create a blank order
                clsOrders order = new clsOrders();

                //read in the fields from the current record
                order.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNumber"]);
                order.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                order.OrderAddress = Convert.ToString(DB.DataTable.Rows[Index]["OrderAddress"]);
                order.OrderPostcode = Convert.ToString(DB.DataTable.Rows[Index]["OrderPostcode"]);
                order.OrderCountyCode = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderCountyCode"]);
                order.OrderDeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDeliverystatus"]);
                order.OrderTotalAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderTotalAmount"]);
                
                //add the record to the private data member
                mOrderList.Add(order);
                //point at the next Record
                Index++;
            }
        }


        public int Add()
        {
            //Adds a new record to the database based on the value of the ThisOrder
            //Connect To databse
            clsDataConnection DB = new clsDataConnection();

            //set the parameter for the stored procedure
            DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderPostcode", mThisOrder.OrderPostcode);
            DB.AddParameter("@OrderCountyCode", mThisOrder.OrderCountyCode);
            DB.AddParameter("@OrderDeliveryStatus", mThisOrder.OrderDeliveryStatus);
            DB.AddParameter("@OrderTotalAmount", mThisOrder.OrderTotalAmount);

            //execute the query returning the primary key 
            return DB.Execute("sproc_tblOrders_Insert"); 
        }

        public void Update()
        {
            //update an existing record based on the value of ThisOrder
            //Connect to database
            clsDataConnection DB = new clsDataConnection();

            //set the parameter for the stored procedure.
            DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);
            DB.AddParameter("@OrderNumber", mThisOrder.OrderNumber);
            DB.AddParameter("@OrderPostcode", mThisOrder.OrderPostcode);
            DB.AddParameter("@OrderCountyCode", mThisOrder.OrderCountyCode);
            DB.AddParameter("@OrderDeliveryStatus", mThisOrder.OrderDeliveryStatus);
            DB.AddParameter("@OrderTotalAmount", mThisOrder.OrderTotalAmount);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);

            //execute the stored procedure.
            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete()
        {
            //delete the record pointed by thisOrder
            //Connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNumber", mThisOrder.OrderNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }

        void PopulateArray(clsDataConnection DB)
        {
            //Populate the arrayylist based on the data table in the parameter DB
            //Variable for the index 
            Int32 Index = 0;

            //variable to Store the record count 
            Int32 RecordCount;

            //Get the count of the record
            RecordCount = DB.Count;
            //clear the private Arraylist
            mOrderList = new List<clsOrders>();
            
            //while there are record to process
            while(Index < RecordCount)
            {
                //create a blank order
                clsOrders order = new clsOrders();

                //read tin the field from the current record 
                order.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNumber"]);
                order.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                order.OrderAddress = Convert.ToString(DB.DataTable.Rows[Index]["OrderAddress"]);
                order.OrderPostcode = Convert.ToString(DB.DataTable.Rows[Index]["OrderPostcode"]);
                order.OrderCountyCode = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderCountyCode"]);
                order.OrderDeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDeliverystatus"]);
                order.OrderTotalAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderTotalAmount"]);

                //Add the record to the private data member
                mOrderList.Add(order);
                //Point at the next record
                Index++;
            }
        }

        public void ReportByPostcode(string Postcode)
        {
            //filter the record bassed on the full or partial postcode
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //Send the postcode parameter too the database
            DB.AddParameter("@Postcode", Postcode);
            //Execute The stored Procedure 
            DB.Execute("sproc_tblOrders_FilterByPostcode");
            //populate the arraylist with the data table
            PopulateArray(DB);
        }
    }
}
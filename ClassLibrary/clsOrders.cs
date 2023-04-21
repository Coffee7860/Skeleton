using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for order date
        private DateTime mOrderDate;

        //public property for order date
        public DateTime OrderDate 
        {
            get
            {
                //return the private date
                return mOrderDate;
            }
            set
            {
                //set the private data
                mOrderDate = value;
            } 
        }

        //private data member for order address
        private String mOrderAddress;

        //public property for the order address
        public String OrderAddress
        {
            get
            {
                //return the private data
                return mOrderAddress;
            }
            set
            {
                //set the private data
                mOrderAddress = value;
            }
        }

        //private data member for order postcode
        private String mOrderPostcode;

        //public property for the order postcode
        public String OrderPostcode 
        {
            get 
            { 
                //return the private data
                return mOrderPostcode;
            } 
            set
            {
                //set the private data
                mOrderPostcode = value;
            }
        }

        //private data member for order county code
        private Int32 mOrderCountyCode;

        //public property for the order county code
        public Int32 OrderCountyCode
        {
            get
            {
                //return the private data
                return mOrderCountyCode;
            }
            set
            {
                //set the private data
                mOrderCountyCode = value;
            }
        }

        //private data member for order total amount
        private Int32 mOrderTotalAmount;

        //public property for the order total amouty
        public Int32 OrderTotalAmount
        {
            get
            {
                //return the private data
                return mOrderTotalAmount;
            }
            set
            {
                //set the private data
                mOrderTotalAmount = value;
            }
        }

        //private data member for order delivery status
        private Boolean mOrderDeliveryStatus;

        //public property for the order delivery status
        public Boolean OrderDeliveryStatus
        {
            get
            {
                //return the private data
                return mOrderDeliveryStatus;
            }
            set
            {
                //set the priavte data
                mOrderDeliveryStatus = value;
            }
        }

        //private data member for order number
        private Int32 mOrderNumber;

        //public property for the order number
        public Int32 OrderNumber
        {
            get
            {
                //this line of code send data out of the property
                return mOrderNumber;
            }
            set
            {
                // this line of code allow data in to property
                mOrderNumber = value;
            }
        }
                

        public bool Find(int OrderNumber)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order number to search for
            DB.AddParameter("@OrderNumber", OrderNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderNumber");

            //if one record is found (there should be only one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderAddress = Convert.ToString(DB.DataTable.Rows[0]["OrderAddress"]);
                mOrderPostcode = Convert.ToString(DB.DataTable.Rows[0]["OrderPostcode"]);
                mOrderCountyCode = Convert.ToInt32(DB.DataTable.Rows[0]["OrderCountyCode"]);
                mOrderDeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderDeliverystatus"]);
                mOrderTotalAmount = Convert.ToInt32(DB.DataTable.Rows[0]["OrderTotalAmount"]);

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

        public string Valid(string orderAddress, string orderPostcode, string orderDate)
        {
            //create a string variable to store the error
            string Error = "";
            //create a temporary variable to store date value
            DateTime DateTemp;

            try
            {
                //copy the order date value to then data temp variable
                DateTemp = Convert.ToDateTime(orderDate);
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

            //check if the post code blank
            if (orderPostcode.Length == 0)
            {
                //record the error
                Error = Error + "The Postcode May not be blank: ";
            }

            //check if the postcode is greater than 10 character
            if (orderPostcode.Length > 10)
            {
                //record the error
                Error = Error + "The Postcode Must be Less than 10 Character: ";
            }

            //check if the address is blank
            if (orderAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Address Cannot be blank";
            }

            //check if the address is too long
            if (orderAddress.Length > 48)
            {
                //record the error
                Error = Error + "The Address Should be Under 22 Character";
            }

            //return the error message 
            return Error;
        }
    }
}
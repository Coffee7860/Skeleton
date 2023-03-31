using System;

namespace ClassLibrary
{
    public class clsOrders
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

        private String mOrderAddress;
        public String OrderAddress
        {
            get
            {
                return mOrderAddress;
            }
            set
            {
                mOrderAddress = value;
            }
        }

        private String mOrderPostcode;
        public String OrderPostcode 
        {
            get 
            { 
                return mOrderPostcode;
            } 
            set
            {
                mOrderPostcode = value;
            }
        }

        private Int32 mOrderCountyCode;
        public Int32 OrderCountyCode
        {
            get
            {
                return mOrderCountyCode;
            }
            set
            {
                mOrderCountyCode = value;
            }
        }

        private Int32 mOrderTotalAmount;
        public Int32 OrderTotalAmount
        {
            get
            {
                return mOrderTotalAmount;
            }
            set
            {
                mOrderTotalAmount = value;
            }
        }

        private Boolean mOrderDeliveryStatus;
        public Boolean OrderDeliveryStatus
        {
            get
            {
                return mOrderDeliveryStatus;
            }
            set
            {
                mOrderDeliveryStatus = value;
            }
        }

        private Int32 mOrderNumber;
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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNumber", OrderNumber);
            DB.Execute("sproc_tblOrders_FilterByOrderNumber");
            if(DB.Count == 1)
            {
                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderAddress = Convert.ToString(DB.DataTable.Rows[0]["OrderAddress"]);
                mOrderPostcode = Convert.ToString(DB.DataTable.Rows[0]["OrderPostcode"]);
                mOrderCountyCode = Convert.ToInt32(DB.DataTable.Rows[0]["OrderCountyCode"]);
                mOrderDeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderDeliverystatus"]);
                mOrderTotalAmount = Convert.ToInt32(DB.DataTable.Rows[0]["OrderTotalAmount"]);
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public string Valid(string orderAddress, string orderPostcode, string orderDate)
        {
            string Error = "";
            DateTime DateTemp;
            try
            {
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //Record The error
                    Error = Error + "the Date Cannot be in the past: ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in future: ";
                }
            }
            catch 
            {
                Error = Error + "The Date was not a valid date";
            }

            if (orderPostcode.Length == 0)
            {
                Error = Error + "The Postcode May not be blank: ";
            }

            if (orderPostcode.Length > 10)
            {
                Error = Error + "The Postcode Must be Less than 10 Character: ";
            }
            return Error;
        }

    }
}
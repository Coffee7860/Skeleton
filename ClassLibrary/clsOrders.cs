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
                

        public bool Find(int orderNumber)
        {
            //set the private data members to the test data value
            mOrderNumber = 11;
            mOrderDate = Convert.ToDateTime("24/12/2022");
            mOrderAddress = "5, Canvendish Road";
            mOrderPostcode = "LS2 3AR";
            mOrderCountyCode = 826;
            mOrderDeliveryStatus = true;
            mOrderTotalAmount = 200;
            //always return true
            return true;
        }
    }
}
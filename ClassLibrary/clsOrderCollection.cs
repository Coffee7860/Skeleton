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
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count 
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        clsOrders mThisOrder = new clsOrders();
        public clsOrders ThisOrder 
        {
            get 
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            } 
        }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrders_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrders order = new clsOrders();
                order.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNumber"]);
                order.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                order.OrderAddress = Convert.ToString(DB.DataTable.Rows[Index]["OrderAddress"]);
                order.OrderPostcode = Convert.ToString(DB.DataTable.Rows[Index]["OrderPostcode"]);
                order.OrderCountyCode = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderCountyCode"]);
                order.OrderDeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDeliverystatus"]);
                order.OrderTotalAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderTotalAmount"]);
                mOrderList.Add(order);
                Index++;
            }
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderPostcode", mThisOrder.OrderPostcode);
            DB.AddParameter("@OrderCountyCode", mThisOrder.OrderCountyCode);
            DB.AddParameter("@OrderDeliveryStatus", mThisOrder.OrderDeliveryStatus);
            DB.AddParameter("@OrderTotalAmount", mThisOrder.OrderTotalAmount);

            return DB.Execute("sproc_tblOrders_Insert"); 
        }
    }
}
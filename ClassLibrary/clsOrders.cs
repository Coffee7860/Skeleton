using System;

namespace ClassLibrary
{
    public class clsOrders
    { 
        public DateTime OrderDate { get; set; }
        public string OrderAddress { get; set; }
        public string OrderPostcode { get; set; }
        public int OrderCountyCode { get; set; }
        public int OrderTotalAmount { get; set; }
        public bool OrderDeliveryStatus { get; set; }
        public int OrderNumber { get; set; }
    }
}
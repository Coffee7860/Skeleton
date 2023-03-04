using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Active { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderAddress { get; set; }
        public string OrderPostcode { get; set; }
    }
}
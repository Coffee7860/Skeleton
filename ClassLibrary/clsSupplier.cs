using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public DateTime OrderDate { get; set; }
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string ContactNumber { get; set; }
        public int UnitCost { get; set; }
        public bool Location { get; set; }
    }
}
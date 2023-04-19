using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool StaffAvailableStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNum { get; set; }
        public string Address { get; set; }
        public DateTime DateJoined { get; set; }
        public int StaffId { get; set; }

        public bool Find(int staffId)
        {
            throw new NotImplementedException();
        }
    }
}
using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Boolean mStaffAvailableStatus;
        public bool StaffAvailableStatus
        {
            get
            {
                //return the private data
                return mStaffAvailableStatus;
            }
            set
            {
                //set the priavte data
                mStaffAvailableStatus = value;
            }
        }
        private string mFirstName;
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the priavte data
                mFirstName = value;
            }
        }
        public string LastName { get; set; }
        public string ContactNum { get; set; }
        public string Address { get; set; }
        public DateTime JoinDate { get; set; }
        public int StaffId { get; set; }

        public bool Find(int staffId)
        {
            return true;
        }
    }
}
using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for customer id

        private int mCustomerId;
        public int CustomerId { get; set; }
        //private data member for firstname
        private int mFirstName;
        public string FirstName { get; set; }
        //private data member for lastname
        private int mLastName;
        public string LastName { get; set; }
        //private data member for address
        private int mAddress;
        public string Address { get; set; }
        //private data member for emailaddress
        private int mEmailAddress;
        public string EmailAddress { get; set; }
        //private data member for date of birth
        private int mDateOfBirth;
        public DateTime DateOfBirth { get; set; }
        //private data member for loyal customer
        private int mLoyalCustomer;
        public bool LoyalCustomer { get; set; }

    }
}

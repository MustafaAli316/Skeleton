using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for customer id
        private int mCustomerId;
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool LoyalCustomer { get; set; }
    }
}
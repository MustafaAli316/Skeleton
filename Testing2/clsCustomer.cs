using System;

namespace Testing2
{
    public class clsCustomer
    {
        internal string EmailAddress;
        internal DateTime DateOfBirth;
        internal bool LoyalCustomer;

        public int CustomerId { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Address { get; internal set; }
    }
}
using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for customer 
        private Int32 mCustomerId;
        private string mFirstName;
        private string mLastName;
        private string mAddress;
        private string mEmailAddress;
        private DateTime mDateOfBirth;
        private Boolean mLoyalCustomer;


        //customerid public property
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }

        }
         
        
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        
        public string EmailAddress
        {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }
        
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
       
        public bool LoyalCustomer
        {
            get
            {
                return mLoyalCustomer;
            }
            set
            {
                mLoyalCustomer = value;
            }
        }

        public bool Find(int customerId)
        {
            //set the private data 
            mCustomerId = 4;
            mDateOfBirth = Convert.ToDateTime("22/12/2000");
            mAddress = "64 stanmore road";
            mEmailAddress = "arif786@live.com";
            mFirstName = "ahsan";
            mLastName = "arif";
            mLoyalCustomer = false;
            return true;
        }
    }
}

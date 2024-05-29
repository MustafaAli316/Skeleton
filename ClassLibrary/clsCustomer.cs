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

        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add parameter for the customerid to serach for
            DB.AddParameter("@CustomerId", CustomerId);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustumerId");

            if (DB.Count == 1) 
            {
                //copy the data from the database to the private data member
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mLoyalCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["LoyalCustomer"]);
                //return that eerything worked OK
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

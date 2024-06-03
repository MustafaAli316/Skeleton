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

        public string Valid(string firstName, string lastName, string dateOfBirth, string address, string emailAddress)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the data values
            DateTime DateTemp;
            //if first name is blank
            if(firstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank : ";
            }
            //if the first name is greater then 10 characters
            if(firstName.Length > 10)
            {
                //record the error
                Error = Error + "The first name must be less the 10 characters: ";
            }
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The last name may not be blank : ";
            }
            //if the first name is greater then 10 characters
            if (lastName.Length > 10)
            {
                //record the error
                Error = Error + "The last name must be less the 10 characters: ";
            }
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The addresss may not be blank : ";
            }
            //if the address is greater then 50 characters
            if (address.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less the 50 characters: ";
            }
            if (emailAddress.Length == 0)
            {
                //record the error
                Error = Error + "The email address may not be blank : ";
            }
            //if the email address is greater then 50 characters
            if (emailAddress.Length > 50)
            {
                //record the error
                Error = Error + "The email address must be less the 50 characters: ";
            }

            //check to see if the date is less
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);

                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date:";
             }

            //return any error message
            return Error;
        }
    }
}

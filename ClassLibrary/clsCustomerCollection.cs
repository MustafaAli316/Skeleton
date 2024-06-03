using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection() 
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //object for the data connect
            clsDataConnection DB = new clsDataConnection();

            //execute procedure
            DB.Execute("sproc_tblCustomer_SelectAll");

            //get the count of the records
            RecordCount = DB.Count;

            //while there are records to process
            while (index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();

                //read in the fields for the current record
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[index]["CustomerId"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[index]["LastName"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[index]["DateOfBirth"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[index]["Address"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[index]["EmailAddress"]);
                ACustomer.LoyalCustomer = Convert.ToBoolean(DB.DataTable.Rows[index]["LoyalCustomer"]);

                //add the record to the private data member
                mCustomerList.Add(ACustomer);

                //point at the next record
                index++;
            }
        }
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //public property for the customer lsit
        public List<clsCustomer> CustomerList 
        {
            get 
            { 
                //set the private data
                return mCustomerList;
            }

            set 
            { 
                //set the private data
                mCustomerList = value;
            } 
        }
        public int Count 
        { 
            get 
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set 
            {
                //later
            } 
        }
        public clsCustomer ThisCustomer { get; set; }
    }
}
using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        public clsCustomerCollection() 
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
         
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 index = 0;

            //variable to store the record count
            Int32 RecordCount;

            //get the count of the records
            RecordCount = DB.Count;

            //clear the private array list
            mCustomerList = new List<clsCustomer>();

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

        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomer ThisCustomer 
        { get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisAddress
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@LoyalCustomer", mThisCustomer.LoyalCustomer);

            //excute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //adds a record to the database based on the values of mThisAddress
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@LoyalCustomer", mThisCustomer.LoyalCustomer);

            //excute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //delect the record pointed to by thisCustomer
            //connect to the data base
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //excute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");

        }

        public void ReportByFirstName(string FirstName)
        {
           //filter the record based on a full 
           //connect to the database
           clsDataConnection DB = new clsDataConnection();
            //send the firstname parameter to the database
            DB.AddParameter("@FirstName", FirstName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFirstName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
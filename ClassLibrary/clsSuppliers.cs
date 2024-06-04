using System;


namespace ClassLibrary
{
    public class clsSuppliers
    {
        //public DateTime DateAdded { get; set; }
       // public bool Active { get; set; }
      //  public int Supplier_id { get; set; }
       // public string Supplier_Name { get; set; }
       // public string Contact_Number { get; set; }
        //public string Post_Code { get; set; }
       // public string Address { get; set; }
        //public string City { get; set; }
       // public string Country { get; set; }
        //public string Email { get; set; }

       // public bool Find(int Supplier_id)
        //{
            //return always true
          //  return true;
        //}

        //private data member for the Supplier id property
        private Int32 mSupplier_id;
        //addressId public property
        public int Supplier_id
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplier_id;
            }
            set
            {
                //this line of code allows data into the property
                mSupplier_id = value;
            }
        }
        //private data member for the Supplier Name property
        private string mSupplier_Name;
        //addressId public property
        public string Supplier_Name
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplier_Name;
            }
            set
            {
                //this line of code allows data into the property
                mSupplier_Name = value;
            }
        }
        //private data member for the Contact Number property
        private string mContact_Number;
        //addressId public property
        public string Contact_Number
        {
            get
            {
                //this line of code sends data out of the property
                return mContact_Number;
            }
            set
            {
                //this line of code allows data into the property
                mContact_Number = value;
            }
        }
        //private data member for the Email property
        private string mEmail;
        //addressId public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        //private data member for the Post Code property
        private string mPost_Code;
        //addressId public property
        public string Post_Code
        {
            get
            {
                //this line of code sends data out of the property
                return mPost_Code;
            }
            set
            {
                //this line of code allows data into the property
                mPost_Code = value;
            }
        }
        //private data member for the maddress property
        private string mAddress;
        //addressId public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }
        //private data member for the mCity property
        private string mCity;
        //addressId public property
        public string City
        {
            get
            {
                //this line of code sends data out of the property
                return mCity;
            }
            set
            {
                //this line of code allows data into the property
                mCity = value;
            }
        }
        //private data member for the Country property
        private string mCountry;
        //addressId public property
        public string Country
        {
            get
            {
                //this line of code sends data out of the property
                return mCountry;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }
        //private data member for the date added property
        private DateTime mDateAdded;
        //date added public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        //private data member for the active property
        private Boolean mActive;
        //active public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        /****** FIND METHOD ******/
        public bool Find(int Supplier_id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@Supplier_id", Supplier_id);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplier_id");
            //if one record is found ( There should be either one or zero )
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mSupplier_id = Convert.ToInt32(DB.DataTable.Rows[0]["Supplier_id"]);
                mSupplier_Name = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Name"]);
                mContact_Number = Convert.ToString(DB.DataTable.Rows[0]["Contact_Number"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPost_Code = Convert.ToString(DB.DataTable.Rows[0]["Post_Code"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mCountry = Convert.ToString(DB.DataTable.Rows[0]["Country"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            { 
                return false; 
            }

            //set the private data members to the test data value

           // mSupplier_id = 21;
           // mSupplier_Name = "Mausham";
           // mContact_Number = "07423619166";
           // mEmail = "mausham001123@gmail.com";
           // mAddress = "Some Address";
           // mPost_Code = "LE1 3UG";
         //   mCity = "Leicester";
          //  mCountry = "United Kingdom";
          //  mDateAdded = Convert.ToDateTime("07/06/2024");
          //  mActive = true;
            //always return true
           // return true;


        }
    }
}


using System;
using System.IO;


namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the order id property
        private Int32 mOrderID;
        //orderid public property
        public Int32 OrderID
        { 
        get
            {
                //this line of code sends data out of the property 
                return mOrderID;
            }
        set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }
        }
        //private data member for the order id property
        private DateTime mOrderDate;
        //orderdate public property
        public DateTime OrderDate
        {
            get
            {
                //this line of code sends data out of the property 
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }
        }
        //private data member for the order id property
        private Int32 mQuantity;
        //quantity public property
        public Int32 Quantity
        {
            get
            {
                //this line of code sends data out of the property 
                return mQuantity;
            }
            set
            {
                    //this line of code allows data into the property
                    mQuantity = value;
            }
        }
         //private data member for the Product id property
        private Int32 mProductID;
        //Productid public property
        public Int32 ProductID
        {
            get
            {
                //this line of code sends data out of the property 
                return mProductID;
            }
            set
            {
                //this line of code allows data into the property
                mProductID = value;
            }
        }
        //private data member for the courier... property
        private String mCourierCompany;
        //courierc... public property
        public String CourierCompany
        {
            get
            {
                //this line of code sends data out of the property 
                return mCourierCompany;
            }
            set
            {
                //this line of code allows data into the property
                mCourierCompany = value;
            }
        }
         //private data member for the total property
        private Double mTotal;
        //total public property
        public Double Total

        { 
        get
            {
                //this line of code sends data out of the property 
                return mTotal;
            }
        set
            {
                //this line of code allows data into the property
                mTotal = value;
            }
        }
        //private data member for the ordercompleted property
        private bool mOrderCompleted;
        //ordercompleted public property
        public bool OrderCompleted

        {
            get
            {
                //this line of code sends data out of the property 
                return mOrderCompleted;
            }
            set
            {
                //this line of code allows data into the property
                mOrderCompleted = value;
            }
        }
       /* //public DateTime OrderDate { get; set; }
        //public bool OrderCompleted { get; set; }
        //public int OrderID { get; set; }
        //public int Quantity { get; set; }
       // public int ProductID { get; set; }
       // public string CourierCompany { get; set; }
        //public double Total { get; set; }*/

        public bool Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the new orderid search
            DB.AddParameter("@OrderID", OrderID);
            //execute the sttored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is foung( there should be either one or zero
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]); ;
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mOrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderCompleted"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mTotal = Convert.ToDouble(DB.DataTable.Rows[0]["Total"]);
                mCourierCompany = Convert.ToString(DB.DataTable.Rows[0]["CourierCompany"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating theres a problem
                return false;
            }


           
        }

        public string Valid(string orderDate, string productID, string quantity, string courierCompany)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;
            //if the Quantity is blank
            if (productID.Length == 0)
            {
                //record the error
                Error = Error + "the productID may not be blank:  ";
            }
            //if the courier company is no greater than 6 characters
            if (productID.Length > 6)
            {
                Error = Error + "the productID must be less than 6 characters :  ";
            }
            //create an instance of date and time to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the  orderdate value to the datetemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateComp) //compare orderDate with date 
                {
                    //record error
                    Error = Error + "the date cannot be in the past : ";
                }
                //check to see if the date is greater than todays date 
                if(DateTemp > DateComp)
                {
                    Error = Error + "the date cannot be in the future : ";
                }
            }
           catch
            {
                //record error
                Error = Error + "The date is invalid";
            }
            //is the quantity blank
           if (quantity.Length == 0)
            {
                //record error
                Error = Error + "The post code may not be blank: ";
            }
           //if the quantity is too long
           if(quantity.Length > 9)
            {
                //record the error
                Error = Error + "The quantity must be less than 9 characters"; 
            }
           //is the couriercompany blank
           if(courierCompany.Length == 0)
            {
                //record the error
                Error = Error + "The courier may not be blank: ";
            }
           //if the courier company is greater than 50
           if(courierCompany.Length >50)
            {
                //record the error
                Error = Error + "The courier must be less than 50 characters:  ";
            }

            //return any error messages
            return Error;
        

        
        }
    }
}
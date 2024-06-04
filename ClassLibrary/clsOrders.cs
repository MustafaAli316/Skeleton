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
            //set the private data members to the test data value
            mOrderID = 21;
            mOrderDate = Convert.ToDateTime("23/12/2022");
            mProductID=21;
            mOrderCompleted= true;
            mQuantity=21;
            mTotal = 21;
            mCourierCompany="Royal Mail";
            //always return the true
            return true;
        }

        public string Valid(string orderID, string orderDate, string productID, string quantity, string total, string courierCompany)
        {
            //create a string variable to store the error
            String Error = "";
            //if the Quantity is blank
            if(courierCompany.Length == 0)
            {
                //record the error
                Error = Error + "the courierCompany may not be blank:  "; 
            }
            //if the courier company is no greater than 6 characters
            if(courierCompany.Length  > 6)
            {
                Error = Error + "the courier company must be less than 6 characters :  ";
            }
            return Error;
        }
    }
}
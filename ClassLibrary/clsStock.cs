using System;

namespace ClassLibrary
{
    public class clsStock
    {




        //private data member for the shoes no property
        private int mShoesNo;
        private DateTime mDateAdded;
        private string mShoesBrand;
        private string mShoesDesc;
        private string mShoesColour;
        private decimal mPrice;
        private int mAvailable;
        private bool mActive;

        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }


            set
            {
                //this line of code sends data out of the property
                mActive = value;
            }
        }
        public DateTime DateAdded 
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }


            set
            {
                //this line of code sends data out of the property
                mDateAdded = value;
            }
        }

        //ShoesNo public property
        public int ShoesNo {

            get
            {
                //this line of code sends data out of the property
                return mShoesNo;
            }


            set
            {
                //this line of code sends data out of the property
                mShoesNo = value;
            }


        }

        public string ShoesDesc 
        {
            get
            {
                //this line of code sends data out of the property
                return mShoesDesc;
            }


            set
            {
                //this line of code sends data out of the property
                mShoesDesc = value;
            }
        }
        public string ShoesBrand
        {
            get
            {
                //this line of code sends data out of the property
                return mShoesBrand;
            }


            set
            {
                //this line of code sends data out of the property
                mShoesBrand = value;
            }
        }
        public string ShoesColour
        {
            get
            {
                //this line of code sends data out of the property
                return mShoesColour;
            }


            set
            {
                //this line of code sends data out of the property
                mShoesColour = value;
            }
        }

        public decimal Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }


            set
            {
                //this line of code sends data out of the property
                mPrice = value;
            }
        }

        public int Available
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailable;
            }


            set
            {
                //this line of code sends data out of the property
                mAvailable = value;
            }
        }


                                     //FIND METHOD
        public bool Find(int shoeNo)
        {
            //CREATE AN INSTANCE OF THE Data connection 
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the address id 
            DB.AddParameter("@ShoesNo", shoeNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByShoesNo");
            //if one record is found 
            if (DB.Count==1)
            {
                //COPY THE DATA FROM THE DB TO THE PRivate data membets
                mShoesNo = Convert.ToInt32(DB.DataTable.Rows[0]["ShoesNo"]);
                mShoesDesc = Convert.ToString(DB.DataTable.Rows[0]["ShoesDesc"]);
                mShoesBrand = Convert.ToString(DB.DataTable.Rows[0]["ShoesBrand"]);
                mShoesColour= Convert.ToString(DB.DataTable.Rows[0]["ShoesColour"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToInt32(DB.DataTable.Rows[0]["Available"]);
                mDateAdded= Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                return true;
            }
            //if no code found
            else
            {
                return false;
            }
        }

        public string Valid(string dateAdded, string shoesBrand, string shoesDesc, string shoesColour, string price, string available)
        {
            //create a string variable to srore the error 
            String Error = "";
            //create a temporary variable to store the date values 
            DateTime DateTemp; 
            //if the shoesBrand is blank
            if(shoesBrand.Length == 0)
            {
                //record error
                Error = Error + "The Shoes Brand may not be blank : ";
            }
            //if the shoes brand is greater than 51 
            if(shoesBrand.Length > 51)
            {
                Error = Error + " The Shoes Brand must be less than 51 Characters : ";
            }


            
            //create an instance of DateTime to compare with DateTemp 
            //in the if statements 
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);

                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future : ";
                }

            }

            catch
            {
                Error = Error + "The date was not a valid date : "; 

            }

            // Error as still filling in  comment regardless of correct code 
            if (shoesDesc.Length == 0)
            {
                //Record the error
                Error = Error + "The Shoes Description may not be blank : ";
            }


            if (shoesDesc.Length > 50)
            {
                //Record the error
                Error = Error + "The Shoes Description must be less than 50 characters : ";
            }

            if (shoesColour.Length == 0)
            {
                //Record the error
                Error = Error + "The Shoes Colour may not be blank : ";
            }


            if (shoesColour.Length > 11)
            {
                //Record the error
                Error = Error + "The Shoes Colour must be less than 11 characters : ";
            }


            if (price.Length == 0)
            {
                //Record the error
                Error = Error + "The Shoes price may not be blank : ";
            }


            if (price.Length > 18)
            {
                //Record the error
                Error = Error + "The Shoes price must be less than 19 characters : ";
            }


            //return any error messages
            return Error;


        }
    }
}
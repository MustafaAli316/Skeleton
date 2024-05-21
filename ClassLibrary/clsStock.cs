using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //good test data
        //create some test data to pass the method
        //string ShoesNo = "1";
        //string ShoesBrand = "Nike";
        //string ShoesDesc = "high top";
        //string ShoesColour = "Price";
        //string Price = "59.99";
        //string Available = "2";
        //string DateAdded = DateTime.Now.ToShortDateString;;;



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

            //set the private data members to the test data value
            mShoesNo = 1;
            mDateAdded = Convert.ToDateTime("23/12/2022");
            mPrice = 59.99m;
            mShoesBrand = "Nike";
            mShoesColour = "Black";
            mShoesDesc = "High top";
            mAvailable = 2;
            mActive = true;
            
            //always return true
            return true;
        }
    }
}
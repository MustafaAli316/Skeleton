using System;

namespace ClassLibrary
{
    public class clsStock
    {

        //private data member for the shoes no property
        private int mShoesNo;
        private DateTime mDateAdded;
        private string mShoesDesc;

        public bool Active { get; set; }
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
        public string ShoesBrand { get; set; }
        public string ShoesColour { get; set; }

        public decimal Price { get; set; }

       public int Available { get; set;}

        public bool Find(int shoeNo)
        {

            //set the private data members to the test data value
            mShoesNo = 1;
            mDateAdded = Convert.ToDateTime("23/12/2022");
            //always return true
            return true;
        }
    }
}
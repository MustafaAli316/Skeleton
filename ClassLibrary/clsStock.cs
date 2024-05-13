using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }

        public int ShoesNo { get; set; }
        public string ShoesDesc { get; set; }
        public string ShoesBrand { get; set; }
        public string ShoesColour { get; set; }

        public decimal Price { get; set; }

       public int Available { get; set;}

        public bool Find(int shoeNo)
        {
           // throw new NotImplementedException();

            //always return true
            return true;
        }
    }
}
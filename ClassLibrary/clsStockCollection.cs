using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list 
        List<clsStock> mStockList = new List<clsStock>();

        public List<clsStock> StockList
        {
            get { return mStockList; }
            set { mStockList = value; }

        }
        public int Count
        {
            get { return mStockList.Count; }
            set { }
        }
        public clsStock ThisStock { get; set; }


        public clsStockCollection()
        {
            ////create the items of test data
            //clsStock TestItem = new clsStock();
            ////set its properties 
            //TestItem.Active = true;
            //TestItem.ShoesNo = 1;
            //TestItem.ShoesDesc = "High top";
            //TestItem.DateAdded = DateTime.Now;
            //TestItem.ShoesBrand = "Nike";
            //TestItem.ShoesColour = "Black";
            //TestItem.Price = 59;
            //TestItem.Available = 2;

            ////add the test item to the test list 
            //mStockList.Add(TestItem);
            ////re initialise the object for some new data
            //TestItem = new clsStock();
            ////set its properties 
            //TestItem.Active = true;
            //TestItem.ShoesNo = 2;
            //TestItem.ShoesDesc = "Low top";
            //TestItem.DateAdded = DateTime.Now;
            //TestItem.ShoesBrand = "Adidas";
            //TestItem.ShoesColour = "Green";
            //TestItem.Price = 49;
            //TestItem.Available = 1;
            //mStockList.Add(TestItem);

            //variable for index
            Int32 Index = 0; 
            //varaible to store the record count 
            Int32 RecordCount = 0;
            //onject for the data connect 
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure 
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records 
            RecordCount =  DB.Count;
            //while there are records to process 
            while (Index < RecordCount)
            {
                //create a blank address 
                clsStock AnStock = new clsStock();
                //read in the fields for the current record 
                // AnStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStock.ShoesNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ShoesNo"]);
                AnStock.ShoesDesc = Convert.ToString(DB.DataTable.Rows[Index]["ShoesDesc"]);
                AnStock.ShoesBrand = Convert.ToString(DB.DataTable.Rows[Index]["ShoesBrand"]);
                AnStock.ShoesColour = Convert.ToString(DB.DataTable.Rows[Index]["ShoesColour"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);



            }
























        }
    }
}
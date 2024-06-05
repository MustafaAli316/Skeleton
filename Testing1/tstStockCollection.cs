using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testing6
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class 
            clsStockCollection AllStock = new clsStockCollection();
            //test to see it exists 
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property 
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to list 
            //create the item of test data 
            clsStock TestItem = new clsStock();
            //set its properties 
            TestItem.Active = true;
            TestItem.ShoesNo = 1;
            TestItem.ShoesDesc = "High top";
            TestItem.DateAdded = DateTime.Now;
            TestItem.ShoesBrand = "Nike";
            TestItem.ShoesColour = "Black";
            TestItem.Price = 59;
            TestItem.Available = 2;
            //add item to the list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStock.StockList = TestList;
            //Test to see taht the values are the same 
            Assert.AreEqual(AllStock.StockList , TestList);

        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property 
             clsStock TestStock = new clsStock();

            //set its properties 
            TestStock.Active = true;
            TestStock.ShoesNo = 1;
            TestStock.ShoesDesc = "High top";
            TestStock.DateAdded = DateTime.Now;
            TestStock.ShoesBrand = "Nike";
            TestStock.ShoesColour = "Black";
            TestStock.Price = 59;
            TestStock.Available = 2;
            //assign the data to the property 
            AllStock.ThisStock = TestStock;
            //Test to see taht the values are the same 
            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property 
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to list 
            //create the item of test data 
            clsStock TestItem = new clsStock();
            //set its properties 
            TestItem.Active = true;
            TestItem.ShoesNo = 1;
            TestItem.ShoesDesc = "High top";
            TestItem.DateAdded = DateTime.Now;
            TestItem.ShoesBrand = "Nike";
            TestItem.ShoesColour = "Black";
            TestItem.Price = 59;
            TestItem.Available = 2;
            //add item to the list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStock.StockList = TestList;
            //Test to see taht the values are the same 
            Assert.AreEqual(AllStock.Count, TestList.Count);

        }

   

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class 
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Active = true;
            TestItem.ShoesNo = 1;
            TestItem.ShoesDesc = "High top";
            TestItem.DateAdded = DateTime.Now;
            TestItem.ShoesBrand = "Nike";
            TestItem.ShoesColour = "Black";
            TestItem.Price = 59;
            TestItem.Available = 2;
            //set thisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record 
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data 
            TestItem.ShoesNo = PrimaryKey;
            //mpdify the test record 
            TestItem.Active = true;
            TestItem.ShoesNo = 13;
            TestItem.ShoesDesc = " Flip flop new ";
            TestItem.DateAdded = DateTime.Now;
            TestItem.ShoesBrand = "Starbucks";
            TestItem.ShoesColour = "Orange";
            TestItem.Price = 59;
            TestItem.Available = 2;
            //Set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //Update the record 
            AllStock.Update();
            //find the recod 
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if this stock mathces the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class 
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
           // TestItem.Active = true;
            TestItem.ShoesNo = 1;
            TestItem.ShoesDesc = "High top";
            TestItem.DateAdded = DateTime.Now;
            TestItem.ShoesBrand = "Nike";
            TestItem.ShoesColour = "Black";
            TestItem.Price = 59;
            TestItem.Available = 2;
            //set thisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record 
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data 
            TestItem.ShoesNo = PrimaryKey;
            //find teh record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that record was found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instace of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data 
            clsStock TestItem = new clsStock();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.ShoesNo = 1;
            TestItem.ShoesDesc = "High top";
            TestItem.DateAdded = DateTime.Now;
            TestItem.ShoesBrand = "Nike";
            TestItem.ShoesColour = "Black";
            TestItem.Price = 59;
            TestItem.Available = 2;

            //set thisstock to the test data 
            AllStock.ThisStock = TestItem;
            //add record
            PrimaryKey = AllStock.Add();
            //set the pk of the test data
            TestItem.ShoesNo = PrimaryKey;

            //assign the data to the property 
            AllStock.ThisStock.Find(PrimaryKey);
            //Test to see taht the values are the same 
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void ReportbyProductNameMethodOK()
        {
            //create an instace of the class containing infiltered results
            clsStockCollection AllStock = new clsStockCollection();
            //create an instace of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a blank string 
            FilteredStocks.ReportbyProductName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            //create an instace of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a product name that doesnt exist 
            FilteredStocks.ReportbyProductName("xxxxXXX");
            //test to see tha there are no records
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportProductNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //variablke to store the outcome 
            Boolean OK = true;
            //apply a shoes desc doesnt exist
            FilteredStocks.ReportbyProductName("High top");
            //check that the correct number of records are found
            if (FilteredStocks.Count ==2)
            {
                //check to see that the first record is 18
                if (FilteredStocks.StockList[0].ShoesNo != 18)
                {
                    OK = false;
                }
                //check to see that the first record is 18
                if (FilteredStocks.StockList[1].ShoesNo != 19)
                {
                    OK = false;
                }
                else { OK = false; }
                //test to see that no records
                Assert.IsTrue(OK);
            }


        }




    }
}

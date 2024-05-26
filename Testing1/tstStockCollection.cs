using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Testing1
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
        public void CountPropertyOK()
        {
            //create an instance of the class 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to property 
            Int32 SomeCount = 2; 
            //assign the data to the property 
            AllStock.Count = SomeCount;
            //test to see that thevalues are the same 
            Assert.AreEqual(AllStock.Count, SomeCount);
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

        public void TwoRecordsPresent()
        {
            //create an instance of the class 
            clsStockCollection AllStock = new clsStockCollection();
            //test to see two values are the same 
            Assert.AreEqual(AllStock.Count, 2);


        }




    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnStock.Active= TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.Active, TestData);
        }
        [TestMethod] 
        public void DateAddedPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnStock.DateAdded = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }
        [TestMethod]
        public void ShoesNoPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            int TestData = 1;
            //assign the data to the property 
            AnStock.ShoesNo = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.ShoesNo, TestData);
        }

        [TestMethod]
        public void ShoesDescPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            var TestData = "Black High top";
            //assign the data to the property 
            AnStock.ShoesNo = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.ShoesDesc, TestData);
        }

        [TestMethod]
        public void ShoesDescPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            var TestData = "Black High top";
            //assign the data to the property 
            AnStock.ShoesNo = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.ShoesDesc, TestData);
        }

        [TestMethod]
        public void ShoesBrandPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            var TestData = "Nike";
            //assign the data to the property 
            AnStock.ShoesBrand = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.ShoesBrand, TestData);
        }

        [TestMethod]
        public void ShoesColourPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            var TestData = "Black";
            //assign the data to the property 
            AnStock.ShoesColour = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.ShoesColour, TestData);
        }

        [TestMethod]
        public void PricePropertyOk()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            decimal TestData = 59.99m;
            //assign the data to the property 
            AnStock.Price = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.Price, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOk()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            int TestData = 2;
            //assign the data to the property 
            AnStock.Available = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.Available, TestData);
        }

    }
}

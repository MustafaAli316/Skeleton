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
    }
}

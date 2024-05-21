using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class TstOrder
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create instance for the class we want to create
            clsOrders Anorder = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(Anorder); 
           

        }
        [TestMethod]
        public void OrderCompletedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some data to assign the property
            Boolean TestData = true;
            //Assign data to the property
            AnOrder.OrderCompleted = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderCompleted,TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);



        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);



        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);



        }
        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AnOrder.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ProductID, TestData);



        }
        [TestMethod]
        public void CourierCompanyPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            String TestData = "Some Company";
            //Assign the data to the property
            AnOrder.CourierCompany = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CourierCompany, TestData);



        }
        [TestMethod]
        public void TotalPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Double TestData = 1.11;
            //Assign the data to the property
            AnOrder.Total = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Total, TestData);



        }
    }
}

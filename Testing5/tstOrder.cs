using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the method
        
        String OrderDate = DateTime.Now.ToShortDateString();
        String ProductID = "01";
        String Quantity = "1";
        String CourierCompany = "RoyalMail";
        


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
            String TestData = "Royal Mail";
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
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
           Found = AnOrder.Find(OrderID);
            //check the orderID
            if(AnOrder.OrderID != 21)
            { 
            OK = false;
            } 
               //test to see that the result is correct
               Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the date
            if (AnOrder.OrderDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestQuantity()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the quantity
            if (AnOrder.Quantity != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestProductID()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the productID
            if (AnOrder.ProductID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCourierCompanyFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the courier...
            if (AnOrder.CourierCompany != "Royal Mail")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestTotalFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the total
            if (AnOrder.Total != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestOrderCompletedFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the orderID
            if (AnOrder.OrderCompleted != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the clss we want to create
            clsOrders AnOrder = new clsOrders();
        //string variables to store error message
        String Error = "";
        //invoke the method
        Error = AnOrder.Valid(OrderDate,ProductID,Quantity,CourierCompany);
            //test to see that they are correct
         Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CourierCompanyMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CourierCompany = ""; //this should trigger an error message
                                  //invoke the method
            Error = AnOrder.Valid( OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CourierCompanyMin()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CourierCompany = "a"; //this should be ok
                                        //invoke the method
            Error = AnOrder.Valid(OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CourierCompanyMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CourierCompany = "aa"; //this should be ok
                                         //invoke the method
            Error = AnOrder.Valid( OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CourierCompanyMaxlessOne()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CourierCompany = "aaaaa"; //this should be ok
                                          //invoke the method
            Error = AnOrder.Valid( OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CourierCompanyMax()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CourierCompany = "aaaaaa"; //this should be ok
                                          //invoke the method
            Error = AnOrder.Valid( OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CourierCompanyMid()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CourierCompany = "aaa"; //this should be ok
                                          //invoke the method
            Error = AnOrder.Valid(OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CourierCompanyMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CourierCompany = "aaaaaaa"; //this should fail
                                          //invoke the method
            Error = AnOrder.Valid(OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CourierCompanyExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CourierCompany = "";
            CourierCompany = CourierCompany.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create a variable to store testdata
            DateTime TestDate;
            //set the date and time to todays date
            TestDate = DateTime.Now.Date;
            //change to whatever date is less 100yrs
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate,ProductID,Quantity,CourierCompany);
            //test to seethat the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create a variable to store testdata
            DateTime TestDate;
            //set the date and time to todays date
            TestDate = DateTime.Now.Date;
            //change to whatever date is less 100yrs
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create a variable to store testdata
            DateTime TestDate;
            //set the date and time to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            String OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create a variable to store testdata
            DateTime TestDate;
            //set the date and time to todays date
            TestDate = DateTime.Now.Date;
            //change to whatever date is less 100yrs
            TestDate = TestDate.AddYears(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //create a variable to store testdata
            DateTime TestDate;
            //set the date and time to todays date
            TestDate = DateTime.Now.Date;
            //change to whatever date is over 100yrs
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ProductID, Quantity,CourierCompany);
            //test to seethat the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create 
            clsOrders AnOrder = new clsOrders();
            //string  c = variable to store any error message
            String Error = "";
            //set the date and time to todays date
            String OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ProductID, Quantity, CourierCompany);
            //test to seethat the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of a class we want to create 
           // clsOrders AnOrder = new 
        }


    }
}

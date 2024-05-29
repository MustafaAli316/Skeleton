using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing2
{
    [TestClass]
    public class TstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an intance of the class want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see the two values are same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]

        public void FirstNamePropertyOK()
        {
            //create an intance of the class want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "ahsan";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);

        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an intance of the class want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "arif";
            //assign the data to the property
            AnCustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK() 
        {
            //create an intance of the class want to create
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "16 rockery road";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);

        }
        [TestMethod]

        public void EmailAddressPropertyOK()
        {
            //create an intance of the class want to create
            clsCustomer AnCustomer = new clsCustomer();
            string TestData = "arif@live.com";
            //assign the data to the property
            AnCustomer.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.EmailAddress, TestData);
        }
        [TestMethod]

        public void DateOfBirthPropertyOK() 
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }
        [TestMethod]

        public void LoyalCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.LoyalCustomer = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.LoyalCustomer, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the methods
            Int32 CustomerId = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustumerIdFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            // create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean vriable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invoke the method 
            Found = AnCustomer.Find(CustomerId);
            //check the customer id
            if (AnCustomer.CustomerId != 4)
            {
                OK = false;
            }
            //test to see the result
            Assert.IsTrue(OK);  
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4; 
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the FirstName property
            if (AnCustomer.FirstName != "ahsan     ")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
           Int32 CustomerId = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the LastName property
            if (AnCustomer.LastName != "arif      ")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the Date Of Birth property
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("22/12/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the town property
            if (AnCustomer.EmailAddress != "arif786@live.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the town property
            if (AnCustomer.Address != "64 stanmore road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLoyalCustomerFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the active property
            if (AnCustomer.LoyalCustomer != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}

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
       

        
    }
}

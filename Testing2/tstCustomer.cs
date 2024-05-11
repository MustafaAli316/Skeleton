using ClassLibrary; 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
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
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
        //create some test data to assign to the property
        Int32 TestData = 1;
        //assign the data to the property
        AnCustomer.CustomerId = TestData;
            //test to see the two values are same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
    }
}

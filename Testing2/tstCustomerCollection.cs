using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that it exist
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            //create some test data to assign to the property 
            List<clsCustomer> TestList = new List<clsCustomer>();

            //Add an item to list 
            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();

            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FirstName = "jordan";
            TestItem.LastName = "mike";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Address = "19 street road";
            TestItem.EmailAddress = "12313@gmail.com";
            TestItem.LoyalCustomer = true;

            //add item to the list 
            TestList.Add(TestItem);

            //assign the data to the property 
            AllCustomer.CustomerList = TestList;
            //Test to see taht the values are the same 
            Assert.AreEqual(AllCustomer.CustomerList, TestList);

        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property 
            clsCustomer TestItem = new clsCustomer();
            //set its properties 
            TestItem.CustomerId = 1;
            TestItem.FirstName = "jordan";
            TestItem.LastName = "mike";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Address = "19 street road";
            TestItem.EmailAddress = "12313@gmail.com";
            TestItem.LoyalCustomer = true;
            //assign the data to the property 
            AllCustomer.ThisCustomer = TestItem;
            //Test to see taht the values are the same 
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            //create some test data to assign to the property 
            List<clsCustomer> TestList = new List<clsCustomer>();

            //Add an item to list 
            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();

            //set its properties
            TestItem.CustomerId = 1;
            TestItem.FirstName = "jordan";
            TestItem.LastName = "mike";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Address = "19 street road";
            TestItem.EmailAddress = "12313@gmail.com";
            TestItem.LoyalCustomer = true;

            //add item to the list 
            TestList.Add(TestItem);

            //assign the data to the property 
            AllCustomer.CustomerList = TestList;

            //Test to see taht the values are the same 
            Assert.AreEqual(AllCustomer.Count, TestList.Count);

        }
    }
}

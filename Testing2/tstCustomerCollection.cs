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
        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.LoyalCustomer = true;
            TestItem.FirstName = "ahsan";
            TestItem.LastName = "arif";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-20).AddDays(-43);
            TestItem.Address = "64 stanmore road";
            TestItem.EmailAddress = "arif786@live.com";
            //set This Address to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.FirstName = "ahsan";
            TestItem.LastName = "arif";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-20).AddDays(-43);
            TestItem.Address = "64 stanmore road";
            TestItem.EmailAddress = "arif786@live.com";
            TestItem.LoyalCustomer = true;
            //set This Address to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //set its properties 
            TestItem.FirstName = "false";
            TestItem.LastName = "sadsad";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-20).AddDays(-44);
            TestItem.Address = "65 sdasd road";
            TestItem.EmailAddress = "arif786@live.com";
            TestItem.LoyalCustomer = true;
            //set the record based on the new test data
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }





    }
}

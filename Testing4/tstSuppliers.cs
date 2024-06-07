using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSuppliers
    {
        public bool OK { get; private set; }
        public object AnSuppliers { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //test to see that it exists
            Assert.IsNotNull(AnSuppliers);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnSuppliers.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnSuppliers.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.DateAdded, TestData);
        }
        [TestMethod]
        public void Supplier_idPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnSuppliers.Supplier_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.Supplier_id, TestData);
        }
        [TestMethod]
        public void Supplier_NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            string TestData = "Mausham Adhikari";
            //assign the data to the property
            AnSuppliers.Supplier_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.Supplier_Name, TestData);
        }
        [TestMethod]
        public void Contact_NumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            string TestData = "07423619166";
            //assign the data to the property
            AnSuppliers.Contact_Number = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.Contact_Number, TestData);
        }
        [TestMethod]
        public void Post_CodePropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            string TestData = "LE1 3UG";
            //assign the data to the property
            AnSuppliers.Post_Code = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.Post_Code, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            string TestData = "Flat 1 Orchard House";
            //assign the data to the property
            AnSuppliers.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.Address, TestData);
        }
        [TestMethod]
        public void CityPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnSuppliers.City = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.City, TestData);
        }
         [TestMethod]
        public void CountryPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            string TestData = "United Kingdom";
            //assign the data to the property
            AnSuppliers.Country = TestData;
            //test to see that the two values are the same
           
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            string TestData = "mausham2080@gmail.com";
            //assign the data to the property
            AnSuppliers.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.Email, TestData);
        }
 
        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestSupplierIdFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //check the supplier id property
            if (AnSuppliers.Supplier_id != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //check the SUPPLIER NAME property
            if (AnSuppliers.Supplier_Name != "Mausham")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContactFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //check the contact property
            if (AnSuppliers.Contact_Number != "07423619166")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //check the house no property
            if (AnSuppliers.Email != "mausham2080@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //check the Address property
            if (AnSuppliers.Address != "Flat 1 Orchard House")
            {
                OK = false;
            }
            //test to see that the result is correct
           
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //check the house no property
            if (AnSuppliers.Post_Code != "LE1 3UG")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCityFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //check the address id property
            if (AnSuppliers.City != "Leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCountryFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //check the house no property
            if (AnSuppliers.Country != "United Kingdom")
            {
                OK = false;
            }
            //test to see that the result is correct
          
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //check the house no property
            if (AnSuppliers.DateAdded != Convert.ToDateTime("07/06/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Supplier_id = 1;
            //invoke the method
            Found = AnSuppliers.Find(Supplier_id);
            //check the active property
            if (AnSuppliers.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
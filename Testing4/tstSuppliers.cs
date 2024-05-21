using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSuppliers
    {
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
            string TestData = "LE1 4AB";
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
            string TestData = "Some Address";
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
            Assert.AreEqual(AnSuppliers.Country, TestData);
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
    }
}
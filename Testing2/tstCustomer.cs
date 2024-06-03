using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing2
{
    [TestClass]
    public class TstCustomer
    {
        //good test data
        //create some test data to pass the method
        string FirstName = "Taimour   ";
        string LastName = "Bhatti    ";
        string DateOfBirth = DateTime.Now.ToShortDateString();
        string Address = "16 rookery road";
        string EmailAddress = "bhatti@gmail.com";




        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any eror massage
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            Assert.AreEqual(Error, "");
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



        /* TEST FOR PARAMETES*/

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; // this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "tt"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "ttttttttt"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "tttttttttt"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "ttttt"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "ttttttttttt"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 't');// this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date of birth data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date of birth is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date of birth data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date of birth is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date of birth data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date of birth data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date of birth is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string DateOfBirth = "this is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; // this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "a"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "tt"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "ttttttttt"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "tttttttttt"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "ttttt"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "ttttttttttt"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 't');// this should fail
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "r";
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "rr";
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(49, 't');// this should fail
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(50, 't');// this should fail
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(51, 't');// this should fail
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(25, 't');// this should fail
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(500, 't');// this should fail
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "r";
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmaiAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "rr";
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(49, 't');// this should fail
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(50, 't');// this should fail
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(51, 't');// this should fail
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(25, 't');// this should fail
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(500, 't');// this should fail
            Error = AnCustomer.Valid(FirstName, LastName, DateOfBirth, Address, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

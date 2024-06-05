using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;

namespace Testing1
{
    [TestClass]
    public class tstStockUser
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the class
            clsStockUser AnUser = new clsStockUser();
            //test to see it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instace of class
            clsStockUser AnUser = new clsStockUser();
            //creaye some test data
            Int32 TestData  = 1;
            //assign data to property
            AnUser.UserID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instace of class
            clsStockUser AnUser = new clsStockUser();
            //create some test data
            string TestData = "Mustafa";
            //assign the data to property
            AnUser.UserName = TestData;
            //test to see thar the two values are the same 
            Assert.AreEqual(AnUser.UserName,TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instace of class
            clsStockUser AnUser = new clsStockUser();
            //create some test data
            string TestData = "Mustafa123";
            //assign the data to property
            AnUser.Password = TestData;
            //test to see thar the two values are the same 
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instace of class
            clsStockUser AnUser = new clsStockUser();
            //create some test data
            string TestData = "Stock";
            //assign the data to property
            AnUser.Department = TestData;
            //test to see thar the two values are the same 
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class
            clsStockUser AnUser = new clsStockUser();
            //create a bool varaible to store results
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Mustafa";
            string Password = "Mustafa123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class
            clsStockUser AnUser = new clsStockUser();
            //create a bool varaible to store results
            Boolean Found = false;
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Mustafa";
            string Password = "Mustafa123";
            //invoke method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




    }
}

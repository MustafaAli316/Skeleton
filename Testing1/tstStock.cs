using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnStock.Active = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnStock.DateAdded = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }
        [TestMethod]
        public void ShoesNoPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            int TestData = 1;
            //assign the data to the property 
            AnStock.ShoesNo = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.ShoesNo, TestData);
        }

        [TestMethod]
        public void ShoesDescPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            string TestData = "High top";
            //assign the data to the property 
            AnStock.ShoesDesc = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.ShoesDesc, TestData);
        }



        [TestMethod]
        public void ShoesBrandPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            string TestData = "Nike";
            //assign the data to the property 
            AnStock.ShoesBrand = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.ShoesBrand, TestData);
        }

        [TestMethod]
        public void ShoesColourPropertyOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            string TestData = "Black";
            //assign the data to the property 
            AnStock.ShoesColour = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.ShoesColour, TestData);
        }

        [TestMethod]
        public void PricePropertyOk()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            decimal TestData = 59.99m;
            //assign the data to the property 
            AnStock.Price = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.Price, TestData);
        }

        [TestMethod]
        public void AvailablePropertyOk()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            int TestData = 2;
            //assign the data to the property 
            AnStock.Available = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStock.Available, TestData);
        }





        [TestMethod]
        public void FindMethodOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 ShoeNo = 21;
            //invoke the method 
            Found = AnStock.Find(ShoeNo);
            //test to see if the result is true 
            Assert.IsTrue(Found);

        }


        /****All Property data tests****/

        [TestMethod]
        public void TestShoesNoFound()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the metod 
            int ShoeNo = 1;
            //invoke find method
            Found = AnStock.Find(ShoeNo);
            //check the address id 
            if (AnStock.ShoesNo != 1)
            {
                OK = false;
            }
            //test to see that the reslut is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the metod 
            int ShoeNo = 1;
            //invoke find method
            Found = AnStock.Find(ShoeNo);
            //check the address id 
            if (AnStock.DateAdded != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the reslut is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestShoesDescFound()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the metod 
            int ShoeNo = 1;
            //invoke find method
            Found = AnStock.Find(ShoeNo);
            //check the address id 
            if (AnStock.ShoesDesc != "High top")
            {
                OK = false;
            }
            //test to see that the reslut is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestShoesBrandFound()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the metod 
            int ShoesNo = 1;
            //invoke find method
            Found = AnStock.Find(ShoesNo);
            //check the address id 
            if (AnStock.ShoesBrand != "Nike")
            {
                OK = false;
            }
            //test to see that the reslut is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestShoesColourFound()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the metod 
            int ShoesNo = 1;
            //invoke find method
            Found = AnStock.Find(ShoesNo);
            //check the address id 
            if (AnStock.ShoesColour != "Black")
            {
                OK = false;
            }
            //test to see that the reslut is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the metod 
            int ShoesNo = 1;
            //invoke find method
            Found = AnStock.Find(ShoesNo);
            //check the address id 
            if (AnStock.Price != 59.99m)
            {
                OK = false;
            }
            //test to see that the reslut is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the metod 
            int ShoesNo = 1;
            //invoke find method
            Found = AnStock.Find(ShoesNo);
            //check the address id 
            if (AnStock.Available != 2)
            {
                OK = false;
            }
            //test to see that the reslut is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the metod 
            int ShoesNo = 1;
            //invoke find method
            Found = AnStock.Find(ShoesNo);
            //check the address id 
            if (AnStock.Active != true)
            {
                OK = false;
            }
            //test to see that the reslut is correct
            Assert.IsTrue(OK);

        }

    }
}

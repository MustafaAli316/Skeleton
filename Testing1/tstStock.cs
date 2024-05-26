using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstStock
    {

        //good test data
        //create some test data to pass the method
        string ShoesBrand = "Nike";
        string ShoesDesc = "high top";
        string ShoesColour = "Price";
        string Price = "59.99";
        string Available = "2";
        string DateAdded = DateTime.Now.ToShortDateString();

        [TestMethod] //d
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock); 
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method  
            Error = AnStock.Valid(DateAdded,ShoesBrand,ShoesDesc, ShoesColour, Price, Available);
            //test to see that the values are the same
            Assert.AreEqual(Error, "");
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



                /* TESTS FOR PARAMETERS*/



        [TestMethod]
        public void ShoesBrandMinLessOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string ShoesBrand = "";  //String might be wrong or string lower case 
            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoesBrandMin()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string ShoesBrand = "a";  //String might be wrong or string lower case 
            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoesBrandMinPlusone()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string ShoesBrand = "aa";  //String might be wrong or string lower case 
            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoesBrandMaxLessOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string ShoesBrand = "";
            ShoesBrand = ShoesBrand.PadRight(49, 'a');
            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ShoesBrandMax()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string ShoesBrand = "";
            ShoesBrand = ShoesBrand.PadRight(50, 'a');
            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoesBrandMid()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string ShoesBrand = "";
            ShoesBrand = ShoesBrand.PadRight(25, 'a');
            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ShoesBrandMaxPlusOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string ShoesBrand = "";
            ShoesBrand = ShoesBrand.PadRight(51, 'a');
            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");  // error comes up when on notequal 

        }

        [TestMethod]
        public void ShoesBrandExtremeMax()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";
            //create some test data to pass the method 
            string ShoesBrand = "";
            ShoesBrand = ShoesBrand.PadRight(500, 'a'); 
            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]

        public void DateAddedExtremeMin()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMin()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
           
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";

            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string c=variable to store any error message 
            String Error = "";

            //convert the date variable to a string variable
            string DateAdded = "This is not a date! ";

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ShoesDescMinLessOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string ShoesDesc = "";

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoesDescMin()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
        
            string ShoesDesc = "a";

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ShoesDescMinPlusOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesDesc = "aa";

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ShoesDescMaxLessOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesDesc = "";
            ShoesDesc = ShoesDesc.PadRight(49, 'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ShoesDescMax()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesDesc = "";
            ShoesDesc = ShoesDesc.PadRight(50, 'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoesDescMaxPlusOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesDesc = "";
            ShoesDesc = ShoesDesc.PadRight(51, 'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoesDescMid()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesDesc = "";
            ShoesDesc = ShoesDesc.PadRight(25, 'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void ShoesColourMinLessOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string ShoesColour = "";

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoesColourMin()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesColour = "a";

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ShoesColourMinPlusOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesColour = "aa";

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ShoesColourMaxLessOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesColour = "";
            ShoesColour = ShoesColour.PadRight(9, 'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ShoesColourMax()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesColour = "";
            ShoesColour = ShoesColour.PadRight(10, 'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoesColourMaxPlusOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesColour = "";
          

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoesColourMid()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string ShoesColour = "";
            ShoesColour = ShoesColour.PadRight(5, 'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string Price = "";

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string Price = "a";

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string Price = "aa";

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string Price = "";
            Price = Price.PadRight(17, 'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMax()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string Price = "";
            Price = Price.PadRight(18, 'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string Price = "";
            Price = Price.PadRight(19,'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an istance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message 
            String Error = "";

            string Price = "";
            Price = Price.PadRight(9, 'a');

            //invoke the method 
            Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }





    }
}


using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Testing5
{
    [TestClass]
    public class tstOrderCollection
    {
        public clsOrdersCollection Count { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //crete some data to assing the property to
            //in this case the data needs to be in a list of object
            List<clsOrders> TestList = new List<clsOrders>();
            //add item to the link
            //created the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.OrderID = 1;
            TestItem.ProductID = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Quantity = 1;
            TestItem.Total = 10;
            TestItem.CourierCompany = "evri";
            //add item to list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the 2 values are thesame
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }
        [TestMethod]
        public void ThisOrderPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //crete some data to assing the property to
            //add item to the link
            //created the item of test data
            clsOrders TestOrder = new clsOrders();
            //set its properties
            TestOrder.OrderCompleted = true;
            TestOrder.OrderID = 1;
            TestOrder.ProductID = 2;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.Quantity = 1;
            TestOrder.Total = 10;
            TestOrder.CourierCompany = "evri";
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the 2 values are thesame
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);


        }
        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //crete some data to assing the property to
            //in this case the data needs to be in a list of object
            List<clsOrders> TestList = new List<clsOrders>();
            //add item to the link
            //created the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.OrderID = 1;
            TestItem.ProductID = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Quantity = 1;
            TestItem.Total = 10;
            TestItem.CourierCompany = "evri";
            //add item to list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the 2 values are thesame
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create test datsa
            clsOrders TestItem = new clsOrders();
            //variable to store,,,
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.OrderID = 5;
            TestItem.ProductID = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Quantity = 1;
            TestItem.Total = 10;
            TestItem.CourierCompany = "evri";
            //set
            AllOrders.ThisOrder = TestItem;
            //add record
            PrimaryKey = AllOrders.Add();
            //set the primary key
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see they are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create test datsa
            clsOrders TestItem = new clsOrders();
            //variable to store,,,
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderCompleted = false;
            TestItem.OrderID = 1;
            TestItem.ProductID = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Quantity = 1;
            TestItem.Total = 10;
            TestItem.CourierCompany = "evri";
            //set
            AllOrders.ThisOrder = TestItem;
            //add record
            PrimaryKey = AllOrders.Add();
            //set the primary key
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete record
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see they are the same
            Assert.IsFalse(Found);

        }
        public void UpdateMethod()
        {
            //create an instance of the class we want to create 
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create test datsa
            clsOrders TestItem = new clsOrders();
            //variable to store,,,
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderCompleted = true;
            TestItem.OrderID = 1;
            TestItem.ProductID = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Quantity = 1;
            TestItem.Total = 10;
            TestItem.CourierCompany = "evri";
            //set
            AllOrders.ThisOrder = TestItem;
            //add record
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            TestItem.OrderCompleted = false;
            TestItem.ProductID = 6;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Quantity = 10;
            TestItem.Total = 100;
            TestItem.CourierCompany = "Royal Mail";
            //set
            //find the record
            AllOrders.ThisOrder = TestItem;
            //delete record
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see they are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

    }
}


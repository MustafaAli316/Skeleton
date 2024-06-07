using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private...
        List<clsOrders> mAddressList = new List<clsOrders>();
        //private...
        clsOrders mThisOrder = new clsOrders();
        public clsOrdersCollection()
        {
        //variable for the index
        Int32 Index = 0;
            //variable to store record count
            Int32 RecordCount = 0;
            //onject forthe data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectALL");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrders AnOrder = new clsOrders();
                //read in the fiels for the current record
                AnOrder.OrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderCompleted"]);
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrder.Total = Convert.ToInt32(DB.DataTable.Rows[Index]["Total"]);
                AnOrder.CourierCompany = Convert.ToString(DB.DataTable.Rows[Index]["CourierCompany"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                //add item to list
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;

            }

        }
        //private data member fornthe list
        List<clsOrders> mOrderList = new List<clsOrders>();
        public List<clsOrders> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the privat data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mOrderList.Count;
            }
            set
            {
               //we shall worry about thgis later
               
            }
        }

        public clsOrders ThisOrder
        {
            get
            {
                return mThisOrder;
            }

            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            mThisOrder.OrderID = 123;
            return mThisOrder.OrderID;
            //adds a record to the database
            /*   clsDataConnection DB = new clsDataConnection();
               //SET...
               DB.AddParameter("@OrderID", mThisOrder.OrderID);
               DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
               DB.AddParameter("@OrderCompleted", mThisOrder.OrderCompleted);
               DB.AddParameter("@Quantity", mThisOrder.Quantity);
               DB.AddParameter("@ProductID", mThisOrder.ProductID);
               DB.AddParameter("@Total", mThisOrder.Total);
               DB.AddParameter("@CourierCompany", mThisOrder.CourierCompany);

               return DB.Execute("sproc_tblOrder_Insert");
            */
        }
    }
}
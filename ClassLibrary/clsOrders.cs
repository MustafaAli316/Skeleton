using System;


namespace ClassLibrary
{
    public class clsOrders
    {
        public DateTime OrderDate { get; set; }
        public bool OrderCompleted { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public string CourierCompany { get; set; }
        public double Total { get; set; }
    }
}
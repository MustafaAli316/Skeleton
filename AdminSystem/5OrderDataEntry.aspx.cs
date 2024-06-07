using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;

    public int OrderID { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["AddressID"]);
        if(IsPostBack == false)
        {
            if(OrderId != -1)
            {
                DisplayOrder();
            }
        }
    }
    void DisplayOrder()
    {
        clsOrdersCollection Order = new clsOrdersCollection();

        Order.ThisOrder.Find(OrderId);
        txtOrderID.Text = Order.ThisOrder.OrderID.ToString();
        txtCourierCompany.Text = Order.ThisOrder.CourierCompany.ToString();
        txtOrderDate.Text = Order.ThisOrder.OrderDate.ToString();
        txtQuantity.Text = Order.ThisOrder.Quantity.ToString();
        txtProductID.Text = Order.ThisOrder.ProductID.ToString();
        txtTotal.Text = Order.ThisOrder.Total.ToString();
        chkOrderCompleted.Checked = Order.ThisOrder.OrderCompleted;

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtOrderID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of the class
        clsOrders AnOrder = new clsOrders();
        //capture the data
       
        String OrderDate = txtOrderDate.Text;
        String ProductID = txtProductID.Text;
        String Quantity = txtQuantity.Text;
        String CourierCompany = txtCourierCompany.Text;
        String Error = "";
        //validate data
        Error = AnOrder.Valid(OrderDate, ProductID, Quantity, CourierCompany);
        if(Error =="")
        {
            //capture the data
            AnOrder.OrderID = OrderID;
            AnOrder.ProductID = Convert.ToInt32(txtProductID.Text);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            AnOrder.Total = Convert.ToInt32(txtTotal.Text);
            AnOrder.CourierCompany = CourierCompany;
            AnOrder.OrderCompleted = chkOrderCompleted.Checked;
            clsOrdersCollection OrderList = new clsOrdersCollection();
            if(OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();

            }
       
            //redirect back to the liust page
            Response.Redirect("5OrderList.aspx");

            //Navigate to the view page
            Response.Redirect("5OrderViewer.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }



        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instqance of the address class
        clsOrders AnOrder = new clsOrders();
        //create a variable to store the primary key
        Int32 OrderID;
        //create a variable to nstorethe result of find
        Boolean Found = false;
        //get the primary key
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
           txtCourierCompany.Text = AnOrder.CourierCompany;
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtQuantity.Text = AnOrder.Quantity.ToString();
            txtProductID.Text = AnOrder.ProductID.ToString();
            txtTotal.Text = AnOrder.Total.ToString();
            chkOrderCompleted.Checked = AnOrder.OrderCompleted;
        }


    }

    protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {
      
        
    }
}
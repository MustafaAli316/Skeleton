using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        String OrderID =txtOrderID.Text;
        String OrderDate = txtOrderDate.Text;
        String ProductID = txtProductID.Text;
        String Quantity = txtQuantity.Text;
        String CourierCompany = txtCourierCompany.Text;
        String OrderCompleted = chkOrderCompleted.Text;
        String Total = txtTotal.Text;
        String Error = "";
        //validate data
        Error = AnOrder.Valid(OrderDate, ProductID, Quantity, CourierCompany);
        if(Error =="")
        {
            //capture the data
            AnOrder.ProductID = Convert.ToInt32(txtProductID.Text);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            AnOrder.CourierCompany = CourierCompany;
            Session["AnOrder"] = AnOrder;
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
}
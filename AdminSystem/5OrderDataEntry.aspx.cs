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
        clsOrders Anorder = new clsOrders();
        //capture the orderId
        Anorder.OrderID = Convert.ToInt32(txtOrderID.Text);
        //capture the order date    
        Anorder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        //capture the product Id
        Anorder.ProductID = Convert.ToInt32(txtProductID.Text);
        //capture the quantity
        Anorder.Quantity = Convert.ToInt32(txtQuantity.Text);
        //capture the total
        Anorder.Total = Convert.ToInt32(txtTotal.Text);
        //capture the order status
        Anorder.OrderCompleted = chkOrderCompleted.Checked;
        //capture the courier company
        Anorder.CourierCompany = txtCourierCompany.Text;
        //store the courier company in the session
        Session["AnOrder"] = Anorder;
        //Navigate to the view page
        Response.Redirect("5OrderViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}
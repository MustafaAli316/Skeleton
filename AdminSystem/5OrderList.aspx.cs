using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the listr box
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        clsOrdersCollection Orders = new clsOrdersCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "CourierCompany";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        //redirect
        Response.Redirect("5OrderDataEntry.aspx");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if(lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("5OrderDataEntry.aspx");
        }
        else
        {
            lblEror.Text = "Please select a record from the list to edit";
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if(lstOrderList.SelectedIndex != -1)
            {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"]= OrderID;
            Response.Redirect("5OrderConfirmDelete.aspx");

        }
        else
        {
            lblEror.Text = "Please select a record from the list to delete";
        }
    }
}

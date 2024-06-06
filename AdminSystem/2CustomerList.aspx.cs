using System;
using System.Activities;
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
        //if its the first time the page is displayed
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
        clsCustomerUser AnUser = new clsCustomerUser();
        AnUser = (clsCustomerUser)Session["AnUser"];
        Response.Write("Logged in as : " + AnUser.UserName);
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "FirstName";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerId"] = -1;
        //redirect to the data entry page
        Response.Redirect("2CustomerDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the PK value of the record to be edited
        Int32 CustomerId;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1) 
        {
            //get the pk value of the record to edit
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store into the session object 
            Session["CustomerId"] = CustomerId;
            //redirect to the data entry page
            Response.Redirect("2CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the recrod to be deleted
        Int32 CustomerId;
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record deleted
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerId"] = CustomerId;
            //redirect to the delete page
            Response.Redirect("2CustomerConfirmDelete.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }

    
    }


    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        //retrieve the value of firstname frpm presentation layer
        ACustomer.ReportByFirstName(txtFilter.Text);
        //set the data source to the list of first name
        lstCustomerList.DataSource = ACustomer.CustomerList;
        // set the name of primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the name of the field to display
        lstCustomerList.DataTextField = "FirstName";
        //bind the data to the list
        lstCustomerList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        //set an empty string 
        ACustomer.ReportByFirstName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data soucre to the list of customer collection
        lstCustomerList.DataSource = ACustomer.CustomerList;
        //set the name of the  primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the name of the field to display
        lstCustomerList.DataTextField = "FirstName";
        //bind the datato the list
        lstCustomerList.DataBind();
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
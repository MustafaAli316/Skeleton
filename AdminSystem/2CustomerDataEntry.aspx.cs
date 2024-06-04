using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the pk with page level scope
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false) 
        {
            //if this is not a new record
            if (CustomerId != -1) 
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    private void DisplayCustomer()
    {
        //create an instance of the customer
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerId);
        //display the data for the record
        txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
        txtFirstName.Text = CustomerBook.ThisCustomer.FirstName.ToString();
        txtLastName.Text = CustomerBook.ThisCustomer.LastName.ToString();
        txtDateOfBirth.Text = CustomerBook.ThisCustomer.DateOfBirth.ToString();
        txtAddress.Text = CustomerBook.ThisCustomer.Address.ToString();
        txtEmailAddress.Text = CustomerBook.ThisCustomer.EmailAddress.ToString();
        chkLoyalCustomer.Checked = CustomerBook.ThisCustomer.LoyalCustomer;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer id
        //string CustomerId = txtCustomerId.Text;
        //capture the customer first name
        string FirstName = txtFirstName.Text;
        //capture the customer first name
        string LastName = txtLastName.Text;
        //capture the customer date of birth
        String DateOfBirth = txtDateOfBirth.Text;
        //capture the customer email address
        string EmailAddress = txtEmailAddress.Text;
        //capture the customer Address
        string Address = txtAddress.Text;
        //capture the customer is that a loyal customer
        string LoyalCustomer = chkLoyalCustomer.Text;
        //variable to store any error messages
        String Error = "";
        //validate the data
        Error = ACustomer.Valid(FirstName, LastName, DateOfBirth, EmailAddress, Address);
        if (Error == "")
        {
            //capture the first name
            ACustomer.CustomerId = CustomerId;
            //capture the first name
            ACustomer.FirstName = FirstName;    
            //capture the last name
            ACustomer.LastName = LastName;
            //capture the date of birth
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //capture the Email address
            ACustomer.EmailAddress = EmailAddress;
            //capture the address
            ACustomer.Address = Address;
            //capture the address
            ACustomer.LoyalCustomer = chkLoyalCustomer.Checked;
            //create a new instance of the Customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            
            //if this is a new record
            if (CustomerId == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            else 
            {
                //find the record
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Update();
            }
            //navigate to the view page
            Response.Redirect("2CustomerList.aspx");
        }
        else 
        {
            //display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find opration
        Boolean Found = false;
        //get the primary key
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record 
        Found = ACustomer.Find(CustomerId);
        //if found
        if(Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = ACustomer.FirstName;
            txtLastName.Text = ACustomer.LastName;
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
            txtEmailAddress.Text = ACustomer.EmailAddress;
            txtAddress.Text = ACustomer.Address;
            chkLoyalCustomer.Checked = ACustomer.LoyalCustomer;
        }
    }
}
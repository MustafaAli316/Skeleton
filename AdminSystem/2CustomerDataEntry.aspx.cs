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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer id
        string CustomerId = txtCustomerId.Text;
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
            ACustomer.FirstName = FirstName;    
            //capture the last name
            ACustomer.LastName = LastName;
            //capture the date of birth
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //capture the Email address
            ACustomer.EmailAddress = EmailAddress;
            //capture the address
            ACustomer.Address = Address;
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //navigate to the view page
            Response.Redirect("2CustomerViewer.aspx");
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
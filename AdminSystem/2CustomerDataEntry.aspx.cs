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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer id
        ACustomer.CustomerId  = Convert.ToInt32(txtCustomerId.Text);
        //capture the customer first name
        ACustomer.FirstName = txtFirstName.Text;
        //capture the customer first name
        ACustomer.LastName = txtLastName.Text;
        //capture the customer email address
        ACustomer.EmailAddress = txtEmailAddress.Text;
        //capture the customer Address
        ACustomer.Address = txtAddress.Text;
        //capture the customer date of birth
        ACustomer.DateOfBirth = Convert.ToDateTime(DateTime.Now);
        //capture the customer is that a loyal customer
        ACustomer.LoyalCustomer = chkLoyalCustomer.Checked;
        //store the customer in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the view page 
        Response.Redirect("2CustomerViewer.aspx");
    }
}
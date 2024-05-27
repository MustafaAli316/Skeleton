using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 
       //create a new instance of clsCustomer
 clsCustomer ACustomer = new clsCustomer();
 //get the data from the session object
 ACustomer = (clsCustomer)Session["ACustomer"];
 //display the customer id for this entry
 Response.Write(ACustomer.CustomerId);
 //display the first name for this entry
 Response.Write(ACustomer.FirstName);
 //display the last name for this entry
 Response.Write(ACustomer.LastName);
 //display the date of birth for this entry
 Response.Write(ACustomer.DateOfBirth);
 //display the address for this entry
 Response.Write(ACustomer.Address);
 //display the email address for this entry
 Response.Write(ACustomer.EmailAddress);
 //display the loyal customer for this entry
 Response.Write(ACustomer.LoyalCustomer);

    }
}

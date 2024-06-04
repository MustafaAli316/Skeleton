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
        //create a new instance of clsSuppliers
        clsSuppliers AnSuppliers = new clsSuppliers();
        //capture the Suppliers Name
        AnSuppliers.Supplier_Name = txtSuppliersName.Text;
        //capture the Contact
        AnSuppliers.Contact_Number = txtContact.Text;
        //capture the Email
        AnSuppliers.Email = txtEmail.Text;
        //capture the Address
        AnSuppliers.Address = txtAddress.Text;
        //capture the Post Code
        AnSuppliers.Post_Code = txtPostCode.Text;
        //capture the City
        AnSuppliers.City = txtCity.Text;    
        //capture the Country 
        AnSuppliers.Country = txtCountry.Text;  
        //capture the Date Added
        AnSuppliers.DateAdded = Convert.ToDateTime(DateTime.Now);
        //capture Active CheckBox
        AnSuppliers.Active = chkActive.Checked;
        //store the address in the session object
        Session["AnSuppliers"] = AnSuppliers;
        //navigate to the view page
        Response.Redirect("4SuppliersViewer.aspx");
    }
}
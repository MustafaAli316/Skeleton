using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsSuppliers
        clsSuppliers AnSuppliers = new clsSuppliers();
        //get the data from the session object
        AnSuppliers = (clsSuppliers)Session["AnSuppliers"];
        //display the Suppliers Name for this entry
        Response.Write(AnSuppliers.Supplier_Name);
        //display the Contact for this entry
        Response.Write(AnSuppliers.Contact_Number);
        //display the Email for this entry
        Response.Write(AnSuppliers.Email);
        //display the Address for this entry
        Response.Write(AnSuppliers.Address);
        //display the Post Code for this entry
        Response.Write(AnSuppliers.Post_Code);
        //display the City for this entry
        Response.Write(AnSuppliers.City);
        //display the Country for this entry
        Response.Write(AnSuppliers.Country);
        //display the DateAdded for this entry
        Response.Write(AnSuppliers.DateAdded);
        //display the Check Active for this entry
        Response.Write(AnSuppliers.Active);


    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be delected
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be delected from the session object
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection class
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //find the record to delete
        CustomerList.ThisCustomer.Find(CustomerId);
        //delect the record
        CustomerList.Delete();
        //redirct back to main page
        Response.Redirect("2CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to main page
        Response.Redirect("2CustomerList.aspx");
    }

}
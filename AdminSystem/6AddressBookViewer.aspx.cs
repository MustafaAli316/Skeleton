﻿using System;
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
        //create an instanc eo clsStock
        clsStock AnStock = new clsStock();
        //get the data from the session object 
        AnStock = (clsStock)Session["AnStock"];
        //display the house number for this entry 
        Response.Write(AnStock.ShoesBrand);
    }
}
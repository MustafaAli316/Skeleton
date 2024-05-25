using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         
         
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();

        //capture the Shoe Brand
        String ShoesBrand = txtShoesBrand.Text;
        //capture the Shoe Desc
        String ShoesDesc = txtShoesDesc.Text;
        //capture the shoes colour
        String ShoesColour = txtShoesColour.Text;
        //capture the price 
        String Price = txtPrice.Text;
        //capture availability 
        String Available = txtAvaiable.Text;
        //capture active
        String Active = chkActive.Text;
        //capture dateAdded 
        String DateAdded = txtDateAdded.Text;

        //variable to store any error messages
        String Error = "";
        //validate the error


        ///commented errors


        //Error.AnStock.Valid(ShoesBrand, ShoesDesc, ShoesColour, Price, Available, DateAdded);

        //if (Error - "")
        //{


        //    //capture the Shoe Brand
        //    ShoesBrand = txtShoesBrand.Text;
        //    //capture the Shoe Desc
        //    ShoesDesc = txtShoesDesc.Text;
        //    //capture the shoes colour
        //    ShoesColour = txtShoesColour.Text;
        //    //capture the price 
        //    Price = Convert.ToDecimal(txtPrice.Text);
        //    //capture availability 
        //    Available = Convert.ToInt32(txtAvaiable.Text);
        //    //capture dateAdded 
        //    DateAdded = Convert.ToDateTime(DateTime.Now);

        //    //store the stock in the session object
        //    Session["AnStock"] = AnStock;
        //    //navigate to the view page
        //    Response.Redirect("6AddressBookViewer.aspx");
        //}
    }
} 
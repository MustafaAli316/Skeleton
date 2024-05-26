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
        string ShoesBrand = txtShoesBrand.Text;
        //capture the Shoe Desc
        string ShoesDesc = txtShoesDesc.Text;
        //capture the shoes colour
        string ShoesColour = txtShoesColour.Text;
        //capture the price 
        string Price = txtPrice.Text;
        //capture availability 
        string Available = txtAvaiable.Text;
        //capture active
        string Active = chkActive.Text;
        //capture dateAdded 
        string DateAdded = txtDateAdded.Text;



        //variable to store any error messages
        string Error = "";
        //validate the errors

        Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);

        if(Error == "")
        {
            //capture 
            AnStock.ShoesBrand = ShoesBrand;
            //capture 
            AnStock.ShoesDesc = ShoesDesc;
            //Capture 
            AnStock.ShoesColour = ShoesColour;
            //capture 
            //AnStock.Price = Price;
            //capture 
            AnStock.DateAdded = Convert.ToDateTime(DateAdded);

            //Store the address in the session object 
            Session["AnStock"] = AnStock;
            //navigate to view page 
            Response.Redirect("6AddressBookViewer.aspx");
           

        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }
} 
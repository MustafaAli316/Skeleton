using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ShoesNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        ShoesNo = Convert.ToInt32(Session["ShoesNo"]);
        if (IsPostBack == false)
        {
            //if this is ot a new record
            if (ShoesNo != -1)
            {
                DisplayStock();
            }
        }
    }

    void DisplayStock() {
        //create an instance of the address book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update
        StockBook.ThisStock.Find(ShoesNo);
        //display the data for the record
        txtShoesNo.Text = StockBook.ThisStock.ShoesNo.ToString();
        txtShoesBrand.Text = StockBook.ThisStock.ShoesBrand.ToString();
        txtShoesDesc.Text = StockBook.ThisStock.ShoesDesc.ToString();
        txtShoesColour.Text = StockBook.ThisStock.ShoesColour.ToString();
        txtDateAdded.Text = StockBook.ThisStock.DateAdded.ToString();
        txtPrice.Text = StockBook.ThisStock.Price.ToString();
        txtAvaiable.Text = StockBook.ThisStock.Available.ToString();
      

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
       // string Active = chkActive.Text;
        //capture dateAdded 
        string DateAdded = txtDateAdded.Text;



        //variable to store any error messages
        string Error = "";
        //validate the errors

        Error = AnStock.Valid(DateAdded, ShoesBrand, ShoesDesc, ShoesColour, Price, Available);

        if(Error == "")
        {
            //capture the shoesNO
            AnStock.ShoesNo = ShoesNo;
            //capture 
            AnStock.ShoesBrand = ShoesBrand;
            //capture 
            AnStock.ShoesDesc = ShoesDesc;
            //Capture 
            AnStock.ShoesColour = ShoesColour;
            //capture 
            AnStock.Price = Convert.ToDecimal(Price);
            //capture 
            AnStock.DateAdded = Convert.ToDateTime(DateAdded);
            //capture active
          
            //create a new instance 
            clsStockCollection StockList = new clsStockCollection();

            if (ShoesNo == -1)
            {
                StockList.ThisStock = AnStock;
                //add the new record 
                StockList.Add();


            }
            else
            {
                //find the record to updte
                StockList.ThisStock.Find(ShoesNo);
                //set the this stock propery
                StockList.ThisStock = AnStock;
                //update the record
                StockList.Update();
            }

            //redirect to the list page 
            Response.Redirect("6AddressBookList.aspx");

        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }





 

  

    //protected void btnFind_Click(object sender, EventArgs e)
    //{
    //    //create an instace of class
    //    clsStock AnStock = new clsStock();
    //    //create varaibe 
    //    Int32 ShoesNo;
    //    //create a var to store resilts of find operation 
    //    Boolean Found = false;
    //    //get pk entered by the uer
    //    ShoesNo = Convert.ToInt32(txtShoesNo.Text);
    //    //FIDN RECORD
    //    Found = AnStock.Find(ShoesNo);
    //    //if found
    //    if( Found == true )
    //    {
    //        //displau values
    //        txtShoesDesc.Text = AnStock.ShoesDesc;

    //    }

    //}

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instace of class
        clsStock AnStock = new clsStock();
        //create varaibe 
        Int32 ShoesNo;
        //create a var to store resilts of find operation 
        Boolean Found = false;
        //get pk entered by the uer
        ShoesNo = Convert.ToInt32(txtShoesNo.Text);
        //FIDN RECORD
        Found = AnStock.Find(ShoesNo);
        //if found
        if (Found == true)
        {
            //displau values
            txtShoesBrand.Text = AnStock.ShoesBrand;
            txtShoesDesc.Text = AnStock.ShoesDesc;
            txtShoesColour.Text = AnStock.ShoesColour;
            txtDateAdded.Text = AnStock.DateAdded.ToString();
            txtPrice.Text = AnStock.Price.ToString();
            txtAvaiable.Text = AnStock.Available.ToString();

        }
    }
} 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false )
        {
            DisplayStocks();
        }

        clsStockUser AnUser = new clsStockUser();
        AnUser = (clsStockUser)Session["AnUser"];
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayStocks()
    {
        //create an instance of the stock collection 
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to the list of addresses in the collection 
        lstStockList.DataSource = Stock.StockList;
        //SET THE NAME OF TH EPRIMARY KEY
        lstStockList.DataValueField = "ShoesNo";
        //set the data field to display 
        lstStockList.DataTextField = "ShoesDesc";
        //bind the data to the list 
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicte this is a new record 
        Session["ShoesNo"] = -1;
        //redirect to the data entry page 
        Response.Redirect("6AddressBookDataEntry.aspx");
    }




    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to sore the pk value of  record to be edited 
        Int32 ShoesNo;
        //if a record has been selected from the list 
        if(lstStockList.SelectedIndex  !=-1 )
        {
            //get the pk value of the record o edit
            ShoesNo = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data im te session object
            Session["ShoesNo"] = ShoesNo;
            //redirect to the edit page 
            Response.Redirect("6AddressBookDataEntry.aspx");
        }
        else
        {
            //if no record jas ben selected
            lblError.Text = "Please select a record from the list to edit";
        }


    }

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the pk value of the record to be deleted
        Int32 ShoesNo;
        //if  a record has been selected from the list
        if(lstStockList.SelectedIndex !=-1)
        {
            //get the pk value of the record delete
            ShoesNo = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ShoesNo"] = ShoesNo;
            //redirect to the delete page 
            Response.Redirect("6AddressBookConfirmDelete.aspx");
        }
        else //if no record is selected
        {
            //display an error message 
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create instace of the address object
        clsStockCollection AnStock = new clsStockCollection();
        //retrieve value
        AnStock.ReportbyProductName(txtShoesDescription.Text);
        //set data source to the lst
        lstStockList.DataSource = AnStock.StockList;
        //set the name of pk
        lstStockList.DataValueField = "ShoesNo";
        //set the name of field to display 
        lstStockList.DataTextField = "ShoesDesc";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create instace of the address object
        clsStockCollection AnStock = new clsStockCollection();
        //retrieve value
        AnStock.ReportbyProductName("");
        //clear any existing filter 
        txtShoesDescription.Text = "";
        lstStockList.DataSource = AnStock.StockList;
        lstStockList.DataValueField = "ShoesNo";
        lstStockList.DataTextField = "ShoesDesc";
        lstStockList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("6AddressBookLogin.aspx");
    }
}
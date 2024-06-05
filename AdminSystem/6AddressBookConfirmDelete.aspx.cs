using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ShoesNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        ShoesNo = Convert.ToInt32(Session["ShoesNo"]);
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(ShoesNo);
        StockBook.Delete();



        Response.Redirect("6AddressBookList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("6AddressBookList.aspx");
    }
}
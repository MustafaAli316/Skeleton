using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _6AddressBookLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance
        clsStockUser AnUser = new clsStockUser();
        //create variables
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create var to store results
        Boolean Found = false;
        //get the username
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        //find record
        Found = AnUser.FindUser(UserName, Password);
        Session["AnUser"] = AnUser;
        //if username is empty or pass
        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a Username";
        }
        else if(txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password";
        }
        else if(Found == true)
        {
            Response.Redirect("6AddressBookList.aspx");
        }
        else if(Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again!";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnLogin_Click1(object sender, EventArgs e)
    {
        
    }
}
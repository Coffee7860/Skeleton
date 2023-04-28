using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed3_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer=new clsCustomer();

        Int32 Customer_Id;

        Boolean Found=false;

        Customer_Id = Convert.ToInt32(txtCustomerId.Text);

        Found = ACustomer.Find(Customer_Id);

        if (Found==true)
        {
            txtFirstName.Text = ACustomer.FirstName;
            txtLastName.Text = ACustomer.LastName;
            txtEmail.Text = ACustomer.Email;
            txtPassword.Text = ACustomer.Password;
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Creating a new instance of clsOrders
        clsCustomer Acustomer = new clsCustomer();

        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string EmailId = txtEmail.Text.ToString();
        string Address=txtEmail.Text;  
        string Password = txtPassword.Text;
        string PhoneNumber=txtPhoneNumber.Text;
        string Date = DateTime.Now.Date.ToString();
        int Customer_Id=Convert.ToInt32(txtCustomerId.Text);
        string Error = "";

        //Validate the data
        Error = Acustomer.Valid(FirstName, LastName, EmailId,Address,Password, PhoneNumber,Date);
        if (Error == "")
        {
            Acustomer.FirstName = FirstName;
            Acustomer.LastName = LastName;
            Acustomer.DateJoined = Convert.ToDateTime(Date);
            Acustomer.Address = Address; 
            Acustomer.Password = Password;
           


            //create A new instance Of the Order Collection.
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new Record (OrderNumber = -1 then add the data)
            if (Customer_Id == -1)
            {
                //set the thisOrderProperty
                CustomerList.ThisCustomer = Acustomer;
                //Add the new record
                CustomerList.Add();
            }
            //else it must be an update
            else
            {
                //find the record to update 
                CustomerList.ThisCustomer.Find(Customer_Id);
                //Set The ThisOrder Property
                CustomerList.ThisCustomer = Acustomer;
                //Update the Record
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //Display The Error Message
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerDataEntry.aspx");
    }
}
}
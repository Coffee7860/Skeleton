using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{ //varible to store the primary key value of the record to be deleted
    Int32 StaffId;
    //event handler for the page load
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order to be deleted from the session object
        StaffId = Convert.ToInt32(Session["StaffId"]);

    }

    protected void Yes_Click(object sender, EventArgs e)
    {
        //create a new instance of the order class
        clsStaffCollection staff = new clsStaffCollection();

        //find the record to delete
        staff.ThisStaff.Find(StaffId);
        //Delete the record using primary key
        staff.Delete();

        //Redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }


    protected void No_Click(object sender, EventArgs e)
    {
        //Redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}
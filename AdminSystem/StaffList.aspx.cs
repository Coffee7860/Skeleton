using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order To be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new a record
            if (StaffId != -1)
            {
                //display the current data for the record selected.
                DisplayStock();
            }
        }
    }
    void DisplayStock()
    {
        //create an instance of the Order Collection.
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to list of Order in the collection.
        ListBox1.DataSource = Staff.StaffList;
        //set the name of the primary key.
        ListBox1.DataValueField = "StaffId";
        //set the data field to display
        ListBox1.DataTextField = "LastName";
        //bind the data to the list.
        ListBox1.DataBind();
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        //redirect  to the data entry page 
        Response.Redirect("StaffDataEntry.aspx");
    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffId;
        //if the record has been selected from the list
        if (ListBox1.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit the record.
            StaffId = Convert.ToInt32(ListBox1.SelectedValue);
            //store the data in the session Object.
            Session["StaffId"] = StaffId;
            //Redirect to the edit Page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            //If no record is selected then it will diplay error.
            Label1.Text = "Please Select A record To edit From the List";
        }
    }
}
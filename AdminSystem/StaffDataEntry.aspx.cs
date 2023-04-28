using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private readonly int StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();

        string FirstName = TextBox2.Text;

        string LastName = TextBox3.Text;

        string ContactNum = TextBox4.Text;

        string Address = TextBox5.Text;

        string JoinDate = TextBox6.Text;

        //string StaffId = TextBox1.Text;

        //Variable to store Any Error Message
        string Error = "";

        //Validate the data
        Error = staff.Valid(FirstName, JoinDate);
        if (Error == "")
        {

            staff.StaffId = Convert.ToInt32(StaffId);

            staff.FirstName = FirstName;

            staff.LastName = LastName;

            staff.ContactNum = ContactNum;

            staff.Address = Address;

            staff.JoinDate = Convert.ToDateTime(JoinDate); ;

            staff.StaffAvailableStatus = No.Checked;

            //create A new instance Of the Staff Collection.
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new Record (OrderNumber = -1 then add the data)
            if (StaffId == -1)
            {
                //set the thisstaffProperty
                StaffList.ThisStaff = staff;
                //Add the new record
                StaffList.Add();
            }
            //else it must be an update
            else
            {
                //find the record to update 
                StaffList.ThisStaff.Find(StaffId);
                //Set The Thisstaff Property
                StaffList.ThisStaff = staff;
                //Update the Record
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //Display The Error Message
            Label7.Text = Error;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockDataEntry.aspx");
    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(TextBox1.Text);
        Found = staff.Find(StaffId);
        if (Found == true)
        {
            TextBox1.Text = staff.StaffId.ToString();
            TextBox2.Text = staff.FirstName.ToString();
            TextBox3.Text = staff.LastName.ToString();
            TextBox4.Text = staff.ContactNum.ToString();
            TextBox5.Text = staff.Address.ToString();
            No.Checked = staff.StaffAvailableStatus;
            TextBox5.Text = staff.JoinDate.ToString();
        }
    }
}
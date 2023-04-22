using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //new instance of clsSupplier
        clsSupplier supplier = new clsSupplier();
        //capture the SupplierID
        string CompanyName = txtCompanyName.Text;
        string CompanyAddress = txtCompanyAddress.Text;
        string ContactNumber = txtContactNumber.Text;
        string OrderDate = txtOrderDate.Text;
        string UnitCost = txtUnitCost.Text;
        string Error = "";
        Error = supplier.Valid(CompanyName, CompanyAddress, ContactNumber, OrderDate);
        if (Error == "")
        {
            supplier.CompanyName = CompanyName;
            supplier.CompanyAddress = CompanyAddress;
            supplier.ContactNumber = ContactNumber;
            supplier.UnitCost = Convert.ToInt32(UnitCost);
            supplier.OrderDate = Convert.ToDateTime(OrderDate);
            supplier.Location = chkLocationLocal.Checked;

            //store the CompanyName in the session
            Session["supplier"] = supplier;
            //navigate to the viewer page
            Response.Redirect("SupplierViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}
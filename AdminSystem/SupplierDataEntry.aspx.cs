using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier supplier = new clsSupplier();
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
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            if (SupplierId == -1)
            {
                SupplierList.ThisSupplier = supplier;
                SupplierList.Add();
            }
            else 
            {
                SupplierList.ThisSupplier.Find(SupplierId);
                SupplierList.ThisSupplier = supplier;
                SupplierList.Update();
            }
            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

        /*clsSupplier supplier = new clsSupplier();
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
        }*/
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier supplier = new clsSupplier();
        Int32 SupplierId;
        Boolean Found = false;
        SupplierId = Convert.ToInt32(txtSupplierID.Text);
        Found = supplier.Find(SupplierId);
        if (Found == true) 
        {
            txtCompanyName.Text = supplier.CompanyName;
            txtCompanyAddress.Text = supplier.CompanyAddress;
            txtContactNumber.Text = supplier.ContactNumber;
            txtUnitCost.Text = supplier.UnitCost.ToString();
            txtOrderDate.Text = supplier.OrderDate.ToString();
            chkLocationLocal.Checked = supplier.Location;

        }
    }
    void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ThisSupplier.Find(SupplierId);
        txtSupplierID.Text = Suppliers.ThisSupplier.SupplierId.ToString();
        txtCompanyName.Text = Suppliers.ThisSupplier.CompanyName;
        txtCompanyAddress.Text = Suppliers.ThisSupplier.CompanyAddress;
        txtContactNumber.Text = Suppliers.ThisSupplier.ContactNumber;
        txtUnitCost.Text = Suppliers.ThisSupplier.UnitCost.ToString();
        txtOrderDate.Text = Suppliers.ThisSupplier.OrderDate.ToString();
        chkLocationLocal.Checked = Suppliers.ThisSupplier.Location;
    }
}
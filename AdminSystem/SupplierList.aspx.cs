using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
        if (IsPostBack == false)
        {
            if (SupplierId != -1) 
            {
                DisplaySuppliers();
            }
            
        }

    }
    void DisplaySuppliers() 
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierId";
        lstSupplierList.DataTextField = "CompanyAddress";
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierId;
        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierId"] = SupplierId;
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else 
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierId;
        if (lstSupplierList.SelectedIndex != -1) 
        {
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierId"] = SupplierId;
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
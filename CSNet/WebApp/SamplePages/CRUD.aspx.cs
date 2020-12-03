﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
#endregion

namespace WebApp.SamplePages
{
    public partial class CRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        protected Exception GetInnerException(Exception ex)
        {
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            return ex;
        }



        protected void Clear_Click(object sender, EventArgs e)
        {
            ProductID.Text = "";
            ProductName.Text = "";
            CategoryList.SelectedIndex = 0;
            SupplierList.SelectedIndex = 0;
            QuantityPerUnit.Text = "";
            UnitPrice.Text = "";
            Discontinued.Checked = false;
            UnitsOnOrder.Text = "";
            //UnitsInStock.Text = "";
            ProductArg.Text = "";
            ProductList.DataSource = null;
            ProductList.DataBind();
        }

        protected void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //determine the select GridView Row
                //this obtains a pointer to the selected row
                GridViewRow agvrow = ProductList.Rows[ProductList.SelectedIndex];
                HiddenField aPointerToControl = agvrow.FindControl("ProductID") as HiddenField;
                //fields from the gridview are returned as a string
                string hiddenfieldvalue = aPointerToControl.Value;
                //convert the string value to a numeric
                int productid = int.Parse(hiddenfieldvalue);
                //above 3 lines of code could be combined
                //int productid = int.Parse((agvrow.FindControl("ProductID") as HiddenField).Value);

                ProductController sysmgr = new ProductController();
                Product info = sysmgr.Product_FindByID(productid);
                if (info == null)
                {
                    MessageLabel.Text = "Product not currently on file. Refresh your search";
                    //fast way to empty fields, use an event method already coded
                    Clear_Click(sender, e);
                }
                else
                {
                    ProductID.Text = info.ProductID.ToString();
                    ProductName.Text = info.ProductName;
                    CategoryList.SelectedValue = info.CategoryID.HasValue ?
                        info.CategoryID.ToString() : "0";
                    SupplierList.SelectedValue = info.CategoryID.HasValue ?
                        info.CategoryID.ToString() : "0";
                    QuantityPerUnit.Text = info.QuantityPerUnit.ToString();
                    UnitPrice.Text = string.Format("{0:0.00}", info.UnitPrice);
                    UnitsOnOrder.Text = info.UnitsOnOrder.ToString();
                    Discontinued.Checked = info.Discontinued;
                }
            }
            catch (Exception ex)
            {
                MessageLabel.Text = GetInnerException(ex).Message;
            }
        }

        protected void SearchProduct_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ProductArg.Text))
            {
                MessageLabel.Text = "You require a value for the search";
            }
        }
    }
}
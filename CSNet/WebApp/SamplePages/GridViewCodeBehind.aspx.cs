﻿using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class GridViewCodeBehind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected Exception GetInnerException(Exception ex)
        {
            while(ex.InnerException != null)
            { 
                ex = ex.InnerException; 
            }
            return ex;
        }
        protected void SearchProduct_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ProductArg.Text))
            {
                MessageLabel.Text = "Enter a product name (or portion of) then press search";
            }
            else
            {
                try
                {
                    ProductController sysmgr = new ProductController();
                    List<Product> info = sysmgr.Product_GetByPartialProductName
                        (ProductArg.Text);
                    if(info.Count> 0)
                    {
                        ProductList.DataSource = info;
                        ProductList.DataBind();
                    }
                    else
                    {
                        MessageLabel.Text = "No Products match your search Value";
                        //to empty Gridview
                        ProductList.DataSource = null;
                        ProductList.DataBind();
                    }

                }
                catch(Exception ex)
                {
                    MessageLabel.Text = GetInnerException(ex).Message;
                }
            }

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            ProductID.Text = "";
            ProductName.Text = "";
            UnitPrice.Text = "";
            Discontinued.Checked = false;
            ProductArg.Text = "";
            ProductList.DataSource = null;
            ProductList.DataBind();
        }
        protected void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //determine the select GridView Row
                // this obtains a pointer to the selected row
                GridViewRow agvrow = ProductList.Rows[ProductList.SelectedIndex];
                HiddenField aPointerToControl = agvrow.FindControl("ProductID") as HiddenField;

                //fields from the gridview all returned as a sting
                string hiddenfieldvalue = aPointerToControl.Value ;
                //convert the string value to a numeric
                int productid = int.Parse(hiddenfieldvalue);
                //above 3 lines of code could be combined
                //int  productid = int.Parse((agvrow.FindControl("ProductID") as HiddenField).Value);

                ProductController sysmgr = new ProductController();
                Product info  = sysmgr.Product_FindByID(productid);
                if(info == null)
                {
                    MessageLabel.Text = "Enter a product name (or portion of) then press search";
                    Clear_Click(sender, e);
                }
                else
                {
                    ProductID.Text = info.ProductID.ToString();
                    ProductName.Text = info.ProductName;
                    UnitPrice.Text = string.Format("{0:0.00}", info.UnitPrice);
                    Discontinued.Checked = info.Discontinued;

                }

            }
            catch (Exception ex)
            {
                MessageLabel.Text = GetInnerException(ex).Message;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional namespace
using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
#endregion
namespace WebApp.SamplePages
{
    public partial class SimpleQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        protected void RegionSearch_Click(object sender, EventArgs e)
        {
            
            //veryfiy, you have input
            if (string.IsNullOrEmpty(RegionArg.Text))
            {
                MessageLabel.Text = "Enter a Region ID";
            }
            else
            {
                // I am assuming that a number as been entered,
                //  this should be validated
                //standard lookup
                // connec to controller CLASS by creating an instance
                RegionController sysmgr = new RegionController();
                    //issue your call to the class instance
                    NorthwindSystem.Entities.Region info = sysmgr.Region_FindByID(int.Parse(RegionArg.Text));
                //test result and either dis[lay record or appropriate message
                if(info == null)
                {
                    MessageLabel.Text = "No region supplied value";
                }
                else
                {
                    RegionID.Text = info.RegionID.ToString();
                    RegionDescription.Text = info.RegionDescription;
                }

            }
        }
    }
}
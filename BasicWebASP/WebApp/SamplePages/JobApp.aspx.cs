using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class JobApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string msg = "";
            msg += "Name: " + Fullname.Text;
            msg += "Email: " + EmailAddress.Text;
            msg += "Phone: " + Phone.Text;
            msg += "Time: " + (FullOrPartTime.SelectedValue== "1" ? "Full time" :
                                FullOrPartTime.SelectedValue == "2" ? "Part time" : "Either");

            // handle the checkBoxList
            // traverse the checkbox list, review one otwm
            //      at a time and add those items selected to te message
            // if not items were choosen, then an appropriate message
            //      stating that no items were chosen

            msg += "Jobs: ";

            //set my found flag "nothing found (false)
            bool found = false;

            //loop processing, if something is found then
            //      set the found flag to true
            foreach (ListItem jobrow in Jobs.Items)
            {
                // for each item in the collection
                if (jobrow.Selected)
                {
                    msg += jobrow.Text + "";
                    found = true;
                }
            }

            // CHECK IF NOTHING WAS FOUND
            if (!found)
            {
                msg += "You did not select a job. Application rejected.";
            }

            MessageLabel.Text = msg;
        }
        
        protected void Clear_Click(object sender, EventArgs e)
        {
            Fullname.Text = "";
            EmailAddress.Text = "";
            Phone.Text = "";
            // for List there a couple of ways to reset
            //a) manually rest the control SelectIndex to -1
            FullOrPartTime.SelectedIndex = -1;
            //b) use a control
            Jobs.ClearSelection();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PressMe_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(firstName.Text))
            {
                OutputArea.Text = "Please enter your firstname";
            }
            else
            {
                OutputArea.Text = "welcome " + firstName.Text;
            }
        }
    }
}
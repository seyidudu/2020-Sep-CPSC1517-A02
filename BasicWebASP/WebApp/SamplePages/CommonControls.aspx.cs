using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class CommonControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // this method executes BEFORE any event method on 
            //      EACH processing of this web page

            // this is a great place to do common code that is
            //  required on EACH process of the page
            // Example: empty out old messages
            MessageLabel.Text = "";

            //this is an excellent place  to do a page initialization
            //  of control for the 1st time
            // checking the 1st time for this page uses the post back flag
            // IsPostBack is a boolean value (true or false)
            if(!Page.IsPostBack)
            {
                //if the page is not post back. It means that this 
                //      is the first time the page has been displayed
                // you can do page initialization

                //create a collection of instances (class objectas)
                //  that will be used to load the dropdownlist
                // this will simulate the loading of the control
                //      as if the data came from the database table
                // each instance will represent a record on the 
                // database dataset.
                // to accomplish this simulation, we will create a
                // class and use it with the LIst<T>
                // the <T> in this example is the class DDLData
                List<DDLData> DDLCollection = new List<DDLData>();
                DDLCollection.Add(new DDLData(1, "COMP1008"));
                DDLCollection.Add(new DDLData(2, "DMIT1508"));
                DDLCollection.Add(new DDLData(3, "DMIT2018"));
                DDLCollection.Add(new DDLData(4, "CPSC1517"));


                // sorting a List<T>
                //(x,y) are olace holders representing any 2 records at any 
                // given time during the sort
                // => (lamdda symbol) is part of the delegate syntax and I suggest that you read this symbol as "do the foLlowing"
                // comparing x to y is ascending
                // comparing y to x is descending
                DDLCollection.Sort((x,y) => x.DisplayText.CompareTo(y.DisplayText));
                //place the data into the dropdownlist control
                // 3 steps to this proces

                // a) assign the data collcetion to the control
                CollectionList.DataSource = DDLCollection;

                // b) in thbis step, you will assign value that you will
                //      display to the user and the value that you will be 
                //      asssociated and reurn from the control when
                //      the user picks a particular selection
                // in the <select> control, this data was setup using the <option>
                //      <option value="xxx"> display string </option>

                // 2 styles in the seeting up the control valuess
                //a) physical string of the field name

                CollectionList.DataValueField = "ValueId";
                //b) OOP style coding
                CollectionList.DataTextField = nameof(DDLData.DisplayText);

                // 3 bind your data source to your control
                CollectionList.DataBind();

                // 4 optional is to add a prompt list yo your dropdownlist
                CollectionList.Items.Insert(0, new ListItem("select..."));            }
        }

        protected void SubmitNumberChoice_Click(object sender, EventArgs e)
        {
            //validation checking i have gfood data for my choice
            int numberchoice = 0;           if (string.IsNullOrEmpty(NumberChoice.Text))
            {
                MessageLabel.Text = "Enter a number from 1 to 4";
            }
           else if (!int.TryParse(NumberChoice.Text, out numberchoice))
            {
                MessageLabel.Text = "Invalid number! Enter a number from 1 to 4";
            }
            else if(numberchoice < 1 || numberchoice > 4)
            {
                MessageLabel.Text = "Number is out of range! Enter a number from 1 to 4";
            }
            else
            {
                //goog inout data
                // RadioButtonList
                // assign a value to the RadioButtonList to indicate the item choice
                //      based in the input data value
                // this can be done through either: . SelectedValue or .SelecteINdex
                // .SelectedValue will match the control item to the arguement (BEST TO USE)
                // .SelectedIndex selects the control item to show based on the mumerical
                //      index value (For PHYSICAL POSITIONING ONLY)
                RadioButtonListChoice.SelectedValue = numberchoice.ToString();
                //RadioButtonListChoice.SelectedValue = numberchoice.ToString();

                //set th checkbox
                if (numberchoice == 2 || numberchoice == 4)
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }
                //position in CollectionList on the selected item row
                // this can be done through either: . SelectedValue or .SelecteINdex
                // .SelectedValue will match the control item to the arguement (BEST TO USE)
                // .SelectedIndex selects the control item to show based on the mumerical
                //      index value (For PHYSICAL POSITIONING ONLY)
                CollectionList.SelectedValue = numberchoice.ToString();

                //acess data from the CollectionList and display in the ReadOnly Label
                // this can be done through either: . SelectedValue or .SelecteIndex
                // or .Selected Item
                // .SelectedValue will return the value associatred with the select item
                //      from the dropdownlist (is a value)
                // .SelectedIndex will return the index of row  selected in the
                //      dropdownlist (is the physical index positon of the row
                // .SelectedItem will return the index of row  selected in the
                //      dropdownlist (is the physical index positon of the row
                //      index value (For PHYSICAL POSITIONING ONLY)

                DisplayReadOnly.Text = CollectionList.SelectedItem.Text +
                                      " at index " + CollectionList.SelectedIndex +
                                      " having a value of " + CollectionList.SelectedValue +
                                      ". This matches the radio button choice item value " +
                                      RadioButtonListChoice.SelectedValue;
            }
        }
    }
}
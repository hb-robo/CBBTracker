using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBBTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            string prospectName = prospectNameTextBox.Text;
            string statName = statNameTextBox.Text;

            string result = "You have requested the " + statName + " of " + prospectName;

            resultLabel.Text = result;
        }
    }
}
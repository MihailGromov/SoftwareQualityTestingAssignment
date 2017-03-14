using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestForSelenium
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string gender = tbxGender.Text;
            int age = Convert.ToInt32(tbxAge.Text);

            Customer c = new Customer();

            lblResult.Text = (c.CalcPremium(age, gender)).ToString();
        }
    }
}
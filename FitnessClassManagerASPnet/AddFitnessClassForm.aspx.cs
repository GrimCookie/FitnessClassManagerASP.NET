using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessClassManagerASPnet
{
    public partial class AddFitnessClassForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public FitnessClassOpportunity GetData()
        {
            //stores the data from the form into a new class to be passed to the main page
            DateTime startDate = new DateTime(calStartDate.SelectedDate.Year, calStartDate.SelectedDate.Month, calStartDate.SelectedDate.Day);
            DateTime time = Convert.ToDateTime(txtTime.Text);
            return new FitnessClassOpportunity(txtId.Text, txtDescription.Text, txtLocation.Text, Convert.ToInt32(txtSpaces.Text), cboDay.SelectedItem.ToString(), time, Convert.ToInt32(txtDuration.Text), chkMultiWeek.Checked, startDate, txtNumSessions.Text);
        }

        protected void calStartDate_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        protected void chkMultiWeek_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkMultiWeek.Checked)
            {
                txtNumSessions.Enabled = true;
                txtNumSessions.Text = "";
            }
            else
            {
                txtNumSessions.Text = "N/A";
                txtNumSessions.Enabled = false;
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            //session state contains the get data methods retuned new FitnessClassOpportunity
            Session["FitnessClassOpportunity"] = GetData();
            Response.Redirect("~/FitnessClassManagerMain.aspx");

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //return the session state variable as null as nothing is being added
            Session["FitnessClassOpportunity"] = null;
            Response.Redirect("~/FitnessClassManagerMain.aspx");
        }
    }
}
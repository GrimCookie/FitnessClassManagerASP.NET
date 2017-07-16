using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FitnessClassManagerASPnet
{
    public partial class AddFitnessClassForm : Form
    {
        public AddFitnessClassForm()
        {
            InitializeComponent();
        }

        public FitnessClassOpportunity GetData()
        {
            DateTime startDate = new DateTime(dtpStartDate.Value.Year, dtpStartDate.Value.Month, dtpStartDate.Value.Day);
            DateTime time = dtpTime.Value;
            return new FitnessClassOpportunity(txtId.Text, txtDescription.Text, txtLocation.Text, Convert.ToInt32(txtSpaces.Text), cboDay.SelectedItem.ToString(), time, Convert.ToInt32(txtDuration.Text), chkMultiWeek.Checked, startDate, txtNumSessions.Text);
        }

        private void AddFitnessClassForm_Load(object sender, EventArgs e)
        {
            cboDay.SelectedIndex = 0;
        }

        private void chkMultiWeek_CheckedChanged(object sender, EventArgs e)
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

        private void cboDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

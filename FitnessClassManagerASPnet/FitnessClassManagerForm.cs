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
    public partial class FitnessClassManagerForm : Form, IFitnessClassManagerUI
    {
        FitnessClassList fitnessClassList;

        public FitnessClassManagerForm()
        {
            InitializeComponent();
        }

        private void btnRunReports_Click(object sender, EventArgs e)
        {
            RunReportAll();
            RunReportDay();
            RunReportLocation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fitnessClassList = new FitnessClassList();
            cboDay.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFitnessClass();
        }

        private void UpdateListbox()
        {
            lstFitnessClasses.Items.Clear();

            for (int i = 0; i < fitnessClassList.Count(); i++)
            {
                lstFitnessClasses.Items.Add(fitnessClassList.getFitnessClass(i));
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveFitnessClass();
        }

        public void RunReportAll()
        {
            TextReportGenerator trg = new TextReportGenerator(fitnessClassList);
            trg.GenerateAllReport("report_all.txt");
        }

        public void RunReportDay()
        {
            TextReportGenerator trg = new TextReportGenerator(fitnessClassList);
            trg.GenerateDayReport("report_day.txt", cboDay.SelectedItem.ToString());
        }

        public void RunReportLocation()
        {
            TextReportGenerator trg = new TextReportGenerator(fitnessClassList);
            trg.GenerateLocationReport("report_location.txt", txtLocation.Text);
        }

        public void SaveData()
        {
            SerializeFileHandler sr = new SerializeFileHandler();
            sr.WriteFitnessClassListToFile(fitnessClassList, "data.dat");
        }

        public void LoadData()
        {
            SerializeFileHandler sr = new SerializeFileHandler();
            fitnessClassList = sr.ReadFitnessClassListFromFile("data.dat");
            UpdateListbox();
        }

        public void AddFitnessClass()
        {
            AddFitnessClassForm frm = new AddFitnessClassForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fitnessClassList.addFitnessClass(frm.GetData());

                    UpdateListbox();
                }
                catch (DuplicateIdException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        public void RemoveFitnessClass()
        {
            fitnessClassList.removefitnessClass((FitnessClassOpportunity)lstFitnessClasses.SelectedItem);

            UpdateListbox();
        }
    }
}

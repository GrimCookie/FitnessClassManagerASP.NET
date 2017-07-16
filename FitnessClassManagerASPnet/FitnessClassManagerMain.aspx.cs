using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessClassManagerASPnet
{
    public partial class FitnessClassManagerMain : System.Web.UI.Page, IFitnessClassManagerUI
    {
        Global gbl = new Global();
        FitnessClassList fitnessClassList;

        protected void Page_Load(object sender, EventArgs e)
        {
            fitnessClassList = (FitnessClassList)Session["FitnessClassList"];
            
            //checks tat the fitness class opportunity coming from the add form isn't null
            //so that it dosent run into a null refernce exepton
            if (Session["FitnessClassOpportunity"] != null)
            {
                if (Session["FitnessClassList"] != null)
                {

                    AddFitnessClass();

                }

                //sets the clas that is being handed over to be null
                //allows another to be added
                Session["FitnessClassOpportunity"] = null;

            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //send the browser to the add form
            Response.Redirect("~/AddFitnessClassForm.aspx");
        }

        protected void brnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void btnRunReports_Click(object sender, EventArgs e)
        {
            //runs all reports with one button click
            RunReportAll();
            RunReportDay();
            RunReportLocation();

        }

        public void RunReportAll()
        {
            TextReportGenerator trg = new TextReportGenerator(fitnessClassList);
            trg.GenerateAllReport(Server.MapPath("report_all.txt"));
        }
        public void RunReportDay()
        {
            TextReportGenerator trg = new TextReportGenerator(fitnessClassList);
            trg.GenerateDayReport(Server.MapPath("report_day.txt"), cboDay.SelectedItem.ToString());
        }
        public void RunReportLocation()
        {
            TextReportGenerator trg = new TextReportGenerator(fitnessClassList);
            trg.GenerateLocationReport(Server.MapPath("report_location.txt"), txtLocation.Text);
        }

        public void SaveData()
        {
            SerializeFileHandler sfh = new SerializeFileHandler();
            sfh.WriteFitnessClassListToFile(fitnessClassList, Server.MapPath("~/data.dat"));
        }
        public void LoadData()
        {
            SerializeFileHandler sfh = new SerializeFileHandler();
            Session["FitnessClassList"] = sfh.ReadFitnessClassListFromFile(Server.MapPath("~/data.dat"));


            //UpdateListBox();
            UpdateListBox();
        }

        public void AddFitnessClass()
        {

            try
            {
                fitnessClassList.addFitnessClass((FitnessClassOpportunity)Session["FitnessClassOpportunity"]);
            }
            catch (DuplicateIdException exception)
            {
                lblAlert.Text = (exception.Message);
            }
            finally
            {
                UpdateListBox();
            }

        }
        public void RemoveFitnessClass()
        {
            //var selectedValue = lstFitnessClasses.SelectedValue;

            //var item = lstBox.Where(x => x.SomeKeyValue == selectedValue).Single();

            //lstFitnessClasses.Remove(item);

            //lstFitnessClasses
            //fitnessClassList.RemoveFitnessClass(lstFitnessClasses.SelectedValue);
            //fitnessClassList

            //UpdateListBox();
        }

        public void UpdateListBox()
        {
            //updates the contense of the list box so changes can be seen
            lstFitnessClasses.Items.Clear();

            for (int i = 0; i < fitnessClassList.Count(); i++)
            {
                lstFitnessClasses.Items.Add(fitnessClassList.getFitnessClass(i).ToString());
            }

        }



    }
}
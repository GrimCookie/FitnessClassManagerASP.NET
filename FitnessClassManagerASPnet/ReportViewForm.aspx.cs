using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessClassManagerASPnet
{
    public partial class ReportViewForm : System.Web.UI.Page
    {

        private FitnessClassList AllReportList = new FitnessClassList();
        private FitnessClassList DayReportList = new FitnessClassList();
        private FitnessClassList LocationReportList = new FitnessClassList();
        //report_location.txt

        protected void Page_Load(object sender, EventArgs e)
        {

            LoadReports(AllReportList, "~/report_all.txt", lstAll);
        
        }

        private void LoadReports(FitnessClassList reportList, String file, ListBox listBox)
        {
            SerializeFileHandler sfh = new SerializeFileHandler();
            reportList = sfh.ReadFitnessClassListFromFile(Server.MapPath(file));


            //UpdateListBox();
            UpdateListBox(listBox, reportList);
        }

        private void UpdateListBox(ListBox listBox, FitnessClassList reportList)
        {
            listBox.Items.Clear();

            for (int i = 0; i < reportList.Count(); i++)
            {
                listBox.Items.Add(reportList.getFitnessClass(i).ToString());
            }
        }

    }
}
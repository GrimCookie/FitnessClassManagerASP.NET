using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace FitnessClassManagerASPnet
{
    class TextReportGenerator : IReportGenerator
    {
        public readonly FitnessClassList fitnessClassList;

        public TextReportGenerator(FitnessClassList fitnessClassList)
        {
            this.fitnessClassList = fitnessClassList;
        }

        public void GenerateAllReport(String filePath)
        {
            CreateReport(filePath, FitnessClassListSorterFilterer.SortById(fitnessClassList));
        }

        public void GenerateDayReport(String filePath, String selectedDay)
        {
            CreateReport(filePath, FitnessClassListSorterFilterer.FilterDay(fitnessClassList, selectedDay));
        }

        public void GenerateLocationReport(String filePath, String selectedLocation)
        {
            CreateReport(filePath, FitnessClassListSorterFilterer.FilterLocation(fitnessClassList, selectedLocation));
        }

        private void CreateReport(String filePath, FitnessClassList fitnessClassList)
        {
            FileStream outFile;
            StreamWriter writer;

            outFile = new FileStream(filePath, FileMode.Create,
                                     FileAccess.Write);
            writer = new StreamWriter(outFile);

            for (int i=0; i < fitnessClassList.Count(); i++)
            {
                FitnessClassOpportunity f = fitnessClassList.getFitnessClass(i);

                // output fitness class opportunity details
                writer.WriteLine(f.ToString());
            }

            // close writer
            writer.Close();

            // close file
            outFile.Close();
        }
        private void ReadReport(String filePath, FitnessClassList fitnessClassList)
        {
            //FileStream inFile;
            //StreamReader reader;
            //String fileRecord;
            //String[] fileFields;

            //// open file and attach to streamreader
            //inFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //reader = new StreamReader(inFile);
            //List<String> reportItem = new List<String>();
            //string DELIM = Environment.NewLine;

            //// get first record from stream
            //fileRecord = reader.ReadLine();

            //for (int i = 0; fileRecord != null; i++)
            //{
            //    //while (fileRecord != null)
            //    //{

            //    // split record into fields
            //    fileFields[i] = fileRecord.Split(DELIM);

            //   // FitnessClassOpportunity FCO = (FitnessClassOpportunity)fileFields;

            //    // set form properties
            //    fitnessClassList.addFitnessClass((FitnessClassOpportunity)fileFields[i]);
            //}

            //// close streamreader and file
            //reader.Close();
            //inFile.Close();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessClassManagerASPnet
{
    interface IReportGenerator
    {
        void GenerateAllReport(String filePath);
        void GenerateDayReport(String filePath, String selectedDay);
        void GenerateLocationReport(String filePath, String selectedDay);
    }
}

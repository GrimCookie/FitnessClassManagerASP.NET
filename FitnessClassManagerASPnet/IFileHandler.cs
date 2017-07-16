using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessClassManagerASPnet
{
    interface IFileHandler
    {
        void WriteFitnessClassListToFile(FitnessClassList fitnessClassList, String filePath);
        FitnessClassList ReadFitnessClassListFromFile(String filePath);
    }
}

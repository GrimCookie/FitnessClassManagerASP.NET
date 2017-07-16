using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessClassManagerASPnet
{
    class FitnessClassListSorterFilterer
    {
        public static FitnessClassList SortById(FitnessClassList fitnessClassList)
        {
            FitnessClassList sortedFitnessClassList = new FitnessClassList();

            for (int i = 0; i < fitnessClassList.Count(); i++)
            {
                sortedFitnessClassList.addFitnessClass(fitnessClassList.getFitnessClass(i));
            }

            sortedFitnessClassList.Sort();

            return sortedFitnessClassList;
        }

        public static FitnessClassList FilterDay(FitnessClassList fitnessClassList, String selectedDay)
        {
            FitnessClassList filteredFitnessClassList = new FitnessClassList();

            for (int i = 0; i < fitnessClassList.Count(); i++)
            {
                if (fitnessClassList.getFitnessClass(i).Day == selectedDay)
                {
                    filteredFitnessClassList.addFitnessClass(fitnessClassList.getFitnessClass(i));
                }
            }

            return filteredFitnessClassList;
        }

        public static FitnessClassList FilterLocation(FitnessClassList fitnessClassList, String selectedLocation)
        {
            FitnessClassList filteredFitnessClassList = new FitnessClassList();

            for (int i = 0; i < fitnessClassList.Count(); i++)
            {
                if (fitnessClassList.getFitnessClass(i).Location == selectedLocation)
                {
                    filteredFitnessClassList.addFitnessClass(fitnessClassList.getFitnessClass(i));
                }
            }

            return filteredFitnessClassList;
        }
    }
}

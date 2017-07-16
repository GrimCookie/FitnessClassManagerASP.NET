using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessClassManagerASPnet
{
    [Serializable]
    class FitnessClassList
    {
        private List<FitnessClassOpportunity> fitnessClassList;

        public FitnessClassList()
        {
            fitnessClassList = new List<FitnessClassOpportunity>();
        }

        public void addFitnessClass(FitnessClassOpportunity fitnessClassOpportunity)
        {
            //Make sure a class with this id does not already exist

            foreach (FitnessClassOpportunity f in fitnessClassList)
            {
                if (f.Id == fitnessClassOpportunity.Id)
                {
                    throw new DuplicateIdException();
                }
            }

            fitnessClassList.Add(fitnessClassOpportunity);
        }

        public void removeFitnessClass(int index)
        {
            fitnessClassList.RemoveAt(index);
        }

        public void removefitnessClass(FitnessClassOpportunity fitnessClassOpportunity)
        {
            fitnessClassList.Remove(fitnessClassOpportunity);
        }

        public FitnessClassOpportunity getFitnessClass(int index)
        {
            return fitnessClassList[index];
        }

        public int Count()
        {
            return fitnessClassList.Count;
        }

        public void Sort()
        {
            fitnessClassList.Sort();
        }
    }
}

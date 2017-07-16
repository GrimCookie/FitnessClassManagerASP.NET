using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessClassManagerASPnet
{
    class DuplicateIdException : Exception
    {
        private static String msg = "Duplicate id numbers not allowed";

        public DuplicateIdException()
            : base(msg)
        {
        }
    }
}

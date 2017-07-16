using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessClassManagerASPnet
{
    [Serializable]
    public class FitnessClassOpportunity : IComparable<FitnessClassOpportunity>
    {
        private String id;

        public String Id
        {
          get { return id; }
          set { id = value; }
        }

        private String description;
        private String location;

        public String Location
        {
            get { return location; }
            set { location = value; }
        }

        private int spaces;
        private String day;

        public String Day
        {
            get { return day; }
            set { day = value; }
        }

        private DateTime time;
        private int duration;
        private bool multiWeek;

        public bool MultiWeek
        {
            get { return multiWeek; }
            set { multiWeek = value; }
        }

        private DateTime startDate;
        private String numSessions;

        public FitnessClassOpportunity(String id,
                                    String description,
                                    String location,
                                    int spaces,
                                    String day,
                                    DateTime time,
                                    int duration,
                                    bool multiWeek,
                                    DateTime startDate,
                                    String numSessions)
        {
            this.id = id;
            this.description = description;
            this.location = location;
            this.spaces = spaces;
            this.day = day;
            this.time = time;
            this.duration = duration;
            this.multiWeek = multiWeek;
            this.startDate = startDate;
            this.numSessions = numSessions;
        }

        public override string ToString()
        {
            String str;
            String strTime;

            strTime = String.Format("{0:hh:mm}", time);

            String multiWeekString;

            if (multiWeek)
            {
                multiWeekString = "Yes";
            }
            else
            {
                multiWeekString = "No";
            }

            str = String.Format("Id: {0}; Description: {1}; Location: {2}; Spaces: {3}; Day: {4}; Time: {5}; Duration: {6}; Multi-week: {7}; Start Date: {8}; Number of sessions: {9}",
                                    id,
                                    description,
                                    location,
                                    spaces,
                                    day,
                                    strTime,
                                    duration,
                                    multiWeekString,
                                    startDate.Date.ToShortDateString(),
                                    numSessions);
            return str;
        }

        public int CompareTo(FitnessClassOpportunity fitnessClass)
        {
            return this.Id.CompareTo(fitnessClass.Id);
        }
    }
}

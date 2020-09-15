using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    /**
     * I'm not sure I want to stick with ints for time, so I'm putting all time methods in a static class so that if changes need
     * to be made in the future, they can almost all be made in one place
     */ 
    class TimeMethods
    {
        //max and min times for running the algorithm, this will be input by the user as a date/time range for scheduling
        DateTime min;
        DateTime max;

        public TimeMethods(DateTime beginningTime, DateTime endTime)
        {
            min = beginningTime;
            max = endTime;
        }
        /*
         *startTime 1 is the start time of the first availability endTime is the end of the first availability 
         * and startTime2 is the start of the second availability. If startTime2 is between startTime1 + 1 hour (minimum shift) and endTime there should be an edge
         * between availability 1 and 2
         */
        public bool shouldMakeEdge(DateTime startTime1, DateTime endTime, DateTime startTime2)
        {
            bool edge = false;
            //the adds and subtracts here guarantee a minimum shift of an hour and gives whomever comes next a 30 minute range of time as leeway
            if ((startTime1.AddHours(1) <= startTime2) && (startTime2 <= endTime))
            {
                edge = true;
            }
            return edge;
        }

        public DateTime getMaxTime()
        {
            //time is measured with an int representing an increment of 15 minutes, in a 2 week period, there are 1344 15 minute periods
            //so the time range is 0-1343
            //  return 1343;
            return max;
        }
        public DateTime getMinTime()
        {
            return min;
        }
    }
}

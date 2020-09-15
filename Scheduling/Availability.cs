using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class Availability
    {
        private Person person;
        private DateTime sTime;
        private DateTime eTime;
        //higher tiers coorespond to lower levels of availability I.E if tier is 0, they are available, if the tier is 1 they are avaialable only if necessary
        private int tier; 

        public Availability(Person p, DateTime s, DateTime e, int t)
        {
            person = p;
            sTime = s;
            eTime = e;
            tier = t;
        }

        public DateTime getStartTime()
        {
            return sTime;
        }
        public DateTime getEndTime()
        {
            return eTime;
        }
        public int getPersonID()
        {
            return person.getID();
        }
        public int getTier()
        {
            return tier;
        }
    }
}

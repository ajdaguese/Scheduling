using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class Person
    {
        int userID;
        string name;
        public Person(int id, string n)
        {
            userID = id;
            name = n;
        }
        public int getID()
        {
            return userID;
        }
    }
}

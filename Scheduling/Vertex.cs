using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    class Vertex
    {
        private List<Vertex> outgoingEdges;
        private List<Vertex> incomingEdges;
        //a list of tuples, each tuple contains an int for a persons id number and an int containing the number of times they have been assigned a shift
        private List<Tuple<int, int>> numTimesScheduled;
        //start time and end time are done in 15 minute increments, they are between 0 and 671, one for each 15 minute increment
        //in a week
        private Availability avail;
        //pathValue keeps track of the length from the start vertex to this one, it will be initalized to max int unless this is the start vertex
        private int pathValue;
        private Vertex previousVertex;
        //Tells whether or not this vertex has yet been visited in the current run
        private bool visited;

        public Vertex(Availability a)
        {
            avail = a;
            visited = false;
            previousVertex = null;
            //initializing my lists
            outgoingEdges = new List<Vertex>();
            incomingEdges = new List<Vertex>();
        }
        public void addIncoming(Vertex e)
        {
            incomingEdges.Add(e);
        }
        public void addOutgoing(Vertex e)
        {
            outgoingEdges.Add(e);
        }
        public List<Vertex> getIncoming()
        {
            return incomingEdges;
        }
        public List<Vertex> getOutgoing()
        {
            return outgoingEdges;
        }
        public DateTime getStartTime()
        {
            return avail.getStartTime();
        }
        public DateTime getEndTime()
        {
            return avail.getEndTime();
        }
        public int getPersonID()
        {
            return avail.getPersonID();
        }
        public int getTier()
        {
            return avail.getTier();
        }
        public bool hasEdge(Vertex v)
        {
            return outgoingEdges.Contains(v) || incomingEdges.Contains(v);
        }
        public void setPathValue(int val)
        {
            pathValue = val;
        }
        public int getPathValue()
        {
            return pathValue;
        }
        public void setTimesScheduled(List<Tuple<int, int>> timeList)
        {
            numTimesScheduled = timeList;
        }
        public List<Tuple<int, int>> getTimesScheduled()
        {
            return numTimesScheduled;
        }
        public void setVisited(bool visit)
        {
            visited = visit;
        }
        public bool getVisited()
        {
            return visited;
        }
        public void setPrevVertex(Vertex v)
        {
            previousVertex = v;
        }
        public Vertex getPrevVertex()
        {
            return previousVertex;
        }
    }
}

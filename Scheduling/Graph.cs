using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scheduling
{
    class Graph
    {
        List<Vertex> vertices;
        TimeMethods time;
        public Graph(List<Availability> avails, TimeMethods t)
        {
            vertices = new List<Vertex>();
            time = t;
           foreach(Availability a in avails)
            {
                vertices.Add(new Vertex(a));
            }
            createGraph();
        }

        private void createGraph()
        {
            foreach(Vertex v1 in vertices)
            {
                foreach(Vertex v2 in vertices)
                {
                    if(makeEdge(v1,v2) && !v1.hasEdge(v2) && !v1.Equals(v2))
                    {
                        v1.addOutgoing(v2);
                        v2.addIncoming(v1);
                    }
                }
            }
        }
        private bool makeEdge(Vertex v1, Vertex v2)
        {
            return time.shouldMakeEdge(v1.getStartTime(), v1.getEndTime(), v2.getStartTime());
        }
        /*
         * This method runs dijkstras algorithm from every start node to every end node to find the best path. Could take some time, the algorithm worst case runtime
         * should be O((V+E)^2), hopefully our data is small enough that it only takes a few minutes to run, I am unsure if there is a more efficient way to complete this
         */ 
        public List<Vertex> makeSchedule()
        {
            //we set the inital int to maxValue, each run of the algorithm we will check if the path length we found is less than currentPathLength, if it is updated the variable
            //If we initalize the currentPathLength to 0 it will think 0 is the size of the best path and never update.
            int currentPathLength = Int32.MaxValue;
            //this will be the best schedule with the first node being the first person scheduled and the last node being the last person scheduled
            //Currently if person B is assigned to start a shift before person A is finished, they will both be present until person A's end time
            List<Vertex> bestPath = null;
            //This should only do the vertices where startTime = 0, though I do not fully understand the syntax
            foreach(Vertex v in from v in vertices where v.getStartTime() == time.getMinTime() select v)
            {
                //sets the pathValues in each vertex to the correct starting value
                initalizeVertices(v);
                //run dijkstra's algorithm
                Tuple<List<Vertex>, int> path = dijkstras(v);
                if (path.Item2 < currentPathLength)
                {
                    currentPathLength = path.Item2;
                    bestPath = path.Item1;
                }
            }
            return bestPath;
        }
        /*
         * initalizes the vertices before running dijkstra's algorithm. All vertices will be initalized to max int except for the start vertex which will be 0
         */
        private void initalizeVertices(Vertex startVertex)
        {
            foreach(Vertex v in vertices)
            {
                //refreshes the timesScheduled to empty for the next run of the algorithm
                v.setTimesScheduled(new List<Tuple<int, int>>());
                //this will be for a new run of the algorithm, so no vertex should be considered visited
                v.setVisited(false);
                if(!v.Equals(startVertex))
                {
                    v.setPathValue(Int32.MaxValue);
                }
                else
                {
                    v.setPathValue(0);
                }
            }
        }
        /**
         * This is Dijkstra's algorithm, except we find the edge weights as we go. Edges for this program are avalibility tier * 2 + the number of times the person potentially
         * being scheduled has worked. tier can be either 0 or 1 (currently) with 1 being only available if need be, if an availability is tier 1, it is equal to that person
         * having worked twice before in the current schedule. This change to Dijkstra's requires some more keeping track of data. Each object needs to know how many times
         * each person has worked in its shortest path 
         */ 
        private Tuple<List<Vertex>, int> dijkstras(Vertex start)
        {
            //list of vertices that we have seen, but are not finalized. geeksforgeeks.org suggests running dijkstra's algorithm until we have visted every vertex
            //but there is a high chance we will have multiple vertices with no incoming edges, so I am using a working set instead
            List<Vertex> workingSet = new List<Vertex>();
            //set of vertices that are finalized
            List<Vertex> sptSet = new List<Vertex>();
            workingSet.Add(start);
            while(workingSet.Count > 0)
            {
                Console.WriteLine("Running");
                //the index of the value in workingSet that has the shortest path
                int indexOfShortestPath = 0;
                //this loop finds the index of the vertex with the shortest path in workingSet
                for (int i = 0; i < workingSet.Count; i++)
                {
                    if (workingSet[i].getPathValue() < workingSet[indexOfShortestPath].getPathValue())
                    {
                        indexOfShortestPath = i;
                    }
                }
                foreach(Vertex v in workingSet[indexOfShortestPath].getOutgoing())
                {
                    //first we add this new vertex to the workingSet if it has not been visited. If it has been visited, it should already be in the working set
                    if(!v.getVisited())
                    {
                        workingSet.Add(v);
                        v.setVisited(true);
                    }
                    //second we need to find the number of times the person in the vertex we are looking at has worked
                    int personID = v.getPersonID();
                    bool IDExists = false;
                    //the index of the person we are looking for in the list
                    int personIndex = -1;
                    int timesWorked = 0;
                    //This loop checks if the person is already in the list meaning they have a number of times worked greater than 0. If they do, update the relevant variables
                    //from their initalized state and break the loop
                    for (int i = 0; i < workingSet[indexOfShortestPath].getTimesScheduled().Count; i++)
                    {
                        if(personID == workingSet[indexOfShortestPath].getTimesScheduled()[i].Item1)
                        {
                            IDExists = true;
                            timesWorked = workingSet[indexOfShortestPath].getTimesScheduled()[i].Item2;
                            personIndex = i;
                            break;
                        }
                    }
                    int edge = timesWorked + (v.getTier() * 2);
                    //if this new path is shorter than the current path, update the vertex
                    if((workingSet[indexOfShortestPath].getPathValue() + edge) < v.getPathValue())
                    {
                        v.setPathValue(workingSet[indexOfShortestPath].getPathValue() + edge);
                        v.setPrevVertex(workingSet[indexOfShortestPath]);
                        List<Tuple<int, int>> newList = deepCopyTupleList(workingSet[indexOfShortestPath].getTimesScheduled());
                        if(IDExists)
                        {
                            newList[personIndex] = new Tuple<int, int>(v.getPersonID(), newList[personIndex].Item2 + 1);
                        }
                        else
                        {
                            //if this person is not yet in the list, add them to the list with the number of times worked being 1
                            newList.Add(new Tuple<int, int>(v.getPersonID(), 1));
                        }
                        v.setTimesScheduled(newList);
                    }
                }
                //adds this node to the final set, removing it from the working set
                sptSet.Add(workingSet[indexOfShortestPath]);
                workingSet.RemoveAt(indexOfShortestPath);
            }
            int shortestPathVal = Int32.MaxValue;
            Vertex currVert = null;
            //this loop determines the shortest path to an end from the start vertex of this algorithm 
            foreach(Vertex v in from v in vertices where v.getEndTime() == time.getMaxTime() select v)
            {
                if(v.getPathValue() < shortestPathVal)
                {
                    shortestPathVal = v.getPathValue();
                    currVert= v;
                }
            }
            //a tuple containg a list of vertices that is the ideal path where index 0 is the first scheduled person and the final index is the final scheduled person
            //and an int containing the shortest path value. Tuples cannot be updated, so the list has to be made before setting the tuple
            Tuple<List<Vertex>, int> pathStats;
            List<Vertex> path = new List<Vertex>();
            path.Add(currVert);
            while(currVert.getPrevVertex() != null)
            {
                currVert = currVert.getPrevVertex();
                path.Insert(0, currVert);
            }
            pathStats = new Tuple<List<Vertex>, int>(path, shortestPathVal);
            return pathStats;
        }

        private List<Tuple<int, int>> deepCopyTupleList(List<Tuple<int, int>> orig)
        {
            List<Tuple<int, int>> newList = new List<Tuple<int, int>>();
            foreach(Tuple<int, int> t in orig)
            {
                newList.Add(new Tuple<int, int>(t.Item1, t.Item2));
            }
            return newList;
        }
    }
}

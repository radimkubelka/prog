using System;

namespace GraphPlayground
{
    internal class Program
    {
        public static void DFS(Graph graph, Node startNode, Node targetNode = null)
        {
            Node currentnode = startNode;
            startNode.visited = true;
            while (true)
            {
                Console.WriteLine("jsem v uzlu " + currentnode.index);
                Node neighborToVisit = null;
                foreach (Node neighbor in currentnode.neighbors)
                {
                    if (!neighbor.visited)
                    {
                        neighborToVisit = neighbor;
                        break;
                    }
                }
                if (neighborToVisit == null)    //všichni sousedi navštíveni
                {
                    if (currentnode == startNode)
                    {
                        Console.WriteLine("jsem ve startovacím uzlu a nemám kam jít. Komčím DFS");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Jsem ve slepé uličce a vracím se z uzlu "+ currentnode.index + " do uzlu " + currentnode.cameFrom.index);
                        currentnode = currentnode.cameFrom;
                    }
                }
                else    //přejdu do nenavštívené nody
                {
                    Console.WriteLine("Jdu z uzlu "+ currentnode.index + " do nenavštíveného souseda " + neighborToVisit.index);
                    neighborToVisit.visited = true;
                    neighborToVisit.cameFrom = currentnode;
                    currentnode = neighborToVisit;
                }
            }
        }

        public static void BFS(Graph graph, Node startNode, Node targetNode = null) 
        {
            
        }

        static void Main(string[] args)
        {
            //Create and print the graph
            Graph graph = new Graph();
            graph.PrintGraph();
            graph.PrintGraphForVisualization();

            //Call both algorithms with a random starting node
            Random rng = new Random();
            DFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);
            BFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);

            Console.ReadKey();
        }
    }
}

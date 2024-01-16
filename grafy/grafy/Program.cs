﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    internal class Program
    {
        class Node
        {
            private int index;
            private List<Node> neighbors;
            public Node(int index)
            {
                this.index = index;
                neighbors = new List<Node>();
            }
            public void AddNeighbor(Node node)
            {
                if (neighbors.Contains(node))
                {
                    Console.WriteLine("Node " + node.index + " is already neighbor of " + index);
                }
                else
                {
                    neighbors.Add(node);
                    //node.AddNeighbor(this);     tím když přidám 4 k 1 tak se přidá 1 ke 4
                    Console.WriteLine($"Added {node.index} to the neighbors of {index}");
                }
                
            }
            public int GetIndex()       //index můžu číst ale ne přenastavit
            {
                return index;
            }
            public int[] GetNeighborsIndices()
            {
                int[] indices = new int[neighbors.Count];
                for (int i = 0; i< neighbors.Count; i++)
                {
                    indices[i] = neighbors[i].index;
                }
                return indices;
            }
            public Node MoveToNeighbor(int index)
            {
                foreach (Node neighbor in neighbors)
                {
                    if (neighbor.index == index)
                    {
                        return neighbor;
                    }
                }
                Console.WriteLine("Node " + index + " is not a neighbor of " + this.index);
                return this;
            }
        }
        static void Main(string[] args)
        {
            /* sousedi
             * 1 - 4, 6
             * 2 - 3, 5, 6
             * 3 - 2, 5
             * 4 - 1, 6
             * 5 - 2, 3
             * 6 -1, 2, 4
            */

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            node1.AddNeighbor(node4);
            node1.AddNeighbor(node6);

            node2.AddNeighbor(node3);
            node2.AddNeighbor(node5);
            node2.AddNeighbor(node6);

            node3.AddNeighbor(node2);
            node3.AddNeighbor(node5);

            node4.AddNeighbor(node1);
            node4.AddNeighbor(node6);

            node5.AddNeighbor(node2);
            node5.AddNeighbor(node3);

            node6.AddNeighbor(node1);
            node6.AddNeighbor(node2);
            node6.AddNeighbor(node4);


            Node currentnode = node1;

            while (true/*= pojede do nekonečna*/)
            {
                Console.WriteLine("Current node: " + currentnode.GetIndex());
                Console.WriteLine("Neighbors: ");
                foreach (int neighborIndex in currentnode.GetNeighborsIndices())
                {
                    Console.Write(neighborIndex + " ");
                }
                Console.Write("\n");
                Console.WriteLine("Choose where to go.");
                int desiredneighbor = int.Parse(Console.ReadLine());
                currentnode = currentnode.MoveToNeighbor(desiredneighbor);
                Console.WriteLine();
            }


        } 
    }
}

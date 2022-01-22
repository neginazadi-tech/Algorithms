using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm
{
    //implementing Dijkstra by proirity queue (implementing by binary MaxHeap) and weighted graph
    public class DijkstraAlgorithm
    {
        public class Node
        {
            public string Val { get; set; }
            public int Priority { get; set; }
            public Node(string val, int priority)
            {
                this.Val = val;
                this.Priority = priority;
            }
        }
        //max heap binary
        //public class PriorityQueue
        //{
        //    Queue<Node> _values;
        //    public PriorityQueue(Queue<Node> values)
        //    {
        //        _values = values;
        //    }

        //    public void Enqueue(string val, int priority)
        //    {
        //        var newNode = new Node(val, priority);
        //        _values.Enqueue(newNode);
        //        BubbleUp();
        //    }

        //    private void BubbleUp()
        //    {
        //        var len = _values.Dequeue();
                

        //        throw new NotImplementedException();
        //    }
        //}
    }
}

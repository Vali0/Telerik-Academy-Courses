using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01FriendsOfPesho
{
    public class Edge
    {
        public Edge(int nodeId, int weight)
        {
            this.NodeId = nodeId;
            this.Weight = weight;
        }
        public int Weight { get; set; }
        public int NodeId { get; set; }
    }
}
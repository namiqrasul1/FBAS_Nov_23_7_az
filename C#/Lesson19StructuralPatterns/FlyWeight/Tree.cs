using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class Tree
    {
        public Tree(int x, int y, string color, string texture, string name)
        {
            X = x;
            Y = y;
            Type = TreeFactory.GetTreeType(name, texture, color);
        }

        public int X { get; set; }
        public int Y { get; set; }
        public TreeType Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class TreeFactory
    {
        static readonly List<TreeType> types = [];
        public static TreeType GetTreeType(string name, string texture, string color)
        {
            var type = types.FirstOrDefault(ty => ty.Name == name && ty.Texture == texture && ty.Color == color);
            if (type is null)
            {
                type = new TreeType { Color = color, Texture = texture, Name = name };
                types.Add(type);
            }
            return type;
        }
    }
}

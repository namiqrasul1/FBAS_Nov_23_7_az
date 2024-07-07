using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Category : ICloneable
    {
        public string Name { get; set; }
        public object Clone()
        {
            return new Category { Name = Name };
        }
    }
}

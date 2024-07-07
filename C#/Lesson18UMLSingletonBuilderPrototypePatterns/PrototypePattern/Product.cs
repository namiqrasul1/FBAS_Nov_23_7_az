using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Product : IPrototype
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public IPrototype Clone()
        {
            return new Product { Name = this.Name, Price = this.Price };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Product
    {
        internal int Id { get; set; }
        protected string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        
    }
}

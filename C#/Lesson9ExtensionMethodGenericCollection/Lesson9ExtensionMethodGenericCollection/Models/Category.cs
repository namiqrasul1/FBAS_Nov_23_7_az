using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9ExtensionMethodGenericCollection.Models
{
    class Trousers { }
    class TShirt { }
    class Shoes { }
    internal class Category<T> where T : class, new()
    {
        public T? Product { get; set; }
    }
}

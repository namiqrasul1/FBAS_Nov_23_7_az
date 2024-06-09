using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9ExtensionMethodGenericCollection.Models
{
    internal class User : IA
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBhirt { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}

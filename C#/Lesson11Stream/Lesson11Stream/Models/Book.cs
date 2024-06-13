using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11Stream.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Jenre { get; set; }

        public override string ToString() => $"{Id} {Name} {Author} {Jenre}";
    }
}

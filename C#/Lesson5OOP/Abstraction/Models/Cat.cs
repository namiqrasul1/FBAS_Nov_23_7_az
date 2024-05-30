using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
    internal class Cat : Animal
    {
        public override string Name { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Miyau");
        }
    }
}

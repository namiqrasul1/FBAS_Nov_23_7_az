using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Cat : Animal
    {
        public override void Sound() { Console.WriteLine("Miyau"); }
    }
}

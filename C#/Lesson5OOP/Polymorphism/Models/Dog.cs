using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal sealed class Dog : Animal
    {
        public sealed override void Sound() { Console.WriteLine("Hav hav hav"); }
    }
}

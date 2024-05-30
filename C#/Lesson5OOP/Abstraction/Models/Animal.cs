using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
    internal abstract class Animal
    {
        public abstract string Name { get; set; }

        public abstract void Sound();
    }
}

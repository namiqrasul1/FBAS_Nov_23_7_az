using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Interfaces
{
    internal class User : IMusician, IClone
    {
        public int MyProperty { get; set; }

        public IClone Clone()
        {
            return new User() { MyProperty = MyProperty};
        }

        public void Play()
        {
            Console.WriteLine("dunya senin dunya menim");

        }
        
    }
}

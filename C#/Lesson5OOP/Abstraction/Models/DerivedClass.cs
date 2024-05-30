using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
    internal class DerivedClass : SomeClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedClass Method");
        }
    }
}

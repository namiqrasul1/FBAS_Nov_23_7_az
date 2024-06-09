using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9ExtensionMethodGenericCollection.Models
{
    interface IA { }
    class A : IA { }
    class B : IA { }

    struct C : IA { }

    // T ancaq IA interfaceinden implement eden class ola biler
    internal class FileName <T> where T : class, IA, new()
    {
    }
}

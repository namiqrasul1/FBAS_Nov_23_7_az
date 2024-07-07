using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal interface IPrototype
    {
        IPrototype Clone();
    }
}

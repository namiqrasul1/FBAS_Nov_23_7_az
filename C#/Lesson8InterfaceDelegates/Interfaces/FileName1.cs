using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IInterface
    {
        void Foo(int a);
    }

    interface IC : IInterface
    {
        void Boo();
    }
    internal class FileName1 : IC
    {
        public void Foo(int a)
        {
            throw new NotImplementedException();
        }

        public void Boo() { }

    }
}

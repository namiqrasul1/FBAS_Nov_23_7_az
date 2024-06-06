using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IAA
    {
        void Foo();
    } 

    interface IBB
    {
        void Foo();
    }

    internal class FileName2 : IAA, IBB
    {
        void IAA.Foo() { Console.WriteLine("IAA.Foo"); }
        public void Foo()
        {
            Console.WriteLine("FileName2.Foo...IBB");
        }
    }
}

using Ecommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6ExceptionHandlingReadonlyOperatorOverloadingIndexer
{
    class Any { }
    public class SomeClass : Product
    {
        const int constField = 1;
        readonly int readonlyField;
        //const Any any = new Any();
        readonly Any any2 = new Any();

        public SomeClass(int a)
        {
            readonlyField = a;

        }

        void Foo()
        {
            //readonlyField = 2;
            //any2 = new Any();
        }
    }
}

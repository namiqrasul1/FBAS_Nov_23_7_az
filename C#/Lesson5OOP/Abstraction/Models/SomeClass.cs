using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
    internal abstract class SomeClass
    {
        int field;
        static int staticFiled;
        const int constField = 1;
        public int MyProperty { get; set; }
        public static int MyProperty1 { get; set; }

        public void Foo() { }
        public static void StaticMethod() { }
        public virtual void VirtualMethod() { }

        public abstract void AbstractMethod();
    }
}

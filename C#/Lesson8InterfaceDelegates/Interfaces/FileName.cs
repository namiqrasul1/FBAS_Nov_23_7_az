using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IA
    {
        void Method();
    }

    class Some : IA
    {
        public void Method()
        {

        }
    }

    class App
    {
        public void Method()
        {
            IA ia = new Some();
        }
    }
}

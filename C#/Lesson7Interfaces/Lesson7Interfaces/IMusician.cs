using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Interfaces
{
    internal interface IMusician
    {
        void Play();
        void Stop() { Console.WriteLine("IMusician"); }

        //int field;
        static int staticField = 2;
        const int constField = 2;

        public int MyProperty { get; set; }

        static IMusician() { }

    }
}

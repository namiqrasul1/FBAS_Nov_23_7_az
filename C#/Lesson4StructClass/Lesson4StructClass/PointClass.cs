using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleNamespace
{
    class PointClass
    {
        public int x;
        public int y;

        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public PointClass Clone()
        {
            return new PointClass(this.x, this.y);
        }

        public void Show()
        {
            Console.WriteLine($"{x} {y}");
        }

        public override string ToString() => $"{x} {y}";

        ~PointClass() { } // Finalizer
    }
}

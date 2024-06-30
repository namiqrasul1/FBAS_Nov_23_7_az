using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15GarbageCollection
{
    class Some : IDisposable
    {
        ~Some()
        {
            Dispose();    
        }

        public void Dispose()
        {
            Console.WriteLine("object disposed");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var some = new Some();
                Console.WriteLine(GC.GetGeneration(some));
                some.Dispose(); 
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}

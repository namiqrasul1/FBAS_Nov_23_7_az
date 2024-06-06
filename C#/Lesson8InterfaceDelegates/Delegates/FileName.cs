using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        //static void Foo(MyDelegate del) { }
        static int Some(Action<int, string> action) { return 1; }
        static void Main(string[] args)
        {
            // Action    => return type is void
            // Func      => return type is some type (without void)
            // Predicate => return type bool (only 1 parameter)

            //Action action = Foo;
            //action();

            //Action<int> action = FooWithInt;
            //action.Invoke(42);
            //Action<int, string> ac = FooWithIntString;
            //Some(FooWithIntString);

            //List<int> arr = [1, 2, 3, 4, 5, 6, 6];
            //arr.ForEach(FooWithInt);

            //Func<double, double, bool> func = Equal;
            //var r = func.Invoke(4, 5);

            //Func<int, bool> f = IsNegative;
            //Predicate<int> p = IsNegative;


            //List<int> arr = [1, -2, 3, -4, 5, 6, -6];
            //arr.RemoveAll(IsNegative);

            //arr.ForEach(FooWithInt);

            /////////////////////////////////////////////////////
            /// anonymous functions

            // delegate (parameter list) { // body }

            //Action<int> action = delegate (int arg) { Console.WriteLine(arg); };
            //action.Invoke(142);

            //List<int> arr = [1, -2, 3, -4, 5, 6, -6, 25432, 432, 4, 6, 457, 56, 23, 4, 365, 45324];

            //int min = int.Parse(Console.ReadLine());
            //int max = int.Parse(Console.ReadLine());


            //arr.RemoveAll(delegate (int arg) { return min < arg && arg < max; });

            //arr.ForEach(delegate (int arg) { Console.WriteLine(arg); });

            /////////////////////////////////////////////////////////////////
            /// lambda expression

            // (parameterName) => { body }
            // (parameterName) => body 

            //Predicate<int> predicate = arg => { return arg > 0; };
            //Predicate<int> predicate = arg => arg > 0;
            Func<int, string, bool> predicate = (arg, s) => arg > 0;

            List<int> arr = [1, -2, 3, -4, 5, 6, -6];

            arr.RemoveAll(arg => arg > 0);

            arr.ForEach(x => Console.WriteLine(x));

        }

        static void Foo() { Console.WriteLine("Foo()"); }
        static void FooWithInt(int arg) { Console.WriteLine(arg); }
        static void FooWithIntString(int arg, string a) { Console.WriteLine(arg); }

        static bool Equal(double d, double d1) => d == d1;
        static bool IsNegative(int arg) => arg < 0;





        delegate void MyDelegate(string s);

    }
}

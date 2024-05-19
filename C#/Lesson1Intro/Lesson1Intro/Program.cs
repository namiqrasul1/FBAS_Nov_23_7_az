using System.Text;

namespace Lesson1Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region MyRegion

            //foreach (var arg in args)
            //{
            //    Console.WriteLine(arg);
            //}
            //Console.WriteLine("Hello, World!");
            //Console.ReadKey();


            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("dasdasd");
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            //Console.WriteLine("asjhkdasjhkd");

            //string name = "murad";
            //Console.WriteLine(name);
            //Console.WriteLine("{0} {1}", name, "matata");

            Console.OutputEncoding = Encoding.Unicode;

            //string name = "kamil";
            //string name1 = "əsedov";
            //// concatenation
            ////var result = name + " " + name1;

            //// interpolation
            //var result = $"{name} asdkjlasdlkas {name1}";

            //Console.WriteLine(result);


            //            var str = @"
            //asd
            //asd \t
            //as
            //d
            //asd
            //as
            //d
            //asd
            //as
            //d
            //asd";
            //            Console.WriteLine(str);

            //var path = @"C:\Users\namiqrasullu\Desktop\Инструкция_переходник.pdf";


            //var a = 42; // compile-time
            //dynamic d = 42; // run-time 
            ////d.Foo(); it throws exception
            ///



            // Data types
            // Value types     => deyer saxlayirlar
            // Reference types => adres saxlayirlar

            //byte b = 255;
            //sbyte sb = -127;

            ////Program program = new Program();
            ////Console.WriteLine(program.ToString());
            //decimal d = 4.2m;
            //float f = 2.2f;

            //var str = "42";
            ////int num = int.Parse(str);
            //int num = Convert.ToInt32(str);

            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"your age is {age}");
            //Console.Write("hakuna");
            //Console.WriteLine("matata");
            //Console.Write("john");

            //while (true)
            //{
            //    ConsoleKeyInfo key = Console.ReadKey();
            //    //Console.WriteLine(key.Key);
            //    switch (key.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            Console.WriteLine("yuxari"); break;
            //        case ConsoleKey.DownArrow:
            //            Console.WriteLine("ashagi"); break;
            //        default:
            //            break;
            //    }

            //}

            //int a = 3;
            //switch (a)
            //{
            //    case 2:
            //        Console.WriteLine("case 2");
            //        break;
            //    case 1: 
            //    case 3: 
            //    case 4:
            //        Console.WriteLine("case 1,3,4");
            //        break;

            //}

            #endregion

            int a = 42;
            Console.WriteLine($"Before function: {a}");
            Change(a);
            Console.WriteLine($"After function: {a}");

        }
        static void Change(int arg)
        {
            arg = arg + 1;
        }

    }
}

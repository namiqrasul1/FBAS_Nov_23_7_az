internal class Program
{
    public int a;
    private static void Main(string[] args)
    {

        #region Homework

        //string[] arr = { "1. Home", "2. About", "3. Exit", "4. Contact" };
        //int index = 0;
        //while (true)
        //{
        //    Console.Clear();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.ForegroundColor = i == index ? ConsoleColor.Green : ConsoleColor.White;
        //        Console.WriteLine(arr[i]);
        //    }


        //    ConsoleKeyInfo key = Console.ReadKey();

        //    switch (key.Key)
        //    {
        //        case ConsoleKey.DownArrow:
        //            index = index == arr.Length - 1 ? 0 : index + 1;
        //            break;
        //        case ConsoleKey.UpArrow:
        //            index = index == 0 ? arr.Length - 1 : index - 1;
        //            break;
        //    }
        //}
        #endregion

        #region Value Types

        //int? a = null; // nullable
        //a = 0;

        //Console.WriteLine(a);


        //int a = 1;
        //int b = a;
        //b = 2;
        //Console.WriteLine(a);


        // ref => deyishenin ozu gonderilir, mutleq deyer assign olunmush deyishen istifade ede bilerik
        //int a = 2;

        //Console.WriteLine($"Before function: {a}");
        //Change(ref a);
        //Console.WriteLine($"After function: {a}");

        //Program o = new Program();
        //o.a = 2;
        //Change(ref o);
        //Console.WriteLine(o.a);


        // out => deyishenin ozu gonderilir, funksiya daxilinde mutleq deyer assign olunmalidir
        //int a1;

        ////Console.WriteLine($"Before function: {a1}");
        //Change(out a1);
        //Console.WriteLine($"After function: {a1}");

        //Change(out int a4);
        //Console.WriteLine(a4);
        //int a = 4;

        ////Console.WriteLine($"Before function: {a}");
        //ChangeByRef(ref a);
        //Console.WriteLine($"After function: {a}");

        //int n = 42;

        //Foo(n);

        #endregion

        #region Nullable, NullConditional Operator, checked

        // Data Types 
        // Reference type => adres, default deyer => null
        // Value     type => deyer, dafault deyer => 0, value typelar null saxlaya bilmirler

        //int n = default;
        //string s = default;
        //Console.WriteLine(n);
        //Console.WriteLine(s);

        //int? n1 = null; // nullable
        //string s1 = null;
        //s1?.ToLower(); // null condational operator


        // checked => Typelar uzerinde data itkisi olma ehtimalini yoxlayir, eger rangeden kenara chixma varsa OverflowExcetion atir.
        // type-safe yoxlayir ve nezaret edir.
        //int a = int.MaxValue;
        //checked
        //{
        //    a++;
        //}
        //Console.WriteLine(a);

        #endregion


        #region TypeCasting

        // Implicit (Q/Ashkar)
        // Explicit (Ashkar)

        // Implicit => Upcast

        //int a = 10;
        //double d = a;

        //double d = 3.2;
        //int a = Convert.ToInt32(d);


        // Parse => Type-n oz icherisinde static Parse methodu var ki, string qebul edir chevire bilirse chevirir, eks halda FormatException atir

        // TryParse => Type-n oz icherisinde static TryParse methodu var ki, bize chevire bilse true, eks halda false qaytarir
        //string s = null;
        //int.TryParse(s, out int a);
        //Console.WriteLine(a);

        // DR - DRY
        // KISS
        // SOLID

        #endregion

    }

    static void Foo(in int a)
    {
        //a = 12; // readonly variable
    }
    static void ChangeByRef(ref int argument)
    {
        
    }
    static void Change(out int argument)
    {
        argument = 42;
    }
    static void Change(ref Program obj)
    {
        obj = new Program();
        obj.a = 42;
    }

    void Boo(string? s)
    {

    }
   
}
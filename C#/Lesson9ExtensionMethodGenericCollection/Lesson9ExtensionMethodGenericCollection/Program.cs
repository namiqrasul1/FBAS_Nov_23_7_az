//using Lesson9ExtensionMethodGenericCollection.Extensions;
//using Lesson9ExtensionMethodGenericCollection.Models;
//using System.Net.Http.Headers;


//// Action
//// Func
//// Predicate

//internal class Program
//{
//    //static double Foo(int a, int b) {  return a + b; }

//    //private static void Main(string[] args)
//    //{
//    //    //int z = 42;
//    //    //double foo(int a, int b) { return a * b + z; }

//    //    //Func<int, int, double> func = Foo;
//    //    //Func<int, int, double> func1 = delegate (int a, int b) { return a + b * z; };
//    //    //Func<int, int, double> func2 = (a, b) => { return a + b + z; };
//    //    //Func<int, int, double> func3 = foo;

//    //    var str = "hakuna  , matata";
//    //    //str.WordCount();
//    //    //string s = "aasdlkasdklsa";
//    //    //s.WordCount();

//    //    User user = new()
//    //    {
//    //        Id = 1,
//    //        Name = "hakuna",
//    //        DateOfBhirt = DateTime.Now.AddYears(-42),
//    //    };

//    //    User user1 = new()
//    //    {
//    //        Id = 2,
//    //        Name = "hakuna2",
//    //        DateOfBhirt = DateTime.Now.AddYears(-36),
//    //    };

//    //    user.Compare(user1);

//    //    //if(user.IsAdult())
//    //    //{

//    //    //}


//    //}

//    static void Print<T, U>(T[] arr)
//    {
//        foreach (var item in arr)
//        {
//            Console.Write($"{item} ");
//        }
//        Console.WriteLine();
//    }




//    static void SomeMethod<T>() where T : struct
//    {

//    }

//    static void SomeMethod1<T>() where T : class
//    {

//    }

//    static void SomeMethod2<T>() where T : class, new()
//    {

//    }

//    static void SomeMethod3<T>() where T : new()
//    {

//    }

//    static void SomeMethod4<T>() where T : Exception
//    {

//    }

//    static void SomeMethod5<T>() where T : IA
//    {
//        //FileName<C> file = new(); 
//    }

   
//    static void SomeMethod6<T>()
//    {

//    }

//    static void Main(string[] args)
//    {
//        //SomeMethod<int>();
//        //SomeMethod<User>();
//        //SomeMethod<string>();

//        //SomeMethod1<int>();
//        //SomeMethod1<User>();
//        //SomeMethod1<string>();
//        //SomeMethod1<IA>();

//        //SomeMethod2<int>();
//        //SomeMethod2<User>();
//        //SomeMethod2<string>();
//        //SomeMethod2<IA>();


//        //SomeMethod3<int>();
//        //SomeMethod3<User>();
//        //SomeMethod3<string>();
//        //SomeMethod3<IA>();        
        
//        //SomeMethod4<int>();
//        //SomeMethod4<User>();
//        //SomeMethod4<string>();
//        //SomeMethod4<IA>();
//        //SomeMethod4<AggregateException>();

//        //SomeMethod5<int>();
//        //SomeMethod5<User>();
//        //SomeMethod5<string>();
//        //SomeMethod5<IA>();
//        //SomeMethod5<AggregateException>();

//        //int[] arr = [1, 12, 4, 3, 213, 12, 3];
//        //Print<int, User>(arr);

//        //Category<Trousers> category = new();
//        //Category<Shoes> category1 = new();
//        //Category<int> category2 = new();
//        //Category<User> category3 = new();

//    }



//}
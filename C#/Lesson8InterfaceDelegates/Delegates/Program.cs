//using System.Diagnostics.Metrics;

//internal class Program
//{
//    // delegate returnType DelegateName(parameter list);
//    delegate void MyDelegate();
//    private static void Main(string[] args)
//    {
//        //MyDelegate myDelegate = new MyDelegate(Foo);
//        //MyDelegate myDelegate = Foo;
//        ////myDelegate.Invoke();
//        //myDelegate();

//        MyDelegate myDelegate = Boo;
//        myDelegate += Foo;
//        myDelegate -= Foo;

//        myDelegate();

//        // += subscribe
//        // -= unsubscribes
//        // =

//        MyDel myDel = SomeMethod;
//        myDel += SomeMethod1;
        
//        foreach (var del in myDel.GetInvocationList())
//        {
//            Console.WriteLine(del.Method.Name);
//            foreach (var item in del.Method.GetParameters())
//            {
//                Console.WriteLine(item.ParameterType);
//                Console.WriteLine(item.Name);
//            }
//            Console.WriteLine("********************");
//        }
//    }












//    static void Foo() { Console.WriteLine("Foo"); }
//    static void Boo() { Console.WriteLine("Boo"); }


//    delegate bool MyDel(int i, string s, double d);


//    static bool SomeMethod(int age, string s, double d)
//    {
//        // logic
//        return true;
//    }

//    static bool SomeMethod1(int a, string ss, double dd)
//    {
//        // logic
//        return true;
//    }

//    // SendMessage
//    // SendMail
//}
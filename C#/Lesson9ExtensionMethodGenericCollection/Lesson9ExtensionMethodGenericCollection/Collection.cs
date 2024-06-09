using Lesson9ExtensionMethodGenericCollection.Models;
using System.Collections;
using System.Collections.ObjectModel;

namespace Lesson9ExtensionMethodGenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing   => value type reference type kechmesidir
            //int a = 1;
            //object b = a;

            //// unboxing => reference type value type kechmesidir
            //int c = (int)b;


            //ArrayList arrayList = new();

            //arrayList.Add(1);
            //arrayList.Add("string");
            //arrayList.Add(5.6);
            //arrayList.Add(new User());

            //object?[] arr = arrayList.ToArray();


            //var s = arrayList[3] as User;

            //arrayList.Contains(s);



            //User user = new User() { Id = 1};
            //User user1 = user;
            //user.Equals(user1);

            //Stack stack = new Stack();



            //Stack<int> ints = new Stack<int>();


            //Queue<string> queue = new Queue<string>();

            List<User> users = new List<User>();
            List<string> list = ["hakuna", "matata", "john", "doe", "kamil", "fazil", "nazim"];
            ReadOnlyCollection<string> roc = list.AsReadOnly();

            var name = list.Find(x => x.Contains('t'));
            var n = list.FindAll(x => x.Contains("il"));
            

            Console.WriteLine(name);

        }
    }
}

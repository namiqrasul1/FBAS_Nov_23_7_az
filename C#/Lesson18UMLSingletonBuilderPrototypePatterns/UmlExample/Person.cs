using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlExample
{
    internal class Person
    {
        private static int _id = 1;
        private int age;
        private float salary;

        public string Name { get; set; }
        public static int NextId() => _id++;
        public List<Person> Children { get; set; }
    }
}

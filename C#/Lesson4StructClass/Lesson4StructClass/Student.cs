using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4StructClass
{
    internal class Student
    {
        public string name;
        public string surname;

        public int GetAge() => age;
        public void SetAge(int value) => age = 16 < value ? value : throw new ArgumentOutOfRangeException();

        private int age;

        // Property
        public int Age
        {
            get => age;
            set => age = 16 < value ? value : throw new ArgumentOutOfRangeException();
        }

        public double Average { get; set; } // auto-property

        public Student() { }
        public Student(string name, string surname, int age, double average)
        {
            this.name = name;
            this.surname = surname;
            Age = age;
            Average = average;
        }

    }
}

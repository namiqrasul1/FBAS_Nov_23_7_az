using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Student : Person
    {
        public double Average { get; set; }

        public Student(string name, string surname, string bdate, double avg) : base(name, surname, bdate)
        {
            Average = avg;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine($" {Average}");
        }
    }
}

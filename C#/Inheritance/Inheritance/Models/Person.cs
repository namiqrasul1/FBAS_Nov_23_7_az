using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BDate { get; set; }

        public Person(string name, string surname, string date)
        {
            Name = name;
            Surname = surname;
            BDate = DateTime.Parse(date);
            
        }

        public void Show()
        {
            Console.Write($"{Name} {Surname} {BDate.ToShortDateString()}");
        }


    }
}

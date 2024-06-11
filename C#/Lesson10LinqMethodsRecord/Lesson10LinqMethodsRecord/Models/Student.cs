using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10LinqMethodsRecord.Models
{
    internal class Student : IComparable<Student>, IComparable
    {
        private static int _id = 1;
        public int Id { get; init; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public Student()
        {
            Id = _id++;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {DateOfBirth}";
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Student? other)
        {
            if (this.DateOfBirth == other?.DateOfBirth) return 0;
            if (this.DateOfBirth.CompareTo(other?.DateOfBirth) == 1) return -1;
            return 1;

        }
    }
}

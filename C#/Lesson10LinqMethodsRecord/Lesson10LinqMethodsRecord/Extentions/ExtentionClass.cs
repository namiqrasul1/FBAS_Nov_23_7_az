using Lesson10LinqMethodsRecord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10LinqMethodsRecord.Extentions
{
    internal static class ExtentionClass
    {
        public static Student? GetElderStudent(this List<Student> students)
        {
            var result = students.FirstOrDefault();
            if (result is not null)
            {
                foreach (var student in students)
                {
                    if (result.DateOfBirth.CompareTo(student.DateOfBirth) == 1)
                        result = student;
                }
            }
            return result;

        }
    }
}

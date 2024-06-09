using Lesson9ExtensionMethodGenericCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9ExtensionMethodGenericCollection.Extensions
{
    internal static class ExtensionClass
    {
        public static int WordCount(this string str)
        {
            var count = str.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }

        public static bool IsAdult(this User user)
        {
            return DateTime.Now.Year - user.DateOfBhirt.Year >= 18;
        }

        public static int Compare(this User user, User other)
        {
            return user.DateOfBhirt.CompareTo(other.DateOfBhirt);
        }
    }
}

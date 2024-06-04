using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmHomework.Helpers
{
    enum StringType
    {
        Numeric,
        Alpha,
        AlphaNumeric
    }
    internal static class RandomGenerator
    {
        private static readonly Random _random = new Random();

        public static string GenerateString(int length, StringType type)
        {
            string str = type switch
            {
                StringType.Numeric => "0123456789",
                StringType.Alpha => "abcdefghijklmnopqrstuvwxyz",
                StringType.AlphaNumeric => "0123456789abcdefghijklmnopqrstuvwxyz",
                _ => throw new ArgumentException()
            };

            var result = string.Empty;
            for (int i = 0; i < length; i++)
            {
                result += str[_random.Next(0, str.Length)];
            }

            return result;
        }

        //public static int GenerateInt(int length) {
        //    Random rn = new Random();
        //}
    }
}

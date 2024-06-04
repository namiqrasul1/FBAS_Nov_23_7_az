using AtmHomework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmHomework.Models
{
    internal class Card
    {
        public string Pan { get; init; }
        public string Pin { get; init; }
        public string Cvc { get; init; }
        public string ExpireDate { get; init; }
        public decimal Balance { get; set; }

        public Card(decimal amount, int year)
        {
            Pan = RandomGenerator.GenerateString(16, StringType.Numeric);
            Pin = RandomGenerator.GenerateString(4, StringType.Numeric);
            Cvc = RandomGenerator.GenerateString(3, StringType.Numeric);
            Balance = amount;
            ExpireDate = DateTime.Now.AddYears(year).ToString("MM/yy");
        }


        public override string ToString()
        {
            return $"{Pan} {Pin} {Cvc} {ExpireDate} {Balance}";
        }
    }
}

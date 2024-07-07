using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class President
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private static President president;
        private President() { }
        public static President GetInstance()
        {

            //president = president ?? new President();
            president ??= new President();
            return president;
        }
    }
}

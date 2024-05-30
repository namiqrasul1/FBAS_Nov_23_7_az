using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class DerivedClass : BaseClass
    {
        //protected Some Some1 { get; set; }
        public DerivedClass(int a) : base(a) 
        {

        }
    }
}

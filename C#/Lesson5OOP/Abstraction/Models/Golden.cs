using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
    internal class Golden : Dog
    {
        public override string Name { get; set; }

        public override void AnotherAbstractMethod()
        {
            throw new NotImplementedException();
        }

        public override void Sound()
        {
            throw new NotImplementedException();
        }
    }
}

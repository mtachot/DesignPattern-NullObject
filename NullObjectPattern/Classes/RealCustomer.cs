using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Classes
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override bool isNil()
        {
            return false;
        }

        public override string getName()
        {
            return this.name;
        }
    }
}

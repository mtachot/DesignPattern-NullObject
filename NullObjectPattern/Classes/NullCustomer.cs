using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Classes
{
    public class NullCustomer : AbstractCustomer
    {
        public override bool isNil()
        {
            return true;
        }

        public override string getName()
        {
            return "Not available in Customer Database";
        }
    }
}

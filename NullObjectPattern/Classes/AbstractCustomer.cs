using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Classes
{
    public abstract class AbstractCustomer
    {
        protected string name;
        public abstract bool isNil();
        public abstract string getName();
    }
}

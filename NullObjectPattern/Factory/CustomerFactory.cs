using NullObjectPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Factory
{
    public class CustomerFactory
    {
        public static string[] names = { "Rob", "Laura", "Anon" };
        public static AbstractCustomer getCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (String.Compare(names[i].ToUpper(), name.ToUpper()) == 0)
                    return new RealCustomer(name);
            }
            return new NullCustomer();
        }
    }
}

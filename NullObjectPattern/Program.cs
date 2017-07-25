using NullObjectPattern.Classes;
using NullObjectPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            AbstractCustomer customer1 = CustomerFactory.getCustomer("Rob");
            AbstractCustomer customer2 = CustomerFactory.getCustomer("Bob");
            AbstractCustomer customer3 = CustomerFactory.getCustomer("Laura");
            AbstractCustomer customer4 = CustomerFactory.getCustomer("Ano");

            Console.WriteLine(customer1.getName());
            Console.WriteLine(customer2.getName());
            Console.WriteLine(customer3.getName());
            Console.WriteLine(customer4.getName());

            Console.ReadLine();
        }
    }
}

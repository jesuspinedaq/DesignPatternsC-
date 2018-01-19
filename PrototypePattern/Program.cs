using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Department = "HR";
            customer.Name = "Msc LT";

            Customer clonedCustomer = customer.Clone() as Customer;
            clonedCustomer.Name = "AVg";

            Console.WriteLine(customer.ToString());
            Console.WriteLine(clonedCustomer.ToString());

            Console.ReadKey();
        }
    }
}

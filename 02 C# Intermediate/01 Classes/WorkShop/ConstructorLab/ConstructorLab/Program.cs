using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(102,"john");
            Console.WriteLine(customer.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableStringLab
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14;
            var value = "hello";
            value = "hello world";
            var department = "Hr";
            value = string.Format("Hello {0}, you belong to {1} deprtment", "username", department);
            //Console.WriteLine(value);
            Console.WriteLine($"Hello username, you belong to {department}deprtment");

            var numbers = new int[3] { 1, 2, 3 };
            var newVal = string.Join(",", numbers);
            Console.WriteLine(newVal);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLabs
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            var numbers = new int[3] { 10, 20, 30 };
            //var result = calc.Add(numbers);
            var result = calc.Add("use add feature", 10, 20, 30, 40);
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrrideObjectLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { FirstName = "bill", LastName = "macfield" };
            //Console.WriteLine(person);
            var point1 = new Point { X = 1, Y = 1 };
            var point2 = new Point { X = 1, Y = 1 };
            //var point2 = point1;
            if(point1.Equals(person))
            {
                Console.WriteLine("point1 == point2");
            }
        }
    }
}

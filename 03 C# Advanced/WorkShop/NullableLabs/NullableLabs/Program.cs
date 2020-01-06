using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableLabs
{
    public class Foo
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //int number = null;
            Nullable<int> numberNullable = null;
            int? number2 = null;
            int number3 = number2 ?? -1;
            bool? isTrue = null;
            char? c = null;
            //if (date.HasValue)
            //    Console.WriteLine(date.Value);
            //if(number2.HasValue)
            //    Console.WriteLine("number has value");

            dynamic value = 0;
            value = "123";
            dynamic foo = new Foo();
            value = foo.Start();
            Console.WriteLine(value);
        }
    }
}

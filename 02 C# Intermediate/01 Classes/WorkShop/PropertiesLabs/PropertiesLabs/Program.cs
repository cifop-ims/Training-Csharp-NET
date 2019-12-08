using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("ahmed",new DateTime(1990,1,1));
            //person.SetName("ahmed");
            //Console.WriteLine(person.GetName());
            //person.Name = "ahmed";
            person.Nationality = "Tunisian";
            Console.WriteLine(person.Nationality);
        }
    }
}

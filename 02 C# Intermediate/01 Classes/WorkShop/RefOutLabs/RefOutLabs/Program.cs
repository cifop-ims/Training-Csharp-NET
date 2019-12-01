using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            //Increment(ref number);
            //SetValue(out number);
            //Console.WriteLine(number);

            string value = "1000-";
           
          
            int result;
            //int convertedNumber;
            //try
            //{
            //     convertedNumber = int.Parse(value);
            //}
            //catch (Exception)
            //{

            //    convertedNumber = 0;
            //}
            if(int.TryParse(value,out result))
            {
                Console.WriteLine($"Conversion done: {result}");
            }
            else
            {
                Console.WriteLine($"Conversion failed : {result}");
            }
        }

        static void SetValue(out int number)
        {
            number = 100;
        }

        static void Increment(ref int number)
        {
            number += 10;
        }
    }
}

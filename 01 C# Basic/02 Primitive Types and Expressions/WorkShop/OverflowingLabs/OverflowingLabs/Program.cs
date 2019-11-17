using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverflowingLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    byte value = 255;
                    value++;
                    Console.WriteLine(value);
                }
            }
            catch (Exception)
            {

                // handler execption
                Console.WriteLine("overflow occurs !!");
            }
        }
    }
}

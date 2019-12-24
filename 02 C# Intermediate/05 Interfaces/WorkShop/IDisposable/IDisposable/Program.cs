using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new Container();
            //container.Dispose();
            using (var container = new Container())
            {
                //...
                System.Console.WriteLine("Inside Using Block");
                throw new Exception("error");
            }
        }
    }
}

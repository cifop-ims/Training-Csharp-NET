using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interfaces;

namespace Unity.Implementations
{

    public class Service : IService
    {
        public void SayHello()
        {
            Console.WriteLine("Hello !");
        }
    }
}

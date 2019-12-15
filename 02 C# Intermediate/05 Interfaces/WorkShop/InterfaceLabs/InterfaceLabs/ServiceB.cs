using System;

namespace InterfaceLabs
{
    public class ServiceB : IService
    {
        public void Process()
        {
            Console.WriteLine("Service B : Process done");
        }
    }
}

using System;

namespace IDisposableLabs
{
    public class Container : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Container is disposed");
        }
    }
}

using System;

namespace ComposionLabs
{
    public class Installer
    {
        private readonly Logger _logger;
        private readonly ServiceA _serviceA;

        public Installer(Logger logger, ServiceA serviceA)
        {
            _logger = logger;
            _serviceA = serviceA;
        }
        public void Setup()
        {
            _logger.Log($"Setup starts {DateTime.Now}");
            //......
            Console.WriteLine("Setup Done");
            _logger.Log($"Setup ends {DateTime.Now}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interfaces;

namespace Unity.Implementations
{
    public class ServiceManager : IServiceManager
    {
        private readonly IService _service;

        public ServiceManager(IService service)
        {
            _service = service;
        }
        public void DisplayGreetingMsg()
        {
            _service.SayHello();
        }
    }
}

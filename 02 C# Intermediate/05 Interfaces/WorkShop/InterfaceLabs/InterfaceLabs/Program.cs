using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceA = new ServiceA();
            var serviceB = new ServiceB();

            var serviceManager = new ServiceManager(serviceB);
            serviceManager.Start();

            //var serviceImpl = (ILog) service;
            //serviceImpl.Log("ididi");
            //IService serviceImpl2 = service;
            //serviceImpl2.Process();
            //service.Process();
            //service.CustomProcess();
        }
    }
}

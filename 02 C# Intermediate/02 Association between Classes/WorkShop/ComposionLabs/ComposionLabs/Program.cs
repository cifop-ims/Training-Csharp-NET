using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposionLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var service = new ServiceA();
            var installer = new Installer(logger, service);
            installer.Setup();
        }
    }
}

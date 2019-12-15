using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interfaces;

namespace Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            var unityContainer = new UnityContainer();
            var container = new Container(unityContainer);
            container.RegisterTypes();
            var shell = unityContainer.Resolve<IShell>();
            shell.Start();
        }
    }
}

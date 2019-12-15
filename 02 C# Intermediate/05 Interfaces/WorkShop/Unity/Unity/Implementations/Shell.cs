using Unity.Interfaces;

namespace Unity.Implementations
{
    public class Shell : IShell
    {
        private readonly IServiceManager _serviceManager;

        public Shell(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public void Start()
        {
            _serviceManager.DisplayGreetingMsg();
        }
    }
}

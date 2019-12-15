using Unity.Implementations;
using Unity.Interfaces;

namespace Unity
{
    public class Container
    {
        private readonly UnityContainer _unityContainer;

        public Container(UnityContainer unityContainer)
        {
           _unityContainer = unityContainer;
        }

        public void RegisterTypes()
        {
            _unityContainer.RegisterType<IService, Service>();
            _unityContainer.RegisterType<IServiceManager, ServiceManager>();
            _unityContainer.RegisterType<IShell, Shell>();
        }
    }
}

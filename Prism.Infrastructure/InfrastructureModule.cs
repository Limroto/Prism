using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace Prism.Infrastructure
{
    public class InfrastructureModule : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _manager;

        public InfrastructureModule(IUnityContainer container, IRegionManager manager)
        {
            _container = container;
            _manager = manager;
            RegisterServicesAndViews();
        }

        private void RegisterServicesAndViews()
        {
            //_container.RegisterType<..>();
        }

        public void Initialize()
        {
            //_container.Resolve<...>();
        }
    }
}
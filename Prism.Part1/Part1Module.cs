using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Prism.Infrastructure;

namespace Prism.Part1
{
    public class Part1Module : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _manager;

        public Part1Module(IUnityContainer container, IRegionManager manager)
        {
            _container = container;
            _manager = manager;
            RegisterServicesAndViews();
        }

        private void RegisterServicesAndViews()
        {
            _container.RegisterType<HeaderPart1>();
            //_container.RegisterType<..>();
        }

        public void Initialize()
        {
            //_container.Resolve<...>();
            var topView = _container.Resolve<HeaderPart1>();

            var topRegion = _manager.Regions[RegionNames.HeaderRegion];
            topRegion.Add(topView);
            
        }
    }
}
